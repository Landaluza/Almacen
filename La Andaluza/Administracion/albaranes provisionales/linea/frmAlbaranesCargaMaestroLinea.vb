Public Class frmAlbaranesCargaMaestroLinea
    Inherits gridsimpleform
    Implements Queriable

    Private dboAlbaranesCargaMaestroLinea As DBO_AlbaranesCargaMaestroLinea

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.new(New spAlbaranesCargaMaestroLinea(), MaestroID.ToString)
        InitializeComponent()
        dboAlbaranesCargaMaestroLinea = New DBO_AlbaranesCargaMaestroLinea
        MyBase.newRegForm = CType(New frmEntAlbaranesCargaMaestroLinea(GridSimpleForm.ACCION_INSERTAR, CType(sp, spAlbaranesCargaMaestroLinea)), DetailedSimpleForm)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboAlbaranesCargaMaestroLinea, databussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboAlbaranesCargaMaestroLinea = CType(sp, spAlbaranesCargaMaestroLinea).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboAlbaranesCargaMaestroLinea Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboAlbaranesCargaMaestroLinea, databussines))
        Else
            MyBase.EventHandeld = True
            Messagebox.show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource() Implements Queriable.dataGridViewFill
        'dim dt as datatable = DataTableFill(Me.spAlbaranesCargaMaestroLinea.DataGridViewStoredProcedure)

        If Not datasource Is Nothing Then
            GeneralBindingSource.DataSource = datasource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("AlbaranCargaProviMaestroID", TiposColumna.Miles, 50)
                .FormatoColumna("SCC", TiposColumna.Miles, 50)
                .FormatoColumna("CodigoQS", TiposColumna.Miles, 50)
                .FormatoColumna("AticuloDescripcion", TiposColumna.Izquierda, True)
                .FormatoColumna("Cajas", TiposColumna.Miles, 50)
                .FormatoColumna("UnidadMedidaID", TiposColumna.Miles, 50)
                .FormatoColumna("Lote", TiposColumna.Izquierda, True)
                .FormatoColumna("TipoPaletID", TiposColumna.Miles, 50)
                .FormatoColumna("Observaciones", TiposColumna.Izquierda, True)
                .FormatoColumna("Reserva1", TiposColumna.Izquierda, True)
                .FormatoColumna("Reserva2", TiposColumna.Izquierda, True)
                .FormatoColumna("Reserva3", TiposColumna.Izquierda, True)
                .FormatoColumna("LoteAlternativo", TiposColumna.Izquierda, True)
            End With
        End If

    End Sub

End Class
