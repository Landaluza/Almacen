Public Class frmReporteErrores
    Private bitmap As Bitmap

    Public Sub New(ByVal image As Bitmap)

        ' This call is required by the designer.
        InitializeComponent()

        Me.pbErrorImage.Image = image
        Me.bitmap = image
    End Sub

    Private Sub btnSend_Click(sender As System.Object, e As System.EventArgs) Handles btnSend.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim captura As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\temp.jpg"
            Dim file As New File()
            Dim dtb As New DataBase(Config.Server)
            Dim usuario As String = dtb.Consultar("select usuario from usuarios where usuarioid=" & Config.User, False).Rows(0).Item(0).ToString

            file.saveImage(Me.bitmap, captura)

            Dim mail As New Mail.Mail1And1(True, "Error " & Convert.ToString(Now.Date) & " Usuario: " & usuario, Me.txtErrorMessage.Text, captura, _
                Config.MailReportAddress, Config.MailReportPass, Config.MailReportAddress, _
                String.Empty, String.Empty, Config.MailClientHost)

            Me.Cursor = Cursors.Default
            Me.Close()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            messagebox.show("Error al enviar el email. Detalles:" & Environment.NewLine & ex.Message)        
        End Try
    End Sub
End Class