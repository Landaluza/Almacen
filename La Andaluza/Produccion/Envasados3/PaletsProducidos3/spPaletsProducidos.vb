

Public Class spPaletsProducidos
Inherits StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[PaletsProducidos5Select]", _
                        "[dbo].[PaletsProducidosInsert]", _
                        "[dbo].[PaletsProducidosUpdate]", _
                        "[dbo].[PaletsProducidos3Delete]", _
                        "[dbo].[PaletsProducidosSelectDgv]", _
                        "[dbo].[PaletsProducidos6SelectByFormatoEnvasadoID]")
    End Sub

    Overrides Function Delete(ByVal id As Integer, ByRef transactDtb As DataBase) As Boolean
        Return True
    End Function

    Public Function Select_RecordBySSCC(ByVal scc As String, ByRef transactDtb As DataBase) As DBO_PaletsProducidos
        Dim dbo As New DBO_PaletsProducidos
        dbo.searchKey = dbo.item("SCC")
        dbo.searchKey.value = scc
        MyBase.Select_proc(CType(dbo, DataBussines), "[dbo].[PaletsProducidos5SelectBySCC]", transactDtb)
        Return dbo
    End Function

    Public Function marcarComoExtraviado(ByVal scc As Integer, ByRef transactDtb As DataBase) As Boolean
        Try
            Dim m_dbo As New DBO_PaletsProducidos
            m_dbo = Me.Select_RecordBySSCC(scc.ToString, transactDtb)
            m_dbo.EnAlmacen = False
            m_dbo.Id_Estado = 2
            Return Me.Grabar(CType(m_dbo, DataBussines), transactDtb)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function estaCargado(ByVal scc As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        Dim dt As DataTable = dtb.Consultar("[dbo].[PaletsProducidos4EstaCargado]" & scc)
        

        Return If(If(dt.Rows(0).Item(0) Is Nothing, 0, Convert.ToInt32(dt.Rows(0).Item(0))) > 0, True, False)
    End Function

    Public Sub Detalles(ByVal formatoEnvasado As String, ByVal scc As String, ByRef descripcion As String, ByRef cajas As Integer)
        Dim dt As DataTable = dtb.Consultar("select articulo from formatosenvasados, ArticulosEnvasadosHistoricoSinLinea where TipoFormatoEnvasadoID = tipoFormato and formatoEnvasadoid=" & formatoEnvasado, False)
        descripcion = dt.Rows(0).Item(0).ToString
        dt = dtb.Consultar("[dbo].[PaletsProducidos4CalcularCajas] " & scc)
        cajas = Convert.ToInt32(dt.Rows(0).Item(0))
    End Sub

    Public Function DevolverLotesMultiLote(ByVal scc As String) As String
        Dim calendar As New Calendar
        Dim lotes As String = "Multilote: " & Environment.NewLine

        Dim dt As DataTable = dtb.Consultar("SelectSCClotes " & scc)
        For Each row As DataRow In dt.Rows
            lotes = lotes & calendar.DevuelveFechaJuliana(CDate(row.Item(0))) & ", "
        Next

        Return lotes
    End Function
End Class
