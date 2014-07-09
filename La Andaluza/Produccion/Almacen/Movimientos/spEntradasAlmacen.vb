Public Class spEntradasAlmacen
    Private dtb As DataBase

    Public Sub New()
        dtb = New DataBase(Config.Server)
    End Sub
    Public Function EstaEnAlmacen(ByVal scc As String) As Boolean
        Dim Tabla As DataTable = dtb.Consultar("select count(* ) from PaletsAlmacenEntradas where sscc=" & scc, False)

        If If(Tabla.Rows(0).Item(0) Is Nothing, 0, Convert.ToInt32(Tabla.Rows(0).Item(0))) = 0 Then Return False

        Return True
    End Function
End Class
