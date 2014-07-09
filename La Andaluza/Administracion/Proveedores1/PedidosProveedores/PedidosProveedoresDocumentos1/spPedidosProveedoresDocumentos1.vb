

Class spPedidosProveedoresDocumentos1
    inherits sp

    Public Sub New()
        MyBase.New("[dbo].[PedidosProveedoresDocumentos1Select]", "[dbo].[PedidosProveedoresDocumentos1Insert]", "[dbo].[PedidosProveedoresDocumentos1Update]", _
                    "[dbo].[PedidosProveedoresDocumentos1Delete]", "PedidosProveedoresDocumentos1SelectDgv", "PedidosProveedoresDocumentos1SelectDgvByPedidoProveedorMaestroID")
    End Sub

    'Public Function Select_Record(ByVal PedidoProveedorDocumentoID As Int32) As DBO_PedidosProveedoresDocumentos1
    '    dtb.Conectar()
    '    Dim DBO_PedidosProveedoresDocumentos1 As New DBO_PedidosProveedoresDocumentos1

    '    Dim selectProcedure As String = "[dbo].[PedidosProveedoresDocumentos1Select]"
    '    Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando(selectProcedure)
    '    selectCommand.CommandType = CommandType.StoredProcedure
    '    selectCommand.Parameters.AddWithValue("@PedidoProveedorDocumentoID", PedidoProveedorDocumentoID)
    '    Try
    '        Dim reader As System.Data.SqlClient.SqlDataReader  = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
    '        If reader.Read Then
    '            DBO_PedidosProveedoresDocumentos1.PedidoProveedorDocumentoID = If(reader("PedidoProveedorDocumentoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidoProveedorDocumentoID")))
    '            DBO_PedidosProveedoresDocumentos1.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
    '            DBO_PedidosProveedoresDocumentos1.Ruta = If(reader("Ruta") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Ruta")))
    '            DBO_PedidosProveedoresDocumentos1.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
    '            DBO_PedidosProveedoresDocumentos1.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
    '            DBO_PedidosProveedoresDocumentos1.PedidoProveedorMaestroID = If(reader("PedidoProveedorMaestroID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidoProveedorMaestroID")))
    '            DBO_PedidosProveedoresDocumentos1.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
    '            DBO_PedidosProveedoresDocumentos1.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
    '        Else
    '            DBO_PedidosProveedoresDocumentos1 = Nothing
    '        End If
    '        reader.Close()
    '    Catch ex As System.Data.SqlClient.SqlException
    '        Throw
    '    Finally
    '        dtb.Desconectar()
    '    End Try
    '    Return DBO_PedidosProveedoresDocumentos1
    'End Function

    Public Function PedidosProveedoresDocumentos1Insert(ByVal dbo_PedidosProveedoresDocumentos1 As DBO_PedidosProveedoresDocumentos1) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[PedidosProveedoresDocumentos1Insert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.Comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_PedidosProveedoresDocumentos1.Descripcion)
        insertCommand.Parameters.AddWithValue("@Ruta", dbo_PedidosProveedoresDocumentos1.Ruta)
        insertCommand.Parameters.AddWithValue("@Fecha", dbo_PedidosProveedoresDocumentos1.Fecha)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_PedidosProveedoresDocumentos1.Observaciones)
        insertCommand.Parameters.AddWithValue("@PedidoProveedorMaestroID", dbo_PedidosProveedoresDocumentos1.PedidoProveedorMaestroID)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_PedidosProveedoresDocumentos1.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_PedidosProveedoresDocumentos1.UsuarioModificacion)
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

End Class
