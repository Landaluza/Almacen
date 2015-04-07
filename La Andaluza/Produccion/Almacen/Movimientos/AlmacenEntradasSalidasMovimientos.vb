Public Class AlmacenEntradasSalidasMovimientos
    Private m_EsSalida As Boolean
    Private m_SSCC As String
    Public todoOk As Boolean
    Private dtb As DataBase
    Public Sub New(ByRef SSCC As String, EsSalida As Boolean)
        InitializeComponent()
        m_EsSalida = EsSalida
        m_SSCC = SSCC
        dtb = New DataBase(Config.Server)
    End Sub

    Private Sub AlmacenEntradasSalidasMovimientos_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        dgvMovimientosAnteriores.DataSource = dtb.Consultar("PaletsAlmacenEntradas1SelectDgvBySSCC " & m_SSCC.ToString)

        If dgvMovimientosAnteriores.RowCount > 0 Then
            lblTexto.Text = "Movimientos del SSCC " & m_SSCC

            Dim Cajas As Integer = 0
            For Each m_Row As DataGridViewRow In dgvMovimientosAnteriores.Rows
                Cajas += If(m_Row.Cells("Cajas").Value Is Nothing, 0, Convert.ToInt32(m_Row.Cells("Cajas").Value))
            Next
            lblCajas.Text = "Cajas en almacen = " & Cajas.ToString


            If m_EsSalida Then
                If Cajas <= 0 Then
                    lblTexto2.Text = "No hay que cajas que llevar a envasado. Por favor, comprueba los movimientos"
                ElseIf Cajas = Convert.ToInt32(dgvMovimientosAnteriores.Rows(0).Cells("CajasPalet").Value) Then
                    lblTexto2.Text = "Parece que vas a devolver a envasado un palet completo. Por favor, comprueba los movimientos"
                End If
            Else
                lblTexto2.Text = "Ya hay una entrada con este SSCC. Por favor, comprueba los movimientos"
            End If

            With dgvMovimientosAnteriores
                .Columns("PaletAlmacenEntradaID").Visible = False
                .Columns("Vigente").Visible = False
                .Columns("Articulo").Visible = False
                .Columns("CajasPalet").Visible = False

                .FormatoColumna("Fecha", TiposColumna.Izquierda, 100)
                .FormatoColumna("Cajas", TiposColumna.Miles, 50)
                .FormatoColumna("ComentariosCarga", TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", TiposColumna.Izquierda, True)
                .FormatoGeneral()
            End With
        Else
            TodoOK = True
            Me.Close()
        End If
    End Sub

    Private Sub butAceptar_Click(sender As System.Object, e As System.EventArgs) Handles butAceptar.Click
        TodoOK = True
        Me.Close()
    End Sub

    Private Sub butCancelar_Click(sender As System.Object, e As System.EventArgs) Handles butCancelar.Click
        TodoOK = False
        Me.Close()
    End Sub

End Class