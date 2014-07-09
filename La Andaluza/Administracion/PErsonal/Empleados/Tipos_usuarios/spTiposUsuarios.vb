

Public Class spTiposUsuarios
    Inherits StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[TiposUsuariosSelect]", _
                      "[dbo].[TiposUsuariosInsert]", _
                      "[dbo].[TiposUsuariosUpdate]", _
                      "[dbo].[TiposUsuariosDelete]", _
                      "[dbo].[TiposUsuariosSelectDgv]", _
                      "[dbo].[TiposUsuariosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal TipoUsuarioID As Int32, ByRef transactDtb As DataBase) As DBO_TiposUsuarios
        Dim dbo As New DBO_TiposUsuarios
        dbo.searchKey = dbo.item("TipoUsuarioID")
        dbo.searchKey.value = TipoUsuarioID
        MyBase.Select_Record(CType(dbo, DataBussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal TipoUsuarioID As Int32, ByRef transactDtb As DataBase) As Boolean
        Dim dbo As New DBO_TiposUsuarios
        dbo.searchKey = dbo.item("TipoUsuarioID")
        dbo.searchKey.value = TipoUsuarioID
        Return MyBase.DeleteProcedure(CType(dbo, DataBussines), dtb)
    End Function

   Public Sub cargar_TiposUsuarios(ByRef cbo As ComboBox)
       cbo.mam_DataSource("TiposUsuariosCbo", False)
   End Sub

End Class
