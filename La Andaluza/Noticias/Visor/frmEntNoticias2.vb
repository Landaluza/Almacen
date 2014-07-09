Public Class frmEntNoticias2
    Inherits DetailedSimpleForm
    Private m_DBO_Noticias As DBO_Noticias

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spNoticias = Nothing, Optional ByRef v_dbo As DBO_Noticias = Nothing)
        MyBase.New(modoDeApertura, v_sp, CType(v_dbo, DataBussines))
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spNoticias, v_sp)
        m_DBO_Noticias = If(v_dbo Is Nothing, New DBO_Noticias, v_dbo)
        dbo = m_DBO_Noticias

    End Sub

    Public Sub New()
        MyBase.new(GridSimpleForm.ACCION_VER, New spNoticias, New DBO_Noticias)
        InitializeComponent()
    End Sub


    Overrides Sub SetValores()

        Me.m_DBO_Noticias = CType(dbo, DBO_Noticias)

        txtTitulo.Text = m_DBO_Noticias.Titulo
        txtTexto.Text = m_DBO_Noticias.Texto
        txtFecha.Text = m_DBO_Noticias.Fecha.ToShortDateString
        Me.Text = txtTexto.Text

    End Sub

    Protected Overrides Function GetValores() As Boolean
        Return False
    End Function

    Public Overrides Sub Guardar(ByRef transactDtb As DataBase)
        Me.Close()
    End Sub

    Private Sub frmEntNoticias2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.butGuardar.Visible = False
        Me.Separator1.Visible = False
    End Sub
End Class
