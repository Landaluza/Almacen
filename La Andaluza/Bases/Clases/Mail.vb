Imports System.Net.Mail
Imports System.IO

Module Mail
    Public Class Mail
        Protected message As New MailMessage()
        Protected client As New SmtpClient()

        Public Sub New()
        End Sub

        Public Sub New(ByVal ClientHost As String, ByVal fromAddress As String, ByVal fromPass As String)
            client.Host = ClientHost
            client.Credentials = New System.Net.NetworkCredential(fromAddress, fromPass)
        End Sub

        Public Sub New(ByVal subject As String, ByVal messageBody As String, ByVal attachmentFile As String, _
            ByVal fromAddress As String, ByVal fromPassword As String, ByVal toAddress As String, _
            ByVal ccAddress As String, ByVal bccAddress As String, ByVal ClientHost As String)

            message.From = New MailAddress(fromAddress)
            'Allow multiple "To" addresses to be separated by a semi-colon
            Me.setTo(toAddress)
            'Allow multiple "Cc" addresses to be separated by a semi-colon
            If ccAddress <> String.Empty Then Me.setCC(ccAddress)
            'Allow multiple "Bcc" addresses to be separated by a semi-colon
            If bccAddress <> String.Empty Then Me.setBCC(bccAddress)
            message.Subject = subject
            message.Body = messageBody
            'ADJUNTOS
            Me.setAtachment(attachmentFile)

            message.IsBodyHtml = True
            'message.BodyEncoding = System.Text.Encoding.UTF8 'Permitiria introducir codigo no HTML
            message.Priority = MailPriority.High

            client = New SmtpClient(ClientHost)
            'Set the SMTP server to be used to send the message
            client.EnableSsl = True

            client.Credentials = New System.Net.NetworkCredential(fromAddress, fromPassword)
            'client.Port = 587 'gmail uses this port
            'client.Host = ClientHost
            'client.EnableSsl = True' estaba a true hasta el 08/08/2011 y funcionaba correctamente, a partir de ese dia se cambia a false

        End Sub

        Public Sub setTo(ByVal toAddress As String)
            If Not toAddress Is Nothing Then
                For Each addr As String In toAddress.Split(";"c)
                    message.To.Add(New MailAddress(addr))
                Next
            End If
        End Sub

        Public Sub setCC(ByVal ccAddress As String)
            If Not ccAddress Is Nothing Then
                For Each addr As String In ccAddress.Split(";"c)
                    message.CC.Add(New MailAddress(addr))
                Next
            End If
        End Sub

        Public Sub setFrom(ByVal fromAddress As String)
            message.From = New MailAddress(fromAddress)
        End Sub

        Public Sub setBCC(ByVal bccAddress As String)
            If Not bccAddress Is Nothing Then
                For Each addr As String In bccAddress.Split(";"c)
                    message.Bcc.Add(New MailAddress(addr))
                Next
            End If
        End Sub

        Public Sub setSubject(ByVal subject As String)
            message.Subject = subject
        End Sub

        Public Sub setMessage(ByVal messageBody As String)
            message.Body = messageBody
        End Sub

        Public Sub setAtachments(ByRef atachments() As String)
            If Not atachments Is Nothing Then
                Try
                    For Each atach As String In atachments
                        message.Attachments.Add(New System.Net.Mail.Attachment(atach))
                    Next
                Catch ex As Exception
                    messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub

        Public Sub setAtachment(ByVal atach As String)
            If Not atach Is Nothing Then
                message.Attachments.Add(New System.Net.Mail.Attachment(atach))
            End If
        End Sub

        Public Sub setHost(ByVal ClientHost As String)
            client.Host = ClientHost
        End Sub

        Public Sub setCredentials(ByVal fromAddress As String, ByVal fromPass As String)
            client.Credentials = New System.Net.NetworkCredential(fromAddress, fromPass)
        End Sub

        Public Sub sendMail()
            Try
                client.SendAsync(message, Me)
                'client.Send(message)
                messagebox.show("Email enviado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As SmtpException
                messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Function SendEmail(ByVal subject As String, ByVal messageBody As String, ByVal attachmentFiles As String, _
            ByVal fromAddress As String, ByVal fromPassword As String, ByVal toAddress As String, _
            ByVal ccAddress As String, ByVal bccAddress As String, ByVal ClientHost As String) As Boolean

            message.From = New MailAddress(fromAddress)
            'Allow multiple "To" addresses to be separated by a semi-colon
            Me.setTo(toAddress)
            'Allow multiple "Cc" addresses to be separated by a semi-colon
            Me.setCC(ccAddress)
            'Allow multiple "Bcc" addresses to be separated by a semi-colon
            Me.setBCC(bccAddress)
            message.Subject = subject
            message.Body = messageBody
            'ADJUNTOS

            'para usar este metodo deberia recibir un vector como parametro
            'Me.setAtachments(attachmentFiles)
            Me.setAtachment(attachmentFiles)

            message.IsBodyHtml = True
            'message.BodyEncoding = System.Text.Encoding.UTF8 'Permitiria introducir codigo no HTML
            message.Priority = MailPriority.High

            'Set the SMTP server to be used to send the message
            client.Credentials = New System.Net.NetworkCredential(fromAddress, fromPassword)
            'client.Port = 587 'gmail uses this port
            client.Host = ClientHost
            'client.EnableSsl = True' estaba a true hasta el 08/08/2011 y funcionaba correctamente, a partir de ese dia se cambia a false
            client.EnableSsl = False

            Try
                'client.Send(message)
                'client.SendCompleted += New SendCompletedEventHandler(SendCompletedCallback)
                'Dim userState As String = "test message1"
                'client.SendAsync(message, userState)
                'AddHandler client.SendComplete, AddressOf SendCompletedCallback   

                client.SendAsync(message, Me)
                messagebox.show("Email enviado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Catch ex As SmtpException
                messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Function
    End Class

    Public Class Mail1And1
        Inherits Mail

        Public Sub New(ByVal a As Boolean, ByVal subject As String, ByVal messageBody As String, ByVal attachmentFile As String, _
    ByVal fromAddress As String, ByVal fromPassword As String, ByVal toAddress As String, _
    ByVal ccAddress As String, ByVal bccAddress As String, ByVal ClientHost As String, Optional ByVal notify As Boolean = True)

            message.From = New MailAddress(fromAddress)
            'Allow multiple "To" addresses to be separated by a semi-colon
            Me.setTo(toAddress)
            'Allow multiple "Cc" addresses to be separated by a semi-colon
            If ccAddress <> String.Empty Then Me.setCC(ccAddress)
            'Allow multiple "Bcc" addresses to be separated by a semi-colon
            If bccAddress <> String.Empty Then Me.setBCC(bccAddress)
            message.Subject = subject
            message.Body = messageBody
            'ADJUNTOS
            If attachmentFile <> String.Empty Then Me.setAtachment(attachmentFile)

            message.IsBodyHtml = True
            'message.BodyEncoding = System.Text.Encoding.UTF8 'Permitiria introducir codigo no HTML
            message.Priority = MailPriority.High

            client = New SmtpClient(ClientHost)
            'Set the SMTP server to be used to send the message
            client.EnableSsl = True
            client.Port = 25 '587
            client.Credentials = New System.Net.NetworkCredential(fromAddress, fromPassword)
            'client.Port = 587 'gmail uses this port
            'client.Host = ClientHost
            'client.EnableSsl = True' estaba a true hasta el 08/08/2011 y funcionaba correctamente, a partir de ese dia se cambia a false
            client.Send(message)
            If notify Then messagebox.show("Email enviado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Public Sub enviarAsyncrono()
            MyBase.sendMail()
        End Sub

        Public Sub enviarSincrono()
            Try
                'client.SendAsync(message, Me)
                client.Send(message)
                messagebox.show("Email enviado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As SmtpException
                messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class

    Public Class MailAutomated
        Inherits Mail

        Protected Sub addAtachmentsFromDataBase(ByVal dgvGrilla As System.Windows.Forms.DataGridView)
            'Dim dt As System.Data.DataTable = SelectArticulosFichasTecnicasByMaestroID(dgvGrilla.CurrentRow.Cells("PedidoProveedorMaestroID").Value)
            Dim spPedidosProveedoresDocumentos1 As New spPedidosProveedoresDocumentos1
            Dim dtb As New DataBase(Config.Server)
            Dim dt As System.Data.DataTable = dtb.Consultar("ArticulosFichasTecnicasByMaestroIDSelect " & dgvGrilla.CurrentRow.Cells("PedidoProveedorMaestroID").Value.ToString)
            If dt.Rows.Count > 0 Then

                Try
                    For j As Integer = 0 To dt.Rows.Count - 1
                        Dim psi As New ProcessStartInfo()
                        psi.UseShellExecute = True



                        psi.FileName = Convert.ToString(dt.Rows(j).Item("Ruta"))
                        If IO.File.Exists(psi.FileName) Then
                            Process.Start(psi)

                            If messagebox.show("¿Es la especificacion correcta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                message.Attachments.Add(New System.Net.Mail.Attachment(Convert.ToString(dt.Rows(j).Item("Ruta"))))

                                Dim dbo_PedidosProveedoresDocumentos As New DBO_PedidosProveedoresDocumentos1
                                'Dim ruta As String = "Z:\Sistema de Gestión Integrada\0.2. Calidad\Fichas tecnicas materiales auxiliares\Cajas\Pack-Master\ANONIMA 12 x 250 VER.2.pdf"
                                'fichero = ruta.Substring(ruta.LastIndexOf("\") + 1)
                                dbo_PedidosProveedoresDocumentos.Descripcion = "Ficha especificación " & Path.GetFileName(Convert.ToString(dt.Rows(j).Item("Ruta")))
                                'Convert.ToString(dt.Rows(j).Item("ArticuloID"))
                                dbo_PedidosProveedoresDocumentos.Ruta = Convert.ToString(dt.Rows(j).Item("Ruta"))
                                dbo_PedidosProveedoresDocumentos.Fecha = System.DateTime.Now
                                dbo_PedidosProveedoresDocumentos.Observaciones = String.Empty
                                dbo_PedidosProveedoresDocumentos.PedidoProveedorMaestroID = Convert.ToInt32(dgvGrilla.CurrentRow.Cells("PedidoProveedorMaestroID").Value)
                                dbo_PedidosProveedoresDocumentos.FechaModificacion = System.DateTime.Now.date
                                dbo_PedidosProveedoresDocumentos.UsuarioModificacion = Config.User

                                spPedidosProveedoresDocumentos1.PedidosProveedoresDocumentos1Insert(dbo_PedidosProveedoresDocumentos)
                                'Dim fs As New FileStream(Convert.ToString(dt.Rows(j).Item("Ruta")), FileMode.Open, FileAccess.Read)
                                'Dim a As New Attachment(fs, Convert.ToString(dt.Rows(j).Item("Ruta")), MediaTypeNames.Application.Pdf)
                                'Dim a As New Attachment(Convert.ToString(dt.Rows(j).Item("Ruta")), MediaTypeNames.Application.Pdf)
                                'message.Attachments.Add(a)

                                Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("Acrobat")
                                For Each p As Process In pProcess
                                    p.Kill()
                                Next
                            Else
                                Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("Acrobat")
                                For Each p As Process In pProcess
                                    p.Kill()
                                Next
                            End If
                        Else
                            MessageBox.Show("No existe el fichero: " & Environment.NewLine & psi.FileName.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    Next
                Catch ex As Exception
                    messagebox.show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Else
                MessageBox.Show("No existe especificación para el proveedor " & dgvGrilla.CurrentRow.Cells("Nombre").Value.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End Sub
    End Class

    Public Class MailGerente
        Inherits MailAutomated

        Public Sub New()
        End Sub

        Public Sub New(ByVal dgvGrilla As System.Windows.Forms.DataGridView, ByVal PDFFile As String)
            Me.send(dgvGrilla, PDFFile)
        End Sub

        Public Sub send(ByVal dgvGrilla As System.Windows.Forms.DataGridView, ByVal PDFFile As String)
            Dim m_NumeroPedido As String = dgvGrilla.CurrentRow.Cells("Numero").Value.ToString
            Dim m_Proveedor As String = dgvGrilla.CurrentRow.Cells("Nombre").Value.ToString
            Dim spPedidosProveedoresDocumentos1 As New spPedidosProveedoresDocumentos1

            Try
                Dim sSubject As String = "Pedido " & m_NumeroPedido & " " & m_Proveedor & " para autorizar"
                If IO.File.Exists(PDFFile & m_NumeroPedido & ".PDF") Then

                    Dim dbo_PedidosProveedoresDocumentos As New DBO_PedidosProveedoresDocumentos1
                    dbo_PedidosProveedoresDocumentos.Descripcion = "Pedido"
                    dbo_PedidosProveedoresDocumentos.Ruta = PDFFile & m_NumeroPedido & ".PDF"
                    dbo_PedidosProveedoresDocumentos.Fecha = System.DateTime.Now
                    dbo_PedidosProveedoresDocumentos.Observaciones = String.Empty
                    dbo_PedidosProveedoresDocumentos.PedidoProveedorMaestroID = Convert.ToInt32(dgvGrilla.CurrentRow.Cells("PedidoProveedorMaestroID").Value)
                    dbo_PedidosProveedoresDocumentos.FechaModificacion = System.DateTime.Now.date
                    dbo_PedidosProveedoresDocumentos.UsuarioModificacion = Config.User

                    spPedidosProveedoresDocumentos1.PedidosProveedoresDocumentos1Insert(dbo_PedidosProveedoresDocumentos)
                    Dim sHTMLBody As String =
                       "<html>" & _
                       "   <head><title></title></head>" & _
                       "   <body>" & _
                       "       <table width=""100%"" border=""0"" align=""left"" >" & _
                       "           <tr align=""left"" ><th width=""100%"" scope=""col"" align=""left"" ><a href=""file://" & PDFFile & m_NumeroPedido & ".PDF"">" & m_NumeroPedido & ".PDF</a></th></tr>" & _
                       "           <tr align=""left"" ><th width=""100%"" scope=""col"" align=""left"" >&nbsp;</th></tr>" & _
                       "           <tr align=""left"" ><th width=""100%"" scope=""col"" align=""left"" >&nbsp;</th></tr>" & _
                       "           <tr align=""left"" ><th width=""100%"" scope=""col"" align=""left"" >&nbsp;</th></tr>" & _
                       "        </table>" & _
                       "   <body>" & _
                       "<html>"
                    Me.addAtachmentsFromDataBase(dgvGrilla)
                    Dim sAttachmentFile As String = PDFFile & m_NumeroPedido & ".PDF"
                    Me.SendEmail(sSubject, sHTMLBody, Nothing, "administracion@landaluza.es", "Administracion2008", "gerente@landaluza.es", "calidad@landaluza.es", Nothing, "smtp.1and1.es")
                Else
                    messagebox.show("El PDF File: " & m_NumeroPedido & ".PDF" & " no existe.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                messagebox.show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Function sendSimple(ByVal asunto As String, ByVal cuerpo As String, ByVal fromAdress As String, ByVal fromPass As String) As Boolean
            Try
                Dim sHTMLBody As String =
                   "<html>" & _
                   "   <head><title></title></head>" & _
                   "   <body>ESTE ES UN CORREO DE PRUEBA. BORRAR" & _
                            cuerpo & _
                   "   <body>" & _
                   "<html>"
                '"Administracion2008"
                '"almacen@landaluza.es"
                Return Me.SendEmail(asunto, sHTMLBody, Nothing, fromAdress, fromPass, "gerente@landaluza.es", "calidad@landaluza.es", Nothing, "smtp.1and1.es")
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class

    Public Class MailProveedores
        Inherits MailAutomated

        Public Sub New()
        End Sub

        Public Sub New(ByVal dgvGrilla As System.Windows.Forms.DataGridView, ByVal PDFFile As String)
            Me.send(dgvGrilla, PDFFile)
        End Sub

        Public Sub send(ByVal dgvGrilla As System.Windows.Forms.DataGridView, ByVal PDFFile As String)
            Dim m_NumeroPedido As String = dgvGrilla.CurrentRow.Cells("Numero").Value.ToString
            Dim m_Proveedor As String = dgvGrilla.CurrentRow.Cells("Nombre").Value.ToString
            Dim spPedidosProveedoresMaestros As New spPedidosProveedoresMaestros
            Dim dt As System.Data.DataTable = spPedidosProveedoresMaestros.SelectProveedoresMailsPedidos(Convert.ToInt32(dgvGrilla.CurrentRow.Cells("ProveedorID").Value))
            Try
                Dim toAddress As String = Nothing
                Dim ccAddress As String = Nothing
                Dim sCompanyName As String = Nothing
                Dim sConfirm As String = Nothing

                Dim x As Integer = 0

                For j As Integer = 0 To dt.Rows.Count - 1
                    If x = 0 Then
                        toAddress = dt.Rows(j).Item("Mail").ToString
                        x = x + 1
                    ElseIf x > 0 Then
                        ccAddress = ccAddress & Convert.ToString(dt.Rows(j).Item("Mail")) & "; "
                    End If
                Next
                ccAddress = ccAddress & "gerente@landaluza.eses"

                If Not ccAddress Is Nothing Then
                    ccAddress = Mid(ccAddress, 1, (ccAddress.Length - 2))
                End If

                If Not toAddress Is Nothing Then
                    sConfirm = _
                    "Confirmas el envio de mail solicitando pedido número " & m_NumeroPedido & Environment.NewLine & Environment.NewLine & _
                    "Para: " & toAddress & Environment.NewLine & _
                    "CC : " & ccAddress & Environment.NewLine

                    'Dim Box As DialogResult = 
                    If MessageBox.Show(sConfirm, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Dim sSubject As String = "Pedido " & m_NumeroPedido & " " & m_Proveedor & " Por favor confirmar recepción."
                        If IO.File.Exists(PDFFile & m_NumeroPedido & ".PDF") Then
                            'Codigo HTML generado con KompoZer. Esta en Informatica. Software instalado.

                            Dim sHTMLBody As String = "<html><head><meta content=""text/html; charset=ISO-8859-1 http-equiv=""content-type""><title></title>" &
                                                      "</head><body><big style=""color: red; font-weight: bold;"">Por favor, confirmar por este mismo medio la recepción de este pedido, y que no<br>" &
                                                      "existen problemas para su entrega en el plazo requerido.</big><br><br>" &
                                                      "Si existen nuevas versiones de las fichas técnicas que adjuntamos, deben enviarnos<br> " &
                                                      "las versiones actualizadas.<br><br> " &
                                                      "Cualquier variación en las condiciones economicas acordadas previamente debe <br>" &
                                                      "ser autorizada por Vinagreria La Andaluza, S.L.<br><br></body></html>"


                            'Dim sHTMLBody As String = "<html><head><meta content=""text/html; charset=ISO-8859-1 http-equiv=""content-type""title></title>" &
                            '                           "</head><body>Por favor, confirmar por este mismo medio la recepción de este pedido.<br>" &
                            '                           "<br>" &
                            '                           "Confirmar que no existen problemas para cumplir el plazo de entrega solicitado.<br>" &
                            '                           "<br>" &
                            '                           "Cualquier variación en las condiciones economicas acordadas previamente debe ser autorizada <br>" &
                            '                           "por Vinagreria La Andaluza, S.L.</body></html>"

                            Me.addAtachmentsFromDataBase(dgvGrilla)
                            Dim sAttachmentFile As String = PDFFile & m_NumeroPedido & ".PDF"
                            SendEmail(sSubject, sHTMLBody, sAttachmentFile, "administracion@landaluza.es", "Administracion2008", toAddress, ccAddress, "administracion@landaluza.es", "smtp.1and1.es")
                        Else
                            messagebox.show("El fichero PDF: " & PDFFile & m_NumeroPedido & ".PDF" & " no existe.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
    End Class

    Public Function notificarUsuario(ByVal textoNotificacion As String, ByVal usuarioNotificacion As String) As Boolean
        Try
            Dim spUsuarios As New spUsuarios
            Dim dbo_usuarios As DBO_Usuarios = spUsuarios.select_record_by_usuario(usuarioNotificacion, New DataBase(Config.Server))

            Dim mail As New Mail1And1(True, "Error " & Convert.ToString(DateTime.Now.Date) & " Usuario: " & dbo_usuarios.Usuario, textoNotificacion, Nothing, _
                            Config.MailReportAddress, Config.MailReportPass, Config.MailReportAddress, _
                            String.Empty, String.Empty, Config.MailClientHost)

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Module
