

Public Class spNoticias_TiposUsuarios
Inherits StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[Noticias_TiposUsuariosSelect]",  _
                     "[dbo].[Noticias_TiposUsuariosInsert]",  _
                     "[dbo].[Noticias_TiposUsuariosUpdate]",  _
                     "[dbo].[Noticias_TiposUsuariosDelete]",  _
                     "[dbo].[Noticias_TiposUsuariosSelectDgv]",  _
                     "[dbo].[Noticias_TiposUsuariosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef transactDtb As DataBase) As DBO_Noticias_TiposUsuarios
        Dim dbo As New DBO_Noticias_TiposUsuarios
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, DataBussines), transactDtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef transactDtb As DataBase) As Boolean
        Dim dbo As New DBO_Noticias_TiposUsuarios
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, DataBussines), transactDtb)
    End Function


End Class
