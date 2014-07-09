

Public Class spAutorizacion

    Public Function verificarUsuario(ByVal usuarioId As Integer, ByVal pass As String) As Boolean
        Dim resultado As Integer
        Dim dtb As New DataBase(Config.Server)

        dtb.Conectar()
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[UsuariosVerificar]")
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@usuarioId", usuarioId)
        selectCommand.Parameters.AddWithValue("@pass", pass)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                resultado = If(reader("res") Is Convert.DBNull, 0, Convert.ToInt32(reader("res")))
            Else
                resultado = 0
            End If

            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
        Return if(resultado > 0, True, False)
    End Function
End Class
