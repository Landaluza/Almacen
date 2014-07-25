Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spAlmacenPalets
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("", "", "", "", "", "")
    End Sub
    Public Function expedir(ByVal scc As String, ByVal AlbaranCargaProMaestro As String, Optional ByVal trans as System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        Try
            If trans Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
            Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
            Dim insertCommand As New System.Data.SqlClient.SqlCommand("PaletsProducidosExpedirPalet", connection)
            insertCommand.CommandType = CommandType.StoredProcedure
            If Not trans Is Nothing Then insertCommand.Transaction = trans

            insertCommand.Parameters.AddWithValue("@scc", scc)
            insertCommand.Parameters.AddWithValue("@albaran", AlbaranCargaProMaestro)

            insertCommand.Parameters.AddWithValue("@UsuarioModificacion", BasesParaCompatibilidad.Config.User)
            insertCommand.Parameters.AddWithValue("@FechaModificacion", Today.Date)

            insertCommand.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Return False
            Throw
        Finally
            If trans Is Nothing Then BasesParaCompatibilidad.BD.Cerrar()
        End Try
    End Function

    Public Sub ActulizarCargaEmergencia(ByRef trans as System.Data.SqlClient.SqlTransaction)
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[updateAlbaranCargaSeguridadEmergencia]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Transaction = trans

        updateCommand.ExecuteNonQuery()
    End Sub

    Public Function OrdenCargaselectmax(ByRef trans as System.Data.SqlClient.SqlTransaction) As Integer
        Dim id As Integer
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[OrdenesCargaSelectMax]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Transaction = trans
        Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)

        Try
            reader.Read()
            id = If(reader("ordenID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ordenID")))
        Catch ex As Exception
            Throw
        Finally
            reader.Close()
        End Try

        Return id
    End Function

    Public Function selectEntradasPorFecha(ByVal d As DateTime) As DataTable
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[PaletsAlmacenEntradasSelectByFecha]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        Dim dt As New DataTable
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@fecha", d.Date)

        Try
            
            Dim reader As System.Data.SqlClient.SqlDataReader  = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
        Finally
            connection.Close()
        End Try

        Return dt
    End Function

    Public Sub cargarComboBoxQsAlbaranCargaMaestroProvisional(ByRef combo As Windows.Forms.ComboBox)
        combo.mam_DataSource("AlbaranCargaMaestroProSelectCboQs", False)
    End Sub

    Public Function cargasSinServir() As Integer
        Try
            Return dtb.consultar("select isnull(count(ordenesCarga.OrdenCargaID),0) from OrdenesCarga where servido = 'false' and id_AlbaranCargaProMaestro is null group by ordenesCarga.OrdenCargaID", False).Rows(0).Item(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Sub cargarComboBoxSccPorAlbaranDetalleProvisional(ByRef combo As Windows.Forms.ComboBox, ByVal albaranCargaDetalleProvisional As String)
        combo.mam_DataSource("PaletsProducidosSelectCboSccByAlbaranDetalleProID " & albaranCargaDetalleProvisional, False)
    End Sub
End Class
