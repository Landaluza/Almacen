<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlmacenEntradasSalidasMovimientos
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
        Me.dgvMovimientosAnteriores = New System.Windows.Forms.DataGridView()
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.lblTexto2 = New System.Windows.Forms.Label()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.lblCajas = New System.Windows.Forms.Label()
        Me.lblAviso = New System.Windows.Forms.Label()
        CType(Me.dgvMovimientosAnteriores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMovimientosAnteriores
        '
        Me.dgvMovimientosAnteriores.AllowUserToAddRows = False
        Me.dgvMovimientosAnteriores.AllowUserToDeleteRows = False
        Me.dgvMovimientosAnteriores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimientosAnteriores.Location = New System.Drawing.Point(16, 82)
        Me.dgvMovimientosAnteriores.Name = "dgvMovimientosAnteriores"
        Me.dgvMovimientosAnteriores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovimientosAnteriores.Size = New System.Drawing.Size(863, 150)
        Me.dgvMovimientosAnteriores.TabIndex = 0
        '
        'lblTexto
        '
        Me.lblTexto.AutoSize = True
        Me.lblTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto.Location = New System.Drawing.Point(385, 18)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(72, 24)
        Me.lblTexto.TabIndex = 1
        Me.lblTexto.Text = "Label1"
        '
        'lblTexto2
        '
        Me.lblTexto2.AutoSize = True
        Me.lblTexto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto2.ForeColor = System.Drawing.Color.Red
        Me.lblTexto2.Location = New System.Drawing.Point(17, 285)
        Me.lblTexto2.Name = "lblTexto2"
        Me.lblTexto2.Size = New System.Drawing.Size(0, 20)
        Me.lblTexto2.TabIndex = 2
        '
        'butAceptar
        '
        Me.butAceptar.Location = New System.Drawing.Point(265, 324)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(125, 36)
        Me.butAceptar.TabIndex = 3
        Me.butAceptar.Text = "Realizar movimiento"
        Me.butAceptar.UseVisualStyleBackColor = True
        '
        'butCancelar
        '
        Me.butCancelar.Location = New System.Drawing.Point(423, 324)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(125, 36)
        Me.butCancelar.TabIndex = 4
        Me.butCancelar.Text = "Cancelar movimiento"
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'lblCajas
        '
        Me.lblCajas.AutoSize = True
        Me.lblCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajas.Location = New System.Drawing.Point(12, 244)
        Me.lblCajas.Name = "lblCajas"
        Me.lblCajas.Size = New System.Drawing.Size(54, 20)
        Me.lblCajas.TabIndex = 5
        Me.lblCajas.Text = "Cajas"
        '
        'lblAviso
        '
        Me.lblAviso.AutoSize = True
        Me.lblAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAviso.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblAviso.Location = New System.Drawing.Point(17, 55)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.Size = New System.Drawing.Size(551, 24)
        Me.lblAviso.TabIndex = 6
        Me.lblAviso.Text = "No se recogen los movimientos efectuados manualmente."
        '
        'AlmacenEntradasSalidasMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 372)
        Me.Controls.Add(Me.lblAviso)
        Me.Controls.Add(Me.lblCajas)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.lblTexto2)
        Me.Controls.Add(Me.lblTexto)
        Me.Controls.Add(Me.dgvMovimientosAnteriores)
        Me.Name = "AlmacenEntradasSalidasMovimientos"
        Me.Text = "AlmacenEntradasSalidasMovimientos"
        CType(Me.dgvMovimientosAnteriores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dgvMovimientosAnteriores As System.Windows.Forms.DataGridView
    Private WithEvents lblTexto As System.Windows.Forms.Label
    Private WithEvents lblTexto2 As System.Windows.Forms.Label
    Private WithEvents butAceptar As System.Windows.Forms.Button
    Private WithEvents butCancelar As System.Windows.Forms.Button
    Private WithEvents lblCajas As System.Windows.Forms.Label
    Private WithEvents lblAviso As System.Windows.Forms.Label
End Class
