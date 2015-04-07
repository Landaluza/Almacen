
Public Class frmAlbaranesNoDefinitivos
    Inherits gridsimpleform
    Implements Queriable

    Private dboAlbaranesNoDefinitivos As DBO_AlbaranesNoDefinitivos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.new(New spAlbaranesNoDefinitivos(), MaestroID.ToString)
        InitializeComponent()
        dboAlbaranesNoDefinitivos = New DBO_AlbaranesNoDefinitivos
        MyBase.newRegForm = CType(New frmEntAlbaranesNoDefinitivos(GridSimpleForm.ACCION_INSERTAR, CType(sp, spAlbaranesNoDefinitivos)), DetailedSimpleForm)
        Me.bdnGeneral.Visible = False
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        Me.EventHAndeld = True
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboAlbaranesNoDefinitivos = CType(sp, spAlbaranesNoDefinitivos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboAlbaranesNoDefinitivos Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboAlbaranesNoDefinitivos, databussines))
        Else
            MyBase.EventHAndeld = True
            Messagebox.show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource() Implements Queriable.dataGridViewFill        

        If Not datasource Is Nothing Then
            GeneralBindingSource.DataSource = datasource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Numero", TiposColumna.Miles, 50)
                .FormatoColumna("Fecha", TiposColumna.FechaCorta, 80)
                .FormatoColumna("Observaciones", TiposColumna.Izquierda, True)
                .FormatoColumna("Reserva1", TiposColumna.Izquierda, True)
                .FormatoColumna("Reserva2", TiposColumna.Izquierda, True)
                .FormatoColumna("Reserva3", TiposColumna.Izquierda, True)
                .FormatoColumna("ObservacionControl", TiposColumna.Izquierda, True)
            End With
        End If

    End Sub

End Class
