Public Class DBO_PaletsContenidos2

    Private m_PaletContenidoID As Integer
    Private m_FormatoEnvasadoID As Integer
    Private m_HoraInicio As TimeSpan
    Private m_HoraFin As TimeSpan
    Private m_CantidadCajas As Integer
    Private m_PaletProducidoID As Integer
    Private m_PartePaletContenidoID As Integer
    Private m_Terminado As Boolean
    Private m_EnAlmacen As Boolean
    Private m_Observaciones As String
    Private m_FechaModificacion As date
    Private m_UsuarioModificacion As Int32

    'campos adicionales
    Private m_SCC As Integer
    Private m_FormatoDescripcion As String
    Private m_CapacidadBotellasCajas As Integer
    Private m_LineaID As Integer
    Private m_CajasPalets As Integer
    Private m_NroCajasCompletar As Integer

    Public Sub New()

    End Sub

    Public Property PaletContenidoID() As Integer
        Get
            Return m_PaletContenidoID
        End Get
        Set(ByVal value As Integer)
            m_PaletContenidoID = value
        End Set
    End Property

    Public Property FormatoEnvasadoID() As Integer
        Get
            Return m_FormatoEnvasadoID
        End Get
        Set(ByVal value As Integer)
            m_FormatoEnvasadoID = value
        End Set
    End Property

    Public Property HoraInicio() As TimeSpan
        Get
            Return m_HoraInicio
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraInicio = value
        End Set
    End Property

    Public Property HoraFin() As TimeSpan
        Get
            Return m_HoraFin
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraFin = value
        End Set
    End Property

    Public Property CantidadCajas() As Integer
        Get
            Return m_CantidadCajas
        End Get
        Set(ByVal value As Integer)
            m_CantidadCajas = value
        End Set
    End Property

    Public Property PaletProducidoID() As Integer
        Get
            Return m_PaletProducidoID
        End Get
        Set(ByVal value As Integer)
            m_PaletProducidoID = value
        End Set
    End Property

    Public Property PartePaletContenidoID() As Integer
        Get
            Return m_PartePaletContenidoID
        End Get
        Set(ByVal value As Integer)
            m_PartePaletContenidoID = value
        End Set
    End Property

    Public Property Terminado() As Boolean
        Get
            Return m_Terminado
        End Get
        Set(ByVal value As Boolean)
            m_Terminado = value
        End Set
    End Property

    Public Property EnAlmacen() As Boolean
        Get
            Return m_EnAlmacen
        End Get
        Set(ByVal value As Boolean)
            m_EnAlmacen = value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return m_Observaciones
        End Get
        Set(ByVal value As String)
            m_Observaciones = value
        End Set
    End Property

    Public Property FechaModificacion() As Date
        Get
            Return m_FechaModificacion
        End Get
        Set(ByVal value As Date)
            m_FechaModificacion = value
        End Set
    End Property

    Public Property UsuarioModificacion() As Int32
        Get
            Return m_UsuarioModificacion
        End Get
        Set(ByVal value As Int32)
            m_UsuarioModificacion = value
        End Set
    End Property

    Public Property SCC() As Integer
        Get
            Return m_SCC
        End Get
        Set(ByVal value As Integer)
            m_SCC = value
        End Set
    End Property

    Public Property FormatoDescripcion() As String
        Get
            Return m_FormatoDescripcion
        End Get
        Set(ByVal value As String)
            m_FormatoDescripcion = value
        End Set
    End Property

    Public Property CapacidadBotellasCajas() As Integer
        Get
            Return m_CapacidadBotellasCajas
        End Get
        Set(ByVal value As Integer)
            m_CapacidadBotellasCajas = value
        End Set
    End Property

    Public Property LineaID() As Integer
        Get
            Return m_LineaID
        End Get
        Set(ByVal value As Integer)
            m_LineaID = value
        End Set
    End Property

    Public Property CajasPalets() As Integer
        Get
            Return m_CajasPalets
        End Get
        Set(ByVal value As Integer)
            m_CajasPalets = value
        End Set
    End Property

    Public Property NroCajasCompletar() As Integer
        Get
            Return m_NroCajasCompletar
        End Get
        Set(ByVal value As Integer)
            m_NroCajasCompletar = value
        End Set
    End Property
End Class
