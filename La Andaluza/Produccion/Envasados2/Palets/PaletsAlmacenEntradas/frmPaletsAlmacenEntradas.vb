Public Class frmPaletsAlmacenEntradas
    Inherits FrmAheredarOld

    Public Sub New(ByVal Entradas As Boolean)
        MyBase.New(New spPaletsAlmacenEntradas, If(Entradas, 0, 1))
        InitializeComponent()

        If Entradas Then
            spSelectDgv = "PaletsAlmacenEntradasSelectByCajas 0"
        Else
            spSelectDgv = "AlbaranCargaSeguridadSelectTodos" '"PaletsAlmacenEntradasSelectByCajas 1"
            butEliminar.Enabled = False
        End If
        If Not Entradas Then butEliminar.Enabled = False
        butSalir.Visible = False
        butModificar.Enabled = False
        butNuevo.Enabled = False
    End Sub

    Protected Overrides Sub cargar_datos()
        dataSource = dtb.consultar(spSelectDgv)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            dgvGeneral.DataSource = GeneralBindingSource

            If spSelectDgv = "PaletsAlmacenEntradasSelectByCajas 0" Then
                With dgvGeneral

                    .Columns("PaletAlmacenEntradaID").Visible = False
                    .Columns("Vigente").Visible = False

                    .FormatoColumna("SSCC", TiposColumna.Izquierda, 50)
                    .FormatoColumna("Fecha", TiposColumna.FechaCorta, 72)
                    .FormatoColumna("Articulo", TiposColumna.Izquierda, 300)
                    .FormatoColumna("Cajas", TiposColumna.Miles, 50)
                    .FormatoColumna("ComentariosCarga", TiposColumna.Izquierda, True)
                    .FormatoColumna("Observaciones", TiposColumna.Izquierda, True)
                End With

            Else

            End If
            'dgvGeneral.FormatoGeneral()
            'BindingNavigatorActualizar(dgvGeneral.RowCount)
            'butNuevo.Visible = False
            'butVer.Visible = False
        End If
    End Sub

 
    Public Overrides Sub Eliminar()
        If Not Me.dgvGeneral.CurrentRow Is Nothing Then
            If CType(sp, spPaletsAlmacenEntradas).PaletsAlmacenEntradasDelete(Convert.ToInt32(dgvGeneral.CurrentRow.Cells("PaletAlmacenEntradaID").Value)) Then
                dgvFill()
            Else
                MessageBox.Show("No se pudo eliminar el registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

End Class
