<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlmacenEntradasSalidas
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
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgvEntradasTotales = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbpEntradasHoy = New System.Windows.Forms.TabPage()
        Me.panEntradas = New System.Windows.Forms.Panel()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkSalida = New System.Windows.Forms.CheckBox()
        Me.txtPesoPalet = New System.Windows.Forms.TextBox()
        Me.txtObsCarga = New System.Windows.Forms.TextBox()
        Me.txtPaletsTotales = New System.Windows.Forms.TextBox()
        Me.txtPaletsPorArticulo = New System.Windows.Forms.TextBox()
        Me.txtSCC = New System.Windows.Forms.TextBox()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.txtCajas = New System.Windows.Forms.TextBox()
        Me.txtObsEnvasado = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtSCCEscaneado = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpSalidasHoy = New System.Windows.Forms.TabPage()
        Me.panSalidas = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvEntradasTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tbpEntradasHoy.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbpSalidasHoy.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1164, 583)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "TOTALES"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 35)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1158, 524)
        Me.Panel3.TabIndex = 74
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgvEntradasTotales)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(572, 524)
        Me.Panel5.TabIndex = 73
        '
        'dgvEntradasTotales
        '
        Me.dgvEntradasTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEntradasTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEntradasTotales.Location = New System.Drawing.Point(0, 0)
        Me.dgvEntradasTotales.Name = "dgvEntradasTotales"
        Me.dgvEntradasTotales.RowHeadersVisible = False
        Me.dgvEntradasTotales.RowTemplate.Height = 24
        Me.dgvEntradasTotales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEntradasTotales.Size = New System.Drawing.Size(572, 524)
        Me.dgvEntradasTotales.TabIndex = 71
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(572, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(586, 524)
        Me.Panel4.TabIndex = 72
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 559)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1158, 21)
        Me.Panel2.TabIndex = 73
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1158, 32)
        Me.Panel1.TabIndex = 72
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.CausesValidation = False
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(138, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 24)
        Me.Label16.TabIndex = 70
        Me.Label16.Text = "Entradas"
        '
        'tbpEntradasHoy
        '
        Me.tbpEntradasHoy.Controls.Add(Me.panEntradas)
        Me.tbpEntradasHoy.Location = New System.Drawing.Point(4, 25)
        Me.tbpEntradasHoy.Name = "tbpEntradasHoy"
        Me.tbpEntradasHoy.Size = New System.Drawing.Size(1164, 583)
        Me.tbpEntradasHoy.TabIndex = 4
        Me.tbpEntradasHoy.Text = "Entradas de hoy"
        Me.tbpEntradasHoy.UseVisualStyleBackColor = True
        '
        'panEntradas
        '
        Me.panEntradas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panEntradas.Location = New System.Drawing.Point(0, 0)
        Me.panEntradas.Name = "panEntradas"
        Me.panEntradas.Size = New System.Drawing.Size(1164, 583)
        Me.panEntradas.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.CausesValidation = False
        Me.TabPage1.Controls.Add(Me.chkSalida)
        Me.TabPage1.Controls.Add(Me.txtPesoPalet)
        Me.TabPage1.Controls.Add(Me.txtObsCarga)
        Me.TabPage1.Controls.Add(Me.txtPaletsTotales)
        Me.TabPage1.Controls.Add(Me.txtPaletsPorArticulo)
        Me.TabPage1.Controls.Add(Me.txtSCC)
        Me.TabPage1.Controls.Add(Me.txtLote)
        Me.TabPage1.Controls.Add(Me.txtCajas)
        Me.TabPage1.Controls.Add(Me.txtObsEnvasado)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.btnSalir)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.btnOK)
        Me.TabPage1.Controls.Add(Me.btnBorrar)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtDescripcion)
        Me.TabPage1.Controls.Add(Me.txtSCCEscaneado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1164, 583)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Escanear"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkSalida
        '
        Me.chkSalida.AutoSize = True
        Me.chkSalida.BackColor = System.Drawing.Color.Transparent
        Me.chkSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSalida.ForeColor = System.Drawing.Color.Black
        Me.chkSalida.Location = New System.Drawing.Point(543, 545)
        Me.chkSalida.Name = "chkSalida"
        Me.chkSalida.Size = New System.Drawing.Size(454, 41)
        Me.chkSalida.TabIndex = 3
        Me.chkSalida.Text = "A envasado para completar"
        Me.chkSalida.UseVisualStyleBackColor = False
        '
        'txtPesoPalet
        '
        Me.txtPesoPalet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesoPalet.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoPalet.Location = New System.Drawing.Point(8, 389)
        Me.txtPesoPalet.Name = "txtPesoPalet"
        Me.txtPesoPalet.Size = New System.Drawing.Size(142, 46)
        Me.txtPesoPalet.TabIndex = 80
        Me.txtPesoPalet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtObsCarga
        '
        Me.txtObsCarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsCarga.Location = New System.Drawing.Point(157, 514)
        Me.txtObsCarga.Name = "txtObsCarga"
        Me.txtObsCarga.Size = New System.Drawing.Size(840, 29)
        Me.txtObsCarga.TabIndex = 75
        '
        'txtPaletsTotales
        '
        Me.txtPaletsTotales.BackColor = System.Drawing.SystemColors.Control
        Me.txtPaletsTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaletsTotales.Enabled = False
        Me.txtPaletsTotales.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaletsTotales.Location = New System.Drawing.Point(1049, 35)
        Me.txtPaletsTotales.Name = "txtPaletsTotales"
        Me.txtPaletsTotales.Size = New System.Drawing.Size(104, 85)
        Me.txtPaletsTotales.TabIndex = 74
        Me.txtPaletsTotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPaletsPorArticulo
        '
        Me.txtPaletsPorArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaletsPorArticulo.Enabled = False
        Me.txtPaletsPorArticulo.Font = New System.Drawing.Font("Tahoma", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaletsPorArticulo.Location = New System.Drawing.Point(8, 259)
        Me.txtPaletsPorArticulo.Name = "txtPaletsPorArticulo"
        Me.txtPaletsPorArticulo.Size = New System.Drawing.Size(142, 123)
        Me.txtPaletsPorArticulo.TabIndex = 72
        Me.txtPaletsPorArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSCC
        '
        Me.txtSCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSCC.Enabled = False
        Me.txtSCC.Font = New System.Drawing.Font("Tahoma", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSCC.Location = New System.Drawing.Point(8, 130)
        Me.txtSCC.Name = "txtSCC"
        Me.txtSCC.Size = New System.Drawing.Size(378, 123)
        Me.txtSCC.TabIndex = 3
        Me.txtSCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLote
        '
        Me.txtLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLote.Font = New System.Drawing.Font("Tahoma", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLote.Location = New System.Drawing.Point(392, 130)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(369, 123)
        Me.txtLote.TabIndex = 1
        Me.txtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCajas
        '
        Me.txtCajas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCajas.Enabled = False
        Me.txtCajas.Font = New System.Drawing.Font("Tahoma", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajas.Location = New System.Drawing.Point(767, 130)
        Me.txtCajas.Name = "txtCajas"
        Me.txtCajas.Size = New System.Drawing.Size(231, 123)
        Me.txtCajas.TabIndex = 5
        Me.txtCajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtObsEnvasado
        '
        Me.txtObsEnvasado.BackColor = System.Drawing.SystemColors.Menu
        Me.txtObsEnvasado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsEnvasado.Location = New System.Drawing.Point(157, 479)
        Me.txtObsEnvasado.Name = "txtObsEnvasado"
        Me.txtObsEnvasado.Size = New System.Drawing.Size(840, 29)
        Me.txtObsEnvasado.TabIndex = 58
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(846, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(307, 20)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Palets recepcionados incuyendo este"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.dialog_cancel_3
        Me.btnSalir.Location = New System.Drawing.Point(1003, 438)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 106)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(54, 483)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 24)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Envasado"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 514)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 24)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Almacen"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(165, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 24)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "SCC"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.dialog_ok_3
        Me.btnOK.Location = New System.Drawing.Point(1003, 321)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(150, 101)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.White
        Me.btnBorrar.CausesValidation = False
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = Global.La_Andaluza_Almacen.My.Resources.Resources.edit_clear_locationbar_ltr
        Me.btnBorrar.Location = New System.Drawing.Point(10, 35)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(66, 65)
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 448)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 24)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Observaciones:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(554, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 24)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Lote"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(429, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SCC escaneado"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(843, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 24)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Cajas"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Font = New System.Drawing.Font("Tahoma", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(157, 259)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(840, 213)
        Me.txtDescripcion.TabIndex = 6
        Me.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSCCEscaneado
        '
        Me.txtSCCEscaneado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSCCEscaneado.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSCCEscaneado.Location = New System.Drawing.Point(82, 35)
        Me.txtSCCEscaneado.Name = "txtSCCEscaneado"
        Me.txtSCCEscaneado.Size = New System.Drawing.Size(916, 65)
        Me.txtSCCEscaneado.TabIndex = 1
        Me.txtSCCEscaneado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.CausesValidation = False
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.tbpSalidasHoy)
        Me.TabControl1.Controls.Add(Me.tbpEntradasHoy)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1172, 612)
        Me.TabControl1.TabIndex = 0
        '
        'tbpSalidasHoy
        '
        Me.tbpSalidasHoy.Controls.Add(Me.panSalidas)
        Me.tbpSalidasHoy.Location = New System.Drawing.Point(4, 25)
        Me.tbpSalidasHoy.Name = "tbpSalidasHoy"
        Me.tbpSalidasHoy.Size = New System.Drawing.Size(1164, 583)
        Me.tbpSalidasHoy.TabIndex = 5
        Me.tbpSalidasHoy.Text = "Salidas de hoy"
        Me.tbpSalidasHoy.UseVisualStyleBackColor = True
        '
        'panSalidas
        '
        Me.panSalidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panSalidas.Location = New System.Drawing.Point(0, 0)
        Me.panSalidas.Name = "panSalidas"
        Me.panSalidas.Size = New System.Drawing.Size(1164, 583)
        Me.panSalidas.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'AlmacenEntradasSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 612)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "AlmacenEntradasSalidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Entradas"
        Me.TabPage3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvEntradasTotales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tbpEntradasHoy.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tbpSalidasHoy.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents TabPage3 As System.Windows.Forms.TabPage
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents tbpEntradasHoy As System.Windows.Forms.TabPage
    Private WithEvents panEntradas As System.Windows.Forms.Panel
    Private WithEvents TabPage1 As System.Windows.Forms.TabPage
    Private WithEvents txtPesoPalet As System.Windows.Forms.TextBox
    Private WithEvents txtObsCarga As System.Windows.Forms.TextBox
    Private WithEvents txtPaletsTotales As System.Windows.Forms.TextBox
    Private WithEvents txtPaletsPorArticulo As System.Windows.Forms.TextBox
    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents txtSCCEscaneado As System.Windows.Forms.TextBox
    Private WithEvents txtSCC As System.Windows.Forms.TextBox
    Private WithEvents txtLote As System.Windows.Forms.TextBox
    Private WithEvents txtCajas As System.Windows.Forms.TextBox
    Private WithEvents txtObsEnvasado As System.Windows.Forms.TextBox
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents btnSalir As System.Windows.Forms.Button
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents btnOK As System.Windows.Forms.Button
    Private WithEvents btnBorrar As System.Windows.Forms.Button
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents chkSalida As System.Windows.Forms.CheckBox
    Private WithEvents tbpSalidasHoy As System.Windows.Forms.TabPage
    Private WithEvents panSalidas As System.Windows.Forms.Panel
    Private WithEvents dgvEntradasTotales As System.Windows.Forms.DataGridView
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents Panel5 As System.Windows.Forms.Panel
    Private WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents Panel1 As System.Windows.Forms.Panel
End Class
