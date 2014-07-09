Public Class frmMensajesPendientes
    Private notificador As Notificador
    Private ico As Label
    Private frm As GUIstandar

    Public Sub New(ByRef ico As Label, ByRef frm As GUIstandar)
        InitializeComponent()

        Me.ico = ico
        Me.frm = frm
        notificador = New Notificador
    End Sub

    Public Sub New(ByRef ico As Label, ByRef frm As GUImain)
        InitializeComponent()

        Me.ico = ico
        Me.frm = CType(frm, GUIstandar)
        notificador = New Notificador
    End Sub
    
    Private Sub frmMensajesPendientes_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Dim notificacion As DataTable
        notificacion = Me.notificador.comprobarNotificaciones



        If Not notificacion Is Nothing Then
            Me.DataGridView1.DataSource = notificacion

            Dim cborrar As New DataGridViewImageColumn
            cborrar.Image = My.Resources.edit_remove_3
            cborrar.Name = "borrar"
            cborrar.HeaderText = ""
            cborrar.ToolTipText = "Borra el mensaje"
            cborrar.DisplayIndex = 0
            cborrar.Width = 25            
            Me.DataGridView1.Columns.Add(cborrar)

            Me.DataGridView1.Columns("id").Visible = False
            Me.DataGridView1.FormatoColumna("texto", "Mensaje", TiposColumna.Descripcion, True)
        End If


    End Sub

    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.ColumnIndex = 2 Then
            If notificador.borrarNotificacion(Convert.ToInt32(Me.DataGridView1.CurrentRow.Cells("id").Value)) Then
                If Me.DataGridView1.Rows.Count > 1 Then
                    DataGridView1.Rows.Remove(Me.DataGridView1.CurrentRow)
                Else
                    Me.Close()
                    Me.ico.Enabled = False
                    frm.actualizarnotificaciones()
                End If
            End If
        End If
    End Sub
End Class