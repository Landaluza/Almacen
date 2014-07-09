Public Class clsAlbaranCargaProMaestro
    Private dtb As DataBase

    Public Sub New()
        dtb = New DataBase(Config.Server)
    End Sub

    Private AlbaranCargaProMaestroID As Integer
    Private Numero As Integer
    Private Fecha As DateTime
    Private ResponsableCargaID As Integer
    Private Observaciones As String
    Private Reserva1 As String
    Private Reserva2 As String
    Private Reserva3 As String
    Private CodigoPedidoMaestro As Integer
    Private OrdenCarga As Integer

    Public Property _AlbaranCargaProMaestroID() As Integer
        Get
            Return AlbaranCargaProMaestroID
        End Get

        Set(ByVal value As Integer)
            AlbaranCargaProMaestroID = value
        End Set
    End Property

    Public Property _CodigoPedidoMaestro() As Integer
        Get
            Return CodigoPedidoMaestro
        End Get

        Set(ByVal value As Integer)
            CodigoPedidoMaestro = value
        End Set
    End Property

    Public Property _OrdenCarga() As Integer
        Get
            Return OrdenCarga
        End Get

        Set(ByVal value As Integer)
            OrdenCarga = value
        End Set
    End Property

    Public Property _Numero() As Integer
        Get
            Return Numero
        End Get

        Set(ByVal value As Integer)
            Numero = value
        End Set
    End Property

    Public Property _Fecha() As DateTime
        Get
            Return Fecha
        End Get

        Set(ByVal value As DateTime)
            Fecha = value
        End Set
    End Property

    Public Property _ResponsableCargaID() As Integer
        Get
            Return ResponsableCargaID
        End Get

        Set(ByVal value As Integer)
            ResponsableCargaID = value
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




End Class

