Public Class AlmacenEntradasSalidas
    Private Tabla As DataTable
    Private codigoEscaneado As String
    Private contTiempo As Integer
    Private TodoOk As Boolean
    Private spPaletsAlmacenEntradas As spPaletsAlmacenEntradas
    Private dtb As DataBase
    Private frmPaletsAlmacenEntradas As frmPaletsAlmacenEntradas
    Private frmPaletsAlmacenEntradas2 As frmPaletsAlmacenEntradas
    Public Sub New()
        InitializeComponent()

        spPaletsAlmacenEntradas = New spPaletsAlmacenEntradas
        dtb = New DataBase(Config.Server)

        frmPaletsAlmacenEntradas = New frmPaletsAlmacenEntradas(True)
        Engine_LA.FormEnPestaña(frmPaletsAlmacenEntradas, panEntradas)
        frmPaletsAlmacenEntradas2 = New frmPaletsAlmacenEntradas(False)
        Engine_LA.FormEnPestaña(frmPaletsAlmacenEntradas2, panSalidas)
    End Sub

    Private Sub EntradasAlmacen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        With dgvEntradasTotales
            .dataSource = dtb.Consultar("PaletsAlmacenEntradasSelectEntradasByArticulo")
            .FormatoColumna("Articulo", TiposColumna.Izquierda, True)
            .FormatoColumna("Cajas", TiposColumna.Miles)
            .FormatoGeneral()
        End With

        txtSCCEscaneado.Focus()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtSCCEscaneado.Text = "" Then
            messagebox.show("No ha escaneado el palet", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim frm As New AlmacenEntradasSalidasMovimientos(txtSCC.Text, chkSalida.Checked)
            frm.ShowDialog()
            Me.TodoOk = frm.todook
            If TodoOk Then
                If txtCajas.Text = "" Then txtCajas.Text = "0"
                'Añado el palet a la Tabla
                Dim m_DBO_PaletAlmacenEntrada As New DBO_PaletsAlmacenEntradas
                m_DBO_PaletAlmacenEntrada.PaletAlmacenEntradaID = 0 'Para que grabe nuevo registro
                m_DBO_PaletAlmacenEntrada.Fecha = System.DateTime.Now
                m_DBO_PaletAlmacenEntrada.SSCC = txtSCC.Text
                m_DBO_PaletAlmacenEntrada.Cajas = If(txtCajas.Text = "", 0, Convert.ToInt32(txtCajas.Text))
                m_DBO_PaletAlmacenEntrada.ComentariosCarga = txtObsCarga.Text
                m_DBO_PaletAlmacenEntrada.Observaciones = ""
                m_DBO_PaletAlmacenEntrada.Articulo = txtDescripcion.Text
                m_DBO_PaletAlmacenEntrada.Vigente = True

                If chkSalida.Checked Then
                    m_DBO_PaletAlmacenEntrada.Cajas = -1 * Convert.ToInt32(txtCajas.Text)
                Else
                    m_DBO_PaletAlmacenEntrada.Cajas = Convert.ToInt32(txtCajas.Text)
                End If

                spPaletsAlmacenEntradas.GrabarPaletsAlmacenEntradas(m_DBO_PaletAlmacenEntrada)

                'Actualizo totales y contadores palets
                dgvEntradasTotales.DataSource = dtb.Consultar("PaletsAlmacenEntradasSelectEntradasByArticulo")
                ' ActualizarContadoresPalets()
                frm.Close()
            End If

        End If

        borrarTextos()
        chkSalida.Checked = False
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        borrarTextos()
    End Sub

    Private Sub txtSCCEscaneado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSCCEscaneado.GotFocus
        txtSCCEscaneado.BackColor = Color.Lime
        btnOK.Enabled = False
    End Sub

    Private Sub txtSCCEscaneado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSCCEscaneado.Validating
        recuperarDetalles()
    End Sub

    Private Sub recuperarDetalles()
        Dim LongitudOK As Boolean = True

       If Not IsNumeric(txtSCCEscaneado.Text) Then
            LongitudOK = False
        Else
            'Se escanea el codigo de la parte inferior
            Select Case txtSCCEscaneado.Text.Length
                Case Is = 5 'Entrada manual
                    txtSCC.Text = txtSCCEscaneado.Text

                Case Is = 20
                    Select Case txtSCCEscaneado.Text.Substring(2, 1)
                        Case Is = "1" ' Coviran
                            txtSCC.Text = txtSCCEscaneado.Text.Substring(14, 5)
                        Case Is = "0" 'Resto
                            txtSCC.Text = txtSCCEscaneado.Text.Substring(15, 5)
                    End Select

                Case Is = 26 'Desarrollo de Marcas, Spar, Vivo....
                    txtSCC.Text = txtSCCEscaneado.Text.Substring(15, 5)

                Case Is = 28 'Articulos con fecha caducidad 15 + 5 + (17) + AAMMDD  Este el el formato requerido por Mercadona
                    txtSCC.Text = txtSCCEscaneado.Text.Substring(15, 5)

                Case Is = 29 'Monodosis
                    txtSCC.Text = txtSCCEscaneado.Text.Substring(15, 5)

                Case Else
                    MessageBox.Show("Numero de digitos erroneo", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtSCCEscaneado.Text = ""
                    txtSCCEscaneado.Focus()
                    LongitudOK = False
            End Select
        End If



        Try

            If LongitudOK Then

                If Not Me.spPaletsAlmacenEntradas.EstaEnAlmacen(txtSCC.Text) Then
                    btnOK.Enabled = True

                    Tabla = dtb.Consultar("SelectSCC  " & Me.txtSCC.Text)
                    Dim calendar As New Calendar

                    If Tabla.Rows.Count > 0 Then
                        '    'Compruebo que el palets este en almacen, es decir que le campo EnAlmacen = True, por si se ha dado entrada anteriormente.
                        '    If Tabla.Rows(0).Item(4) Then
                        '        btnOK.Visible = False
                        '        messagebox.show("Este SSCC ya se encuentra en el almacen. AVISAR A MIGUEL ANGEL")
                        '        'txtObsCarga.Text = "Este palet no figuraba en las existencias del almacen."
                        '    Else

                        '    End If

                        'txtFecha.Text = Tabla.Rows(0).Item(0).ToString
                        txtDescripcion.Text = Tabla.Rows(0).Item(1).ToString
                        txtCajas.Text = Tabla.Rows(0).Item(2).ToString
                        txtLote.Text = calendar.DevuelveFechaJuliana(CDate(Tabla.Rows(0).Item(0)))
                        txtObsEnvasado.Text = Tabla.Rows(0).Item(3).ToString
                        txtPesoPalet.Text = Tabla.Rows(0).Item("Peso").ToString
                        Tabla = Nothing
                        txtSCCEscaneado.BackColor = Color.White

                        ' ActualizarContadoresPalets()
                    Else
                        'Si algun campo de la consulta esta vacio esta falla, por ejemplo CajasPalets o PesoPalet
                        btnOK.Enabled = False
                        MessageBox.Show("No se ha encontrado este SSCC" & Environment.NewLine & _
                                "Comprobar que el palet tiene todos los datos", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        borrarTextos()
                    End If
                Else
                    MessageBox.Show("El palet ya ha sido escaneado previamente. Si este dato no es correcto contacte con el administrador.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    borrarTextos()
                End If
            Else
                btnOK.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error en txtSCCEscaneado_Validating", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub borrarTextos()
        txtSCCEscaneado.Text = ""
        txtSCC.Text = ""
        txtLote.Text = ""
        txtCajas.Text = ""
        txtPaletsPorArticulo.Text = ""
        txtPesoPalet.Text = ""
        txtDescripcion.Text = ""
        txtObsCarga.Text = ""
        txtObsEnvasado.Text = ""
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        If TabControl1.SelectedTab.Name Is "tbpEntradasHoy" Then
            frmPaletsAlmacenEntradas.Refrescar()
        ElseIf TabControl1.SelectedTab.Name Is "tbpSalidasHoy" Then
            frmPaletsAlmacenEntradas2.Refrescar()
        End If

    End Sub

    'Private Sub ActualizarContadoresPalets()
    '    Dim PaletsPorArticulo As Integer = 0
    '    Dim CajasTotal As Integer = 0

    '    'Try
    '    '    For Each m_Item As ListViewItem In lvwPalets.Items
    '    '        If m_Item.SubItems(2).Text = txtDescripcion.Text Then
    '    '            PaletsPorArticulo += 1
    '    '        End If

    '    '        CajasTotal += Convert.ToInt32(m_Item.SubItems(3).Text)
    '    '    Next

    '    '    txtPaletsPorArticulo.Text = PaletsPorArticulo + 1
    '    '    txtPaletsTotales.Text = lvwPalets.Items.Count + 1

    '    'Catch ex As Exception
    '    '    messagebox.show("Error en ActualizarContadoresPalets" + Environment.NewLine & ex.Message)
    '    'End Try

    'End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.codigoEscaneado = Me.txtSCCEscaneado.Text Then
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

  
End Class