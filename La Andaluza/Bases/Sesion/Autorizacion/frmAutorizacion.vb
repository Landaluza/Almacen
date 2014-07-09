Public Class frmAutorizacion
    Private resultado As DialogResult
    Private sp As spAutorizacion
    Private embebido As Boolean
    Public Event verificado()
    Public Event cancelado()

    Public ReadOnly Property Retorno As DialogResult
        Get
            Return Me.resultado
        End Get
    End Property

    Public Sub New(Optional embebed As Boolean = True)

        InitializeComponent()

        Me.sp = New spAutorizacion
        Me.embebido = embebed
        Me.resultado = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmAutorizacion_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        DetailedSimpleForm.centerIn(CType(Me.Panel2, Control), Me)
        DetailedSimpleForm.centerHorizontalyIn(CType(Me.Panel1, Control), CType(Me.Panel2, Control))
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        RaiseEvent cancelado()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Me.ComprobarUsuario()
        If Not Me.embebido Then Me.Close()
    End Sub

    Private Sub ComprobarUsuario()
        If Me.sp.verificarUsuario(Config.User, Me.txtPassword.Text) Then
            Me.lError.Visible = False
            Me.resultado = Windows.Forms.DialogResult.OK
            RaiseEvent verificado()
        Else
            Me.lError.Visible = True
            Me.resultado = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub frmAutorizacion_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ComprobarUsuario()
            If Not Me.embebido Then Me.Close()
        End If
    End Sub
End Class
