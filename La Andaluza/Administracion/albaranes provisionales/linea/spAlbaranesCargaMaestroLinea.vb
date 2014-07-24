
Public Class spAlbaranesCargaMaestroLinea
    Inherits StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[AlbaranesCargaMaestroLineaSelect]", _
                      "[dbo].[AlbaranesCargaMaestroLineaInsert]", _
                      "[dbo].[AlbaranesCargaMaestroLineaUpdate]", _
                      "[dbo].[AlbaranesCargaMaestroLineaDelete]", _
                      "[dbo].[AlbaranesCargaMaestroLineaSelectDgv]", _
                      "[dbo].[AlbaranesCargaMaestroLineaSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal AlbaranCargaProviDetalleID As Integer, ByRef dtb As DataBase) As DBO_AlbaranesCargaMaestroLinea
        Dim dbo As New DBO_AlbaranesCargaMaestroLinea
        dbo.searchKey = dbo.item("AlbaranCargaProviDetalleID")
        dbo.searchKey.value = AlbaranCargaProviDetalleID
        MyBase.Select_Record(CType(dbo, DataBussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal AlbaranCargaProviDetalleID As Integer, ByRef dtb As DataBase) As Boolean
        Dim dbo As New DBO_AlbaranesCargaMaestroLinea
        dbo.searchKey = dbo.item("AlbaranCargaProviDetalleID")
        dbo.searchKey.value = AlbaranCargaProviDetalleID
        Return MyBase.DeleteProcedure(CType(dbo, DataBussines), dtb)
    End Function

End Class
