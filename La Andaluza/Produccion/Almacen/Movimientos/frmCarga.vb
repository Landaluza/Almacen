Public Class frmCarga
    Private Tabla As DataTable
    Private O_Item As ListViewItem
    'Private lvi As ListViewItem

    Private ctlAlb As ctlAlbaranCargaProMaestro
    Private ctlAlbDet As ctlAlbaranesCargaProviDetalles
    Private spAlbaran As spAlbaranesCarga
    Private codigoMaestro As String
    Private NumeroPedido As String
    Private loteOriginal As String

    Public Event BeforeSave(sender As Object, e As EventArgs)
    Public Event AfterSave(sender As Object, e As EventArgs)
    Public Event AfterAdd(sender As Object, e As EventArgs)
    Public Event BeforeScan(ByRef sender As Object, ByVal scc As String)
    Public EventHAndled As Boolean

    Private m_TipoPedido As Byte
    Private camposEscaner As Collection
    Private codigoEscaneado As String
    Private contTiempo As Integer
    Private dtb As DataBase


    Public Const ORDEN_DE_CARGA As Byte = 1
    Public Const PEDIDO As Byte = 0

    Public Sub New(ByVal codigo As String, ByVal numeroPedido As String, ByVal tipo_de_pedido As Byte)

        InitializeComponent()

        ctlAlb = New ctlAlbaranCargaProMaestro
        ctlAlbDet = New ctlAlbaranesCargaProviDetalles
        spAlbaran = New spAlbaranesCarga
        dtb = New DataBase(Config.Server)
        Me.codigoMaestro = codigo
        Me.m_TipoPedido = tipo_de_pedido
        Me.NumeroPedido = numeroPedido

        Me.camposEscaner = New Collection
        Me.camposEscaner.Add(Me.txtFecha)
        Me.camposEscaner.Add(Me.txtSCCEscaneado)
        Me.camposEscaner.Add(Me.txtLote)
        Me.camposEscaner.Add(Me.txtCajas)
        Me.camposEscaner.Add(Me.txtSCC)
        Me.camposEscaner.Add(Me.txtPaletsPorArticulo)
        Me.camposEscaner.Add(Me.txtPesoPalet)
        Me.camposEscaner.Add(Me.txtDescripcion)
        Me.camposEscaner.Add(Me.txtObsCarga)
        Me.camposEscaner.Add(Me.txtObsEnvasado)
        Me.camposEscaner.Add(Me.txtPaletsTotales)
        Me.camposEscaner.Add(Me.txtPesoTotal)
        dtpFecha.activarFoco()
    End Sub

    Public ReadOnly Property TipoPedido As Byte
        Get
            Return m_TipoPedido
        End Get
    End Property

    Public Property Codigo As String
        Get
            Return Me.codigoMaestro
        End Get
        Set(ByVal value As String)
            Me.codigoMaestro = value
        End Set
    End Property

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        dtb = New DataBase(Config.Server)
    End Sub

    Private Sub EscaneoSCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolTip1.SetToolTip(Me.btnClear, "Limpia de información los campos")
        Me.ToolTip1.SetToolTip(Me.btnBorrar, "Limpia de información los campos")
        Me.ToolTip1.SetToolTip(Me.btnOK, "Añade el palet al albarán")
        Me.ToolTip1.SetToolTip(Me.btnAnular, "Elimina el palet seleccionado de este albarán")
        Me.ToolTip1.SetToolTip(Me.btnGrabar, "Guarda el albarán de este pedido")
        Me.ToolTip1.SetToolTip(Me.Button4, "Oculta/muestra los paneles")
        Me.ToolTip1.SetToolTip(Me.Button5, "Oculta/muestra los paneles")
        Me.ToolTip1.SetToolTip(Me.txtSCCEscaneado, "Introduce el SSCC a mano o con lector de codigos" & Environment.NewLine & "y al tabular mostrara la información del palet")

        Me.ToolTip1.SetToolTip(Me.cboTipoPalet, "Selecciona el tipo de palet que se carga. Por defecto se marcará el mas usual")

        Dim spTipos As New spPaletsTipos
        spTipos.cargar_PaletsTipos(Me.cboTipoPalet)

        With Me.lvwPalets
            .View = View.Details
            .Columns.Add(New ColumnHeader)
            .Columns(0).Text = "SCC"
            .Columns(0).Width = 40
            .Columns.Add(New ColumnHeader)
            .Columns(1).Text = "Fecha"
            .Columns(1).Width = 0
            .Columns.Add(New ColumnHeader)
            .Columns(2).Text = "Descripcion"
            .Columns(2).Width = 200
            .Columns.Add(New ColumnHeader)
            .Columns(3).Name = "Cajas"
            .Columns(3).Text = "Cajas"
            .Columns(3).Width = 55
            .Columns(3).TextAlign = HorizontalAlignment.Right
            .Columns.Add(New ColumnHeader)
            .Columns(4).Text = "Lote"
            .Columns(4).Width = 50
            .Columns(4).TextAlign = HorizontalAlignment.Right
            .Columns.Add(New ColumnHeader)
            .Columns(5).Text = "ObsEnvasado"
            .Columns(5).Width = 250
            .Columns(5).TextAlign = HorizontalAlignment.Left
            .Columns.Add(New ColumnHeader)
            .Columns(6).Text = "ObsCarga"
            .Columns(6).Width = 250
            .Columns(6).TextAlign = HorizontalAlignment.Left

            .Columns.Add(New ColumnHeader)
            .Columns(7).Name = "Peso"
            .Columns(7).Text = "Peso"
            .Columns(7).Width = 55
            .Columns(7).TextAlign = HorizontalAlignment.Right

            .FullRowSelect = True
            .GridLines = True
        End With

        dgvTotalesFill()
        txtSCCEscaneado.Focus()
    End Sub

    Public Sub dgvTotalesFill()
        Dim dt As DataTable
        Dim dtPalets As DataTable

        If Me.TipoPedido = PEDIDO Then
            dt = dtb.Consultar("SumCajasByArticulo " & Me.codigoMaestro)
            dtPalets = dtb.Consultar("SumPaletsByTipoPalet " & Me.codigoMaestro)
        Else
            dt = dtb.Consultar("SumCajasByArticuloOC " & Me.codigoMaestro)
            dtPalets = dtb.Consultar("SumPaletsByTipoPaletOC " & Me.codigoMaestro)
        End If
        'If Me.TipoPedido = PEDIDO Then
        '    . dataSource = dtb.Consultar("SumCajasByArticulo " & Me.codigoMaestro)
        'Else
        '    . dataSource = dtb.Consultar("SumCajasByArticuloOC " & Me.codigoMaestro)
        'End If
        If Not dt Is Nothing Then
            With (dgvTotales)
                dgvTotales.DataSource = dt

                .FormatoColumna("Articulo", TiposColumna.Izquierda, True)
                .FormatoColumna("Cajas", TiposColumna.Miles, , 1)
                .FormatoColumna("Palets", TiposColumna.Miles, , 2)
                .FormatoGeneral()
            End With
        End If

        If Not dtPalets Is Nothing Then
            dgvTotalesPalets.DataSource = dtPalets
            dgvTotalesPalets.FormatoColumna("Descripcion", TiposColumna.Descripcion, True)
        End If
    End Sub

    Public Sub dgvDetallesFill()
        Dim data As DataTable

        If Me.TipoPedido = PEDIDO Then
            data = dtb.Consultar("AlbaranCargaSeguridadSelect " & Me.codigoMaestro)
        Else
            data = dtb.Consultar("AlbaranCargaSeguridadSelectOC " & Me.codigoMaestro)
        End If

        If Not data Is Nothing Then
            Dim row As DataRow
            Dim lvi As New ListViewItem

            For Each row In data.Rows
                lvi = New ListViewItem(New String() { _
                                           If(IsDBNull(row.Item("SCC")), String.Empty, row.Item("SCC").ToString), _
                                           If(IsDBNull(row.Item("Fecha")), String.Empty, row.Item("Fecha").ToString), _
                                           If(IsDBNull(row.Item("Descripcion")), String.Empty, row.Item("Descripcion").ToString), _
                                           If(IsDBNull(row.Item("Cajas")), String.Empty, row.Item("Cajas").ToString), _
                                           If(IsDBNull(row.Item("Lote")), String.Empty, row.Item("Lote").ToString), _
                                           If(IsDBNull(row.Item("ObsEnvasado")), String.Empty, row.Item("ObsEnvasado").ToString), _
                                           If(IsDBNull(row.Item("ObsCarga")), String.Empty, row.Item("ObsCarga").ToString), _
                                           If(IsDBNull(row.Item("Peso")), String.Empty, row.Item("Peso").ToString), _
                                           If(IsDBNull(row.Item("TipoPaletID")), String.Empty, row.Item("TipoPaletID").ToString), _
                                           If(IsDBNull(row.Item("sinpalet")), "0", row.Item("sinpalet").ToString)})
                Me.lvwPalets.Items.Add(lvi)
            Next

            ActualizarContadoresPalets()
        End If

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        O_Item = Nothing

        Me.Cursor = Cursors.WaitCursor
        If txtSCCEscaneado.Text = "" Then
            MessageBox.Show("No has escaneado el palet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            O_Item = lvwPalets.FindItemWithText(txtSCC.Text)
            If Not O_Item Is Nothing Then 'Si no se encontró la cadena
                MessageBox.Show("Este SSCC esta repetido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                'Compruebo que no supere el maximo de palets o kilos que admite el camión.
                If If(txtPaletsTotales.Text = "", 0, Convert.ToInt32(txtPaletsTotales.Text)) > If(txtMaximoPalets.Text = "", 0, Convert.ToInt32(txtMaximoPalets.Text)) Then
                    MessageBox.Show("Superas el maximo de palets para este camión", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf If(txtPesoTotal.Text = "", 0, Convert.ToInt32(txtPesoTotal.Text.Replace(".", ""))) > If(txtMaximoKilos.Text = "", 0, Convert.ToInt32(txtMaximoKilos.Text)) Then
                    MessageBox.Show("Superas el maximo de kilos para este camión", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If


                'Añado palet a la lista
                O_Item = New ListViewItem(New String() {txtSCC.Text, txtFecha.Text, _
                                                          txtDescripcion.Text, txtCajas.Text, _
                                                          txtLote.Text, txtObsEnvasado.Text, _
                                                          txtObsCarga.Text, txtPesoPalet.Text, _
                                                          Me.cboTipoPalet.SelectedValue.ToString, If(Me.cbSinPalet.Checked, "1", "0")})


                'Grabo el registro en seguridad, hay que hacerlo antes para que actualice correctamente dgvTotales

                If Me.TipoPedido = PEDIDO Then
                    If Not spAlbaran.spInsertAlbaranCargaSeguridad(Convert.ToInt32(txtSCC.Text), 1, txtDescripcion.Text, Convert.ToInt32(txtCajas.Text), 1, txtLote.Text, Convert.ToInt32(Me.cboTipoPalet.SelectedValue), _
                                                  txtPesoPalet.Text, txtObsEnvasado.Text, txtObsCarga.Text, "", "", Now, 1, _
                                                  Convert.ToInt32(Me.codigoMaestro), Nothing, If(Me.loteOriginal = txtLote.Text, "", txtLote.Text), _
                                                  Me.cbSinPalet.Checked) Then
                        MessageBox.Show("No se pudo guardar el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.Cursor = Cursors.Default
                        Return
                    End If
                Else
                    If Not spAlbaran.spInsertAlbaranCargaSeguridad(Convert.ToInt32(txtSCC.Text), 1, txtDescripcion.Text, Convert.ToInt32(txtCajas.Text), 1, txtLote.Text, Convert.ToInt32(Me.cboTipoPalet.SelectedValue), _
                                                  txtPesoPalet.Text, txtObsEnvasado.Text, txtObsCarga.Text, "", "", Now, 1, _
                                                  Nothing, Convert.ToInt32(Me.codigoMaestro), If(Me.loteOriginal = txtLote.Text, "", txtLote.Text), _
                                                   Me.cbSinPalet.Checked) Then
                        MessageBox.Show("No se pudo guardar el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.Cursor = Cursors.Default
                        Return
                    End If
                End If

                Me.lvwPalets.Items.Add(O_Item)
                'Actualizo totales y contadores palets
                If Me.TipoPedido = PEDIDO Then
                    dgvTotales.DataSource = dtb.Consultar("SumCajasByArticulo " & Me.codigoMaestro)
                    dgvTotalesPalets.DataSource = dtb.Consultar("SumPaletsByTipoPalet " & Me.codigoMaestro)
                Else
                    dgvTotales.DataSource = dtb.Consultar("SumCajasByArticuloOC " & Me.codigoMaestro)
                    dgvTotalesPalets.DataSource = dtb.Consultar("SumPaletsByTipoPaletOC " & Me.codigoMaestro)
                End If
                'como el procedimiento no devuelve nada se claculan los totales desde el mismo codigo
                'actualizar_totales()

                'Para que no sume el peso del palet
                txtPesoPalet.Text = "0"
                ActualizarContadoresPalets()
                RaiseEvent AfterAdd(Nothing, Nothing)

            End If
        End If
        borrarTextos()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub actualizar_totales()
        Dim aux_t As DataGridViewRow
        Dim indice As Integer
        Dim i As Integer = 0

        While i < lvwPalets.Items.Count()
            indice = -1

            For Each aux_t In Me.dgvTotales.Rows
                If aux_t.Cells("Articulo").Value.ToString = lvwPalets.Items(i).SubItems(2).Text Then
                    indice = aux_t.Index
                End If
            Next

            If indice = -1 Then
                Dim dt As DataTable = CType(Me.dgvTotales.DataSource, DataTable)
                Dim row As DataRow = dt.NewRow

                row(0) = lvwPalets.Items(i).SubItems(2).Text
                row(1) = lvwPalets.Items(i).SubItems(3).Text
                row(2) = 0
                dt.Rows.Add(row)
            Else
                Me.dgvTotales.Rows(indice).Cells("Cajas").Value = If(Me.dgvTotales.Rows(indice).Cells("Cajas").Value Is Nothing, 0, Convert.ToInt32(Me.dgvTotales.Rows(indice).Cells("Cajas").Value)) + Convert.ToInt32(lvwPalets.Items(i).SubItems(3).Text)
            End If

            i = i + 1
        End While
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        If Me.lvwPalets.SelectedItems.Count > 0 Then
            'Borro el palets de la tabla seguridad y del ListView
            Dim spAlbaran As New spAlbaranesCarga
            If spAlbaran.spDeleteAlbaranCargaSeguridad(Convert.ToInt32(lvwPalets.SelectedItems(0).SubItems(0).Text)) Then
                lvwPalets.SelectedItems(0).Remove()

                'Actualizo totales y contadores de palets
                If Me.TipoPedido = PEDIDO Then
                    dgvTotales.DataSource = dtb.Consultar("SumCajasByArticulo " & Me.codigoMaestro)
                    dgvTotalesPalets.DataSource = dtb.Consultar("SumPaletsByTipoPalet " & Me.codigoMaestro)
                Else
                    dgvTotales.DataSource = dtb.Consultar("SumCajasByArticuloOC " & Me.codigoMaestro)
                    dgvTotalesPalets.DataSource = dtb.Consultar("SumPaletsByTipoPaletOC " & Me.codigoMaestro)
                End If
                'dgvTotales.DataSource = RealizarConsulta("SumCajasByArticulo " & Me.codigoMaestro)
                txtPesoPalet.Text = "0"
                ActualizarContadoresPalets()
                RaiseEvent AfterAdd(Nothing, Nothing)
            Else
                MessageBox.Show("No se pudo realizar la operación, si el problema persiste contacte con el administrador", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debes seleccionar al menos un palet", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        'MsgBox("btnGrabar Click " & EventHAndled)
        If Me.lvwPalets.Items.Count = 0 Then
            MessageBox.Show("La carga no contiene palets", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        RaiseEvent BeforeSave(Me, Nothing)
        If Not EventHAndled Then
            'En la tabla existe un campo Numero, lo cree para tener un control de los albaranes ya que el campo ID que tambien es AutoNumerico, lo maneja SQl
            ' y puede ser que falten numeros porque se han borrado algun registro.
            Dim spAlbaran As New spAlbaranesCarga
            Dim spAlmacen As New spAlmacenPalets
            Dim resultado As Boolean = False
            Dim Contador As Integer = 0
            Dim cadena As String
            Dim Linea As String
            Dim Tabla As DataTable
            Dim Numero As Integer
            Dim ConsultaLoteAlternativo As String
            Dim loteAlternativo As String
            Dim dtAux As DataTable
            Dim spOrdenesCarga As New spOrdenesCarga

            Dim extra As Integer = Convert.ToInt32(Me.codigoMaestro)

            dtb.EmpezarTransaccion()
            Try

                Numero = spAlbaran.spMaxAlbaranCargaProMaestro(dtb) + 1

                If Me.codigoMaestro = "0" Then 'en este caso es una carga de emergencia


                    If spAlmacen.cargasSinServir(dtb) = 0 Then 'no existen ordenens de carga ya creadas
                        Dim result As DialogResult = MessageBox.Show("No existen ordenes de carga sin servir, ¿generar una automaticamente?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                        If result = DialogResult.Cancel Then
                            dtb.CancelarTransaccion()
                            Return
                        Else
                            Dim m_DBO_OrdenesCarga As New DBO_OrdenesCarga
                            'crear orden de carga maestro
                            m_DBO_OrdenesCarga.Fecha = New Date(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, Now.Second)
                            m_DBO_OrdenesCarga.Ruta = "Z:\Almacen\Ordenes de carga\" & Now.Year & "." &
                                                                                        Convert.ToString(Now.Month) & "." &
                                                                                        Convert.ToString(Now.Day) & " " &
                                                                                        Convert.ToString(Now.Hour) & "-" &
                                                                                        Convert.ToString(Now.Minute)
                            m_DBO_OrdenesCarga.Observaciones = "Generada en almacen para una carga de emergencia"
                            If Not spOrdenesCarga.GrabarOrdenesCarga(m_DBO_OrdenesCarga, dtb) Then Throw New Exception("No se pudo guardar la orden de carga")
                            'crear orden de carga detalle
                            '-- SECUNDARIO
                        End If
                    End If

                    'actualizar id de orden de carga en albaran carga de seguridad donde id_pedido = null

                    If Not spAlmacen.ActulizarCargaEmergencia(dtb) Then Throw New Exception("No se pudo actualizar la carga de emergencia")
                    Me.codigoMaestro = spAlmacen.OrdenCargaselectmax(dtb).ToString
                    Me.m_TipoPedido = ORDEN_DE_CARGA
                End If

                If Me.TipoPedido = PEDIDO Then
                    If Not ctlAlb.GuardarAlbaranCargaProMaestroParaPedido(Numero,
                                                         dtpFecha.Value,
                                                         1,
                                                         NumeroPedido,
                                                         "Sin asignar a definitivo",
                                                         "",
                                                         "",
                                                         Convert.ToInt32(Me.codigoMaestro), dtb) Then Throw New Exception("Error guardando el albaran provisional")

                    ConsultaLoteAlternativo = "select LoteAlternativo from albaranescargaseguridad where id_pedidoclientemaestro = " & Me.codigoMaestro & " And scc = "
                Else
                    If Not ctlAlb.GuardarAlbaranCargaProMaestroParaOrdenCarga(Numero,
                                                        dtpFecha.Value,
                                                        1,
                                                        NumeroPedido,
                                                        "Sin asignar a definitivo",
                                                        "",
                                                        "",
                                                        Convert.ToInt32(Me.codigoMaestro), dtb) Then Throw New Exception("Error guardando el albaran provisional")

                    ConsultaLoteAlternativo = "select LoteAlternativo from albaranescargaseguridad where id_ordencarga = " & Me.codigoMaestro & " And scc = "
                End If

                Dim spPaletsProducidos As New spPaletsProducidos
                Dim m_db As DBO_PaletsProducidos

                Do While Contador < lvwPalets.Items.Count
                    m_db = Nothing
                    dtAux = dtb.Consultar(ConsultaLoteAlternativo & lvwPalets.Items(Contador).SubItems(0).Text, False)

                    loteAlternativo = If(IsDBNull(dtAux.Rows(0).Item(0)), "", dtAux.Rows(0).Item(0).ToString)

                    cadena = lvwPalets.Items(Contador).SubItems(0).Text

                    Linea = "PaletsProducidosSelectArticuloCodigoQSBySCC " & cadena

                    Tabla = dtb.Consultar(Linea)

                    If Not ctlAlbDet.GuardarAlbaranCargaProviDetalle(Numero,
                                                               Convert.ToInt32(lvwPalets.Items(Contador).SubItems(0).Text),
                                                             Convert.ToInt32(Tabla.Rows(0).Item("CodigoQS")),
                                                              lvwPalets.Items(Contador).SubItems(2).Text,
                                                               Convert.ToInt32(lvwPalets.Items(Contador).SubItems(3).Text),
                                                              33,
                                                              lvwPalets.Items(Contador).SubItems(4).Text,
                                                              44,
                                                              lvwPalets.Items(Contador).SubItems(5).Text,
                                                              "Reserva1",
                                                              "Reserva2",
                                                              "Reserva3",
                                                              loteAlternativo, dtb) Then Throw New Exception("Error guardando los detalles del alabaran provisional")


                    m_db = spPaletsProducidos.Select_RecordBySSCC(lvwPalets.Items(Contador).SubItems(0).Text, dtb)
                    m_db.EnAlmacen = False
                    If Not spPaletsProducidos.Grabar(CType(m_db, DataBussines), dtb) Then Throw New Exception("Error actualizando los datos de los palets")

                    Contador += 1
                Loop

                'Borro los registros de seguridad                
                If Me.TipoPedido = PEDIDO Then
                    If Not spAlbaran.spDeleteAlbaranCargaSeguridadAllPedido(Convert.ToInt32(Me.codigoMaestro), dtb) Then Throw New Exception("Problema limpiando tras las operaciones")
                Else
                    If Not spAlbaran.spDeleteAlbaranCargaSeguridadAllOrdenCarga(Convert.ToInt32(Me.codigoMaestro), dtb) Then Throw New Exception("Problema limpiando tras las operaciones")
                End If

                dtb.TerminarTransaccion()
                resultado = True

            Catch ex As Exception
                dtb.CancelarTransaccion()
                MessageBox.Show("Hubo un problema al realizar las operaciones. Detalles:" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If resultado Then
                    RaiseEvent AfterSave(Me, Nothing)

                    If extra <> 0 Then
                        Me.Close()
                    Else
                        Me.lvwPalets.Items.Clear()

                        Me.dgvTotalesFill()
                        Me.codigoMaestro = "0"
                    End If
                End If

                dgvDetallesFill()
            End Try
        End If
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        borrarTextos()
    End Sub

    Private Sub txtSCCEscaneado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSCCEscaneado.GotFocus
        txtSCCEscaneado.BackColor = Color.Lime
        btnOK.Enabled = False
    End Sub

    Public Sub importar()
        Dim spAlmacen As New spAlmacenPalets
        dtb.EmpezarTransaccion()

        Try
            If spAlmacen.ActulizarCargaEmergencia(dtb) Then
                Me.m_TipoPedido = ORDEN_DE_CARGA
                Me.lvwPalets.Items.Clear()

                dtb.TerminarTransaccion()
            Else
                dtb.CancelarTransaccion()
            End If
        Catch ex As Exception
            dtb.CancelarTransaccion()
        End Try
    End Sub

    Private Sub txtSCCEscaneado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSCCEscaneado.Validating
        RellenarForm()
    End Sub

    Private Sub rellenarForm()
        Dim LongitudOK As Boolean = True
        Dim spPaletsProducidos As New spPaletsProducidos

        If txtSCCEscaneado.Text <> "" Then
            txtSCCEscaneado.BackColor = Color.White

            'Se escanea el codigo de la parte inferior
            Select Case txtSCCEscaneado.Text.Length
                Case Is = 5 'Entrada manual
                    txtSCC.Text = txtSCCEscaneado.Text

                Case Is = 20
                    Select Case txtSCCEscaneado.Text.Substring(2, 1)
                        Case Is = "1" ' Coviran
                            txtSCC.Text = txtSCCEscaneado.Text.Substring(13, 5)
                        Case Is = "0" 'Resto
                            txtSCC.Text = txtSCCEscaneado.Text.Substring(14, 5)
                    End Select

                Case Is = 26 'Desarrollo de Marcas, Spar, Vivo....
                    txtSCC.Text = txtSCCEscaneado.Text.Substring(14, 5)

                Case Is = 28 'Articulos con fecha caducidad 15 + 5 + (17) + AAMMDD  Este el el formato requerido por Mercadona
                    txtSCC.Text = txtSCCEscaneado.Text.Substring(14, 5)

                Case Is = 29 'Monodosis
                    txtSCC.Text = txtSCCEscaneado.Text.Substring(14, 5)

                Case Else
                    MessageBox.Show("Numero de digitos erroneo", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtSCCEscaneado.Text = ""
                    txtSCCEscaneado.Focus()
                    LongitudOK = False
            End Select

            Try
                If LongitudOK Then
                    EventHAndled = False
                    RaiseEvent BeforeScan(Me, txtSCC.Text)
                    If EventHAndled Then
                        btnOK.Enabled = True

                        Tabla = dtb.Consultar("SelectSCC " & Me.txtSCC.Text)


                        If Tabla.Rows.Count > 0 Then
                            'Compruebo que el palets este en almacen, es decir que le campo EnAlmacen = True, por si se ha dado salida anteriormente.
                            If Convert.ToBoolean(Tabla.Rows(0).Item(4)) Then
                                If spPaletsProducidos.estaCargado(Convert.ToInt32(txtSCC.Text)) Then
                                    btnOK.Enabled = False
                                    MessageBox.Show("Este palet figura en una carga. AVISAR A MIGUEL ANGEL", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    txtObsCarga.Text = "Palet Cargado."
                                Else
                                    If Convert.ToString(Tabla.Rows(0).Item(2)) = "0" Or Convert.ToString(Tabla.Rows(0).Item(2)) = "" Then
                                        btnOK.Enabled = False
                                        'messagebox.show("Este palet figura sin contenidos. AVISAR A MIGUEL ANGEL", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                        txtObsCarga.Text = "Palet sin contenidos."

                                        Dim resp As DialogResult = MessageBox.Show("Este palet figura sin contenidos. ¿Desea continuar con su carga?" & Environment.NewLine & "En caso afirmativo se notificara a control.", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                        If resp = DialogResult.No Then
                                            btnOK.Enabled = False
                                            Return
                                        Else
                                            NotificarPaletSinContenidos()
                                            btnOK.Enabled = True
                                        End If
                                    End If

                                    Dim lotes As String
                                    Dim calendar As New Calendar

                                    If Tabla.Rows(0).Item(6).ToString = "1" Then
                                        lotes = spPaletsProducidos.DevolverLotesMultiLote(txtSCC.Text)

                                        Me.btnNoMultilote.Visible = True
                                        Me.btnMultilote.Visible = False
                                        Me.txtLote.Font = New System.Drawing.Font(Me.txtLote.Font.FontFamily.Name, 15)
                                    Else
                                        lotes = calendar.DevuelveFechaJuliana(CDate(Tabla.Rows(0).Item(0)))
                                        Me.btnMultilote.Visible = True
                                        Me.btnNoMultilote.Visible = False
                                        Me.txtLote.Font = New System.Drawing.Font(Me.txtLote.Font.FontFamily.Name, 72)
                                    End If

                                    If If(Tabla.Rows(0).Item(7) Is Nothing, 0, Convert.ToInt32(Tabla.Rows(0).Item(7))) = 3 Then
                                        Me.panNoConforme.Visible = True
                                    Else
                                        Me.panNoConforme.Visible = False
                                    End If

                                    txtFecha.Text = Tabla.Rows(0).Item(0).ToString.Substring(0, Len(Convert.ToString(Tabla.Rows(0).Item(0))) - 8)
                                    txtDescripcion.Text = Tabla.Rows(0).Item(1).ToString
                                    txtCajas.Text = If(Convert.ToString(Tabla.Rows(0).Item(2)) = "", "0", Convert.ToString(Tabla.Rows(0).Item(2)))
                                    txtLote.Text = lotes
                                    txtObsEnvasado.Text = Convert.ToString(Tabla.Rows(0).Item(3))
                                    txtPesoPalet.Text = Convert.ToString(Tabla.Rows(0).Item("Peso"))
                                    If Not IsDBNull(Tabla.Rows(0).Item("TipoPalet")) Then
                                        cboTipoPalet.SelectedValue = Tabla.Rows(0).Item("TipoPalet")
                                    End If

                                    Tabla = Nothing
                                    loteOriginal = txtLote.Text


                                    If txtObsEnvasado.Text.Contains("NO CARGAR") Or txtObsEnvasado.Text.Contains("no cargar") Then
                                        'btnOK.Enabled = False
                                        txtObsEnvasado.BackColor = Color.Yellow
                                        MessageBox.Show("Este palet no se puede cargar." & Environment.NewLine & _
                                               "Comprobar Observaciones de envasado.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                        txtObsEnvasado.BackColor = Color.White
                                    End If

                                    ActualizarContadoresPalets()
                                End If
                            Else
                                Dim resp As DialogResult = MessageBox.Show("Este palet no se encuentra en el almacen. ¿Desea marcalo como 'en almacen' y continuar?" & Environment.NewLine & _
                                                                  "(Pulse 'No' si la información es correcta y no esta en almacen)", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                If resp = DialogResult.Yes Then
                                    dtb.ConsultaAlteraciones("update paletsproducidos set enalmacen=1 where scc = " & txtSCCEscaneado.Text)
                                    rellenarForm()
                                Else
                                    btnOK.Enabled = False
                                    txtObsCarga.Text = "Este palet no figuraba en las existencias del almacen."
                                End If
                            End If
                        Else
                            'Si algun campo de la consulta esta vacio esta falla, por ejemplo CajasPalets o PesoPalet
                            MessageBox.Show("No se ha encontrado este SSCC" & Environment.NewLine & _
                                   "Comprobar que el palet tiene todos los datos" & Environment.NewLine & _
                                   "En menu envasado submenu ArticulosEnvasados puede faltar el dato de cajas por palet" & Environment.NewLine & _
                                   "y submenu Datos palets terminados comprobar que existe el Articulo con sus datos correspondientes", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            borrarTextos()
                        End If
                    Else
                        borrarTextos()
                        btnOK.Enabled = False
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show("Error en txtSCCEscaneado_Validating", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    'Private Sub txtSCC_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSCC.Validating
    '    'Para evitar se escanee por error en este campo
    '    If txtSCC.Text.Length > 6 Then
    '        txtSCC.Text = txtSCCEscaneado.Text.Substring(15, 5)
    '        e.Cancel = True
    '    End If
    'End Sub

    Private Sub borrarTextos()
        'For Each oControl As Control In Me.TabControl1.TabPages(1).Controls
        For Each oControl As Control In Me.CamposEscaner
            If TypeOf (oControl) Is TextBox Then
                If oControl.Name <> "txtPaletsTotales" AndAlso oControl.Name <> "txtPesoTotal" Then
                    oControl.Text = ""
                End If
            End If
        Next
        txtSCCEscaneado.Focus()
        Me.btnMultilote.Visible = False
        Me.btnNoMultilote.Visible = False
        Me.panNoConforme.Visible = False
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage1 Then
            txtSCCEscaneado.Focus()
        ElseIf TabControl1.SelectedTab Is TabPage2 Then

        End If
    End Sub

    Private Sub ActualizarContadoresPalets()
        Dim PaletsPorArticulo As Integer = 0
        Dim PesoTotal As Integer = 0
        Dim CajasTotal As Integer = 0
        Dim totalpal As Integer = 0
        Try
            For Each m_Item As ListViewItem In lvwPalets.Items
                If m_Item.SubItems(2).Text = txtDescripcion.Text Then
                    PaletsPorArticulo += 1
                End If
                If m_Item.SubItems(9).Text <> "True" AndAlso m_Item.SubItems(9).Text <> "1" Then
                    totalpal += 1
                End If

                PesoTotal += If(m_Item.SubItems(7).Text = "", 0, Convert.ToInt32(m_Item.SubItems(7).Text))
                CajasTotal += If(m_Item.SubItems(3).Text = "", 0, Convert.ToInt32(m_Item.SubItems(3).Text))
            Next


            txtPaletsPorArticulo.Text = Convert.ToString(PaletsPorArticulo + 1)

            txtPaletsTotales.Text = totalpal.ToString

            If txtPesoPalet.Text = "" Then txtPesoPalet.Text = "0"

            txtPesoTotal.Text = Format(Convert.ToDecimal(PesoTotal) + Convert.ToDecimal(txtPesoPalet.Text), "0#,0##")
            txtCajasTotal.Text = Format(CajasTotal, "0#")
            txtKilosCargadosTotal.Text = Format(Convert.ToDecimal(PesoTotal), "0#,0##")

        Catch ex As Exception
            MessageBox.Show("Error en ActualizarContadoresPalets. " & Environment.NewLine & "Detalles:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub EscaneoSCC1_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        dgvDetallesFill()
    End Sub

    Private Sub TabControl1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Resize
        DetailedSimpleForm.centerIn(Panel4, Me)
    End Sub

    Private Sub Panel1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel1.Resize
        DetailedSimpleForm.centerIn(Panel5, CType(Panel1, Control))
    End Sub

    Private Sub Panel2_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.Resize
        DetailedSimpleForm.centerIn(CType(Label4, Control), Panel2)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Me.SplitContainer1.Panel1Collapsed Or Me.SplitContainer1.Panel2Collapsed Then
            Me.SplitContainer1.Panel2Collapsed = False
            Me.SplitContainer1.Panel1Collapsed = False
        Else
            Me.SplitContainer1.Panel2Collapsed = True
        End If

        Pantalla.centerVerticalyIn(CType(Button4, Control), SplitContainer1.Panel1)
        Pantalla.centerVerticalyIn(CType(Button5, Control), SplitContainer1.Panel2)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        If Me.SplitContainer1.Panel1Collapsed Or Me.SplitContainer1.Panel2Collapsed Then
            Me.SplitContainer1.Panel2Collapsed = False
            Me.SplitContainer1.Panel1Collapsed = False
        Else
            Me.SplitContainer1.Panel1Collapsed = True
        End If

        Pantalla.centerVerticalyIn(CType(Button4, Control), SplitContainer1.Panel1)
        Pantalla.centerVerticalyIn(CType(Button5, Control), SplitContainer1.Panel2)
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        borrarTextos()
    End Sub

    Private Sub Panel7_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel7.Resize
        Pantalla.centerHorizontalyIn(CType(Me.Label1, Control), Me.Panel7)
    End Sub

    Private Sub TabPage3_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Resize
        Pantalla.centerVerticalyIn(CType(Button4, Control), SplitContainer1.Panel1)
        Pantalla.centerVerticalyIn(CType(Button5, Control), SplitContainer1.Panel2)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.codigoEscaneado = Me.txtSCCEscaneado.Text AndAlso Me.txtSCCEscaneado.Text <> "" Then
            contTiempo += 200

            If contTiempo >= 1000 Then
                txtDescripcion.Focus()
                Me.Timer1.Stop()
                Me.Timer1.Enabled = False
            End If
        Else
            contTiempo = 0
        End If
    End Sub

    Private Sub txtSCCEscaneado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSCCEscaneado.TextChanged
        If Me.txtSCCEscaneado.Text.Length >= 4 Then
            Me.codigoEscaneado = Me.txtSCCEscaneado.Text
            Me.contTiempo = 0

            Me.Timer1.Enabled = True
            Me.Timer1.Start()
        Else
            Me.Timer1.Stop()
            Me.Timer1.Enabled = False
        End If
    End Sub

    Private Sub btnNoMultilote_Click(sender As System.Object, e As System.EventArgs) Handles btnNoMultilote.Click
        dtb.ConsultaAlteraciones("update paletsproducidos set multilote = 0 where scc = " & txtSCCEscaneado.Text)
        rellenarForm()
    End Sub

    Private Sub btnMultilote_Click(sender As System.Object, e As System.EventArgs) Handles btnMultilote.Click
        dtb.ConsultaAlteraciones("update paletsproducidos set multilote = 1 where scc = " & txtSCCEscaneado.Text)
        rellenarForm()
    End Sub

    Private Sub NotificarPaletSinContenidos()
        Me.Cursor = Cursors.WaitCursor
        Dim dtb As New DataBase(Config.Server)
        If Not dtb.ConsultaAlteraciones("insert into notificaciones(texto, id_tipousuario, leido) values('El palet " & txtSCC.Text & " se ha expedido sin contenidos el " & Convert.ToString(Now.Date) & "' , 9, 0)") Then
            MessageBox.Show("No se pudo notificar a control. Vuelva a intentarlo en unos segundos.", "Error al notificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Cursor = Cursors.Default
        Else
            Try
                Dim mail As New Mail.Mail1And1(True, "Palet sin movimientos. Fecha" & Convert.ToString(Now.Date) & " SCC: " & txtSCC.Text, _
                                               "El palet con matrícula " & txtSCC.Text & " se ha expedido sin movimientos sobre él (con 0 cajas).", String.Empty, _
                                                Config.MailReportAddress, Config.MailReportPass, "control@landaluza.es", _
                                                String.Empty, String.Empty, Config.MailClientHost, False)

                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MessageBox.Show("Error al enviar el email. Detalles:" & Environment.NewLine & ex.Message)
            End Try
        End If
        Me.Cursor = Cursors.Default
    End Sub

 
End Class