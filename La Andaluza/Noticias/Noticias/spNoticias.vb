

Public Class spNoticias
Inherits StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[NoticiasSelect]",  _
                     "[dbo].[NoticiasInsert]",  _
                     "[dbo].[NoticiasUpdate]",  _
                     "[dbo].[NoticiasDelete]",  _
                     "[dbo].[NoticiasSelectDgv]",  _
                     "[dbo].[NoticiasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef transactDtb As DataBase) As DBO_Noticias
        Dim dbo As New DBO_Noticias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, DataBussines), transactDtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef transactDtb As DataBase) As Boolean
        Dim dbo As New DBO_Noticias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, DataBussines), transactDtb)
    End Function

End Class
