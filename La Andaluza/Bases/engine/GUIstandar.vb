Public Class GUIstandar
    Inherits GUImain

    Public Sub New(ByRef frm As FrmInicio)
        MyBase.new(frm)
        ' This call is required by the designer.
        InitializeComponent()
        Me.Text = Config.Version_seriada
        SalidasToolStripMenuItem1_Click(Nothing, Nothing)
        EntradasToolStripMenuItem1_Click(Nothing, Nothing)

        Me.SuspendLayout()
        Me.frmNews = New frmNews
        añadirPestañaSinCierre(CType(frmNews, Form))
        cargarAgenda()
        Me.ResumeLayout()
    End Sub

    Public Overrides Sub terminarDeIniciar(ByVal tablausada As String, ByVal ServidorUsado As String, ByVal UsuarioUsado As String, ByVal usua As String)
        MyBase.terminarDeIniciar(tablausada, ServidorUsado, UsuarioUsado, usua)

        TimerNotificaciones.Enabled = True
        TimerNotificaciones.Start()
        Me.Show()

        Me.actualizarnotificaciones()
    End Sub

    Public Overrides Sub stopGUI()
        Try
            Me.TimerNotificaciones.Stop()
            Me.TimerNotificaciones.Enabled = False
            Me.TimerNotificaciones.Dispose()
        Catch ex As Exception
        End Try

        MyBase.stopGUI()
    End Sub

    Public Shadows Sub actualizarnotificaciones()
        Dim notificacion As DataTable

        Me.cmsNotificaciones.Items.Clear()

        Dim nOC As Integer = LAengine.comprobarNumeroOC
        Dim nPed As Integer = LAengine.comprobarNumeroPedidos

        Dim sms2 As New ToolStripMenuItem
        sms2.Text = "Pedidos: " & nPed & "  Ordenes de carga: " & nOC
        sms2.Name = "tsnEscan"
        sms2.Image = My.Resources.scanner_barcode
        Me.cmsNotificaciones.Items.Add(sms2)
        AddHandler sms2.Click, AddressOf Escanear

        notificacion = LAengine.comprobarNotificaciones


        If notificacion.Rows.Count > 0 Then
            Dim separador As New ToolStripSeparator
            Me.cmsNotificaciones.Items.Add(separador)
            MyBase.actualizarNotificaciones(notificacion.Rows.Count.ToString)

            For Each row As DataRow In notificacion.Rows
                Dim sms As New ToolStripMenuItem
                sms.Text = row.Item(0).ToString
                sms.Image = My.Resources.emblem_documents
                Me.cmsNotificaciones.Items.Add(sms)
                AddHandler sms.Click, AddressOf lMensajes_Click
            Next

            Me.lMensajes.Enabled = True

            Dim frm As New frmMensajesPendientes(lMensajes, Me)

            resetearMenuNotificaciones(True)
            Me.frmNews.actualizarNotificacion(CType(frm, Form))
        Else
            resetearMenuNotificaciones(False)
            lMensajes.Enabled = False
        End If
    End Sub

    Protected Sub TimerNotificaciones_Tick(sender As System.Object, e As System.EventArgs) Handles TimerNotificaciones.Tick
        actualizarnotificaciones()
    End Sub

    Private Sub GUIstandar_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BackgroundWorker1.RunWorkerAsync()
    End Sub

End Class