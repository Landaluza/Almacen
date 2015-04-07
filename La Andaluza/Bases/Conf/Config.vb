Public Class Config
    'Public Const SOCKET_PORT As Integer = 8090
    'Public Const SOCKET_SERVER_IP As String = "192.168.10.47"

    Public Shared Server As Integer
    Public Shared QS_Sesion As String
    Public Shared User As Integer
    Public Shared UserType As Integer
    'Public Shared Property UserPermission As Integer
    Public Shared Worker As Integer
    Public Shared UserName As String

    Public Shared dataFillNotificaction As Boolean
    Public Shared MailClientHost As String
    Public Shared MailAddress As String
    Public Shared MailPass As String
    Public Shared MailReportAddress As String
    Public Shared MailReportPass As String
    Public Shared UsuariosProductos As Integer() = {2, 3, 21}

    Public Shared connectionString As String

    Private Shared ventasPath As String
    Private Shared ventaslocalPath As String
    Private Shared versionApp As String
    Public Shared activeScreen As Integer

    Public Shared Sub Cargar_Ajustes_Predeterminados()
        Config.Server = DataBase.SERVIDOR
        Config.MailReportPass = "Administracion2008"
        Config.ventasPath = "Z:\Informatica\La Andalsoaluza app\ExcelFile\Book1.xlsx"
        Config.MailReportAddress = "administracion@lAndalsoaluza.es"
        Config.MailClientHost = "smtp.1Andalso1.es"
        Config.QS_Sesion = "Sesión A - [24 x 80]"
        'Config.QS_Sesion = "Sesión A"
        Config.load()
    End Sub

    Public Shared ReadOnly Property Version_seriada As String
        Get
            Return versionApp
        End Get
    End Property

    Public Shared ReadOnly Property RutaVentasServidor As String
        Get
            Return ventasPath
        End Get
    End Property

    Public Shared ReadOnly Property RutaVentasLocal As String
        Get
            Return ventaslocalPath
        End Get
    End Property

    Public Function checkFiles() As Boolean
        Try
            If System.IO.File.Exists(ventasPath) = True Then
                ventaslocalPath = Application.StartupPath & "\ExcelFile\Book1.xlsx"

                If System.IO.File.Exists(ventaslocalPath) = True Then
                    System.IO.File.Delete(ventaslocalPath)
                    System.IO.File.Copy(ventasPath, ventaslocalPath)
                Else
                    System.IO.File.Copy(ventasPath, ventaslocalPath)
                End If

            End If
            Return True
        Catch ex As Exception
            ventaslocalPath = ventasPath
            Return False
        End Try
    End Function

    Public Function NumeroVersion() As String
        ' •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
        ' | if running the deployed application, you can get the version from the ApplicationDeployment information. If you try |
        ' | to access this when you are running in Visual Studio, it will not work.                                             |
        ' •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
        Dim ourVersion As String
        If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
            ourVersion = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        Else
            ourVersion = My.Application.Info.Version.ToString 'Si estamos en Visual Basic se muestra el numero <Assembly: AssemblyFileVersion("1.0.0.19")> del fichero AssemblyInfo.vb
        End If

        Return ourVersion
    End Function

    Public Sub calcular_version()
        Select Case Convert.ToString(My.Application.Info.Version).Length
            Case Is > 11
                Config.versionApp = "LA Almacen " & Convert.ToString(My.Application.Info.Version).Substring(0, 10) '& " -- " & String.Format("Version {0}", NumeroVersion())
            Case Is = 11
                Config.versionApp = "LA Almacen " & Convert.ToString(My.Application.Info.Version).Substring(0, 9) '& " -- " & String.Format("Version {0}", NumeroVersion())
            Case Is = 10
                Config.versionApp = "LA Almacen " & Convert.ToString(My.Application.Info.Version).Substring(0, 8) '& " -- " & String.Format("Version {0}", NumeroVersion())
            Case Else
                Config.versionApp = "LA Almacen " & Convert.ToString(My.Application.Info.Version).Substring(0, 7) '& " -- " & String.Format("Version {0}", NumeroVersion())
        End Select
    End Sub

    Public Shared Sub save()
        Dim options As New UserOptions
        Dim fil As New File

        options.Screen = Config.activeScreen
        Try
            fil.saveObject(CType(options, Object), Environment.SpecialFolder.MyDocuments & "options.opt")
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub load()
        Dim fil As New File
        Dim opt As UserOptions

        Try
            opt = CType(fil.loadObject(Environment.SpecialFolder.MyDocuments & "options.opt"), UserOptions)
            Config.activeScreen = opt.Screen
        Catch ex As Exception
            Config.activeScreen = 0
        End Try
    End Sub
End Class
