Public Class frmAlbaranesCargaMaestroLinea
    Inherits gridsimpleform
    Implements Queriable

    Private dboAlbaranesCargaMaestroLinea As DBO_AlbaranesCargaMaestroLinea
    Private frm As AgnadirAcargaGrabada
    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.new(New spAlbaranesCargaMaestroLinea(), MaestroID.ToString)
        InitializeComponent()
        dboAlbaranesCargaMaestroLinea = New DBO_AlbaranesCargaMaestroLinea
        MyBase.newRegForm = Nothing
        MyBase.butModificar.Enabled = False
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        frm = New AgnadirAcargaGrabada(Convert.ToInt32(Me.m_MaestroID))
        AddHandler frm.AfterSave, AddressOf recargar
        frm.ShowDialog()

        EventHAndeld = True
    End Sub

    Private Sub recargar(sender As Object, e As EventArgs)
        dgvFill(Nothing, Nothing)
    End Sub
    Private Sub modify_Before() Handles MyBase.BeforeModify
        EventHAndeld = True
    End Sub

    Protected Overrides Sub BindDataSource() Implements Queriable.dataGridViewFill
        'dim dt as datatable = DataTableFill(Me.spAlbaranesCargaMaestroLinea.DataGridViewStoredProcedure)

        If Not datasource Is Nothing Then
            GeneralBindingSource.DataSource = datasource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .Columns("AlbaranCargaProviMaestroID").Visible = False
                .Columns("UnidadMedidaID").Visible = False
                .Columns("Lote").Visible = False
                .Columns("TipoPaletID").Visible = False
                .Columns("Observaciones").Visible = False
                .Columns("Reserva1").Visible = False
                .Columns("Reserva2").Visible = False
                .Columns("Reserva3").Visible = False
                .Columns("LoteAlternativo").Visible = False

                .FormatoColumna("SCC", TiposColumna.Miles, 50)
                .FormatoColumna("CodigoQS", TiposColumna.Miles, 50)
                .FormatoColumna("AticuloDescripcion", "Descripcion", TiposColumna.Izquierda, True)
                .FormatoColumna("Cajas", TiposColumna.Miles, 50)
            End With
        End If



    End Sub

End Class
