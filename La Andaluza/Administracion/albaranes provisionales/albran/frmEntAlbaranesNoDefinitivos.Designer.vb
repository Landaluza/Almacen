<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntAlbaranesNoDefinitivos
    Inherits DetailedSimpleForm

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
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtResponsableCargaID = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtReserva1 = New System.Windows.Forms.TextBox()
        Me.txtReserva2 = New System.Windows.Forms.TextBox()
        Me.txtReserva3 = New System.Windows.Forms.TextBox()
        Me.chbe1 = New System.Windows.Forms.CheckBox()
        Me.chbe2 = New System.Windows.Forms.CheckBox()
        Me.chbe3 = New System.Windows.Forms.CheckBox()
        Me.chbe4 = New System.Windows.Forms.CheckBox()
        Me.chbe5 = New System.Windows.Forms.CheckBox()
        Me.chbe6 = New System.Windows.Forms.CheckBox()
        Me.chbh1 = New System.Windows.Forms.CheckBox()
        Me.chbm1 = New System.Windows.Forms.CheckBox()
        Me.chbm2 = New System.Windows.Forms.CheckBox()
        Me.chbc1 = New System.Windows.Forms.CheckBox()
        Me.chbc2 = New System.Windows.Forms.CheckBox()
        Me.txtObservacionControl = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label
        Me.lblFecha = New System.Windows.Forms.Label
        Me.lblResponsableCargaID = New System.Windows.Forms.Label
        Me.lblObservaciones = New System.Windows.Forms.Label
        Me.lblReserva1 = New System.Windows.Forms.Label
        Me.lblReserva2 = New System.Windows.Forms.Label
        Me.lblReserva3 = New System.Windows.Forms.Label
        Me.lble1 = New System.Windows.Forms.Label
        Me.lble2 = New System.Windows.Forms.Label
        Me.lble3 = New System.Windows.Forms.Label
        Me.lble4 = New System.Windows.Forms.Label
        Me.lble5 = New System.Windows.Forms.Label
        Me.lble6 = New System.Windows.Forms.Label
        Me.lblh1 = New System.Windows.Forms.Label
        Me.lblm1 = New System.Windows.Forms.Label
        Me.lblm2 = New System.Windows.Forms.Label
        Me.lblc1 = New System.Windows.Forms.Label
        Me.lblc2 = New System.Windows.Forms.Label
        Me.lblObservacionControl = New System.Windows.Forms.Label
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel
        Me.tlpMiddle.SuspendLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNumero
        '
        Me.txtNumero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Name = "txtNumero
        Me.txtNumero.TabIndex = 0
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumero.MaxLength = 9
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNumero.Size = New System.Drawing.Size(56,21)
        '
        'dtpFecha
        '
        Me.dtpFecha.Dock = System.Windows.Forms.DockStyle.None
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Name = "dtpFecha
        Me.dtpFecha.TabIndex = 1
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Size = New System.Drawing.Size(95,21)
        '
        'txtResponsableCargaID
        '
        Me.txtResponsableCargaID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtResponsableCargaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsableCargaID.Name = "txtResponsableCargaID
        Me.txtResponsableCargaID.TabIndex = 2
        Me.txtResponsableCargaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResponsableCargaID.Visible = False
        Me.txtResponsableCargaID.BackColor = System.Drawing.SystemColors.Window
        Me.txtResponsableCargaID.MaxLength = 9
        Me.txtResponsableCargaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtResponsableCargaID.Size = New System.Drawing.Size(56,21)
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Name = "txtObservaciones
        Me.txtObservaciones.TabIndex = 3
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Size = New System.Drawing.Size(280,42)
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        '
        'txtReserva1
        '
        Me.txtReserva1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReserva1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReserva1.Name = "txtReserva1
        Me.txtReserva1.TabIndex = 4
        Me.txtReserva1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReserva1.BackColor = System.Drawing.SystemColors.Window
        Me.txtReserva1.MaxLength = 50
        Me.txtReserva1.Size = New System.Drawing.Size(200,42)
        '
        'txtReserva2
        '
        Me.txtReserva2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReserva2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReserva2.Name = "txtReserva2
        Me.txtReserva2.TabIndex = 5
        Me.txtReserva2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReserva2.BackColor = System.Drawing.SystemColors.Window
        Me.txtReserva2.MaxLength = 50
        Me.txtReserva2.Size = New System.Drawing.Size(200,42)
        '
        'txtReserva3
        '
        Me.txtReserva3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReserva3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReserva3.Name = "txtReserva3
        Me.txtReserva3.TabIndex = 6
        Me.txtReserva3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReserva3.BackColor = System.Drawing.SystemColors.Window
        Me.txtReserva3.MaxLength = 50
        Me.txtReserva3.Size = New System.Drawing.Size(200,42)
        '
        'chbe1
        '
        Me.chbe1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbe1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbe1.Name = "chbe1
        Me.chbe1.TabIndex = 7
        Me.chbe1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbe1.BackColor = System.Drawing.SystemColors.Control
        Me.chbe1.UseVisualStyleBackColor = False
        Me.chbe1.Size = New System.Drawing.Size(16,21)
        '
        'chbe2
        '
        Me.chbe2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbe2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbe2.Name = "chbe2
        Me.chbe2.TabIndex = 8
        Me.chbe2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbe2.BackColor = System.Drawing.SystemColors.Control
        Me.chbe2.UseVisualStyleBackColor = False
        Me.chbe2.Size = New System.Drawing.Size(16,21)
        '
        'chbe3
        '
        Me.chbe3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbe3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbe3.Name = "chbe3
        Me.chbe3.TabIndex = 9
        Me.chbe3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbe3.BackColor = System.Drawing.SystemColors.Control
        Me.chbe3.UseVisualStyleBackColor = False
        Me.chbe3.Size = New System.Drawing.Size(16,21)
        '
        'chbe4
        '
        Me.chbe4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbe4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbe4.Name = "chbe4
        Me.chbe4.TabIndex = 10
        Me.chbe4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbe4.BackColor = System.Drawing.SystemColors.Control
        Me.chbe4.UseVisualStyleBackColor = False
        Me.chbe4.Size = New System.Drawing.Size(16,21)
        '
        'chbe5
        '
        Me.chbe5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbe5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbe5.Name = "chbe5
        Me.chbe5.TabIndex = 11
        Me.chbe5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbe5.BackColor = System.Drawing.SystemColors.Control
        Me.chbe5.UseVisualStyleBackColor = False
        Me.chbe5.Size = New System.Drawing.Size(16,21)
        '
        'chbe6
        '
        Me.chbe6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbe6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbe6.Name = "chbe6
        Me.chbe6.TabIndex = 12
        Me.chbe6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbe6.BackColor = System.Drawing.SystemColors.Control
        Me.chbe6.UseVisualStyleBackColor = False
        Me.chbe6.Size = New System.Drawing.Size(16,21)
        '
        'chbh1
        '
        Me.chbh1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbh1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbh1.Name = "chbh1
        Me.chbh1.TabIndex = 13
        Me.chbh1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbh1.BackColor = System.Drawing.SystemColors.Control
        Me.chbh1.UseVisualStyleBackColor = False
        Me.chbh1.Size = New System.Drawing.Size(16,21)
        '
        'chbm1
        '
        Me.chbm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbm1.Name = "chbm1
        Me.chbm1.TabIndex = 14
        Me.chbm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbm1.BackColor = System.Drawing.SystemColors.Control
        Me.chbm1.UseVisualStyleBackColor = False
        Me.chbm1.Size = New System.Drawing.Size(16,21)
        '
        'chbm2
        '
        Me.chbm2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbm2.Name = "chbm2
        Me.chbm2.TabIndex = 15
        Me.chbm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbm2.BackColor = System.Drawing.SystemColors.Control
        Me.chbm2.UseVisualStyleBackColor = False
        Me.chbm2.Size = New System.Drawing.Size(16,21)
        '
        'chbc1
        '
        Me.chbc1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc1.Name = "chbc1
        Me.chbc1.TabIndex = 16
        Me.chbc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc1.BackColor = System.Drawing.SystemColors.Control
        Me.chbc1.UseVisualStyleBackColor = False
        Me.chbc1.Size = New System.Drawing.Size(16,21)
        '
        'chbc2
        '
        Me.chbc2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc2.Name = "chbc2
        Me.chbc2.TabIndex = 17
        Me.chbc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc2.BackColor = System.Drawing.SystemColors.Control
        Me.chbc2.UseVisualStyleBackColor = False
        Me.chbc2.Size = New System.Drawing.Size(16,21)
        '
        'txtObservacionControl
        '
        Me.txtObservacionControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservacionControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionControl.Name = "txtObservacionControl
        Me.txtObservacionControl.TabIndex = 18
        Me.txtObservacionControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacionControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservacionControl.MaxLength = 500
        Me.txtObservacionControl.Size = New System.Drawing.Size(200,42)
        '
        'lblNumero
        '
        Me.lblNumero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNumero.Name = "lblNumero
        Me.lblNumero.Text = "Numero
        Me.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNumero.Size = New System.Drawing.Size(145,21)
        Me.lblNumero.Location = New System.Drawing.Point(20,40)
        '
        'lblFecha
        '
        Me.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFecha.Name = "lblFecha
        Me.lblFecha.Text = "Fecha
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFecha.Size = New System.Drawing.Size(145,21)
        Me.lblFecha.Location = New System.Drawing.Point(20,40)
        '
        'lblResponsableCargaID
        '
        Me.lblResponsableCargaID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblResponsableCargaID.Name = "lblResponsableCargaID
        Me.lblResponsableCargaID.Text = "Responsablecarga
        Me.lblResponsableCargaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblResponsableCargaID.Size = New System.Drawing.Size(145,21)
        Me.lblResponsableCargaID.Location = New System.Drawing.Point(20,40)
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservaciones.Name = "lblObservaciones
        Me.lblObservaciones.Text = "Observaciones
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblObservaciones.Size = New System.Drawing.Size(145,21)
        Me.lblObservaciones.Location = New System.Drawing.Point(20,40)
        '
        'lblReserva1
        '
        Me.lblReserva1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReserva1.Name = "lblReserva1
        Me.lblReserva1.Text = "Reserva1
        Me.lblReserva1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblReserva1.Size = New System.Drawing.Size(145,21)
        Me.lblReserva1.Location = New System.Drawing.Point(20,40)
        '
        'lblReserva2
        '
        Me.lblReserva2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReserva2.Name = "lblReserva2
        Me.lblReserva2.Text = "Reserva2
        Me.lblReserva2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblReserva2.Size = New System.Drawing.Size(145,21)
        Me.lblReserva2.Location = New System.Drawing.Point(20,40)
        '
        'lblReserva3
        '
        Me.lblReserva3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReserva3.Name = "lblReserva3
        Me.lblReserva3.Text = "Reserva3
        Me.lblReserva3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblReserva3.Size = New System.Drawing.Size(145,21)
        Me.lblReserva3.Location = New System.Drawing.Point(20,40)
        '
        'lble1
        '
        Me.lble1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lble1.Name = "lble1
        Me.lble1.Text = "E1
        Me.lble1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lble1.Size = New System.Drawing.Size(145,21)
        Me.lble1.Location = New System.Drawing.Point(20,40)
        '
        'lble2
        '
        Me.lble2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lble2.Name = "lble2
        Me.lble2.Text = "E2
        Me.lble2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lble2.Size = New System.Drawing.Size(145,21)
        Me.lble2.Location = New System.Drawing.Point(20,40)
        '
        'lble3
        '
        Me.lble3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lble3.Name = "lble3
        Me.lble3.Text = "E3
        Me.lble3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lble3.Size = New System.Drawing.Size(145,21)
        Me.lble3.Location = New System.Drawing.Point(20,40)
        '
        'lble4
        '
        Me.lble4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lble4.Name = "lble4
        Me.lble4.Text = "E4
        Me.lble4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lble4.Size = New System.Drawing.Size(145,21)
        Me.lble4.Location = New System.Drawing.Point(20,40)
        '
        'lble5
        '
        Me.lble5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lble5.Name = "lble5
        Me.lble5.Text = "E5
        Me.lble5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lble5.Size = New System.Drawing.Size(145,21)
        Me.lble5.Location = New System.Drawing.Point(20,40)
        '
        'lble6
        '
        Me.lble6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lble6.Name = "lble6
        Me.lble6.Text = "E6
        Me.lble6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lble6.Size = New System.Drawing.Size(145,21)
        Me.lble6.Location = New System.Drawing.Point(20,40)
        '
        'lblh1
        '
        Me.lblh1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblh1.Name = "lblh1
        Me.lblh1.Text = "H1
        Me.lblh1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblh1.Size = New System.Drawing.Size(145,21)
        Me.lblh1.Location = New System.Drawing.Point(20,40)
        '
        'lblm1
        '
        Me.lblm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblm1.Name = "lblm1
        Me.lblm1.Text = "M1
        Me.lblm1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblm1.Size = New System.Drawing.Size(145,21)
        Me.lblm1.Location = New System.Drawing.Point(20,40)
        '
        'lblm2
        '
        Me.lblm2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblm2.Name = "lblm2
        Me.lblm2.Text = "M2
        Me.lblm2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblm2.Size = New System.Drawing.Size(145,21)
        Me.lblm2.Location = New System.Drawing.Point(20,40)
        '
        'lblc1
        '
        Me.lblc1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblc1.Name = "lblc1
        Me.lblc1.Text = "C1
        Me.lblc1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblc1.Size = New System.Drawing.Size(145,21)
        Me.lblc1.Location = New System.Drawing.Point(20,40)
        '
        'lblc2
        '
        Me.lblc2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblc2.Name = "lblc2
        Me.lblc2.Text = "C2
        Me.lblc2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblc2.Size = New System.Drawing.Size(145,21)
        Me.lblc2.Location = New System.Drawing.Point(20,40)
        '
        'lblObservacionControl
        '
        Me.lblObservacionControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservacionControl.Name = "lblObservacionControl
        Me.lblObservacionControl.Text = "Observacioncontrol
        Me.lblObservacionControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblObservacionControl.Size = New System.Drawing.Size(145,21)
        Me.lblObservacionControl.Location = New System.Drawing.Point(20,40)
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Controls.Add(Me.lblNumero, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtNumero, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblResponsableCargaID, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtResponsableCargaID, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblReserva1, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtReserva1, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblReserva2, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtReserva2, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblReserva3, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.txtReserva3, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.lble1, 1, 7)
        Me.tlpMiddle.Controls.Add(Me.chbe1, 2, 7)
        Me.tlpMiddle.Controls.Add(Me.lble2, 1, 8)
        Me.tlpMiddle.Controls.Add(Me.chbe2, 2, 8)
        Me.tlpMiddle.Controls.Add(Me.lble3, 1, 9)
        Me.tlpMiddle.Controls.Add(Me.chbe3, 2, 9)
        Me.tlpMiddle.Controls.Add(Me.lble4, 1, 10)
        Me.tlpMiddle.Controls.Add(Me.chbe4, 2, 10)
        Me.tlpMiddle.Controls.Add(Me.lble5, 1, 11)
        Me.tlpMiddle.Controls.Add(Me.chbe5, 2, 11)
        Me.tlpMiddle.Controls.Add(Me.lble6, 1, 12)
        Me.tlpMiddle.Controls.Add(Me.chbe6, 2, 12)
        Me.tlpMiddle.Controls.Add(Me.lblh1, 1, 13)
        Me.tlpMiddle.Controls.Add(Me.chbh1, 2, 13)
        Me.tlpMiddle.Controls.Add(Me.lblm1, 1, 14)
        Me.tlpMiddle.Controls.Add(Me.chbm1, 2, 14)
        Me.tlpMiddle.Controls.Add(Me.lblm2, 1, 15)
        Me.tlpMiddle.Controls.Add(Me.chbm2, 2, 15)
        Me.tlpMiddle.Controls.Add(Me.lblc1, 1, 16)
        Me.tlpMiddle.Controls.Add(Me.chbc1, 2, 16)
        Me.tlpMiddle.Controls.Add(Me.lblc2, 1, 17)
        Me.tlpMiddle.Controls.Add(Me.chbc2, 2, 17)
        Me.tlpMiddle.Controls.Add(Me.lblObservacionControl, 1, 18)
        Me.tlpMiddle.Controls.Add(Me.txtObservacionControl, 2, 18)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 20
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(504, 513)
        '
        '
        'frmEntAlbaranesNoDefinitivos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Controls.Add(Me.tlpMiddle)
        Me.ClientSize = New System.Drawing.Size(504, 593)
        Me.MinimumSize = New System.Drawing.Size(504, 593)
        Me.Name = "frmEntAlbaranesNoDefinitivos
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AlbaranesNoDefinitivos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.None
        Me.tlpMiddle.Autosize = True
        Me.Size = new Size(475,11799)
        Me.tlpMiddle.PerformLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

       End Sub

    Private WithEvents txtNumero As System.Windows.Forms.TextBox
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtResponsableCargaID As System.Windows.Forms.TextBox
    Private WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Private WithEvents txtReserva1 As System.Windows.Forms.TextBox
    Private WithEvents txtReserva2 As System.Windows.Forms.TextBox
    Private WithEvents txtReserva3 As System.Windows.Forms.TextBox
    Private WithEvents chbe1 As System.Windows.Forms.CheckBox
    Private WithEvents chbe2 As System.Windows.Forms.CheckBox
    Private WithEvents chbe3 As System.Windows.Forms.CheckBox
    Private WithEvents chbe4 As System.Windows.Forms.CheckBox
    Private WithEvents chbe5 As System.Windows.Forms.CheckBox
    Private WithEvents chbe6 As System.Windows.Forms.CheckBox
    Private WithEvents chbh1 As System.Windows.Forms.CheckBox
    Private WithEvents chbm1 As System.Windows.Forms.CheckBox
    Private WithEvents chbm2 As System.Windows.Forms.CheckBox
    Private WithEvents chbc1 As System.Windows.Forms.CheckBox
    Private WithEvents chbc2 As System.Windows.Forms.CheckBox
    Private WithEvents txtObservacionControl As System.Windows.Forms.TextBox
    Private WithEvents lblNumero As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblResponsableCargaID As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents lblReserva1 As System.Windows.Forms.Label
    Private WithEvents lblReserva2 As System.Windows.Forms.Label
    Private WithEvents lblReserva3 As System.Windows.Forms.Label
    Private WithEvents lble1 As System.Windows.Forms.Label
    Private WithEvents lble2 As System.Windows.Forms.Label
    Private WithEvents lble3 As System.Windows.Forms.Label
    Private WithEvents lble4 As System.Windows.Forms.Label
    Private WithEvents lble5 As System.Windows.Forms.Label
    Private WithEvents lble6 As System.Windows.Forms.Label
    Private WithEvents lblh1 As System.Windows.Forms.Label
    Private WithEvents lblm1 As System.Windows.Forms.Label
    Private WithEvents lblm2 As System.Windows.Forms.Label
    Private WithEvents lblc1 As System.Windows.Forms.Label
    Private WithEvents lblc2 As System.Windows.Forms.Label
    Private WithEvents lblObservacionControl As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
