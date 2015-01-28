Public Class Pedido
    Public orden As String
    Public ordenIds As String
    Public nPaletsOrden As Integer
    Public datasource As DataTable
    Public Sub New()
        orden = ""
        ordenIds = ""
        nPaletsOrden = 0

    End Sub

    Public Sub cargar_datos()
        Dim dtb As New DataBase(Config.Server)
        datasource = dtb.Consultar("PedidosClientesByDiaServicio2 '" & orden & "', '" & ordenIds & "', " & nPaletsOrden)
    End Sub
End Class
