Public Class frmEntAlbaranesCargaMaestroLinea
    Inherits DetailedSimpleForm
    Implements Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements Savable.afterSave
    Private m_DBO_AlbaranesCargaMaestroLinea As DBO_AlbaranesCargaMaestroLinea

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spAlbaranesCargaMaestroLinea = Nothing, Optional ByRef v_dbo As DBO_AlbaranesCargaMaestroLinea = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spAlbaranesCargaMaestroLinea, StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_AlbaranesCargaMaestroLinea = If(v_dbo Is Nothing, New DBO_AlbaranesCargaMaestroLinea, v_dbo)
        dbo = m_DBO_AlbaranesCargaMaestroLinea
    End Sub

    Public Sub New()
        MyBase.new(GridSimpleForm.ACCION_INSERTAR, CType(New spAlbaranesCargaMaestroLinea, storedprocedure), CType(New DBO_AlbaranesCargaMaestroLinea, databussines))
        InitializeComponent()
    End Sub

    Private Sub frmEntAlbaranesCargaMaestroLinea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Me.mododeapertura = VISION) Then
        End If
        If Config.userType <> 4 AndAlso Config.userType <> 9 Then
        End If

    End Sub

    Overrides Sub SetValores() Implements Savable.setValores
        If (Me.modoDeApertura = INSERCION) Then
            Me.m_DBO_AlbaranesCargaMaestroLinea = New dbo_AlbaranesCargaMaestroLinea
        Else
            Me.m_DBO_AlbaranesCargaMaestroLinea = CType(dbo, DBO_AlbaranesCargaMaestroLinea)
        End If

        txtAlbaranCargaProviMaestroID.Text = m_DBO_AlbaranesCargaMaestroLinea.AlbaranCargaProviMaestroID.ToString
        txtSCC.Text = m_DBO_AlbaranesCargaMaestroLinea.SCC.ToString
        txtCodigoQS.Text = m_DBO_AlbaranesCargaMaestroLinea.CodigoQS.ToString
        txtAticuloDescripcion.Text = m_DBO_AlbaranesCargaMaestroLinea.AticuloDescripcion
        txtCajas.Text = m_DBO_AlbaranesCargaMaestroLinea.Cajas.ToString
        txtUnidadMedidaID.Text = m_DBO_AlbaranesCargaMaestroLinea.UnidadMedidaID.ToString
        txtLote.Text = m_DBO_AlbaranesCargaMaestroLinea.Lote
        txtTipoPaletID.Text = m_DBO_AlbaranesCargaMaestroLinea.TipoPaletID.ToString
        txtObservaciones.Text = m_DBO_AlbaranesCargaMaestroLinea.Observaciones
        txtReserva1.Text = m_DBO_AlbaranesCargaMaestroLinea.Reserva1
        txtReserva2.Text = m_DBO_AlbaranesCargaMaestroLinea.Reserva2
        txtReserva3.Text = m_DBO_AlbaranesCargaMaestroLinea.Reserva3
        txtLoteAlternativo.Text = m_DBO_AlbaranesCargaMaestroLinea.LoteAlternativo
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements Savable.getValores
        Dim errores As String = String.empty


        m_DBO_AlbaranesCargaMaestroLinea.AlbaranCargaProviMaestroID = System.Convert.ToInt32(txtAlbaranCargaProviMaestroID.Text)


        m_DBO_AlbaranesCargaMaestroLinea.SCC = System.Convert.ToInt32(txtSCC.Text)


        m_DBO_AlbaranesCargaMaestroLinea.CodigoQS = System.Convert.ToInt32(txtCodigoQS.Text)


        m_DBO_AlbaranesCargaMaestroLinea.AticuloDescripcion = txtAticuloDescripcion.Text


        m_DBO_AlbaranesCargaMaestroLinea.Cajas = System.Convert.ToInt32(txtCajas.Text)


        m_DBO_AlbaranesCargaMaestroLinea.UnidadMedidaID = System.Convert.ToInt32(txtUnidadMedidaID.Text)


        m_DBO_AlbaranesCargaMaestroLinea.Lote = txtLote.Text


        m_DBO_AlbaranesCargaMaestroLinea.TipoPaletID = System.Convert.ToInt32(txtTipoPaletID.Text)


        m_DBO_AlbaranesCargaMaestroLinea.Observaciones = txtObservaciones.Text


        m_DBO_AlbaranesCargaMaestroLinea.Reserva1 = txtReserva1.Text


        m_DBO_AlbaranesCargaMaestroLinea.Reserva2 = txtReserva2.Text


        m_DBO_AlbaranesCargaMaestroLinea.Reserva3 = txtReserva3.Text


        m_DBO_AlbaranesCargaMaestroLinea.LoteAlternativo = txtLoteAlternativo.Text


        If (errores = String.empty) Then
            Dbo = CType(m_DBO_AlbaranesCargaMaestroLinea, databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Shadows Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements Savable.Guardar
        MyBase.Guardar(New DataBase(Config.Server))
    End Sub

    Private Sub frmEntAlbaranesCargaMaestroLinea_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        DetailedSimpleForm.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
