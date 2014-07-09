Public Class frmNews
    Private noticias As frmNoticias2

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        noticias = New frmNoticias2(Config.UserType)
        Engine_LA.FormEnPestaña(noticias, Me.panNoticias)
    End Sub
    Public Sub ocultarNotificaciones()
        Me.PanNot1.Visible = False
    End Sub
    Public Sub actualizarNotificacion(ByRef frm As Form)
        Engine_LA.FormEnPestaña(frm, Me.PanMensajesDetalles)
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        noticias.refrescar()
    End Sub

    Private Sub frmNews_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Timer1.Start()
    End Sub

    Private Sub frmNews_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Timer1.Stop()
    End Sub
End Class