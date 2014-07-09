Public Class Notificador
    

    Function comprobarNotificaciones() As DataTable
        Dim dtb As New DataBase(Config.Server)
        Dim dt As DataTable

        Try
            dt = dtb.Consultar("Select texto, id from notificaciones where id_TipoUsuario = " & Config.UserType & " and leido = 0", False)
            'dtb.ConsultaAlteraciones("update notificaciones set leido = 1 where id_TipoUsuario = " & Config.UserType & " and leido = 0")

        Catch ex As Exception
            Return Nothing
        End Try

        Return dt
    End Function

    Public Function borrarNotificacion(ByVal id As Integer) As Boolean
        Dim dtb As New DataBase(Config.Server)

        Try
            Return dtb.ConsultaAlteraciones("delete from notificaciones where id = " & id)             
        Catch ex As Exception
            Return False
        End Try
    End Function


    Function comprobarNumeroPedidos() As Integer
        Dim dtb As New DataBase(Config.Server)


        Dim dt As DataTable = dtb.Consultar("PedidosClientesCountByDiaServicio2", True)

        If dt Is Nothing Then Return 0
        If dt.Rows(0) Is Nothing Then Return 0

        Return Convert.ToInt32(dt.Rows(0).Item(0))
    End Function

    Function comprobarNumeroOC() As Integer
        Dim dtb As New DataBase(Config.Server)


        Dim dt As DataTable = dtb.Consultar("OrdenesDeCargaCountByDiaServicio", True)

        If dt Is Nothing Then Return 0
        If dt.Rows(0) Is Nothing Then Return 0

        Return Convert.ToInt32(dt.Rows(0).Item(0))
    End Function
End Class
