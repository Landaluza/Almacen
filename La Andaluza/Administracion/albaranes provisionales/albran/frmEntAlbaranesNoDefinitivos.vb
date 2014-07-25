Public Class frmEntAlbaranesNoDefinitivos
    Inherits DetailedSimpleForm
    Implements Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements Savable.afterSave
    Private m_DBO_AlbaranesNoDefinitivos As DBO_AlbaranesNoDefinitivos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spAlbaranesNoDefinitivos = Nothing, Optional ByRef v_dbo As DBO_AlbaranesNoDefinitivos = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spAlbaranesNoDefinitivos, StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_AlbaranesNoDefinitivos = If(v_dbo Is Nothing, New DBO_AlbaranesNoDefinitivos, v_dbo)
        dbo = m_DBO_AlbaranesNoDefinitivos
    End Sub

    Public Sub New()
        MyBase.new(GridSimpleForm.ACCION_INSERTAR, CType(New spAlbaranesNoDefinitivos, storedprocedure), CType(New DBO_AlbaranesNoDefinitivos, databussines))
        InitializeComponent()
    End Sub

    Private Sub frmEntAlbaranesNoDefinitivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Me.mododeapertura = VISION) Then
        End If
        If Config.userType <> 4 And Config.userType <> 9 Then
        End If

    End Sub

    Overrides Sub SetValores() Implements Savable.setValores
        Me.m_DBO_AlbaranesNoDefinitivos = CType(dbo, DBO_AlbaranesNoDefinitivos)

        txtNumero.Text = m_DBO_AlbaranesNoDefinitivos.Numero.ToString
        dtpFecha.Value = m_DBO_AlbaranesNoDefinitivos.Fecha
        txtResponsableCargaID.Text = m_DBO_AlbaranesNoDefinitivos.ResponsableCargaID.ToString
        txtObservaciones.Text = m_DBO_AlbaranesNoDefinitivos.Observaciones
        txtReserva1.Text = m_DBO_AlbaranesNoDefinitivos.Reserva1
        txtReserva2.Text = m_DBO_AlbaranesNoDefinitivos.Reserva2
        txtReserva3.Text = m_DBO_AlbaranesNoDefinitivos.Reserva3
        chbe1.Checked = m_DBO_AlbaranesNoDefinitivos.e1
        chbe2.Checked = m_DBO_AlbaranesNoDefinitivos.e2
        chbe3.Checked = m_DBO_AlbaranesNoDefinitivos.e3
        chbe4.Checked = m_DBO_AlbaranesNoDefinitivos.e4
        chbe5.Checked = m_DBO_AlbaranesNoDefinitivos.e5
        chbe6.Checked = m_DBO_AlbaranesNoDefinitivos.e6
        chbh1.Checked = m_DBO_AlbaranesNoDefinitivos.h1
        chbm1.Checked = m_DBO_AlbaranesNoDefinitivos.m1
        chbm2.Checked = m_DBO_AlbaranesNoDefinitivos.m2
        chbc1.Checked = m_DBO_AlbaranesNoDefinitivos.c1
        chbc2.Checked = m_DBO_AlbaranesNoDefinitivos.c2
        txtObservacionControl.Text = m_DBO_AlbaranesNoDefinitivos.ObservacionControl

        Dim frm As New frmAlbaranesCargaMaestroLinea(Me.m_DBO_AlbaranesNoDefinitivos.Numero)
        Engine_LA.FormEnPestaña(frm, panLineas)
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements Savable.getValores
        Dim errores As String = String.empty


        m_DBO_AlbaranesNoDefinitivos.Numero = System.Convert.ToInt32(txtNumero.Text)


        m_DBO_AlbaranesNoDefinitivos.Fecha = dtpFecha.value


        m_DBO_AlbaranesNoDefinitivos.ResponsableCargaID = System.Convert.ToInt32(txtResponsableCargaID.Text)


        m_DBO_AlbaranesNoDefinitivos.Observaciones = txtObservaciones.Text


        m_DBO_AlbaranesNoDefinitivos.Reserva1 = txtReserva1.Text


        m_DBO_AlbaranesNoDefinitivos.Reserva2 = txtReserva2.Text


        m_DBO_AlbaranesNoDefinitivos.Reserva3 = txtReserva3.Text


        m_DBO_AlbaranesNoDefinitivos.e1 = chbe1.Checked

        m_DBO_AlbaranesNoDefinitivos.e2 = chbe2.Checked

        m_DBO_AlbaranesNoDefinitivos.e3 = chbe3.Checked

        m_DBO_AlbaranesNoDefinitivos.e4 = chbe4.Checked

        m_DBO_AlbaranesNoDefinitivos.e5 = chbe5.Checked

        m_DBO_AlbaranesNoDefinitivos.e6 = chbe6.Checked

        m_DBO_AlbaranesNoDefinitivos.h1 = chbh1.Checked

        m_DBO_AlbaranesNoDefinitivos.m1 = chbm1.Checked

        m_DBO_AlbaranesNoDefinitivos.m2 = chbm2.Checked

        m_DBO_AlbaranesNoDefinitivos.c1 = chbc1.Checked

        m_DBO_AlbaranesNoDefinitivos.c2 = chbc2.Checked

        m_DBO_AlbaranesNoDefinitivos.ObservacionControl = txtObservacionControl.Text


        If (errores = String.empty) Then
            Dbo = CType(m_DBO_AlbaranesNoDefinitivos, databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Shadows Sub guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements Savable.Guardar
        MyBase.Guardar(New DataBase(Config.Server))
    End Sub
End Class
