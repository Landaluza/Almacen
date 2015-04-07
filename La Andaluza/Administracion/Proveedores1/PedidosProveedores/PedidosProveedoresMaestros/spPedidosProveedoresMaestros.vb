

Class spPedidosProveedoresMaestros
    inherits sp

    Public Sub New()
        MyBase.New("[dbo].[PedidosProveedoresMaestrosSelect]", "[dbo].[PedidosProveedoresMaestrosInsert]", "[dbo].[PedidosProveedoresMaestrosUpdate]", _
                   "[dbo].[PedidosProveedoresMaestrosDelete]", "PedidosProveedoresMaestrosSelectDgv", String.Empty)
    End Sub

    Public Function SelectProveedoresMailsPedidos(ByVal ProveedorID As Integer) As DataTable
        dtb.Conectar()
        Dim selectProcedure As String = "[dbo].[ProveedoresMailsPedidosSelectDgvByProveedorID]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ProveedorID", ProveedorID)
        Dim dt As New DataTable

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dtb.desconectar()
        End Try
        Return dt
    End Function

End Class
