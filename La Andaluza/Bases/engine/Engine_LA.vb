Public Class Engine_LA
    Private conf As Config
    Private tabAdm As TabManager
    Private previousTab As TabPage
    Private notificador As Notificador
    Private frmGui As GUImain

    Public Property Target_Cerrar_Pestana As SizeF
        Set(value As SizeF)
            Me.tabAdm.Target_Cerrar_Pestana = value
        End Set
        Get
            Return Me.tabAdm.Target_Cerrar_Pestana
        End Get
    End Property

    Public Sub New(ByRef frm As GUImain)
        conf = New Config
        tabAdm = New TabManager(frm.TabControl1, frm)
        notificador = New Notificador
        Me.frmGui = frm

    End Sub

    Public Sub AñadirPestaña(ByRef form As Form)
        Me.tabAdm.añadirPestaña(form)
    End Sub

    Public Sub añadirPestañasinCierre(ByRef form As Form)
        Me.tabAdm.añadirPestañaSinCierre(form)
    End Sub

    Public Sub añadirPestañaAutonoma(ByRef form As Form)
        Me.tabAdm.añadirPestañaAutonoma(form)
    End Sub

    Public Sub volverApestañaPrevia()
        Me.tabAdm.volverApestañaPrevia()
    End Sub

    Public Shared Sub FormEnPestaña(ByVal mObjeto As Form, ByVal mPanel As Panel)
        mPanel.Controls.Clear()
        mObjeto.WindowState = FormWindowState.Normal
        mObjeto.TopLevel = False
        mObjeto.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        mObjeto.Dock = DockStyle.Fill
        mPanel.Controls.Add(mObjeto)
        mObjeto.Show()
    End Sub

    Sub reportarError(ByRef frm As Form, Optional external As Boolean = False)
        Dim Pant As New Pantalla
        Dim img As Bitmap

        If external Then
            img = Pant.capturarPantallaEntera(frm)
        Else
            img = Pant.capturarPantalla(frm)
        End If

        Dim frmReporteErrores As New frmReporteErrores(img)

        If external Then
            frmReporteErrores.ShowDialog()
        Else
            añadirPestañaAutonoma(CType(frmReporteErrores, Form))
        End If
    End Sub

    Function comprobarNotificaciones() As DataTable
        Return notificador.comprobarNotificaciones
    End Function

    Function comprobarNumeroPedidos() As Integer
        Return notificador.comprobarNumeroPedidos
    End Function

    Function comprobarNumeroOC() As Integer
        Return notificador.comprobarNumeroOC
    End Function

End Class
