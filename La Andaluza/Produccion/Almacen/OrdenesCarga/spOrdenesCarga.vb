

Class spOrdenesCarga
    inherits sp

    Public Sub New()
        MyBase.New("[dbo].[OrdenesCargaSelect]", "[dbo].[OrdenesCargaInsert]", "[dbo].[OrdenesCargaUpdate]", _
                   "[dbo].[OrdenesCargaDelete]", "OrdenesCargaSelectDgv", "OrdenesCargaSelectDgvByID")
    End Sub

    Public Function OrdenesCargaInsert(ByVal dbo_OrdenesCarga As DBO_OrdenesCarga, ByRef transacDtb As DataBase) As Boolean
        Dim insertCommand As System.Data.SqlClient.SqlCommand = transacDtb.Comando("[dbo].[OrdenesCargaInsert]")
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Fecha", dbo_OrdenesCarga.Fecha)
        insertCommand.Parameters.AddWithValue("@Ruta", dbo_OrdenesCarga.Ruta)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_OrdenesCarga.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_OrdenesCarga.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_OrdenesCarga.UsuarioModificacion)

        Try
            insertCommand.ExecuteNonQuery()
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        End Try
    End Function


    Public Function GrabarOrdenesCarga(ByVal dbo_OrdenesCarga As DBO_OrdenesCarga, ByRef transactDtb As DataBase) As Boolean
        dbo_OrdenesCarga.FechaModificacion = System.DateTime.Now.Date
        dbo_OrdenesCarga.UsuarioModificacion = Config.User

        Return OrdenesCargaInsert(dbo_OrdenesCarga, transactDtb)

    End Function
   
End Class
