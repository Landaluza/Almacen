

Class spPaletsAlmacenEntradas
    inherits sp

    Public Sub New()
        MyBase.New("[dbo].[PaletsAlmacenEntradasSelect]", "[dbo].[PaletsAlmacenEntradasInsert]", "[dbo].[PaletsAlmacenEntradasUpdate]", _
                   "[dbo].[PaletsAlmacenEntradasDelete]", "PaletsAlmacenEntradasSelectByCajas 0", "PaletsAlmacenEntradasSelectByCajas")
    End Sub


    Public Function PaletsAlmacenEntradasInsert(ByVal dbo_PaletsAlmacenEntradas As DBO_PaletsAlmacenEntradas) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[PaletsAlmacenEntradasInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.Comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure

        insertCommand.Parameters.AddWithValue("@SSCC", dbo_PaletsAlmacenEntradas.SSCC)
        insertCommand.Parameters.AddWithValue("@Fecha", dbo_PaletsAlmacenEntradas.Fecha)
        insertCommand.Parameters.AddWithValue("@Articulo", dbo_PaletsAlmacenEntradas.Articulo)
        insertCommand.Parameters.AddWithValue("@Cajas", If(dbo_PaletsAlmacenEntradas.Cajas.HasValue, dbo_PaletsAlmacenEntradas.Cajas, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@ComentariosCarga", dbo_PaletsAlmacenEntradas.ComentariosCarga)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_PaletsAlmacenEntradas.Observaciones)
        insertCommand.Parameters.AddWithValue("@Vigente", dbo_PaletsAlmacenEntradas.Vigente)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_PaletsAlmacenEntradas.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_PaletsAlmacenEntradas.UsuarioModificacion)

        insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            insertCommand.ExecuteNonQuery()
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
    End Function



    Public Function PaletsAlmacenEntradasDelete(ByVal PaletAlmacenEntradaID As Int32) As Boolean


        Dim deleteProcedure As String
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand

        Try
            dtb.Conectar()

            deleteProcedure = "[dbo].[PaletsAlmacenEntradasDelete]"
            deleteCommand = dtb.Comando(deleteProcedure)
            deleteCommand.CommandType = CommandType.StoredProcedure
            '<Tag=[Four][Start]> -- please do not remove this line
            deleteCommand.Parameters.AddWithValue("@OldPaletAlmacenEntradaID", PaletAlmacenEntradaID)
            '<Tag=[Four][End]> -- please do not remove this line
            deleteCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
            deleteCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output

            deleteCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(deleteCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function GrabarPaletsAlmacenEntradas(ByVal dbo_PaletsAlmacenEntradas As DBO_PaletsAlmacenEntradas) As Boolean
        dbo_PaletsAlmacenEntradas.FechaModificacion = System.DateTime.Now.Date
        dbo_PaletsAlmacenEntradas.UsuarioModificacion = Config.User
        If dbo_PaletsAlmacenEntradas.PaletAlmacenEntradaID = 0 Then
            Return PaletsAlmacenEntradasInsert(dbo_PaletsAlmacenEntradas)
        Else
            Return False
        End If
    End Function

    Public Function EstaEnAlmacen(ByVal scc As String) As Boolean
        Dim Tabla As DataTable = dtb.Consultar("select count(* ) from PaletsAlmacenEntradas where sscc=" & scc, False)

        If If(Tabla.Rows(0).Item(0) Is Nothing, 0, Convert.ToInt32(Tabla.Rows(0).Item(0))) = 0 Then Return False

        Return True
    End Function
End Class
