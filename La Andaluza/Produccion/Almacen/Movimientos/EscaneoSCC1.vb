Imports System.Linq


Public Class EscaneoSCC1
    Inherits Windows.Forms.Form

    'Private ctlPal As New ctlPaletsProducidos
    Private Tabla As DataTable
    Private O_Item As ListViewItem
    Private ctlAlb As ctlAlbaranCargaProMaestro
    Private clsAlbDet As clsAlbaranesCargaProviDetalles
    Private ctlAlbDet As ctlAlbaranesCargaProviDetalles
    Private frmCargas As Collection
    ''Private WithEvents WinSockServer As New WinSockServer()
    Private frmEmergencia As frmCarga

    Private pedido As Pedido
    Private orden As Orden

    Public Sub New()
        InitializeComponent()
        frmCargas = New Collection

        ctlAlb = New ctlAlbaranCargaProMaestro
        clsAlbDet = New clsAlbaranesCargaProviDetalles
        ctlAlbDet = New ctlAlbaranesCargaProviDetalles
        Me.ImageList1.Images.Add("pedido", My.Resources.package_installed_updated)
        Me.ImageList1.Images.Add("orden", My.Resources.package_broken2)
        Me.ImageList1.Images.Add("emergencia", My.Resources.package_add)
        DateTimePicker1.activarFoco()
    End Sub

    Private Sub EscaneoSCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ToolTip1.SetToolTip(btnup, "Muestra/oculta los paneles")
        Me.ToolTip1.SetToolTip(btnDown, "Muestra/oculta los paneles")
        dgvFill(True)


        Me.TabControl2.Refresh()
        Me.TabControl2.SelectedIndex = 0
    End Sub

    Private Sub agnadirColumnasPedidos()
        If dgvPedidos.RowCount > 0 Then
            Dim buttonColumn As New DataGridViewButtonColumn()
            buttonColumn.HeaderText = ""
            buttonColumn.Name = "+"
            buttonColumn.Text = "..."
            buttonColumn.Width = 30
            buttonColumn.UseColumnTextForButtonValue = True
            dgvPedidos.Columns.Add(buttonColumn)

            Dim buttonstatus As New DataGridViewImageColumn()
            buttonstatus.HeaderText = ""
            buttonstatus.Name = "s"
            buttonstatus.Image = My.Resources.package_broken
            buttonstatus.Width = 30
            buttonstatus.DisplayIndex = 0
            dgvPedidos.Columns.Add(buttonstatus)
        End If
    End Sub


    Private Sub agnadirColumnasOrdenes()
        If dgvOrdenesCarga.RowCount > 0 Then
            Dim buttonexcel As New DataGridViewImageColumn
            buttonexcel.HeaderText = ""
            buttonexcel.Name = "e"
            buttonexcel.Image = My.Resources.page_excel_16
            buttonexcel.Width = 30
            dgvOrdenesCarga.Columns.Add(buttonexcel)

            Dim buttonColumn As New DataGridViewButtonColumn()
            buttonColumn.HeaderText = ""
            buttonColumn.Name = "+"
            buttonColumn.Text = "..."
            buttonColumn.Width = 30
            buttonColumn.UseColumnTextForButtonValue = True
            dgvOrdenesCarga.Columns.Add(buttonColumn)

            Dim buttonstatus As New DataGridViewImageColumn()
            buttonstatus.HeaderText = ""
            buttonstatus.Name = "s"
            buttonstatus.Image = My.Resources.package_broken
            buttonstatus.Width = 30
            buttonstatus.DisplayIndex = 0
            dgvOrdenesCarga.Columns.Add(buttonstatus)
        End If
    End Sub

    Private Sub abrirPestañas()
        Dim row As DataGridViewRow
        Dim paginas As TabPage
        Dim pan As Panel
        Dim frm As frmCarga

        paginas = New TabPage
        pan = New Panel
        frmEmergencia = New frmCarga("0", "0", frmCarga.PEDIDO)
        ' frmEmergencia = frm

        paginas.Name = "Carga provisional"
        paginas.Text = paginas.Name
        pan.Dock = DockStyle.Fill
        AddHandler frmEmergencia.AfterSave, AddressOf cerrarPestaña
        AddHandler frmEmergencia.BeforeScan, AddressOf comprobarScc
        AddHandler frmEmergencia.AfterAdd, AddressOf dgvFill
        AddHandler frmEmergencia.BeforeSave, AddressOf comprobarPedido

        paginas.Controls.Add(pan)
        Engine_LA.FormEnPestaña(frmEmergencia, pan)
        Me.TabControl2.Controls.Add(paginas)
        Me.frmCargas.Add(frmEmergencia)

        Me.TabControl2.TabPages(Me.TabControl2.TabPages.IndexOf(paginas)).ImageKey = "emergencia"

        Try
            For Each row In dgvPedidos.Rows
                paginas = New TabPage
                pan = New Panel
                frm = New frmCarga(row.Cells("PedidoClienteMaestroID").Value.ToString, If(IsDBNull(row.Cells("Numero").Value), "", row.Cells("Numero").Value.ToString), frmCarga.PEDIDO)

                paginas.Name = If(IsDBNull(row.Cells("Numero").Value), "Sin numero " & row.Index.ToString, row.Cells("Numero").Value.ToString)
                paginas.Text = paginas.Name
                pan.Dock = DockStyle.Fill
                AddHandler frm.AfterSave, AddressOf cerrarPestaña
                AddHandler frm.BeforeScan, AddressOf comprobarScc
                AddHandler frm.AfterAdd, AddressOf dgvFill
                AddHandler frm.BeforeSave, AddressOf comprobarPedido

                paginas.Controls.Add(pan)
                Engine_LA.FormEnPestaña(frm, pan)
                Me.TabControl2.Controls.Add(paginas)
                Me.frmCargas.Add(frm)

                Me.TabControl2.TabPages(Me.TabControl2.TabPages.IndexOf(paginas)).ImageKey = "pedido"
            Next
        Catch ex As Exception
        End Try

        Try
            For Each row In dgvOrdenesCarga.Rows
                paginas = New TabPage
                pan = New Panel
                frm = New frmCarga(row.Cells("OrdenCargaId").Value.ToString, row.Cells("Fecha").Value.ToString, frmCarga.ORDEN_DE_CARGA)


                paginas.Name = If(IsDBNull(row.Cells("Fecha").Value), "Sin fecha " & row.Index, row.Cells("Fecha").Value.ToString)
                paginas.Text = paginas.Name
                pan.Dock = DockStyle.Fill
                AddHandler frm.AfterSave, AddressOf cerrarPestaña
                AddHandler frm.BeforeScan, AddressOf comprobarScc
                AddHandler frm.AfterAdd, AddressOf dgvFill
                AddHandler frm.BeforeSave, AddressOf comprobarPedido

                paginas.Controls.Add(pan)
                Engine_LA.FormEnPestaña(frm, pan)
                Me.TabControl2.Controls.Add(paginas)
                Me.frmCargas.Add(frm)
                Me.TabControl2.TabPages(Me.TabControl2.TabPages.IndexOf(paginas)).ImageKey = "orden"
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvFill(sender As Object, e As EventArgs)
        dgvFill(False)
    End Sub

    Private Sub dgvFill(ByVal addcolumns As Boolean)

        Me.orden = New Orden
        Me.pedido = New Pedido
        Me.orden.addColumns = addcolumns
        dgvPedidosFill()









        'Dim row As DataGridViewRow


        'For Each row In dgvOrdenesCarga.Rows
        '    If row.Cells("terminado").Value = 0 Then
        '        c = row.Cells("s")
        '        c.Value = My.Resources.package_halfgreen
        '        c.ToolTipText = "Faltan contenidos para completar la orden de carga. Cantidad de cajas pendiente:" & row.Cells("pendiente").Value
        '    Else
        '        c = row.Cells("s")
        '        c.Value = My.Resources.package_green
        '        c.ToolTipText = "La orden de carga esta completa"
        '    End If
        'Next

        'For Each row In dgvPedidos.Rows
        '    If row.Cells("terminado").Value = 0 Then
        '        c = row.Cells("s")
        '        c.Value = My.Resources.package_halfgreen
        '        c.ToolTipText = "Faltan contenidos para completar la orden de carga. Cantidad de cajas pendiente:" & row.Cells("pendiente").Value
        '    Else
        '        c = row.Cells("s")
        '        c.Value = My.Resources.package_green
        '        c.ToolTipText = "La orden de carga esta completa"
        '    End If
        'Next


    End Sub

    Private Sub dgvOrdenesCargafill(ByVal palets As String, ByVal nPalets As String)
        bwOrdenes.RunWorkerAsync()
    End Sub

    Private Sub dgvPedidosFill()
        Dim row As DataGridViewRow

        For Each row In dgvPedidos.Rows
            row.Height = Convert.ToInt32(row.Height * 1.5)
            If Not IsDBNull(row.Cells("orden").Value) Then
                Me.pedido.orden = Me.pedido.orden & If(row.Cells("orden").Value Is Nothing, "9999", row.Cells("orden").Value.ToString) & ", "
            Else
                Me.pedido.orden = Me.pedido.orden & "9999, "
            End If
            Me.pedido.ordenIds = Me.pedido.ordenIds & row.Cells("PedidoClienteMaestroID").Value.ToString & ", "
            Me.pedido.nPaletsOrden += 1
        Next

        If Me.pedido.orden <> "" Then
            Me.pedido.orden = Me.pedido.orden.Substring(0, Me.pedido.orden.Length - 2)
            Me.pedido.ordenIds = Me.pedido.ordenIds.Substring(0, Me.pedido.ordenIds.Length - 2)
        End If

        Me.bwPedidos.RunWorkerAsync()


    End Sub

    Private Sub cerrarPestaña(sender As Object, e As EventArgs)
        If Me.TabControl2.SelectedTab.Text <> "Carga provisional" Then
            Dim selected As Integer = Me.TabControl2.SelectedIndex
            Me.TabControl2.SelectedIndex = 0
            Me.TabControl2.TabPages.RemoveAt(selected)
            Me.TabControl2.Refresh()
            dgvFill(Nothing, Nothing)
        Else
            Dim frm As frmCarga = CType(sender, frmCarga)
            frm.Codigo = "0"
        End If
    End Sub


    Private Sub comprobarScc(ByRef sender As Object, ByVal scc As String)
        Dim frm As frmCarga = CType(sender, frmCarga)
        Dim row As DataGridViewRow
        frm.EventHAndled = False

        If frm.TipoPedido = frmCarga.PEDIDO Then
            For Each row In Me.dgvPedidos.Rows
                If Convert.ToString(row.Cells("Numero").Value) = Me.TabControl2.SelectedTab.Text Then
                    If Convert.ToString(row.Cells("Palets").Value).Contains(scc) Then
                        frm.EventHAndled = True
                        Exit For
                    End If
                End If
            Next
        Else
            For Each row In Me.dgvOrdenesCarga.Rows
                If Me.TabControl2.SelectedTab.Text.Length > 15 Then
                    If Convert.ToString(row.Cells("Fecha").Value).Substring(0, 16) = Me.TabControl2.SelectedTab.Text.Substring(0, 16) Then
                        If row.Cells("Palets").Value.ToString.Contains(scc) Then
                            frm.EventHAndled = True
                            Exit For
                        End If
                    End If
                End If
            Next
        End If

        If Not frm.EventHAndled Then
            Dim Respuesta As DialogResult
            Respuesta = MessageBox.Show(" El palet no se encuentra entre los sugeridos" & Environment.NewLine & _
                               "¿Desea continuar?", _
                               "Palet no sugerido", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Respuesta = DialogResult.Yes Then
                frm.EventHAndled = True
            End If
        End If
    End Sub


    Private Sub comprobarPedido(sender As Object, e As EventArgs)
        Dim frm As frmCarga = CType(sender, frmCarga)
        Dim row As DataGridViewRow
        frm.EventHAndled = True

        If Me.TabControl2.SelectedTab.Text <> "Carga provisional" Then
            If frm.TipoPedido = frmCarga.PEDIDO Then
                For Each row In Me.dgvPedidos.Rows
                    If Convert.ToString(row.Cells("Numero").Value) = Me.TabControl2.SelectedTab.Text Then
                        If Convert.ToString(row.Cells("Palets").Value) = "" Then frm.EventHAndled = False
                        Exit For
                    End If
                Next
            Else
                For Each row In Me.dgvOrdenesCarga.Rows
                    If Me.TabControl2.SelectedTab.Text.Length > 15 Then
                        If Convert.ToString(row.Cells("Fecha").Value).Substring(0, 16) = Me.TabControl2.SelectedTab.Text.Substring(0, 16) Then
                            If Convert.ToString(row.Cells("Palets").Value) = "" Or Convert.ToString(row.Cells("Palets").Value) = " Sin información, revisar excel. " Then frm.EventHAndled = False

                            Exit For
                        End If
                    End If
                Next
            End If
        Else
            frm.EventHAndled = False
        End If

        If frm.EventHAndled Then
            Dim Respuesta As DialogResult
            Respuesta = MessageBox.Show(" Aun quedan palets por escanear en el pedido" & Environment.NewLine & _
                               "¿Desea ignorarlos y grabar?", _
                               "Palet no sugerido", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Respuesta = DialogResult.Yes Then
                frm.EventHAndled = False
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub


    Private Sub dgvPedidos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPedidos.CellDoubleClick
        If Not Me.dgvPedidos.CurrentRow Is Nothing Then
            If Not IsDBNull(Me.dgvPedidos.CurrentRow.Cells("Numero").Value) Then
                Dim tab As TabPage
                For Each tab In Me.TabControl2.TabPages
                    If tab.Text = Convert.ToString(Me.dgvPedidos.CurrentRow.Cells("Numero").Value) Then
                        Me.TabControl2.SelectedTab = tab
                        Dim frmCarga As frmCarga = CType(Me.frmCargas.Item(TabControl2.SelectedIndex), frmCarga)
                        frmCarga.TabControl1.SelectedIndex = 1
                        Return
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub ImprimirListadoDeSCCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirListadoDeSCCToolStripMenuItem.Click
        imprimirSCC(0)
    End Sub


    Private Sub EscaneoSCC1_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        '        abrirPestañas()
        Dim st As DataGridViewCellStyle = dgvPedidos.DefaultCellStyle
        st.SelectionBackColor = Color.LimeGreen
        st.SelectionForeColor = Color.White
        dgvPedidos.DefaultCellStyle = st
        Me.Timer1.Start()

    End Sub

    Private Sub dgvPedidos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPedidos.CellClick
        'OrElse Not e.ColumnIndex = dgvPedidos.Columns("+").Index OrElse Not e.ColumnIndex = dgvPedidos.Columns("orden").Index Then Return
        If Not e.RowIndex < 0 Then


            If e.ColumnIndex = dgvPedidos.Columns("+").Index Then
                If Not IsDBNull(Me.dgvPedidos.CurrentRow.Cells("Palets").Value) Then
                    Dim frm As New frmSugerenciaCarga(Me.dgvPedidos.CurrentRow.Cells("Palets").Value.ToString, "Pedido: " & Me.dgvPedidos.CurrentRow.Cells("Numero").Value.ToString & ", " & "Cliente: " & Me.dgvPedidos.CurrentRow.Cells("Cliente").Value.ToString)
                    frm.ShowDialog()
                    dgvFill(Nothing, Nothing)
                End If
            End If
        End If
    End Sub

    Private Sub dgvOrdenesCarga_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOrdenesCarga.CellClick
        If Not dgvOrdenesCarga.CurrentRow Is Nothing Then
            Select Case (e.ColumnIndex)
                Case dgvOrdenesCarga.Columns("+").Index
                    If (Not IsDBNull(Me.dgvOrdenesCarga.CurrentRow.Cells("Palets").Value)) AndAlso Me.dgvOrdenesCarga.CurrentRow.Cells("Palets").Value.ToString <> " Sin información, revisar excel. " Then

                        Dim frm As New frmSugerenciaCarga(Me.dgvOrdenesCarga.CurrentRow.Cells("Palets").Value.ToString, "Orden de Carga: " & Me.dgvOrdenesCarga.CurrentRow.Cells("Fecha").Value.ToString)
                        frm.ShowDialog()
                        dgvFill(Nothing, Nothing)
                    End If
                Case dgvOrdenesCarga.Columns("e").Index
                    If Not IsDBNull(Me.dgvOrdenesCarga.CurrentRow.Cells("ruta").Value) Then
                        Try
                            Dim oApp As New Microsoft.Office.Interop.Excel.Application
                            Dim oWBa As Microsoft.Office.Interop.Excel.Workbook = oApp.Workbooks.Open(Me.dgvOrdenesCarga.CurrentRow.Cells("ruta").Value.ToString)
                            oApp.Visible = True
                            oWBa.Activate()
                        Catch ex As Exception
                            MessageBox.Show("No se pudo abrir el archivo excel. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                Case Else
                    Return
            End Select
        End If
    End Sub

    Private Sub ImprimirListadoDeSCCToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirListadoDeSCCToolStripMenuItem1.Click
        imprimirSCC(1)
    End Sub

    Private Sub imprimirSCC(ByVal opcion As Byte)
        Try
            Dim aux As frmSugerenciaCarga

            If opcion = 0 Then
                aux = New frmSugerenciaCarga(Me.dgvPedidos.CurrentRow.Cells("Palets").Value.ToString, "Pedido: " & Me.dgvPedidos.CurrentRow.Cells("Numero").Value.ToString & ", " & "Cliente: " & Me.dgvPedidos.CurrentRow.Cells("Cliente").Value.ToString)
                aux.dgvFill(Me.dgvPedidos.CurrentRow.Cells("Palets").Value.ToString)
            Else
                aux = New frmSugerenciaCarga(Me.dgvOrdenesCarga.CurrentRow.Cells("Palets").Value.ToString, "Orden de Carga: " & Me.dgvOrdenesCarga.CurrentRow.Cells("Fecha").Value.ToString)
                aux.dgvFill(Me.dgvPedidos.CurrentRow.Cells("Palets").Value.ToString)
            End If
            'Dim aux As New frmSugerenciaCarga(Me.dgvPedidos.CurrentRow.Cells("PedidoClienteMaestroID").Value, Me.dgvPedidos.CurrentRow.Cells("Palets").Value, "Pedido: " & Me.dgvPedidos.CurrentRow.Cells("Numero").Value & ", " & "Cliente: " & Me.dgvPedidos.CurrentRow.Cells("Cliente").Value)
            aux.PrintGrilla.Print()
        Catch ex As Exception
            MessageBox.Show("No se pudo realizar la impresion. Vuelva a intentarlo en unos segundos", "Impresion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub dgvOrdenesCarga_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOrdenesCarga.CellDoubleClick
        If Not dgvOrdenesCarga.CurrentRow Is Nothing Then
            If Not IsDBNull(Me.dgvOrdenesCarga.CurrentRow.Cells("Fecha").Value) Then
                Dim tab As TabPage
                For Each tab In Me.TabControl2.TabPages
                    If tab.Text.Length >= 16 AndAlso Me.dgvOrdenesCarga.CurrentRow.Cells("Fecha").Value.ToString.Length >= 16 Then
                        If tab.Text.ToString.Substring(0, 16) = Me.dgvOrdenesCarga.CurrentRow.Cells("Fecha").Value.ToString.Substring(0, 16) Then
                            Me.TabControl2.SelectedTab = tab
                            Dim frmCarga As frmCarga = CType(Me.frmCargas.Item(TabControl2.SelectedIndex), frmCarga)
                            frmCarga.TabControl1.SelectedIndex = 1
                            Return
                        End If
                    End If
                Next
            End If
        End If
    End Sub


    Private Sub DarPrioridadAltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DarPrioridadAltaToolStripMenuItem.Click
        Try
            Me.dgvPedidos.CurrentRow.Cells("orden").Value = 1
            dgvFill(Nothing, Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ImportarCargaDeEmergenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarCargaDeEmergenciaToolStripMenuItem.Click
        frmEmergencia.importar()
        Try
            Dim tab As TabPage
            For Each tab In Me.TabControl2.TabPages
                If tab.Text.Length >= 16 AndAlso Me.dgvOrdenesCarga.CurrentRow.Cells("Fecha").Value.ToString.Length >= 16 Then
                    If tab.Text.ToString.Substring(0, 16) = Me.dgvOrdenesCarga.CurrentRow.Cells("Fecha").Value.ToString.Substring(0, 16) Then
                        Me.TabControl2.SelectedTab = tab
                        Dim frmCarga As frmCarga = CType(Me.frmCargas.Item(TabControl2.SelectedIndex), frmCarga)
                        frmCarga.dgvDetallesFill()
                        frmCarga.dgvTotalesFill()
                        Return
                    End If
                End If
            Next
        Catch ex As Exception
            Me.TabControl2.SelectedTab = Me.TabControl2.TabPages(0)
            messagebox.show("Ha ocurrido un error al recargar la pestaña de la orden de carga." & Environment.NewLine & "Cierra y vuelve a abrir la ventana para que se vean lso contenidos nuevos", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Me.Close()
            Dim aux As New EscaneoSCC1()
            aux.ShowDialog()
        End Try

    End Sub

    Private Sub PriorizarLasOrdenesDeCargaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriorizarLasOrdenesDeCargaToolStripMenuItem.Click
        Me.SplitContainer1.Panel1Collapsed = True
        dgvOrdenesCargafill("", "0")
    End Sub

    Private Sub PriorizarPedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriorizarPedidosToolStripMenuItem.Click
        Me.SplitContainer1.Panel2Collapsed = True
        dgvPedidosFill()
    End Sub



    Private Sub btnup_Click(sender As System.Object, e As System.EventArgs) Handles btnup.Click
        If Me.SplitContainer1.Panel2Collapsed Or Me.SplitContainer1.Panel1Collapsed Then
            Me.SplitContainer1.Panel1Collapsed = False
            Me.SplitContainer1.Panel2Collapsed = False
            dgvFill(False)
        Else
            Me.SplitContainer1.Panel2Collapsed = True
            dgvPedidosFill()
        End If
    End Sub

    Private Sub btnDown_Click(sender As System.Object, e As System.EventArgs) Handles btnDown.Click
        If Me.SplitContainer1.Panel2Collapsed Or Me.SplitContainer1.Panel1Collapsed Then
            Me.SplitContainer1.Panel1Collapsed = False
            Me.SplitContainer1.Panel2Collapsed = False
            dgvFill(False)
        Else
            Me.SplitContainer1.Panel1Collapsed = True
            dgvOrdenesCargafill("", "0")
        End If
    End Sub

    Private Sub EscaneoSCC1_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        Pantalla.centerVerticalyIn(PanCbtn, PanBtn)
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        dgvFill(False)

    End Sub

    Private Sub btnRefrescar_Click(sender As System.Object, e As System.EventArgs) Handles btnRefrescar.Click

        dgvFill(False)

    End Sub

    Private Sub bwOrdenes_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwOrdenes.DoWork
        Me.orden.cargar_datos()
    End Sub

    Private Sub bwOrdenes_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwOrdenes.RunWorkerCompleted


        dgvOrdenesCarga.DataSource = orden.datasource
        If Not orden.datasource Is Nothing Then
            With dgvOrdenesCarga

                If Not .DataSource Is Nothing Then
                    .Columns("OrdenCargaId").Visible = False
                    .Columns("terminado").Visible = False
                    .Columns("pendiente").Visible = False
                    .Columns("ruta").Visible = False
                    .FormatoColumna("fecha", "Fecha", TiposColumna.Izquierda, 99)
                    .FormatoColumna("Observaciones", TiposColumna.Izquierda, True)
                    .FormatoColumna("Palets", TiposColumna.Izquierda, True)
                    .FormatoGeneral()
                End If
            End With
        End If

        If Me.orden.addColumns Then agnadirColumnasOrdenes()

        Dim c As DataGridViewImageCell

        For Each row As DataGridViewRow In dgvOrdenesCarga.Rows
            row.Height = Convert.ToInt32(row.Height * 1.5)

            If If(row.Cells("terminado").Value Is Nothing, 0, Convert.ToInt32(row.Cells("terminado").Value)) = 0 Then
                c = CType(row.Cells("s"), DataGridViewImageCell)
                c.Value = My.Resources.package_halfgreen
                c.ToolTipText = "Faltan contenidos para completar la orden de carga. Cantidad de cajas pendiente:" & row.Cells("pendiente").Value.ToString
            Else
                c = CType(row.Cells("s"), DataGridViewImageCell)
                c.Value = My.Resources.package_green
                c.ToolTipText = "La orden de carga esta completa"
            End If
        Next

        If Me.orden.addColumns Then abrirPestañas()
    End Sub

    Private Sub bwPedidos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwPedidos.DoWork
        Me.pedido.cargar_datos()
    End Sub

    Private Sub bwPedidos_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwPedidos.RunWorkerCompleted
        dgvPedidos.DataSource = Me.pedido.datasource
        If Not Me.pedido.datasource Is Nothing Then
            With dgvPedidos
                .DataSource = Me.pedido.datasource
                If Not .DataSource Is Nothing Then
                    Try
                        .Columns("PedidoClienteMaestroID").Visible = False
                        .Columns("clienteID").Visible = False
                        .Columns("orden").Visible = False
                        .Columns("terminado").Visible = False
                        .Columns("pendiente").Visible = False
                        .FormatoColumna("Cliente", TiposColumna.Izquierda, 295)
                        .FormatoColumna("Numero", TiposColumna.Miles, 90)
                        .FormatoColumna("Procedencia", TiposColumna.Izquierda, True)
                        .FormatoColumna("Observaciones", TiposColumna.Izquierda, True)
                        .FormatoColumna("Palets", TiposColumna.Izquierda, True)
                        .FormatoGeneral()
                    Catch ex As Exception
                    End Try
                End If
            End With
        End If

        If orden.addColumns Then agnadirColumnasPedidos()

        Dim c As DataGridViewImageCell


        For Each row As DataGridViewRow In dgvPedidos.Rows
            row.Height = Convert.ToInt32(row.Height * 1.5)
            If Not IsDBNull(row.Cells("Palets").Value) Then
                Me.orden.palets = Me.orden.palets & row.Cells("Palets").Value.ToString & ", "
                Me.orden.nPalets += Split(row.Cells("Palets").Value.ToString, ", ").Count
            End If

            If Convert.ToInt32(row.Cells("terminado").Value) = 0 Then
                c = CType(row.Cells("s"), DataGridViewImageCell)
                c.Value = My.Resources.package_halfgreen
                c.ToolTipText = "Faltan contenidos para completar la orden de carga. Cantidad de cajas pendiente:" & row.Cells("pendiente").Value.ToString
            Else
                c = CType(row.Cells("s"), DataGridViewImageCell)
                c.Value = My.Resources.package_green
                c.ToolTipText = "La orden de carga esta completa"
            End If
        Next

        If Me.orden.palets.Length > 0 AndAlso Me.orden.palets.Contains(",") Then Me.orden.palets = Me.orden.palets.Substring(0, Me.orden.palets.Length - 2)
        dgvOrdenesCargafill(Me.orden.palets, Me.orden.nPalets.ToString)

    End Sub
End Class