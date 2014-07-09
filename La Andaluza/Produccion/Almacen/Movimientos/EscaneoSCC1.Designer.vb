<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EscaneoSCC1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ImprimirListadoDeSCCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarPrioridadAltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriorizarPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvOrdenesCarga = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ImprimirListadoDeSCCToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarCargaDeEmergenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriorizarLasOrdenesDeCargaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PrintGrilla = New System.Drawing.Printing.PrintDocument()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.PanBtn = New System.Windows.Forms.Panel()
        Me.PanCbtn = New System.Windows.Forms.Panel()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnup = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage4.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvOrdenesCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.PanBtn.SuspendLayout()
        Me.PanCbtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.CausesValidation = False
        Me.TextBox1.Location = New System.Drawing.Point(209, 543)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(68, 20)
        Me.TextBox1.TabIndex = 68
        Me.TextBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.CausesValidation = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(17, 598)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 51)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "< Anular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.CausesValidation = False
        Me.TextBox2.Location = New System.Drawing.Point(379, 627)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(68, 20)
        Me.TextBox2.TabIndex = 66
        Me.TextBox2.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CausesValidation = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(497, 629)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 67
        '
        'ListView1
        '
        Me.ListView1.CausesValidation = False
        Me.ListView1.Location = New System.Drawing.Point(6, 45)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(972, 482)
        Me.ListView1.TabIndex = 53
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.CausesValidation = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(408, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 24)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Palets cargados."
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.CausesValidation = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(896, 598)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 51)
        Me.Button2.TabIndex = 65
        Me.Button2.Text = "Grabar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(920, 901)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 37)
        Me.Button3.TabIndex = 73
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.SplitContainer1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1006, 652)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Selección cargas"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 646)
        Me.SplitContainer1.SplitterDistance = 314
        Me.SplitContainer1.SplitterIncrement = 3
        Me.SplitContainer1.SplitterWidth = 10
        Me.SplitContainer1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvPedidos)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 314)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pedidos"
        '
        'dgvPedidos
        '
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPedidos.Location = New System.Drawing.Point(3, 16)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.RowHeadersVisible = False
        Me.dgvPedidos.RowTemplate.Height = 24
        Me.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPedidos.Size = New System.Drawing.Size(994, 295)
        Me.dgvPedidos.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirListadoDeSCCToolStripMenuItem, Me.DarPrioridadAltaToolStripMenuItem, Me.PriorizarPedidosToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(200, 70)
        '
        'ImprimirListadoDeSCCToolStripMenuItem
        '
        Me.ImprimirListadoDeSCCToolStripMenuItem.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.imprimir_16
        Me.ImprimirListadoDeSCCToolStripMenuItem.Name = "ImprimirListadoDeSCCToolStripMenuItem"
        Me.ImprimirListadoDeSCCToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ImprimirListadoDeSCCToolStripMenuItem.Text = "Imprimir listado de SCC"
        '
        'DarPrioridadAltaToolStripMenuItem
        '
        Me.DarPrioridadAltaToolStripMenuItem.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.emblem_special
        Me.DarPrioridadAltaToolStripMenuItem.Name = "DarPrioridadAltaToolStripMenuItem"
        Me.DarPrioridadAltaToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.DarPrioridadAltaToolStripMenuItem.Text = "Dar prioridad alta"
        '
        'PriorizarPedidosToolStripMenuItem
        '
        Me.PriorizarPedidosToolStripMenuItem.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.emblem_special
        Me.PriorizarPedidosToolStripMenuItem.Name = "PriorizarPedidosToolStripMenuItem"
        Me.PriorizarPedidosToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.PriorizarPedidosToolStripMenuItem.Text = "Priorizar pedidos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvOrdenesCarga)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1000, 322)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ordenes de carga"
        '
        'dgvOrdenesCarga
        '
        Me.dgvOrdenesCarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrdenesCarga.ContextMenuStrip = Me.ContextMenuStrip2
        Me.dgvOrdenesCarga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOrdenesCarga.Location = New System.Drawing.Point(3, 16)
        Me.dgvOrdenesCarga.Name = "dgvOrdenesCarga"
        Me.dgvOrdenesCarga.RowHeadersVisible = False
        Me.dgvOrdenesCarga.RowTemplate.Height = 24
        Me.dgvOrdenesCarga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrdenesCarga.Size = New System.Drawing.Size(994, 303)
        Me.dgvOrdenesCarga.TabIndex = 0
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirListadoDeSCCToolStripMenuItem1, Me.ImportarCargaDeEmergenciaToolStripMenuItem, Me.PriorizarLasOrdenesDeCargaToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(234, 70)
        '
        'ImprimirListadoDeSCCToolStripMenuItem1
        '
        Me.ImprimirListadoDeSCCToolStripMenuItem1.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.imprimir_16
        Me.ImprimirListadoDeSCCToolStripMenuItem1.Name = "ImprimirListadoDeSCCToolStripMenuItem1"
        Me.ImprimirListadoDeSCCToolStripMenuItem1.Size = New System.Drawing.Size(233, 22)
        Me.ImprimirListadoDeSCCToolStripMenuItem1.Text = "Imprimir listado de SCC"
        '
        'ImportarCargaDeEmergenciaToolStripMenuItem
        '
        Me.ImportarCargaDeEmergenciaToolStripMenuItem.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.package_add
        Me.ImportarCargaDeEmergenciaToolStripMenuItem.Name = "ImportarCargaDeEmergenciaToolStripMenuItem"
        Me.ImportarCargaDeEmergenciaToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.ImportarCargaDeEmergenciaToolStripMenuItem.Text = "Importar carga de emergencia"
        '
        'PriorizarLasOrdenesDeCargaToolStripMenuItem
        '
        Me.PriorizarLasOrdenesDeCargaToolStripMenuItem.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.emblem_special
        Me.PriorizarLasOrdenesDeCargaToolStripMenuItem.Name = "PriorizarLasOrdenesDeCargaToolStripMenuItem"
        Me.PriorizarLasOrdenesDeCargaToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.PriorizarLasOrdenesDeCargaToolStripMenuItem.Text = "Priorizar las ordenes de carga"
        '
        'TabControl2
        '
        Me.TabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.HotTrack = True
        Me.TabControl2.ImageList = Me.ImageList1
        Me.TabControl2.Location = New System.Drawing.Point(14, 0)
        Me.TabControl2.Multiline = True
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1014, 682)
        Me.TabControl2.TabIndex = 72
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefrescar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRefrescar.FlatAppearance.BorderSize = 0
        Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescar.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.view_refresh_4
        Me.btnRefrescar.Location = New System.Drawing.Point(0, 19)
        Me.btnRefrescar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(14, 19)
        Me.btnRefrescar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnRefrescar, "Recargar las sugerencias de carga")
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'PanBtn
        '
        Me.PanBtn.Controls.Add(Me.PanCbtn)
        Me.PanBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanBtn.Location = New System.Drawing.Point(0, 0)
        Me.PanBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.PanBtn.Name = "PanBtn"
        Me.PanBtn.Size = New System.Drawing.Size(14, 682)
        Me.PanBtn.TabIndex = 75
        '
        'PanCbtn
        '
        Me.PanCbtn.Controls.Add(Me.btnDown)
        Me.PanCbtn.Controls.Add(Me.btnRefrescar)
        Me.PanCbtn.Controls.Add(Me.btnup)
        Me.PanCbtn.Location = New System.Drawing.Point(0, 280)
        Me.PanCbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.PanCbtn.Name = "PanCbtn"
        Me.PanCbtn.Size = New System.Drawing.Size(14, 58)
        Me.PanCbtn.TabIndex = 2
        '
        'btnDown
        '
        Me.btnDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDown.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDown.FlatAppearance.BorderSize = 0
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.arrow_down_16
        Me.btnDown.Location = New System.Drawing.Point(0, 38)
        Me.btnDown.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(14, 19)
        Me.btnDown.TabIndex = 1
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnup
        '
        Me.btnup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnup.FlatAppearance.BorderSize = 0
        Me.btnup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnup.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.arrow_up_16
        Me.btnup.Location = New System.Drawing.Point(0, 0)
        Me.btnup.Margin = New System.Windows.Forms.Padding(2)
        Me.btnup.Name = "btnup"
        Me.btnup.Size = New System.Drawing.Size(14, 19)
        Me.btnup.TabIndex = 0
        Me.btnup.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300000
        '
        'EscaneoSCC1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1028, 682)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.PanBtn)
        Me.DoubleBuffered = True
        Me.Name = "EscaneoSCC1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EscaneoSCC"
        Me.TabPage4.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvOrdenesCarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.PanBtn.ResumeLayout(False)
        Me.PanCbtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents TextBox1 As System.Windows.Forms.TextBox
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents TextBox2 As System.Windows.Forms.TextBox
    Private WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Private WithEvents ListView1 As System.Windows.Forms.ListView
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents Button3 As System.Windows.Forms.Button
    Private WithEvents TabPage4 As System.Windows.Forms.TabPage
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents dgvOrdenesCarga As System.Windows.Forms.DataGridView
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents dgvPedidos As System.Windows.Forms.DataGridView
    Private WithEvents TabControl2 As System.Windows.Forms.TabControl
    Private WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Private WithEvents ImprimirListadoDeSCCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents PrintGrilla As System.Drawing.Printing.PrintDocument
    Private WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Private WithEvents ImprimirListadoDeSCCToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents ImageList1 As System.Windows.Forms.ImageList
    Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents DarPrioridadAltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ImportarCargaDeEmergenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents PriorizarLasOrdenesDeCargaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents PriorizarPedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents PanBtn As System.Windows.Forms.Panel
    Private WithEvents PanCbtn As System.Windows.Forms.Panel
    Private WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents btnRefrescar As System.Windows.Forms.Button
    Private WithEvents btnDown As System.Windows.Forms.Button
    Private WithEvents btnup As System.Windows.Forms.Button
End Class
