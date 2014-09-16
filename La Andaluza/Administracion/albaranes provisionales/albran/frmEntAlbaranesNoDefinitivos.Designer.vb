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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntAlbaranesNoDefinitivos))
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
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblResponsableCargaID = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblReserva1 = New System.Windows.Forms.Label()
        Me.lblReserva2 = New System.Windows.Forms.Label()
        Me.lblReserva3 = New System.Windows.Forms.Label()
        Me.lble1 = New System.Windows.Forms.Label()
        Me.lble2 = New System.Windows.Forms.Label()
        Me.lble3 = New System.Windows.Forms.Label()
        Me.lble4 = New System.Windows.Forms.Label()
        Me.lble5 = New System.Windows.Forms.Label()
        Me.lble6 = New System.Windows.Forms.Label()
        Me.lblh1 = New System.Windows.Forms.Label()
        Me.lblm1 = New System.Windows.Forms.Label()
        Me.lblm2 = New System.Windows.Forms.Label()
        Me.lblc1 = New System.Windows.Forms.Label()
        Me.lblc2 = New System.Windows.Forms.Label()
        Me.lblObservacionControl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panLineas = New System.Windows.Forms.Panel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Enabled = False
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(185, 48)
        Me.txtNumero.MaxLength = 9
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(95, 21)
        Me.txtNumero.TabIndex = 0
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(185, 75)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(95, 21)
        Me.dtpFecha.TabIndex = 1
        '
        'txtResponsableCargaID
        '
        Me.txtResponsableCargaID.BackColor = System.Drawing.SystemColors.Window
        Me.txtResponsableCargaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResponsableCargaID.Enabled = False
        Me.txtResponsableCargaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsableCargaID.Location = New System.Drawing.Point(185, 102)
        Me.txtResponsableCargaID.MaxLength = 9
        Me.txtResponsableCargaID.Name = "txtResponsableCargaID"
        Me.txtResponsableCargaID.Size = New System.Drawing.Size(280, 21)
        Me.txtResponsableCargaID.TabIndex = 2
        Me.txtResponsableCargaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtResponsableCargaID.Visible = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Enabled = False
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(185, 129)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(280, 21)
        Me.txtObservaciones.TabIndex = 3
        '
        'txtReserva1
        '
        Me.txtReserva1.BackColor = System.Drawing.SystemColors.Window
        Me.txtReserva1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReserva1.Enabled = False
        Me.txtReserva1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReserva1.Location = New System.Drawing.Point(185, 156)
        Me.txtReserva1.MaxLength = 50
        Me.txtReserva1.Name = "txtReserva1"
        Me.txtReserva1.Size = New System.Drawing.Size(280, 21)
        Me.txtReserva1.TabIndex = 4
        '
        'txtReserva2
        '
        Me.txtReserva2.BackColor = System.Drawing.SystemColors.Window
        Me.txtReserva2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReserva2.Enabled = False
        Me.txtReserva2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReserva2.Location = New System.Drawing.Point(185, 183)
        Me.txtReserva2.MaxLength = 50
        Me.txtReserva2.Name = "txtReserva2"
        Me.txtReserva2.Size = New System.Drawing.Size(280, 21)
        Me.txtReserva2.TabIndex = 5
        '
        'txtReserva3
        '
        Me.txtReserva3.BackColor = System.Drawing.SystemColors.Window
        Me.txtReserva3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReserva3.Enabled = False
        Me.txtReserva3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReserva3.Location = New System.Drawing.Point(185, 210)
        Me.txtReserva3.MaxLength = 50
        Me.txtReserva3.Name = "txtReserva3"
        Me.txtReserva3.Size = New System.Drawing.Size(280, 21)
        Me.txtReserva3.TabIndex = 6
        '
        'chbe1
        '
        Me.chbe1.BackColor = System.Drawing.SystemColors.Control
        Me.chbe1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbe1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbe1.Location = New System.Drawing.Point(185, 237)
        Me.chbe1.Name = "chbe1"
        Me.chbe1.Size = New System.Drawing.Size(16, 21)
        Me.chbe1.TabIndex = 7
        Me.chbe1.UseVisualStyleBackColor = False
        '
        'chbe2
        '
        Me.chbe2.BackColor = System.Drawing.SystemColors.Control
        Me.chbe2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbe2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbe2.Location = New System.Drawing.Point(185, 264)
        Me.chbe2.Name = "chbe2"
        Me.chbe2.Size = New System.Drawing.Size(16, 21)
        Me.chbe2.TabIndex = 8
        Me.chbe2.UseVisualStyleBackColor = False
        '
        'chbe3
        '
        Me.chbe3.BackColor = System.Drawing.SystemColors.Control
        Me.chbe3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbe3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbe3.Location = New System.Drawing.Point(185, 291)
        Me.chbe3.Name = "chbe3"
        Me.chbe3.Size = New System.Drawing.Size(16, 21)
        Me.chbe3.TabIndex = 9
        Me.chbe3.UseVisualStyleBackColor = False
        '
        'chbe4
        '
        Me.chbe4.BackColor = System.Drawing.SystemColors.Control
        Me.chbe4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbe4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbe4.Location = New System.Drawing.Point(185, 318)
        Me.chbe4.Name = "chbe4"
        Me.chbe4.Size = New System.Drawing.Size(16, 21)
        Me.chbe4.TabIndex = 10
        Me.chbe4.UseVisualStyleBackColor = False
        '
        'chbe5
        '
        Me.chbe5.BackColor = System.Drawing.SystemColors.Control
        Me.chbe5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbe5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbe5.Location = New System.Drawing.Point(185, 345)
        Me.chbe5.Name = "chbe5"
        Me.chbe5.Size = New System.Drawing.Size(16, 21)
        Me.chbe5.TabIndex = 11
        Me.chbe5.UseVisualStyleBackColor = False
        '
        'chbe6
        '
        Me.chbe6.BackColor = System.Drawing.SystemColors.Control
        Me.chbe6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbe6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbe6.Location = New System.Drawing.Point(185, 372)
        Me.chbe6.Name = "chbe6"
        Me.chbe6.Size = New System.Drawing.Size(16, 21)
        Me.chbe6.TabIndex = 12
        Me.chbe6.UseVisualStyleBackColor = False
        '
        'chbh1
        '
        Me.chbh1.BackColor = System.Drawing.SystemColors.Control
        Me.chbh1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbh1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbh1.Location = New System.Drawing.Point(454, 241)
        Me.chbh1.Name = "chbh1"
        Me.chbh1.Size = New System.Drawing.Size(16, 21)
        Me.chbh1.TabIndex = 13
        Me.chbh1.UseVisualStyleBackColor = False
        '
        'chbm1
        '
        Me.chbm1.BackColor = System.Drawing.SystemColors.Control
        Me.chbm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbm1.Location = New System.Drawing.Point(454, 268)
        Me.chbm1.Name = "chbm1"
        Me.chbm1.Size = New System.Drawing.Size(16, 21)
        Me.chbm1.TabIndex = 14
        Me.chbm1.UseVisualStyleBackColor = False
        '
        'chbm2
        '
        Me.chbm2.BackColor = System.Drawing.SystemColors.Control
        Me.chbm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbm2.Location = New System.Drawing.Point(454, 295)
        Me.chbm2.Name = "chbm2"
        Me.chbm2.Size = New System.Drawing.Size(16, 21)
        Me.chbm2.TabIndex = 15
        Me.chbm2.UseVisualStyleBackColor = False
        '
        'chbc1
        '
        Me.chbc1.BackColor = System.Drawing.SystemColors.Control
        Me.chbc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc1.Location = New System.Drawing.Point(454, 322)
        Me.chbc1.Name = "chbc1"
        Me.chbc1.Size = New System.Drawing.Size(16, 21)
        Me.chbc1.TabIndex = 16
        Me.chbc1.UseVisualStyleBackColor = False
        '
        'chbc2
        '
        Me.chbc2.BackColor = System.Drawing.SystemColors.Control
        Me.chbc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc2.Location = New System.Drawing.Point(454, 349)
        Me.chbc2.Name = "chbc2"
        Me.chbc2.Size = New System.Drawing.Size(16, 21)
        Me.chbc2.TabIndex = 17
        Me.chbc2.UseVisualStyleBackColor = False
        '
        'txtObservacionControl
        '
        Me.txtObservacionControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservacionControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacionControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionControl.Location = New System.Drawing.Point(185, 399)
        Me.txtObservacionControl.MaxLength = 500
        Me.txtObservacionControl.Multiline = True
        Me.txtObservacionControl.Name = "txtObservacionControl"
        Me.txtObservacionControl.Size = New System.Drawing.Size(285, 92)
        Me.txtObservacionControl.TabIndex = 18
        '
        'lblNumero
        '
        Me.lblNumero.Location = New System.Drawing.Point(34, 45)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(145, 21)
        Me.lblNumero.TabIndex = 0
        Me.lblNumero.Text = "Numero"
        Me.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(34, 72)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(145, 21)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblResponsableCargaID
        '
        Me.lblResponsableCargaID.Location = New System.Drawing.Point(34, 99)
        Me.lblResponsableCargaID.Name = "lblResponsableCargaID"
        Me.lblResponsableCargaID.Size = New System.Drawing.Size(145, 21)
        Me.lblResponsableCargaID.TabIndex = 2
        Me.lblResponsableCargaID.Text = "Responsablecarga"
        Me.lblResponsableCargaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(34, 126)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(145, 21)
        Me.lblObservaciones.TabIndex = 3
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReserva1
        '
        Me.lblReserva1.Location = New System.Drawing.Point(34, 153)
        Me.lblReserva1.Name = "lblReserva1"
        Me.lblReserva1.Size = New System.Drawing.Size(145, 21)
        Me.lblReserva1.TabIndex = 4
        Me.lblReserva1.Text = "Reserva1"
        Me.lblReserva1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReserva2
        '
        Me.lblReserva2.Location = New System.Drawing.Point(34, 180)
        Me.lblReserva2.Name = "lblReserva2"
        Me.lblReserva2.Size = New System.Drawing.Size(145, 21)
        Me.lblReserva2.TabIndex = 5
        Me.lblReserva2.Text = "Reserva2"
        Me.lblReserva2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReserva3
        '
        Me.lblReserva3.Location = New System.Drawing.Point(34, 207)
        Me.lblReserva3.Name = "lblReserva3"
        Me.lblReserva3.Size = New System.Drawing.Size(145, 21)
        Me.lblReserva3.TabIndex = 6
        Me.lblReserva3.Text = "Reserva3"
        Me.lblReserva3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lble1
        '
        Me.lble1.Location = New System.Drawing.Point(34, 234)
        Me.lble1.Name = "lble1"
        Me.lble1.Size = New System.Drawing.Size(145, 21)
        Me.lble1.TabIndex = 7
        Me.lble1.Text = "E1"
        Me.lble1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lble2
        '
        Me.lble2.Location = New System.Drawing.Point(34, 261)
        Me.lble2.Name = "lble2"
        Me.lble2.Size = New System.Drawing.Size(145, 21)
        Me.lble2.TabIndex = 8
        Me.lble2.Text = "E2"
        Me.lble2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lble3
        '
        Me.lble3.Location = New System.Drawing.Point(34, 288)
        Me.lble3.Name = "lble3"
        Me.lble3.Size = New System.Drawing.Size(145, 21)
        Me.lble3.TabIndex = 9
        Me.lble3.Text = "E3"
        Me.lble3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lble4
        '
        Me.lble4.Location = New System.Drawing.Point(34, 315)
        Me.lble4.Name = "lble4"
        Me.lble4.Size = New System.Drawing.Size(145, 21)
        Me.lble4.TabIndex = 10
        Me.lble4.Text = "E4"
        Me.lble4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lble5
        '
        Me.lble5.Location = New System.Drawing.Point(34, 342)
        Me.lble5.Name = "lble5"
        Me.lble5.Size = New System.Drawing.Size(145, 21)
        Me.lble5.TabIndex = 11
        Me.lble5.Text = "E5"
        Me.lble5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lble6
        '
        Me.lble6.Location = New System.Drawing.Point(34, 369)
        Me.lble6.Name = "lble6"
        Me.lble6.Size = New System.Drawing.Size(145, 21)
        Me.lble6.TabIndex = 12
        Me.lble6.Text = "E6"
        Me.lble6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblh1
        '
        Me.lblh1.Location = New System.Drawing.Point(303, 238)
        Me.lblh1.Name = "lblh1"
        Me.lblh1.Size = New System.Drawing.Size(145, 21)
        Me.lblh1.TabIndex = 13
        Me.lblh1.Text = "H1"
        Me.lblh1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblm1
        '
        Me.lblm1.Location = New System.Drawing.Point(303, 265)
        Me.lblm1.Name = "lblm1"
        Me.lblm1.Size = New System.Drawing.Size(145, 21)
        Me.lblm1.TabIndex = 14
        Me.lblm1.Text = "M1"
        Me.lblm1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblm2
        '
        Me.lblm2.Location = New System.Drawing.Point(303, 292)
        Me.lblm2.Name = "lblm2"
        Me.lblm2.Size = New System.Drawing.Size(145, 21)
        Me.lblm2.TabIndex = 15
        Me.lblm2.Text = "M2"
        Me.lblm2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblc1
        '
        Me.lblc1.Location = New System.Drawing.Point(303, 319)
        Me.lblc1.Name = "lblc1"
        Me.lblc1.Size = New System.Drawing.Size(145, 21)
        Me.lblc1.TabIndex = 16
        Me.lblc1.Text = "C1"
        Me.lblc1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblc2
        '
        Me.lblc2.Location = New System.Drawing.Point(303, 346)
        Me.lblc2.Name = "lblc2"
        Me.lblc2.Size = New System.Drawing.Size(145, 21)
        Me.lblc2.TabIndex = 17
        Me.lblc2.Text = "C2"
        Me.lblc2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservacionControl
        '
        Me.lblObservacionControl.Location = New System.Drawing.Point(34, 396)
        Me.lblObservacionControl.Name = "lblObservacionControl"
        Me.lblObservacionControl.Size = New System.Drawing.Size(145, 21)
        Me.lblObservacionControl.TabIndex = 18
        Me.lblObservacionControl.Text = "Observacioncontrol"
        Me.lblObservacionControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(529, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Carga"
        '
        'panLineas
        '
        Me.panLineas.Location = New System.Drawing.Point(532, 65)
        Me.panLineas.Name = "panLineas"
        Me.panLineas.Size = New System.Drawing.Size(472, 426)
        Me.panLineas.TabIndex = 22
        '
        'frmEntAlbaranesNoDefinitivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1036, 559)
        Me.Controls.Add(Me.panLineas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtObservacionControl)
        Me.Controls.Add(Me.lblResponsableCargaID)
        Me.Controls.Add(Me.lblObservacionControl)
        Me.Controls.Add(Me.txtResponsableCargaID)
        Me.Controls.Add(Me.chbc2)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.lblc2)
        Me.Controls.Add(Me.chbc1)
        Me.Controls.Add(Me.lblReserva1)
        Me.Controls.Add(Me.lblc1)
        Me.Controls.Add(Me.txtReserva1)
        Me.Controls.Add(Me.chbm2)
        Me.Controls.Add(Me.lblReserva2)
        Me.Controls.Add(Me.lblm2)
        Me.Controls.Add(Me.txtReserva2)
        Me.Controls.Add(Me.chbm1)
        Me.Controls.Add(Me.lblReserva3)
        Me.Controls.Add(Me.lblm1)
        Me.Controls.Add(Me.txtReserva3)
        Me.Controls.Add(Me.chbh1)
        Me.Controls.Add(Me.lble1)
        Me.Controls.Add(Me.lblh1)
        Me.Controls.Add(Me.chbe1)
        Me.Controls.Add(Me.chbe6)
        Me.Controls.Add(Me.lble2)
        Me.Controls.Add(Me.lble6)
        Me.Controls.Add(Me.chbe2)
        Me.Controls.Add(Me.chbe5)
        Me.Controls.Add(Me.lble3)
        Me.Controls.Add(Me.lble5)
        Me.Controls.Add(Me.chbe3)
        Me.Controls.Add(Me.chbe4)
        Me.Controls.Add(Me.lble4)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntAlbaranesNoDefinitivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AlbaranesNoDefinitivos"
        Me.Controls.SetChildIndex(Me.lble4, 0)
        Me.Controls.SetChildIndex(Me.chbe4, 0)
        Me.Controls.SetChildIndex(Me.chbe3, 0)
        Me.Controls.SetChildIndex(Me.lble5, 0)
        Me.Controls.SetChildIndex(Me.lble3, 0)
        Me.Controls.SetChildIndex(Me.chbe5, 0)
        Me.Controls.SetChildIndex(Me.chbe2, 0)
        Me.Controls.SetChildIndex(Me.lble6, 0)
        Me.Controls.SetChildIndex(Me.lble2, 0)
        Me.Controls.SetChildIndex(Me.chbe6, 0)
        Me.Controls.SetChildIndex(Me.chbe1, 0)
        Me.Controls.SetChildIndex(Me.lblh1, 0)
        Me.Controls.SetChildIndex(Me.lble1, 0)
        Me.Controls.SetChildIndex(Me.chbh1, 0)
        Me.Controls.SetChildIndex(Me.txtReserva3, 0)
        Me.Controls.SetChildIndex(Me.lblm1, 0)
        Me.Controls.SetChildIndex(Me.lblReserva3, 0)
        Me.Controls.SetChildIndex(Me.chbm1, 0)
        Me.Controls.SetChildIndex(Me.txtReserva2, 0)
        Me.Controls.SetChildIndex(Me.lblm2, 0)
        Me.Controls.SetChildIndex(Me.lblReserva2, 0)
        Me.Controls.SetChildIndex(Me.chbm2, 0)
        Me.Controls.SetChildIndex(Me.txtReserva1, 0)
        Me.Controls.SetChildIndex(Me.lblc1, 0)
        Me.Controls.SetChildIndex(Me.lblReserva1, 0)
        Me.Controls.SetChildIndex(Me.chbc1, 0)
        Me.Controls.SetChildIndex(Me.lblc2, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.chbc2, 0)
        Me.Controls.SetChildIndex(Me.txtResponsableCargaID, 0)
        Me.Controls.SetChildIndex(Me.lblObservacionControl, 0)
        Me.Controls.SetChildIndex(Me.lblResponsableCargaID, 0)
        Me.Controls.SetChildIndex(Me.txtObservacionControl, 0)
        Me.Controls.SetChildIndex(Me.dtpFecha, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblFecha, 0)
        Me.Controls.SetChildIndex(Me.txtNumero, 0)
        Me.Controls.SetChildIndex(Me.lblNumero, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.panLineas, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents panLineas As System.Windows.Forms.Panel
End Class
