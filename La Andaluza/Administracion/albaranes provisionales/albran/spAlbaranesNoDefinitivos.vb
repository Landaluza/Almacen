
Public Class spAlbaranesNoDefinitivos
    Inherits StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[AlbaranesNoDefinitivosSelect]", _
                      "[dbo].[AlbaranesNoDefinitivosInsert]", _
                      "[dbo].[AlbaranesNoDefinitivosUpdate]", _
                      "[dbo].[AlbaranesNoDefinitivosDelete]", _
                      "[dbo].[AlbaranesNoDefinitivosSelectDgv]", _
                      "[dbo].[AlbaranesNoDefinitivosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal AlbaranCargaProMaestroID As Integer, ByRef dtb As DataBase) As DBO_AlbaranesNoDefinitivos
        Dim dbo As New DBO_AlbaranesNoDefinitivos
        dbo.searchKey = dbo.item("AlbaranCargaProMaestroID")
        dbo.searchKey.value = AlbaranCargaProMaestroID
        MyBase.Select_Record(CType(dbo, DataBussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal AlbaranCargaProMaestroID As Integer, ByRef dtb As DataBase) As Boolean
        Dim dbo As New DBO_AlbaranesNoDefinitivos
        dbo.searchKey = dbo.item("AlbaranCargaProMaestroID")
        dbo.searchKey.value = AlbaranCargaProMaestroID
        Return MyBase.DeleteProcedure(CType(dbo, DataBussines), dtb)
    End Function

End Class
