<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSugerenciaCarga
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
        Me.dgvSugeridos = New System.Windows.Forms.DataGridView()
        Me.bnd = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.PrintGrilla = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgvSugeridos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnd.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSugeridos
        '
        Me.dgvSugeridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSugeridos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSugeridos.Location = New System.Drawing.Point(0, 25)
        Me.dgvSugeridos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvSugeridos.Name = "dgvSugeridos"
        Me.dgvSugeridos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSugeridos.Size = New System.Drawing.Size(900, 476)
        Me.dgvSugeridos.TabIndex = 0
        '
        'bnd
        '
        Me.bnd.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.bnd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.bnd.Location = New System.Drawing.Point(0, 0)
        Me.bnd.Name = "bnd"
        Me.bnd.Size = New System.Drawing.Size(900, 25)
        Me.bnd.TabIndex = 1
        Me.bnd.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.imprimir_16
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(82, 22)
        Me.ToolStripButton1.Text = "&Imprimir"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.emblem_important_3
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(96, 22)
        Me.ToolStripButton2.Text = "&Extraviado"
        '
        'PrintGrilla
        '
        '
        'frmSugerenciaCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 501)
        Me.Controls.Add(Me.dgvSugeridos)
        Me.Controls.Add(Me.bnd)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSugerenciaCarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmSugerenciaCarga"
        CType(Me.dgvSugeridos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnd.ResumeLayout(False)
        Me.bnd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents dgvSugeridos As System.Windows.Forms.DataGridView
   Private WithEvents bnd As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Public WithEvents PrintGrilla As System.Drawing.Printing.PrintDocument
End Class
