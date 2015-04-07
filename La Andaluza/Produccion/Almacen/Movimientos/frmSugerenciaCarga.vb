Public Class frmSugerenciaCarga
    'Private pedidoMaestro As Integer
    Protected print As ToolStripButton    

    Public Sub New(ByVal valores As String, Optional ByVal titulo As String = "")
        InitializeComponent()

        dgvSugeridos.Columns.Add("Scc", "Scc")
        dgvSugeridos.Columns.Add("Articulo", "Articulo")
        dgvSugeridos.Columns.Add("Cajas", "Cajas")
        'Me.pedidoMaestro = pedido
        dgvFill(valores)        
    End Sub

    Public Sub dgvFill(ByVal valores As String)        
        Dim pp As New DBO_PaletsProducidos
        Dim spPaletsProducidos As New spPaletsProducidos        
        Dim strArr() As String
        Dim descripcion As String = ""
        Dim cajas As Integer = 0

        strArr = valores.Split(","c)

        dgvSugeridos.Rows.Clear()

        For Each scc As String In strArr
            scc = scc.Replace(",", "")
            pp = spPaletsProducidos.Select_RecordBySSCC(scc, spPaletsProducidos.Database)
            spPaletsProducidos.Detalles(pp.FormatoID.ToString, scc, descripcion, cajas)
            dgvSugeridos.Rows.Add(scc, descripcion, cajas)
        Next

        With Me.dgvSugeridos
            '.DataSource = dtb.Consultar ("PaletsSugeridosByPedidosClientes " & Me.pedidoMaestro)
            .FormatoColumna("Scc", TiposColumna.Izquierda, 60, 0)
            .FormatoColumna("Articulo", TiposColumna.Izquierda, True, 2)
            .FormatoColumna("Cajas", TiposColumna.Izquierda, 40, 3)
            .FormatoGeneral()
        End With
    End Sub
    Private Sub PrintGrilla_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintGrilla.PrintPage
        'Impresora.imprimirGrilla(Me.dgvSugeridos, e, 10)        
        'Dim s(0 To 1) As String
        's(0) = Me.Text
        Dim p As New Printer
        p.imprimirGrilla(dgvSugeridos, Me.Text.Split(","c), Nothing, True, True)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            PrintGrilla.Print()
        Catch ex As Exception
            MessageBox.Show("No se pudo realizar la impresion. Vuelva a intentarlo en unos segundos", "Impresion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim resp As Byte = NotificarPaletExtraviado()
        If resp = 1 Then
            'dgvFill()
            Me.dgvSugeridos.Rows.Remove(Me.dgvSugeridos.CurrentRow)
        ElseIf resp = 2 Then
            MessageBox.Show("No se ha podido completar la operación, vuelva a intentarlos en unos minutos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf resp = 0 Then
            MessageBox.Show("Se ha dado de baja el palet pero no se ha podido enviar una notificación al gerente." & Environment.NewLine _
                & " Por favor notifiquelo de la anomalía", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Function NotificarPaletExtraviado() As Byte
        Dim spPaletsProducidos As New spPaletsProducidos
        If spPaletsProducidos.marcarComoExtraviado(Convert.ToInt32(Me.dgvSugeridos.CurrentRow.Cells("Scc").Value), spPaletsProducidos.Database) Then
            Dim m As New Mail.MailGerente()
            If m.sendSimple("Palet " & Me.dgvSugeridos.CurrentRow.Cells("Scc").Value.ToString & _
                            " extraviado", "No se ha podido localizar el palet con scc " & _
                            Me.dgvSugeridos.CurrentRow.Cells("Scc").Value.ToString & _
                            " en el almacen. La aplicacion lo ha marcado como extraviado y a expedido el siguiente palet.", "almacen@lAndalsoaluza.es", "Almacen2008") Then
                Return 1
            Else
                Return 0
            End If
        Else
            Return 2
        End If
    End Function

    Private Sub frmSugerenciaCarga_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.Cursor = Cursors.Default
    End Sub
End Class