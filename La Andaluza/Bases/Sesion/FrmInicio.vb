Public Class FrmInicio
    Private Gform As GUI
    Private Calendar As Calendar
    Public Sub New()

        InitializeComponent()
        Calendar = New Calendar
        Calendar.testDateTime = False
        'DataBase.buildConnectionString(Config.Server)
        Config.Cargar_Ajustes_Predeterminados()
        Me.Gform = New GUI(Me)
        AddHandler Gform.FormClosed, AddressOf cerrar
    End Sub

    Private Sub cerrar(sender As Object, e As FormClosedEventArgs)
        Me.Close()
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        iniciar()
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub iniciar()
        If My.Computer.Name = "MAMVAIO" Then
            txtLogin.Text = "almacen"
            txtPassword.Text = "almacen"
        End If

        If comprobarCampos() Then
            Me.Enabled = False
            While BackgroundWorker1.IsBusy
                Threading.Thread.Sleep(100)
            End While

            Me.BackgroundWorker1.RunWorkerAsync()
        Else
            MessageBox.Show("Error. Los datos no son correctos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Function comprobarCampos() As Boolean
        Dim respuesta As Boolean = True
        If txtLogin.Text.Contains("'") Then
            If Me.LblLoginIssue.Visible = False Then Me.LblLoginIssue.Visible = True
            If respuesta = True Then respuesta = False
        Else
            If Me.LblLoginIssue.Visible = True Then Me.LblLoginIssue.Visible = False
        End If
        If txtLogin.Text = "" Then
            If Me.LblLoginIssue.Visible = False Then Me.LblLoginIssue.Visible = True
            If respuesta = True Then respuesta = False
        Else
            If Me.LblLoginIssue.Visible = True Then Me.LblLoginIssue.Visible = False
        End If
        If txtPassword.Text = "" Then
            If Me.lblPasswordIssue.Visible = False Then Me.lblPasswordIssue.Visible = True
            If respuesta = True Then respuesta = False
        Else
            If Me.lblPasswordIssue.Visible = True Then Me.lblPasswordIssue.Visible = False
        End If

        Return respuesta
    End Function

    Private Sub FrmInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setValores()
    End Sub

    Private Sub setValores()
        Me.Text = Config.Version_seriada
    End Sub

    Private Sub FrmInicio_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = 13 Then
            iniciar()
        End If
    End Sub

    Private Sub FrmInicio_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Me.txtLogin.Text = ""
        Me.txtPassword.Text = ""
        Me.BringToFront()
    End Sub

    Private Sub FrmInicio_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Me.Gform Is Nothing Then Me.Gform.stopGUI()
        Environment.Exit(0)
    End Sub

    Private Sub txtLogin_Enter(sender As System.Object, e As System.EventArgs) Handles txtLogin.Enter, txtLogin.Click
        Me.txtLogin.SelectAll()
    End Sub

    Private Sub txtPassword_Enter(sender As System.Object, e As System.EventArgs) Handles txtPassword.Enter, txtPassword.Click
        Me.txtPassword.SelectAll()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim spUsuarios As New spUsuarios

        If Not Calendar.TestDate() Then
            Config.User = -1
        Else
            If Not spUsuarios.autentificar(txtLogin.Text, txtPassword.Text) Then
                Config.User = 0
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If Config.User = 0 Then
            MessageBox.Show("Error en datos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Enabled = True
        Else
            If Config.User = -1 Then
                MessageBox.Show("No se pudo conectar a la base de datos, vuelva a intentarlo en unos minutos. Si el problema persiste contacte con su administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Enabled = True
            Else
                Me.Hide()
                SplashScreen1.show_loading()

                Gform.terminarDeIniciar("LA", Config.ServerName, Me.txtLogin.Text, txtLogin.Text)

                Me.Enabled = True
                Me.DialogResult = Windows.Forms.DialogResult.OK
                SplashScreen1.hide_loading()
                Gform.Show()
            End If
        End If
    End Sub
End Class
