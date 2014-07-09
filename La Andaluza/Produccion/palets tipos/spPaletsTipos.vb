
Public Class spPaletsTipos
Inherits StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[PaletsTiposSelect]",  _
                     "[dbo].[PaletsTiposInsert]",  _
                     "[dbo].[PaletsTiposUpdate]",  _
                     "[dbo].[PaletsTiposDelete]",  _
                     "[dbo].[PaletsTiposSelectDgv]",  _
                     "[dbo].[PaletsTiposSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal PaletTipoID As Int32, ByRef transactDtb As DataBase) As DBO_PaletsTipos
        Dim dbo As New DBO_PaletsTipos
        dbo.searchKey = dbo.item("PaletTipoID")
        dbo.searchKey.value = PaletTipoID
        MyBase.Select_Record(CType(dbo, DataBussines), transactDtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal PaletTipoID As Int32, ByRef transactDtb As DataBase) As Boolean
        Dim dbo As New DBO_PaletsTipos
        dbo.searchKey = dbo.item("PaletTipoID")
        dbo.searchKey.value = PaletTipoID
        Return MyBase.DeleteProcedure(CType(dbo, DataBussines), transactDtb)
    End Function

   Public Sub cargar_PaletsTipos(ByRef cbo As ComboBox)
       cbo.mam_DataSource("PaletsTiposCbo", False)
   End Sub

End Class
