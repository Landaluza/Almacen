Public Class DBO_OrdenesCargaDetalles

    Private m_id As Int32
    Private m_id_OrdenCarga As Int32
    Private m_descripcion As String
    Private m_observaciones As String
    Private m_palets As Integer
    Private m_pico As Integer
    Private m_cargaPicos As String
    Private m_cargaPicosSCC As String
    Private m_paletsCarga As Integer
    Private m_carga As Integer
    Private m_cargaSinPedidos As Integer
    Private m_FechaModificacion As Date
    Private m_UsuarioModificacion As Int32
    Private m_id_tipoFormato As Int32

    Public Sub New()

    End Sub

    Public Property ID() As Int32
        Get
            Return m_id
        End Get
        Set(ByVal value As Int32)
            m_id = value
        End Set
    End Property

    Public Property carga() As Int32
        Get
            Return m_carga
        End Get
        Set(ByVal value As Int32)
            m_carga = value
        End Set
    End Property

    Public Property id_tipoFormato() As Int32
        Get
            Return m_id_tipoFormato
        End Get
        Set(ByVal value As Int32)
            m_id_tipoFormato = value
        End Set
    End Property

    Public Property Id_OrdenCarga() As Int32
        Get
            Return m_id_OrdenCarga
        End Get
        Set(ByVal value As Int32)
            m_id_OrdenCarga = value
        End Set
    End Property

    Public Property Palets() As Int32
        Get
            Return m_palets
        End Get
        Set(ByVal value As Int32)
            m_palets = value
        End Set
    End Property

    Public Property Pico() As Int32
        Get
            Return m_pico
        End Get
        Set(ByVal value As Int32)
            m_pico = value
        End Set
    End Property

    Public Property CargaSinPedidos() As Int32
        Get
            Return m_cargaSinPedidos
        End Get
        Set(ByVal value As Int32)
            m_cargaSinPedidos = value
        End Set
    End Property

    Public Property PaletsCarga() As Int32
        Get
            Return m_paletsCarga
        End Get
        Set(ByVal value As Int32)
            m_paletsCarga = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return m_descripcion
        End Get
        Set(ByVal value As String)
            m_descripcion = value
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

    Public Property cargaPicos() As String
        Get
            Return m_cargaPicos
        End Get
        Set(ByVal value As String)
            m_cargaPicos = value
        End Set
    End Property

    Public Property cargaPicosSCC() As String
        Get
            Return m_cargaPicosSCC
        End Get
        Set(ByVal value As String)
            m_cargaPicosSCC = value
        End Set
    End Property
End Class

