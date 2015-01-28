Public Class Orden
    Public palets As String
    Public nPalets As Integer
    Public addColumns As Boolean
    Public datasource As DataTable
    Public Sub New()
        palets = ""
        nPalets = 0
        addColumns = False
    End Sub

    Public Sub cargar_datos()
        Dim dtb As New DataBase(Config.Server)
        datasource = dtb.Consultar("OrdenesDeCargaByDiaServicio '" & palets & "'," & nPalets)
    End Sub
End Class
