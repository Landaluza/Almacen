
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

        Dim scr As New Pantalla
        If scr.isMultiScreen Then
            Dim Monitor As New ToolStripMenuItem
            Monitor.Text = "Monitor"
            Monitor.Name = "tsMonitor"
            Me.cmsNotificaciones.Items.Add(Monitor)

            Dim Monitor1 As New ToolStripMenuItem
            Monitor1.Text = "Monitor 1"
            Monitor1.Name = "tsMonitor1"
            AddHandler Monitor1.Click, AddressOf monitor1click
            Monitor.DropDownItems.Add(Monitor1)

            Dim Monitor2 As New ToolStripMenuItem
            Monitor2.Text = "Monitor 2"
            Monitor2.Name = "tsMonitor2"
            AddHandler Monitor2.Click, AddressOf monitor2click
            Monitor.DropDownItems.Add(Monitor2)
        End If


        Dim salir As New ToolStripMenuItem
        salir.Text = "Salir"
        salir.Name = "tssalir"
        salir.Image = My.Resources.application_exit_3_256
        AddHandler salir.Click, AddressOf Me.salir
        Me.cmsNotificaciones.Items.Add(salir)
    End Sub

    Private Sub monitor1click(sender As Object, e As EventArgs)
        Config.activeScreen = 0
    End Sub
    Private Sub monitor2click(sender As Object, e As EventArgs)
        Config.activeScreen = 1
    End Sub

    Protected Sub salir(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Public Sub lMensajes_Click(sender As System.Object, e As System.EventArgs) Handles lMensajes.Click
        Dim frm As New frmMensajesPendientes(Me.lMensajes, Me)
        LAengine.añadirPestañaAutonoma(CType(frm, Form))
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

    Private Sub cargarExtras(ByVal sender As System.Object, _
      ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

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

