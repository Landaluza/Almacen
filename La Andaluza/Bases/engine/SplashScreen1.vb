Public NotInheritable Class SplashScreen1
    Private c As Config

    Public Sub New()

        InitializeComponent()

        Version.Text = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build   'System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.MajorRevision)
        Copyright.Text = My.Application.Info.Copyright
    End Sub
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.ProgressBar1.Enabled Then
            'If source <> LOCAL Then
            Config.Cargar_Ajustes_Predeterminados()
            c = New Config
            c.calcular_version()
        End If
    End Sub

    Private Sub SplashScreen1_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        'If Not Me.ProgressBar1.Enabled Then
        '    'If source <> LOCAL Then
        '    Dim c As New Config
        '    c.checkFiles()
        '    'If Not c.checkFiles Then messageBox.show("No se pudieron cargar algunos archivos, es probable que algunas caracteristicas no funcionen correctamente",String.Empty, MessageBoxButtons.OK ,MessageBoxIcon.Information ))
        '    'End If

        '    'Config.PrintDialogEtiquetas = New PrintDialog()
        '    'Config.PageSetupDialogEtiquetas = New PageSetupDialog
        '    'Config.documentoImpresoraEtiquetas = New System.Drawing.Printing.PrintDocument
        '    'Config.documentoImpresoraEtiquetas.OriginAtMargins = True
        '    'Config.PageSetupDialogEtiquetas.Document = Config.documentoImpresoraEtiquetas
        '    'Config.PrintDialogEtiquetas.Document = Config.documentoImpresoraEtiquetas
        'End If
    End Sub

    Public Sub show_loading()
        Me.ProgressBar1.Enabled = True
        Me.Show()
    End Sub

    Public Sub hide_loading()
        Me.Hide()
        Me.ProgressBar1.Enabled = False
        Me.ProgressBar1.Visible = False
    End Sub


End Class
