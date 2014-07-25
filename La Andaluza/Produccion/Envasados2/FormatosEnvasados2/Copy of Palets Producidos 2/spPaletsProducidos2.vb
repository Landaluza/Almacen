

Class spPaletsProducidos2
    inherits sp

    Public Shared scc As String
    Public Shared message As String

    Public Sub New()
        MyBase.New("[dbo].[PaletsProducidos5Select]", "[dbo].[PaletsProducidos5Insert]", "[dbo].[PaletsProducidos5Update]", _
                   String.Empty, "PaletsProducidos5SelectDgv", "PaletsProducidos3SelectByFormatoEnvasadoID")
    End Sub

    Public Function estaCargado(ByVal scc As String, ByRef dtb As DataBase) As Boolean
        Dim cuenta As Integer = 0


        Dim dt As DataTable = dtb.Consultar("exec [dbo].[PaletsProducidos4EstaCargado] " & scc, False)
        Try
            cuenta = If(Convert.IsDBNull(dt.Rows(0).Item(0)), 0, Convert.ToInt32(dt.Rows(0).Item(0)))
        Catch ex As Exception
            Throw New Exception("Error en la consulta. " & ex.Message)
        End Try

        'Dim selectProcedure As String = "[dbo].[PaletsProducidos4EstaCargado]"
        'Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        'selectCommand.CommandType = CommandType.StoredProcedure
        'If Not trans Is Nothing Then selectCommand.Transaction = trans
        'selectCommand.Parameters.AddWithValue("@SCC", scc)
        'Try
        '    Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
        '    If reader.Read Then
        '        cuenta = If(reader("cuenta") Is Convert.DBNull, 0, Convert.ToInt32(reader("cuenta")))
        '        reader.Close()
        '    End If
        'Catch ex As System.Data.SqlClient.SqlException
        '    Throw New Exception("Error en la consulta. " & ex.Message)
        'Finally
        '    dtb.Desconectar()
        'End Try

        Return If(cuenta > 0, True, False)
    End Function
End Class
