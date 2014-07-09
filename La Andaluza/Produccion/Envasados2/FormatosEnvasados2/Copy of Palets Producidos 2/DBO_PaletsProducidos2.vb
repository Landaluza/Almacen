Public Class DBO_PaletsProducidos2

    Private m_PaletProducidoID As Integer
    Private m_SCC As Integer
    Private m_SCC_IsDBNull As Boolean
    Private m_FormatoID As Integer
    Private m_FechaModificacion As date
    Private m_UsuarioModificacion As Int32
    Private m_ObservacionesPalets As String
    Private m_EnAlmacen As Boolean
    Private m_multiLote As Boolean
    Private m_Id_EStado As Integer


    Private Shared datos As DBO_PaletsProducidos2

    Public Sub New()
    End Sub

    Public Shared Function Instance() As DBO_PaletsProducidos2
        If datos Is Nothing Then
            datos = New DBO_PaletsProducidos2()
        End If
        Return datos
    End Function

    Public Property EnAlmacen() As Boolean
        Get
            Return m_EnAlmacen
        End Get
        Set(ByVal value As Boolean)
            m_EnAlmacen = value
        End Set
    End Property

    Public Property MultiLote() As Boolean
        Get
            Return m_multiLote
        End Get
        Set(ByVal value As Boolean)
            m_multiLote = value
        End Set
    End Property

    Public Property Id_Estado() As Integer
        Get
            Return m_Id_estado
        End Get
        Set(ByVal value As Integer)
            m_Id_estado = value
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

    Public Property SCC() As Integer
        Get
            Return m_SCC
        End Get
        Set(ByVal value As Integer)
            m_SCC = value
        End Set
    End Property

    Public Property SCC_IsDBNull() As Boolean
        Get
            Return m_SCC_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_SCC_IsDBNull = value
        End Set
    End Property

    Public Property FormatoID() As Integer
        Get
            Return m_FormatoID
        End Get
        Set(ByVal value As Integer)
            m_FormatoID = value
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

    Public Property observacionesPalets() As String
        Get
            Return m_observacionesPalets
        End Get
        Set(ByVal value As String)
            m_observacionesPalets = value
        End Set
    End Property

#Region "Campos Calculados"
    Private m_HoraInicio As TimeSpan
    Private m_HoraFin As TimeSpan
    Private m_Terminado As Boolean
    Private m_NroCajas As Integer
    Private m_NroPalets As Integer
    Private m_Velocidad As Double
    Private m_Tiempo As Integer
    Private m_FormatoDesc As String
    Private m_PartePaletContenidoID As Integer
    Private m_LineaID As Integer
    'mas campos
    Private m_CapacidadBotellasCajas As Integer
    Private m_CajasPalet As Integer
    Private m_NroCajasCompletar As Integer

    'mas campos ...
    Private m_EsPrimerPalet As Boolean

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
    Public Property Terminado() As Boolean
        Get
            Return m_Terminado
        End Get
        Set(ByVal value As Boolean)
            m_Terminado = value
        End Set
    End Property
    Public Property NroCajas() As Integer
        Get
            Return m_NroCajas
        End Get
        Set(ByVal value As Integer)
            m_NroCajas = value
        End Set
    End Property
    Public Property NroPalets() As Integer
        Get
            Return m_NroPalets
        End Get
        Set(ByVal value As Integer)
            m_NroPalets = value
        End Set
    End Property
    Public Property Velocidad() As Double
        Get
            Return m_Velocidad
        End Get
        Set(ByVal value As Double)
            m_Velocidad = value
        End Set
    End Property
    Public Property Tiempo() As Integer
        Get
            Return m_Tiempo
        End Get
        Set(ByVal value As Integer)
            m_Tiempo = value
        End Set
    End Property
    Public Property FormatoDescripcion() As String
        Get
            Return m_FormatoDesc
        End Get
        Set(ByVal value As String)
            m_FormatoDesc = value
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

    Public Property LineaID() As Integer
        Get
            Return m_LineaID
        End Get
        Set(ByVal value As Integer)
            m_LineaID = value
        End Set
    End Property


    Public Property CajasPalet() As Integer
        Get
            Return m_CajasPalet
        End Get
        Set(ByVal value As Integer)
            m_CajasPalet = value
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

    Public Property NroCajasCompletar() As Integer
        Get
            Return m_NroCajasCompletar
        End Get
        Set(ByVal value As Integer)
            m_NroCajasCompletar = value
        End Set
    End Property

    Public Property EsPrimerPalet() As Boolean
        Get
            Return m_EsPrimerPalet
        End Get
        Set(ByVal value As Boolean)
            m_EsPrimerPalet = value
        End Set
    End Property
#End Region
End Class
