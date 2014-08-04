
Public Class GUImain
    Inherits Form

    Protected Shared LAengine As Engine_LA
    Protected frmIni As FrmInicio
    Protected frmNews As frmNews
    Protected Event extras_showed()

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(ByRef frm As FrmInicio)
        InitializeComponent()
        LAengine = New Engine_LA(Me)
        Me.Icon = My.Resources.LogoBandejaLa21
        Me.frmIni = frm

        Me.NotifyIcon1 = New NotifyIcon
        Me.NotifyIcon1.Icon = My.Resources.scanner_barcode1
        Me.NotifyIcon1.ContextMenuStrip = Me.cmsNotificaciones

    End Sub

    'Public Sub CambiarSesion()
    '    Dim frm As New frmEspera("Cerrando sesión")
    '    frm.Show()
    '    stopGUI()
    '    FrmInicio.Show()
    '    frm.Close()
    '    Me.Hide()
    'End Sub

    Public Overridable Sub terminarDeIniciar(ByVal tablausada As String, ByVal ServidorUsado As String, ByVal UsuarioUsado As String, ByVal usua As String)
        Me.NotifyIcon1.Visible = True

        Me.ToolTip1.SetToolTip(Me.lServ, "Usuario: " & UsuarioUsado & Environment.NewLine & "Base de datos: " & tablausada & Environment.NewLine & "Servidor: " & ServidorUsado)
        Me.ToolTip1.SetToolTip(Me.lUser, "Usuario conectado: " & usua & Environment.NewLine & "click para acceder a la configuración de usuario")
    End Sub

    Public Sub cerrarPestaña(sender As Object, e As FormClosedEventArgs)
        Try
            Me.TabControl1.TabPages.Remove(Me.TabControl1.SelectedTab)
            LAengine.volverApestañaPrevia()
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub TabControl1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseUp
        If Convert.ToByte(TabControl1.SelectedTab.Tag) <> TabManager.PESTAÑA_SIN_CIERRE Then
            'If .SelectedTab.Text.EndsWith("   x") Then
            Dim ItemRect As Rectangle = TabControl1.GetTabRect(TabControl1.SelectedIndex)
            If ItemRect.Contains(e.Location) Then
                If e.Location.X > (ItemRect.Right - GUImain.LAengine.Target_Cerrar_Pestana.Width) Then
                    ' Code you want to happen when the x is selected.
                    TabControl1.TabPages.Remove(TabControl1.SelectedTab)
                    ' cerrarPestaña()
                    LAengine.volverApestañaPrevia()
                End If
            End If
            'End If
        End If
    End Sub

    Protected Sub TabControl1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then          
            CType(sender, TabControl).DoDragDrop(Me.TabControl1.SelectedTab, DragDropEffects.Copy)

        Else
            Try
                    If Not Convert.ToByte(TabControl1.SelectedTab.Tag) = TabManager.PESTAÑA_SIN_CIERRE Then
                    Dim ItemRect As Rectangle = TabControl1.GetTabRect(TabControl1.SelectedIndex)
                        If ItemRect.Contains(e.Location) Then
                            If e.Location.X > (ItemRect.Right - GUImain.LAengine.Target_Cerrar_Pestana.Width) Then
                                Dim df As Graphics = Me.TabControl1.CreateGraphics
                                df.DrawRectangle(Pens.LightSteelBlue, New Rectangle(ItemRect.Right - 15, 5, 11, 11))
                                df.Dispose()
                            End If
                        End If
                    End If
            Catch ex As Exception
            End Try
        End If
    End Sub


    Protected Function findToolStripItem(ByVal text As String, tool As ToolStrip) As ToolStripItem
        For Each t As ToolStripItem In tool.Items
            If t.Text = text Then
                Return t
            End If
        Next
        Return Nothing
    End Function

    Protected Sub ToolStrip2_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs)
        e.Effect = DragDropEffects.Copy
    End Sub

    Protected Sub TabControl1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TabControl1.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

   

    Protected Sub FrmPrincipal_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.stopGUI()
    End Sub

    Public Overridable Sub stopGUI()
        Try
            Me.NotifyIcon1.Visible = False
            Me.NotifyIcon1.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub FrmPrincipal_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        Environment.Exit(0)
    End Sub


    Protected Sub lReportBug_Click_1(sender As System.Object, e As System.EventArgs) Handles lReportBug.Click
        LAengine.reportarError(Me)
    End Sub

    Public Sub reportBug(sender As Object, e As EventArgs)
        LAengine.reportarError(Me, True)
    End Sub

    Protected Sub Escanear(sender As Object, e As EventArgs)
        Dim frm As New EscaneoSCC1
        GUImain.añadirPestaña_standar(CType(frm, Form)) 'frm.ShowDialog()
    End Sub

    Protected Sub actualizarNotificaciones(ByVal text As String)
        If text <> "" Then
            Me.NotifyIcon1.ShowBalloonTip(36000000, "Nuevas notificaciones", "Tiene " & text & " notificacioens nuevas", ToolTipIcon.Info)
        End If
    End Sub

    Protected Sub resetearMenuNotificaciones(mensaje As Boolean)
        If Not mensaje Then
            Dim sms As New ToolStripMenuItem
            sms.Text = "No tiene mensajes nuevos"
            sms.Name = "tssms"
            sms.Image = My.Resources.emblem_documents
            Me.cmsNotificaciones.Items.Add(sms)
        End If

        Dim separador As New ToolStripSeparator
        Me.cmsNotificaciones.Items.Add(separador)

        Dim err As New ToolStripMenuItem
        err.Text = "Notificar error"
        err.Name = "tsError"
        err.Image = My.Resources.mail_forward_4_16
        AddHandler err.Click, AddressOf reportBug
        Me.cmsNotificaciones.Items.Add(err)

        Dim salir As New ToolStripMenuItem
        salir.Text = "Salir"
        salir.Name = "tssalir"
        salir.Image = My.Resources.application_exit_3_256
        AddHandler salir.Click, AddressOf Me.salir
        Me.cmsNotificaciones.Items.Add(salir)
    End Sub

    Protected Sub salir(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Public Sub lMensajes_Click(sender As System.Object, e As System.EventArgs) Handles lMensajes.Click
        Dim frm As New frmMensajesPendientes(Me.lMensajes, Me)
        LAengine.añadirPestañaAutonoma(CType(frm, Form))
    End Sub

    Protected Sub lAyuda_Click(sender As System.Object, e As System.EventArgs) Handles lAyuda.Click
        Dim url As String = Config.HelpUrl & "?cat=" & Me.TabControl1.SelectedTab.Text.Replace(TabManager.CIERRE_PESTAÑA, "").Replace(" ", "_")
        LAengine.ayuda(url)

    End Sub

    Shared Sub OpenHelp(ByVal categoria As String)
        Dim url As String = Config.HelpUrl & "?cat=" & categoria
        LAengine.ayuda(url)
    End Sub

    Shared Sub añadirPestañaSinCierre(ByRef frmEnt As Form)
        LAengine.añadirPestañasinCierre(frmEnt)
    End Sub

    Shared Sub añadirPestaña(ByRef frmEnt As Form)
        LAengine.añadirPestañaAutonoma(frmEnt)
    End Sub

    Shared Sub añadirPestaña_standar(ByRef frmEnt As Form)
        LAengine.AñadirPestaña(frmEnt)
    End Sub

    Protected Sub NotificarErrorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NotificarErrorToolStripMenuItem.Click
        reportBug(Nothing, Nothing)
    End Sub


    'protected Sub cambiar_sesion()
    '    ini = New FrmInicio
    '    If ini.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        Me.Controls.Remove(msMenu)
    '        msMenu = LAengine.AdministrarPermisosFormulario()
    '        Me.Controls.Add(msMenu)
    '    End If
    'End Sub

    Private Sub cargarExtras(ByVal sender As System.Object, _
      ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        'AddHandler tsNavegacion.MouseEnter, AddressOf ToolStripLabel1_Click
        'AddHandler Me.SplitContainer1.Panel1.MouseLeave, AddressOf ToolStripLabel1_Click

        'calculo del tamaño del cierre de las pestañas
        'TabTarget = CreateGraphics.MeasureString(" x", TabControl1.Font)
        GUImain.LAengine.Target_Cerrar_Pestana = CreateGraphics.MeasureString(TabManager.CIERRE_PESTAÑA, TabControl1.Font)

    End Sub

    Private Sub ended(ByVal sender As System.Object, _
      ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        If Not Config.dataFillNotificaction Then
            frmNews.ocultarNotificaciones() 'Me.PanNot1.Visible = False
        End If

    End Sub


    Private Sub LAgenda_Click(sender As System.Object, e As System.EventArgs) Handles LAgenda.Click
        mAgenda.Show(LAgenda, LAgenda.Location)
    End Sub

    Protected Sub cargarAgenda()
        Dim dtb As New DataBase(Config.Server)
        Dim dt As DataTable = dtb.Consultar("exec ComunicacionesSelectDgv", True)
        If Not dt Is Nothing Then
            Me.mAgenda.Items.Clear()
            Dim sms2 As ToolStripMenuItem

            For Each row As DataRow In dt.Rows
                sms2 = New ToolStripMenuItem
                sms2.Text = Convert.ToString(row.Item(1)) & "  " & _
                        If(Convert.IsDBNull(row.Item(4)), "-", Convert.ToString(row.Item(4))) & " " & _
                        If(Convert.IsDBNull(row.Item(3)), "-", Convert.ToString(row.Item(3))) & " " & _
                        If(Convert.IsDBNull(row.Item(2)), "-", Convert.ToString(row.Item(2)))

                Me.mAgenda.Items.Add(sms2)
            Next
        End If
    End Sub


    Protected Sub EntradasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem1.Click
        Dim frm As New AlmacenEntradasSalidas
        añadirPestaña(CType(frm, Form))
    End Sub

    Protected Sub SalidasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalidasToolStripMenuItem1.Click
        Dim frm As New EscaneoSCC1
        añadirPestaña(CType(frm, Form))
    End Sub

    Private Sub AlbaranesProvisionalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlbaranesProvisionalesToolStripMenuItem.Click
        Dim frm As New frmAlbaranesNoDefinitivos
        añadirPestaña(CType(frm, Form))
    End Sub
End Class

