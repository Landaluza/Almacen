<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNews
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gbFixed = New System.Windows.Forms.GroupBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.gbNotification = New System.Windows.Forms.GroupBox()
        Me.PanNotificacionesDetalle = New System.Windows.Forms.Panel()
        Me.PanMensajes = New System.Windows.Forms.Panel()
        Me.PanMensajesDetalles = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.PanNot1 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.bgNew = New System.Windows.Forms.GroupBox()
        Me.PanNoticias = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbFixed.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbNotification.SuspendLayout()
        Me.PanNotificacionesDetalle.SuspendLayout()
        Me.PanMensajes.SuspendLayout()
        Me.PanNot1.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bgNew.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbFixed
        '
        Me.gbFixed.Controls.Add(Me.Panel6)
        Me.gbFixed.Controls.Add(Me.PictureBox2)
        Me.gbFixed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbFixed.Location = New System.Drawing.Point(0, 403)
        Me.gbFixed.Margin = New System.Windows.Forms.Padding(3, 100, 3, 3)
        Me.gbFixed.Name = "gbFixed"
        Me.gbFixed.Size = New System.Drawing.Size(598, 312)
        Me.gbFixed.TabIndex = 5
        Me.gbFixed.TabStop = False
        Me.gbFixed.Text = "Correcciones"
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(288, 16)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(307, 293)
        Me.Panel6.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.emblem_notice_256
        Me.PictureBox2.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(285, 293)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'gbNotification
        '
        Me.gbNotification.Controls.Add(Me.PanNotificacionesDetalle)
        Me.gbNotification.Controls.Add(Me.PictureBox3)
        Me.gbNotification.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbNotification.Location = New System.Drawing.Point(598, 403)
        Me.gbNotification.Margin = New System.Windows.Forms.Padding(3, 100, 3, 3)
        Me.gbNotification.Name = "gbNotification"
        Me.gbNotification.Size = New System.Drawing.Size(524, 312)
        Me.gbNotification.TabIndex = 6
        Me.gbNotification.TabStop = False
        Me.gbNotification.Text = "Notificaciones"
        '
        'PanNotificacionesDetalle
        '
        Me.PanNotificacionesDetalle.AutoScroll = True
        Me.PanNotificacionesDetalle.Controls.Add(Me.PanMensajes)
        Me.PanNotificacionesDetalle.Controls.Add(Me.PanNot1)
        Me.PanNotificacionesDetalle.Controls.Add(Me.Panel10)
        Me.PanNotificacionesDetalle.Controls.Add(Me.Panel7)
        Me.PanNotificacionesDetalle.Controls.Add(Me.Panel12)
        Me.PanNotificacionesDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanNotificacionesDetalle.Location = New System.Drawing.Point(239, 16)
        Me.PanNotificacionesDetalle.Name = "PanNotificacionesDetalle"
        Me.PanNotificacionesDetalle.Size = New System.Drawing.Size(282, 293)
        Me.PanNotificacionesDetalle.TabIndex = 11
        '
        'PanMensajes
        '
        Me.PanMensajes.Controls.Add(Me.PanMensajesDetalles)
        Me.PanMensajes.Controls.Add(Me.Label30)
        Me.PanMensajes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanMensajes.Location = New System.Drawing.Point(0, 121)
        Me.PanMensajes.Name = "PanMensajes"
        Me.PanMensajes.Size = New System.Drawing.Size(282, 143)
        Me.PanMensajes.TabIndex = 6
        '
        'PanMensajesDetalles
        '
        Me.PanMensajesDetalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanMensajesDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMensajesDetalles.Location = New System.Drawing.Point(0, 16)
        Me.PanMensajesDetalles.Name = "PanMensajesDetalles"
        Me.PanMensajesDetalles.Size = New System.Drawing.Size(282, 127)
        Me.PanMensajesDetalles.TabIndex = 6
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(0, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(156, 16)
        Me.Label30.TabIndex = 5
        Me.Label30.Text = "Mensajes pendientes"
        '
        'PanNot1
        '
        Me.PanNot1.Controls.Add(Me.Label21)
        Me.PanNot1.Controls.Add(Me.Label20)
        Me.PanNot1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanNot1.Location = New System.Drawing.Point(0, 81)
        Me.PanNot1.Name = "PanNot1"
        Me.PanNot1.Size = New System.Drawing.Size(282, 40)
        Me.PanNot1.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label21.Location = New System.Drawing.Point(20, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(257, 13)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "No ha terminado de rellenar la información de usuario"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(0, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(165, 16)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Información de usuario"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 71)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(282, 10)
        Me.Panel10.TabIndex = 20
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(282, 10)
        Me.Panel11.TabIndex = 21
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 29)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(282, 42)
        Me.Panel7.TabIndex = 19
        Me.Panel7.Visible = False
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(282, 29)
        Me.Panel12.TabIndex = 21
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox3.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.emblem_important_2_256
        Me.PictureBox3.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(236, 293)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'bgNew
        '
        Me.bgNew.Controls.Add(Me.PanNoticias)
        Me.bgNew.Controls.Add(Me.PictureBox1)
        Me.bgNew.Dock = System.Windows.Forms.DockStyle.Top
        Me.bgNew.Location = New System.Drawing.Point(0, 0)
        Me.bgNew.Margin = New System.Windows.Forms.Padding(3, 100, 3, 3)
        Me.bgNew.Name = "bgNew"
        Me.bgNew.Size = New System.Drawing.Size(1122, 403)
        Me.bgNew.TabIndex = 4
        Me.bgNew.TabStop = False
        Me.bgNew.Text = "Novedades"
        '
        'PanNoticias
        '
        Me.PanNoticias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanNoticias.Location = New System.Drawing.Point(288, 16)
        Me.PanNoticias.Name = "PanNoticias"
        Me.PanNoticias.Size = New System.Drawing.Size(831, 384)
        Me.PanNoticias.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.emblem_new_256
        Me.PictureBox1.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 384)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 900000
        '
        'frmNews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1122, 715)
        Me.Controls.Add(Me.gbFixed)
        Me.Controls.Add(Me.gbNotification)
        Me.Controls.Add(Me.bgNew)
        Me.Name = "frmNews"
        Me.Text = "Novedades"
        Me.gbFixed.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbNotification.ResumeLayout(False)
        Me.PanNotificacionesDetalle.ResumeLayout(False)
        Me.PanMensajes.ResumeLayout(False)
        Me.PanMensajes.PerformLayout()
        Me.PanNot1.ResumeLayout(False)
        Me.PanNot1.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bgNew.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents gbFixed As System.Windows.Forms.GroupBox
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents gbNotification As System.Windows.Forms.GroupBox
    Private WithEvents PanNotificacionesDetalle As System.Windows.Forms.Panel
    Private WithEvents PanMensajes As System.Windows.Forms.Panel
    Private WithEvents PanMensajesDetalles As System.Windows.Forms.Panel
    Private WithEvents Label30 As System.Windows.Forms.Label
    Private WithEvents PanNot1 As System.Windows.Forms.Panel
    Private WithEvents Label21 As System.Windows.Forms.Label
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents Panel10 As System.Windows.Forms.Panel
    Private WithEvents Panel11 As System.Windows.Forms.Panel
    Private WithEvents Panel7 As System.Windows.Forms.Panel
    Private WithEvents Panel12 As System.Windows.Forms.Panel
    Private WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Private WithEvents bgNew As System.Windows.Forms.GroupBox
    Private WithEvents PanNoticias As System.Windows.Forms.Panel
    Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents Timer1 As System.Windows.Forms.Timer
End Class
