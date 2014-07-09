<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntNoticias2
    Inherits La_Andaluza_Almacen.DetailedSimpleForm

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.tlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTitulo
        '
        Me.txtTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTitulo.BackColor = System.Drawing.SystemColors.Control
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.Enabled = False
        Me.txtTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.Location = New System.Drawing.Point(32, 58)
        Me.txtTitulo.MaxLength = 350
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(836, 17)
        Me.txtTitulo.TabIndex = 0
        '
        'txtTexto
        '
        Me.txtTexto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTexto.BackColor = System.Drawing.SystemColors.Control
        Me.txtTexto.Enabled = False
        Me.txtTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTexto.Location = New System.Drawing.Point(32, 88)
        Me.txtTexto.MaxLength = 8000
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(836, 388)
        Me.txtTexto.TabIndex = 1
        '
        'tlpTop
        '
        Me.tlpTop.Location = New System.Drawing.Point(0, 0)
        Me.tlpTop.Name = "tlpTop"
        Me.tlpTop.Size = New System.Drawing.Size(200, 100)
        Me.tlpTop.TabIndex = 0
        '
        'txtFecha
        '
        Me.txtFecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFecha.BackColor = System.Drawing.SystemColors.Control
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(32, 35)
        Me.txtFecha.MaxLength = 350
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(836, 17)
        Me.txtFecha.TabIndex = 8
        '
        'frmEntNoticias2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(900, 512)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.txtTexto)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MinimumSize = New System.Drawing.Size(440, 186)
        Me.Name = "frmEntNoticias2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Noticias2"
        Me.Controls.SetChildIndex(Me.txtTexto, 0)
        Me.Controls.SetChildIndex(Me.txtTitulo, 0)
        Me.Controls.SetChildIndex(Me.txtFecha, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtTitulo As System.Windows.Forms.TextBox
    Private WithEvents txtTexto As System.Windows.Forms.TextBox
    Private WithEvents tlpTop As System.Windows.Forms.TableLayoutPanel
    Private WithEvents txtFecha As System.Windows.Forms.TextBox
End Class
