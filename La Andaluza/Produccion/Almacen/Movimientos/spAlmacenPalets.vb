

Public Class spAlmacenPalets
    Inherits sp

    Public Sub New()
        MyBase.New("", "", "", "", "", "")
    End Sub
  
    Public Function ActulizarCargaEmergencia(ByRef transacDtb As DataBase) As Boolean
        Return transacDtb.ConsultaAlteraciones("exec [dbo].[updateAlbaranCargaSeguridadEmergencia]")
    End Function

    Public Function OrdenCargaselectmax(ByRef transactDtb As DataBase) As Integer
        Dim dt As DataTable = transactDtb.Consultar("exec [dbo].[OrdenesCargaSelectMax]")
        
        Return Convert.ToInt32(dt.Rows(0).Item(0))
    End Function

 

    Public Function cargasSinServir(ByRef transacDtb As DataBase) As Integer
        Try
            Return Convert.ToInt32(transacDtb.Consultar("select isnull(count(ordenesCarga.OrdenCargaID),0) from OrdenesCarga where servido = 'false' and id_AlbaranCargaProMaestro is null group by ordenesCarga.OrdenCargaID", False).Rows(0).Item(0))
        Catch ex As Exception
            Return 0
        End Try
    End Function

End Class
