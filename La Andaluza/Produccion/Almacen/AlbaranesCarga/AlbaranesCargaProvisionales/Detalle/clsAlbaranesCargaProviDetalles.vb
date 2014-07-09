Public Class clsAlbaranesCargaProviDetalles
    

#Region "Atributos"
    Private AlbaranCargaProviDetalleID As Integer
    Private AlbaranCargaProviMaestroID As Integer
    Private SCC As Integer
    Private CodigoQS As Integer
    Private AticuloDescripcion As String
    Private Cajas As Integer
    Private UnidadMedidaID As Integer
    Private Lote As String
    Private TipoPaletID As Integer
    Private Observaciones As String
    Private Reserva1 As String
    Private Reserva2 As String
    Private Reserva3 As String
    Private LoteAlternativo As String

#End Region

#Region "Propiedades"
    Public Property _AlbaranCargaProviDetalleID() As Integer
        Get
            Return AlbaranCargaProviDetalleID
        End Get

        Set(ByVal value As Integer)
            AlbaranCargaProviDetalleID = value
        End Set
    End Property


    Public Property _AlbaranCargaProviMaestroID() As Integer
        Get
            Return AlbaranCargaProviMaestroID
        End Get

        Set(ByVal value As Integer)
            AlbaranCargaProviMaestroID = value
        End Set
    End Property

    Public Property _SCC() As Integer
        Get
            Return SCC
        End Get

        Set(ByVal value As Integer)
            SCC = value
        End Set
    End Property

    Public Property _CodigoQS() As Integer
        Get
            Return CodigoQS
        End Get

        Set(ByVal value As Integer)
            CodigoQS = value
        End Set
    End Property

    Public Property _AticuloDescripcion() As String
        Get
            Return AticuloDescripcion
        End Get

        Set(ByVal value As String)
            AticuloDescripcion = value
        End Set
    End Property

    Public Property _Cajas() As Integer
        Get
            Return Cajas
        End Get

        Set(ByVal value As Integer)
            Cajas = value
        End Set
    End Property

    Public Property _UnidadMedidaID() As Integer
        Get
            Return UnidadMedidaID
        End Get

        Set(ByVal value As Integer)
            UnidadMedidaID = value
        End Set
    End Property

    Public Property _Lote() As String
        Get
            Return Lote
        End Get

        Set(ByVal value As String)
            Lote = value
        End Set
    End Property

    Public Property _TipoPaletID() As Integer
        Get
            Return TipoPaletID
        End Get

        Set(ByVal value As Integer)
            TipoPaletID = value
        End Set
    End Property

    Public Property _Observaciones() As String
        Get
            Return Observaciones
        End Get

        Set(ByVal value As String)
            Observaciones = value
        End Set
    End Property

    Public Property _Reserva1() As String
        Get
            Return Reserva1
        End Get

        Set(ByVal value As String)
            Reserva1 = value
        End Set
    End Property

    Public Property _Reserva2() As String
        Get
            Return Reserva2
        End Get

        Set(ByVal value As String)
            Reserva2 = value
        End Set
    End Property

    Public Property _Reserva3() As String
        Get
            Return Reserva3
        End Get

        Set(ByVal value As String)
            Reserva3 = value
        End Set
    End Property

    Public Property _LoteAlternativo() As String
        Get
            Return LoteAlternativo
        End Get

        Set(ByVal value As String)
            LoteAlternativo = value
        End Set
    End Property

#End Region





End Class
