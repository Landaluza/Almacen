<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUIstandar
    Inherits La_Andaluza_Almacen.GUImain

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUIstandar))
        Me.TimerNotificaciones = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerNotificaciones
        '
        Me.TimerNotificaciones.Interval = 36000000
        Me.TimerNotificaciones.Tag = "36000000"
        '
        'GUIstandar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 682)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GUIstandar"
        Me.Text = "GUIEnvasado"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents TimerNotificaciones As System.Windows.Forms.Timer
End Class
