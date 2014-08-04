<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUImain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUImain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LAgenda = New System.Windows.Forms.Label()
        Me.mAgenda = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AsdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lPersonalSinFin = New System.Windows.Forms.Label()
        Me.lAyuda = New System.Windows.Forms.Label()
        Me.lUser = New System.Windows.Forms.Label()
        Me.lMensajes = New System.Windows.Forms.Label()
        Me.lReportBug = New System.Windows.Forms.Label()
        Me.lServ = New System.Windows.Forms.Label()
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.EntradasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlbaranesProvisionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsNotificaciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MensajesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NotificarErrorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tsPetañalateral = New System.Windows.Forms.ToolStripButton()
        Me.tsNavegacion = New System.Windows.Forms.ToolStripLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmsNotificacionesOperaciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.mAgenda.SuspendLayout()
        Me.msMenu.SuspendLayout()
        Me.cmsNotificaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.LAgenda)
        Me.Panel1.Controls.Add(Me.lPersonalSinFin)
        Me.Panel1.Controls.Add(Me.lAyuda)
        Me.Panel1.Controls.Add(Me.lUser)
        Me.Panel1.Controls.Add(Me.lMensajes)
        Me.Panel1.Controls.Add(Me.lReportBug)
        Me.Panel1.Controls.Add(Me.lServ)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 657)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1042, 25)
        Me.Panel1.TabIndex = 3
        '
        'LAgenda
        '
        Me.LAgenda.ContextMenuStrip = Me.mAgenda
        Me.LAgenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LAgenda.Dock = System.Windows.Forms.DockStyle.Left
        Me.LAgenda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LAgenda.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.accessories_dictionary
        Me.LAgenda.Location = New System.Drawing.Point(62, 0)
        Me.LAgenda.Name = "LAgenda"
        Me.LAgenda.Size = New System.Drawing.Size(31, 21)
        Me.LAgenda.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.LAgenda, "Vista rapida de contactos")
        '
        'mAgenda
        '
        Me.mAgenda.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsdToolStripMenuItem})
        Me.mAgenda.Name = "mAgenda"
        Me.mAgenda.Size = New System.Drawing.Size(123, 26)
        '
        'AsdToolStripMenuItem
        '
        Me.AsdToolStripMenuItem.Name = "AsdToolStripMenuItem"
        Me.AsdToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AsdToolStripMenuItem.Text = "Sin datos"
        '
        'lPersonalSinFin
        '
        Me.lPersonalSinFin.Dock = System.Windows.Forms.DockStyle.Right
        Me.lPersonalSinFin.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.appointmentmissed16
        Me.lPersonalSinFin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lPersonalSinFin.Location = New System.Drawing.Point(926, 0)
        Me.lPersonalSinFin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lPersonalSinFin.Name = "lPersonalSinFin"
        Me.lPersonalSinFin.Size = New System.Drawing.Size(20, 21)
        Me.lPersonalSinFin.TabIndex = 63
        Me.lPersonalSinFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lPersonalSinFin, "Existen empleados con turnos sin finalizar. Click para ver detalles")
        Me.lPersonalSinFin.Visible = False
        '
        'lAyuda
        '
        Me.lAyuda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lAyuda.Dock = System.Windows.Forms.DockStyle.Left
        Me.lAyuda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lAyuda.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.help_2
        Me.lAyuda.Location = New System.Drawing.Point(31, 0)
        Me.lAyuda.Name = "lAyuda"
        Me.lAyuda.Size = New System.Drawing.Size(31, 21)
        Me.lAyuda.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.lAyuda, "ayuda sobre la ventana activa")
        '
        'lUser
        '
        Me.lUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lUser.Dock = System.Windows.Forms.DockStyle.Left
        Me.lUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lUser.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.user_suit
        Me.lUser.Location = New System.Drawing.Point(0, 0)
        Me.lUser.Name = "lUser"
        Me.lUser.Size = New System.Drawing.Size(31, 21)
        Me.lUser.TabIndex = 60
        '
        'lMensajes
        '
        Me.lMensajes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lMensajes.Dock = System.Windows.Forms.DockStyle.Right
        Me.lMensajes.Enabled = False
        Me.lMensajes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lMensajes.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.emblem_mail_16
        Me.lMensajes.Location = New System.Drawing.Point(946, 0)
        Me.lMensajes.Name = "lMensajes"
        Me.lMensajes.Size = New System.Drawing.Size(31, 21)
        Me.lMensajes.TabIndex = 61
        Me.ToolTip1.SetToolTip(Me.lMensajes, "Mensajes pendientes")
        '
        'lReportBug
        '
        Me.lReportBug.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lReportBug.Dock = System.Windows.Forms.DockStyle.Right
        Me.lReportBug.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lReportBug.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.mail_forward_4_16
        Me.lReportBug.Location = New System.Drawing.Point(977, 0)
        Me.lReportBug.Name = "lReportBug"
        Me.lReportBug.Size = New System.Drawing.Size(31, 21)
        Me.lReportBug.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.lReportBug, "Reportar un error")
        '
        'lServ
        '
        Me.lServ.Dock = System.Windows.Forms.DockStyle.Right
        Me.lServ.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lServ.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.network_transmit
        Me.lServ.Location = New System.Drawing.Point(1008, 0)
        Me.lServ.Name = "lServ"
        Me.lServ.Size = New System.Drawing.Size(30, 21)
        Me.lServ.TabIndex = 58
        '
        'msMenu
        '
        Me.msMenu.BackColor = System.Drawing.SystemColors.Control
        Me.msMenu.GripMargin = New System.Windows.Forms.Padding(2)
        Me.msMenu.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradasToolStripMenuItem1, Me.SalidasToolStripMenuItem1, Me.AlbaranesProvisionalesToolStripMenuItem})
        Me.msMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMenu.MinimumSize = New System.Drawing.Size(1092, 30)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.msMenu.Size = New System.Drawing.Size(1092, 30)
        Me.msMenu.TabIndex = 14
        '
        'EntradasToolStripMenuItem1
        '
        Me.EntradasToolStripMenuItem1.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.package_green
        Me.EntradasToolStripMenuItem1.Name = "EntradasToolStripMenuItem1"
        Me.EntradasToolStripMenuItem1.Size = New System.Drawing.Size(86, 26)
        Me.EntradasToolStripMenuItem1.Text = "Entradas"
        '
        'SalidasToolStripMenuItem1
        '
        Me.SalidasToolStripMenuItem1.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.scanner_barcode
        Me.SalidasToolStripMenuItem1.Name = "SalidasToolStripMenuItem1"
        Me.SalidasToolStripMenuItem1.Size = New System.Drawing.Size(77, 26)
        Me.SalidasToolStripMenuItem1.Text = "Salidas"
        '
        'AlbaranesProvisionalesToolStripMenuItem
        '
        Me.AlbaranesProvisionalesToolStripMenuItem.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.document_16
        Me.AlbaranesProvisionalesToolStripMenuItem.Name = "AlbaranesProvisionalesToolStripMenuItem"
        Me.AlbaranesProvisionalesToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.AlbaranesProvisionalesToolStripMenuItem.Text = "Albaranes provisionales"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.ContextMenuStrip = Me.cmsNotificaciones
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'cmsNotificaciones
        '
        Me.cmsNotificaciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MensajesToolStripMenuItem, Me.ToolStripSeparator1, Me.NotificarErrorToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.cmsNotificaciones.Name = "cmsNotificaciones"
        Me.cmsNotificaciones.Size = New System.Drawing.Size(213, 76)
        '
        'MensajesToolStripMenuItem
        '
        Me.MensajesToolStripMenuItem.Enabled = False
        Me.MensajesToolStripMenuItem.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.emblem_mail
        Me.MensajesToolStripMenuItem.Name = "MensajesToolStripMenuItem"
        Me.MensajesToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.MensajesToolStripMenuItem.Text = "No tiene mensajes nuevos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(209, 6)
        '
        'NotificarErrorToolStripMenuItem
        '
        Me.NotificarErrorToolStripMenuItem.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.mail_forward_4_16
        Me.NotificarErrorToolStripMenuItem.Name = "NotificarErrorToolStripMenuItem"
        Me.NotificarErrorToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.NotificarErrorToolStripMenuItem.Text = "Notificar error"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.application_exit_3_256
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TabControl1
        '
        Me.TabControl1.AllowDrop = True
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 30)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1042, 652)
        Me.TabControl1.TabIndex = 0
        '
        'tsPetañalateral
        '
        Me.tsPetañalateral.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsPetañalateral.Image = CType(resources.GetObject("tsPetañalateral.Image"), System.Drawing.Image)
        Me.tsPetañalateral.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPetañalateral.Margin = New System.Windows.Forms.Padding(0, 45, 0, 2)
        Me.tsPetañalateral.Name = "tsPetañalateral"
        Me.tsPetañalateral.Size = New System.Drawing.Size(16, 75)
        Me.tsPetañalateral.Text = "Panel lateral"
        '
        'tsNavegacion
        '
        Me.tsNavegacion.Margin = New System.Windows.Forms.Padding(0, 45, 0, 2)
        Me.tsNavegacion.Name = "tsNavegacion"
        Me.tsNavegacion.Size = New System.Drawing.Size(16, 70)
        Me.tsNavegacion.Text = "Navegación"
        Me.tsNavegacion.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270
        Me.tsNavegacion.ToolTipText = "Permite crear una barra de herramientas personalizada"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'cmsNotificacionesOperaciones
        '
        Me.cmsNotificacionesOperaciones.Name = "ContextMenuStrip1"
        Me.cmsNotificacionesOperaciones.Size = New System.Drawing.Size(61, 4)
        '
        'BackgroundWorker1
        '
        '
        'GUImain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1042, 682)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.msMenu)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msMenu
        Me.Name = "GUImain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "04.04.2012  La Andaluza Desarrollo."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.mAgenda.ResumeLayout(False)
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.cmsNotificaciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tsmPlanesGeneralesHigiene As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msMenu As System.Windows.Forms.MenuStrip
    Protected WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Protected WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Protected WithEvents tsNavegacion As System.Windows.Forms.ToolStripLabel
    Protected WithEvents lServ As System.Windows.Forms.Label
    Protected WithEvents lReportBug As System.Windows.Forms.Label
    Protected WithEvents lUser As System.Windows.Forms.Label
    Protected WithEvents cmsNotificaciones As System.Windows.Forms.ContextMenuStrip
    Protected WithEvents MensajesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Protected WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents cmsNotificacionesOperaciones As System.Windows.Forms.ContextMenuStrip
    Protected WithEvents lMensajes As System.Windows.Forms.Label
    Protected WithEvents tsPetañalateral As System.Windows.Forms.ToolStripButton
    Protected WithEvents lAyuda As System.Windows.Forms.Label
    Protected WithEvents NotificarErrorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Protected WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Protected WithEvents lPersonalSinFin As System.Windows.Forms.Label
    Protected WithEvents LAgenda As System.Windows.Forms.Label
    Private WithEvents mAgenda As System.Windows.Forms.ContextMenuStrip
    Private WithEvents AsdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents AlbaranesProvisionalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents EntradasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents SalidasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents Panel1 As System.Windows.Forms.Panel

End Class
