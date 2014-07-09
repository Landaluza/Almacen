Public Class Ruta
    Private RutaExcelVentas As String = "Z:\Comercial\Estadisticas\Ventas 2002 a la actualidad.xls"
    Private ResumenFacturasMensuales As String = "Z:\Compras\Proveedores\Control facturas periódicas.xls"
    Private VacacionesPersonal As String

    Public ReadOnly Property ExcelVentas As String
        Get
            Return RutaExcelVentas
        End Get
    End Property

    Public ReadOnly Property FacturasMensuales As String
        Get
            Return ResumenFacturasMensuales
        End Get
    End Property

    Public ReadOnly Property Vacaciones As String
        Get
            Return VacacionesPersonal
        End Get
    End Property

    Public Sub New()
        Dim agno As Integer = DateTime.Now.Year
        agno = Convert.ToInt32((CDbl(agno / 100) - Convert.ToInt32(agno / 100)) * 100)
        VacacionesPersonal = "Z:\Recursos Humanos\Vacaciones\2.0" & agno & "\Vacaciones 20" & agno & ".xls"
    End Sub

End Class
