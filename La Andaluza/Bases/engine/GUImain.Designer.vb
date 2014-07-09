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
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsNotificaciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MensajesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NotificarErrorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanContenido = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tsCustomMenu = New System.Windows.Forms.ToolStrip()
        Me.scExtra = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tsPestañas = New System.Windows.Forms.ToolStrip()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.tsPetañalateral = New System.Windows.Forms.ToolStripButton()
        Me.tsNavegacion = New System.Windows.Forms.ToolStripLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmsNotificacionesOperaciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.EntradasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.mAgenda.SuspendLayout()
        Me.msMenu.SuspendLayout()
        Me.cmsNotificaciones.SuspendLayout()
        Me.PanContenido.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.scExtra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scExtra.Panel1.SuspendLayout()
        Me.scExtra.Panel2.SuspendLayout()
        Me.scExtra.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradasToolStripMenuItem1, Me.SalidasToolStripMenuItem1})
        Me.msMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMenu.MinimumSize = New System.Drawing.Size(1092, 25)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.msMenu.Size = New System.Drawing.Size(1092, 25)
        Me.msMenu.TabIndex = 14
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
        'PanContenido
        '
        Me.PanContenido.Controls.Add(Me.SplitContainer1)
        Me.PanContenido.Controls.Add(Me.Panel4)
        Me.PanContenido.Controls.Add(Me.Panel3)
        Me.PanContenido.Controls.Add(Me.Button8)
        Me.PanContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanContenido.Location = New System.Drawing.Point(0, 25)
        Me.PanContenido.Name = "PanContenido"
        Me.PanContenido.Size = New System.Drawing.Size(1042, 632)
        Me.PanContenido.TabIndex = 55
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(18, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tsCustomMenu)
        Me.SplitContainer1.Panel1Collapsed = True
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.scExtra)
        Me.SplitContainer1.Size = New System.Drawing.Size(1006, 632)
        Me.SplitContainer1.SplitterDistance = 198
        Me.SplitContainer1.TabIndex = 55
        '
        'tsCustomMenu
        '
        Me.tsCustomMenu.AllowDrop = True
        Me.tsCustomMenu.AllowMerge = False
        Me.tsCustomMenu.AutoSize = False
        Me.tsCustomMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.tsCustomMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCustomMenu.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.tsCustomMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsCustomMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsCustomMenu.MinimumSize = New System.Drawing.Size(0, 90)
        Me.tsCustomMenu.Name = "tsCustomMenu"
        Me.tsCustomMenu.Size = New System.Drawing.Size(198, 404)
        Me.tsCustomMenu.TabIndex = 57
        Me.tsCustomMenu.Text = "ToolStrip2"
        Me.tsCustomMenu.Visible = False
        '
        'scExtra
        '
        Me.scExtra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scExtra.Location = New System.Drawing.Point(0, 0)
        Me.scExtra.Name = "scExtra"
        '
        'scExtra.Panel1
        '
        Me.scExtra.Panel1.Controls.Add(Me.TabControl1)
        '
        'scExtra.Panel2
        '
        Me.scExtra.Panel2.Controls.Add(Me.TabControl2)
        Me.scExtra.Panel2Collapsed = True
        Me.scExtra.Size = New System.Drawing.Size(1006, 632)
        Me.scExtra.SplitterDistance = 981
        Me.scExtra.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.AllowDrop = True
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1006, 632)
        Me.TabControl1.TabIndex = 0
        '
        'TabControl2
        '
        Me.TabControl2.AllowDrop = True
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(96, 100)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel9)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(88, 74)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Arrastra aquí   x"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel9.Controls.Add(Me.Label26)
        Me.Panel9.Controls.Add(Me.Label25)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(88, 74)
        Me.Panel9.TabIndex = 0
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(3, 250)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(122, 16)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Para una vista dual"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(3, 287)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(163, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "arrastra una pestaña aquí "
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ToolStrip1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1024, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(18, 632)
        Me.Panel4.TabIndex = 56
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AllowMerge = False
        Me.ToolStrip1.CanOverflow = False
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(18, 102)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.tsPestañas)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(18, 632)
        Me.Panel3.TabIndex = 0
        '
        'tsPestañas
        '
        Me.tsPestañas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsPestañas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsPestañas.Location = New System.Drawing.Point(0, 0)
        Me.tsPestañas.Name = "tsPestañas"
        Me.tsPestañas.Size = New System.Drawing.Size(18, 102)
        Me.tsPestañas.TabIndex = 0
        Me.tsPestañas.Text = "ToolStrip1"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(287, 158)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(87, 71)
        Me.Button8.TabIndex = 54
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
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
        'EntradasToolStripMenuItem1
        '
        Me.EntradasToolStripMenuItem1.Name = "EntradasToolStripMenuItem1"
        Me.EntradasToolStripMenuItem1.Size = New System.Drawing.Size(64, 21)
        Me.EntradasToolStripMenuItem1.Text = "Entradas"
        '
        'SalidasToolStripMenuItem1
        '
        Me.SalidasToolStripMenuItem1.Name = "SalidasToolStripMenuItem1"
        Me.SalidasToolStripMenuItem1.Size = New System.Drawing.Size(55, 21)
        Me.SalidasToolStripMenuItem1.Text = "Salidas"
        '
        'GUImain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 682)
        Me.Controls.Add(Me.PanContenido)
        Me.Controls.Add(Me.msMenu)
        Me.Controls.Add(Me.Panel1)
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
        Me.PanContenido.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.scExtra.Panel1.ResumeLayout(False)
        Me.scExtra.Panel2.ResumeLayout(False)
        CType(Me.scExtra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scExtra.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tsmPlanesGeneralesHigiene As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msMenu As System.Windows.Forms.MenuStrip
    Protected WithEvents Panel1 As System.Windows.Forms.Panel
    Protected WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Protected WithEvents PanContenido As System.Windows.Forms.Panel
    Protected WithEvents Button8 As System.Windows.Forms.Button
    Protected WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Protected WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Protected WithEvents Panel4 As System.Windows.Forms.Panel
    Protected WithEvents Panel3 As System.Windows.Forms.Panel
    Protected WithEvents tsPestañas As System.Windows.Forms.ToolStrip
    Protected WithEvents tsNavegacion As System.Windows.Forms.ToolStripLabel
    Protected WithEvents tsCustomMenu As System.Windows.Forms.ToolStrip
    Protected WithEvents lServ As System.Windows.Forms.Label
    Protected WithEvents lReportBug As System.Windows.Forms.Label
    Protected WithEvents lUser As System.Windows.Forms.Label
    Protected WithEvents scExtra As System.Windows.Forms.SplitContainer
    Protected WithEvents TabPage1 As System.Windows.Forms.TabPage
    Protected WithEvents Panel9 As System.Windows.Forms.Panel
    Protected WithEvents Label26 As System.Windows.Forms.Label
    Protected WithEvents Label25 As System.Windows.Forms.Label
    Protected WithEvents cmsNotificaciones As System.Windows.Forms.ContextMenuStrip
    Protected WithEvents MensajesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Protected WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents cmsNotificacionesOperaciones As System.Windows.Forms.ContextMenuStrip
    Protected WithEvents lMensajes As System.Windows.Forms.Label
    Protected WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Protected WithEvents tsPetañalateral As System.Windows.Forms.ToolStripButton
    Protected WithEvents lAyuda As System.Windows.Forms.Label
    Protected WithEvents NotificarErrorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents TabControl2 As System.Windows.Forms.TabControl
    Protected WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Protected WithEvents lPersonalSinFin As System.Windows.Forms.Label
    Protected WithEvents LAgenda As System.Windows.Forms.Label
    Private WithEvents mAgenda As System.Windows.Forms.ContextMenuStrip
    Private WithEvents AsdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntradasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalidasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
