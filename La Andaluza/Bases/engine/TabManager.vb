Public Class TabManager
    Public Const UNIPESTAÑA As Byte = 1
    Public Const MULTIPESTAÑA As Byte = 2
    Public Const PESTAÑA_SIN_CIERRE As Byte = 3
    Public Const CIERRE_PESTAÑA As String = "  x"

    Public Target_Cerrar_Pestana As SizeF

    Private previousTab As TabPage
    Private previousTab2 As TabPage
    Private tabControl As System.Windows.Forms.TabControl
    Private frmGui As GUImain

    Public Sub New(ByRef tc As TabControl, ByRef frm As GUImain)
        Me.tabControl = tc
        frmGui = frm
        AddHandler Me.tabControl.Deselecting, AddressOf Me.TabControl_Deselecting
    End Sub

    Private Sub TabControl_Deselecting(sender As System.Object, e As System.Windows.Forms.TabControlCancelEventArgs)
        If Not e.TabPage Is Nothing Then
            previousTab = Me.tabControl.TabPages(e.TabPage.Name)
        End If
    End Sub

    Public Sub añadirPestañaAutonoma(ByRef form As Form)
        Dim myTabPage As New TabPage()
        Dim f As Form = form
        Engine_LA.FormEnPestaña(form, myTabPage)
        tabControl.TabPages.Add(myTabPage)
        myTabPage.Text = form.Text & (CIERRE_PESTAÑA)
        myTabPage.Name = form.Text
        myTabPage.Tag = MULTIPESTAÑA
        tabControl.SelectedTab = myTabPage

        AddHandler f.FormClosed, AddressOf frmGui.cerrarPestaña
    End Sub

    Public Sub añadirPestañaSinCierre(ByRef form As Form)
        Dim myTabPage As New TabPage()
        Engine_LA.FormEnPestaña(form, myTabPage)
        tabControl.TabPages.Add(myTabPage)
        myTabPage.Text = form.Text '¡& (CIERRE_PESTAÑA)
        myTabPage.Name = form.Text
        myTabPage.Tag = PESTAÑA_SIN_CIERRE
        tabControl.SelectedTab = myTabPage
    End Sub

    Public Sub añadirPestaña(ByRef form As Form)
        For Each t As TabPage In tabControl.TabPages
            If t.Text = form.text & CIERRE_PESTAÑA Then
                tabControl.SelectedTab = t
                Return
            End If
        Next

        Dim myTabPage As TabPage = Nothing
        Dim crear As Boolean = True

        For Each t As TabPage In tabControl.TabPages
            If Convert.ToByte(t.Tag) = UNIPESTAÑA Then
                tabControl.SelectedTab = t
                t.Controls.Clear()
                myTabPage = t
                crear = False
                Exit For
            End If
        Next

        If myTabPage Is Nothing Then myTabPage = New TabPage

        Engine_LA.FormEnPestaña(form, myTabPage)
        If crear Then tabControl.TabPages.Add(myTabPage)
        myTabPage.Text = form.text & (CIERRE_PESTAÑA)
        myTabPage.Name = form.Text
        myTabPage.Tag = UNIPESTAÑA
        tabControl.SelectedTab = myTabPage

        Dim f As Form = form
        AddHandler f.FormClosed, AddressOf frmGui.cerrarPestaña
    End Sub

    Sub volverApestañaPrevia()
        Me.tabControl.SelectedTab = Me.previousTab
    End Sub

End Class
