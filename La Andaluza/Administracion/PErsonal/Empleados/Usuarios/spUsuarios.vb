

Public Class spUsuarios
    Inherits StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[UsuariosSelect]", _
                        "[dbo].[UsuariosInsert]", _
                        "[dbo].[UsuariosUpdate]", _
                        "[dbo].[UsuariosDelete]", _
                        "[dbo].[UsuariosSelectDgv]", _
                        "[dbo].[UsuariosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal UsuarioID As Int32, ByRef transactDtb As DataBase) As DBO_Usuarios
        Dim dbo As New DBO_Usuarios
        dbo.searchKey = dbo.item("UsuarioID")
        dbo.searchKey.value = UsuarioID
        MyBase.Select_Record(CType(dbo, DataBussines), transactDtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal UsuarioID As Int32, ByRef transactDtb As DataBase) As Boolean
        Dim dbo As New DBO_Usuarios
        dbo.searchKey = dbo.item("UsuarioID")
        dbo.searchKey.value = UsuarioID
        Return MyBase.DeleteProcedure(CType(dbo, DataBussines), transactDtb)
    End Function

    Public Sub cargar_Usuarios(ByRef cbo As ComboBox)
        cbo.mam_DataSource("UsuariosCbo", False)
    End Sub

    Public Function CambiarContraseña(ByVal usuarioid As Integer, ByVal oldPass As String, ByVal newPass As String) As Boolean
        Dim dtb As New DataBase(Config.Server)
        dtb.Conectar()
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[UsuariosupdateCriptedPassword]")
        'Dim connection As System.Data.SqlClient.SqlConnection  = Me.dtb.Conexion
        'Dim updateProcedure As String = "[dbo].[UsuariosupdateCriptedPassword]"
        'Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@UsuarioId", usuarioid)
        updateCommand.Parameters.AddWithValue("@criptedPass", newPass)
        updateCommand.Parameters.AddWithValue("@actualPass", oldPass)

        Try
            updateCommand.ExecuteNonQuery()

            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function select_record_by_usuario(ByVal usuario As String, ByRef transactDtb As DataBase) As DBO_Usuarios
        Dim dbo As New DBO_Usuarios
        dbo.searchKey = dbo.item("Usuario")
        dbo.searchKey.value = usuario
        MyBase.Select_proc(CType(dbo, DataBussines), "UsuariosSelectByUsuario", transactDtb)
        Return dbo
    End Function

    Public Function autentificar(ByVal login As String, ByVal pass As String) As Boolean
        Dim dbo As DBO_Usuarios
        Dim dt As DataTable
        Dim dtb As New DataBase(Config.Server)
        Dim spTiposUsuarios As New spTiposUsuarios

        Try

            dt = dtb.Consultar("exec [UsuariosValidar] " & login & ", " & pass, False)

            If If(dt.Rows(0).Item(0) Is Nothing, 0, Convert.ToInt32(dt.Rows(0).Item(0))) > 0 Then
                dbo = select_record_by_usuario(login, dtb)

                Config.User = dbo.ID
                Config.UserType = dbo.TipoUsuarioID

                Config.dataFillNotificaction = False
                Config.Worker = Convert.ToInt32(dtb.Consultar("select id from empleados where id_usuario=" & Config.User, False).Rows(0).Item(0))

                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
