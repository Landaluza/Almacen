Public Class FrmInicio
    'Private ctrSes As New ctlUsuarios
    'Public Const CAMBIO_SESION As Integer = 0
    'Public Const acceso As Integer = 1    
    Private Gform As GUIstandar
    Private Calendar As Calendar
    Public Sub New()

        InitializeComponent()
        Calendar = New Calendar
        Calendar.testDateTime = False
        Me.Gform = New GUIstandar(Me)
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

        If My.Computer.Name = "MAM1" Or My.Computer.Name = "GERENTE1" Or My.Computer.Name = "MAM2-PC" Or My.Computer.Name = "MAMVAIO" Then
            If txtLogin.Text.Length = 0 And txtPassword.Text.Length = 0 Then
                txtLogin.Text = "mam"
                txtPassword.Text = "trucha0121"
            End If
        End If

        If txtLogin.Text = "mamdev" Then
            txtLogin.Text = txtLogin.Text.Replace("mamdev", "mam")
        End If

        If comprobarCampos() Then
            Me.Enabled = False
            If Not Me.BackgroundWorker1.IsBusy Then
                Me.BackgroundWorker1.RunWorkerAsync()
            End If
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

    'Private Sub btnPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPass.Click
    '    recuperarContraseña()
    'End Sub

    'Private Sub lPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lPass.Click
    '    recuperarContraseña()
    'End Sub

    'Private Sub recuperarContraseña()
    '    Dim longitud As Integer
    '    Dim semilla As Integer = datetime.now.Millisecond
    '    Dim rnd As Random

    '    rnd = New Random(semilla)
    '    longitud = 6

    '    Dim s As New System.Text.StringBuilder(longitud)
    '    For i As Integer = 1 To longitud
    '        Dim c As Char = ChrW(rnd.Next(97, 123))

    '        s.Append(c)
    '    Next

    '    Dim spUsuarios As New spUsuarios
    '    dtb.EmpezarTransaccion()

    '    Try
    '        Dim dbo_usuarios As DBO_Usuarios = spUsuarios.select_record_by_usuario(Me.txtLogin.Text, BD.transaction)

    '        If dbo_usuarios.email IsNot String.Empty Then

    '            Dim frm As New frmEntrada("Introduzca su dirección de correo", "La dirección debe coincidir con la que introdujo para su usuario")
    '            frm.ShowDialog()

    '            If frm.Result = dbo_usuarios.email Then
    '                dbo_usuarios.cryptedPassword = s.ToString
    '                spUsuarios.Grabar(dbo_usuarios, dtb.transaction)

    '                Dim cuerpo As String = "Su nueva contraseña es: " & dbo_usuarios.cryptedPassword

    '                If Mail.notificarUsuario(s.ToString, Me.txtLogin.Text) Then
    '                    dtb.TerminarTransaccion()
    '                    MessageBox.Show("Recuperación de contraseñas completada, revise su correo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Else
    '                    dtb.CancelarTransaccion()
    '                    MessageBox.Show("no se pudo recuperar la contraseñas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                End If

    '            Else
    '                dtb.CancelarTransaccion()
    '                MessageBox.Show("Los datos no coinciden. Vuelva a intetarlo o pongase en contacto con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            End If
    '        Else
    '            dtb.CancelarTransaccion()
    '            MessageBox.Show("EL usuario no contiene información sobre su correo. Pongase en contacto con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        End If
    '    Catch ex As Exception
    '        dtb.CancelarTransaccion()
    '        MessageBox.Show("Error recuperando la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    End Try
    'End Sub

    Private Sub FrmInicio_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Me.Gform Is Nothing Then Me.Gform.stopGUI()
        Environment.Exit(0)
    End Sub

    Private Sub txtLogin_Enter(sender As System.Object, e As System.EventArgs) Handles txtLogin.Enter
        Me.txtLogin.SelectAll()
    End Sub

    Private Sub txtPassword_Enter(sender As System.Object, e As System.EventArgs) Handles txtPassword.Enter
        Me.txtPassword.SelectAll()
    End Sub

    Private Sub txtLogin_Click(sender As System.Object, e As System.EventArgs) Handles txtLogin.Click
        Me.txtLogin.SelectAll()
    End Sub

    Private Sub txtPassword_Click(sender As System.Object, e As System.EventArgs) Handles txtPassword.Click
        Me.txtPassword.SelectAll()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        DataBase.buildConnectionString(Config.Server)
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

                Gform.terminarDeIniciar("LA", "Servidor", Me.txtLogin.Text, txtLogin.Text)

                Me.Enabled = True
                Me.DialogResult = Windows.Forms.DialogResult.OK
                SplashScreen1.hide_loading()
                Gform.Show()
            End If
        End If
    End Sub
End Class
