Public Class DBO_PaletsAlmacenEntradas


   Private m_PaletAlmacenEntradaID As Int32
   Private m_SSCC As String
    Private m_Fecha As Date
   Private m_Articulo As String
   Private m_Cajas As Nullable(Of Int32)
   Private m_ComentariosCarga As String
   Private m_Observaciones As String
   Private m_Vigente As Boolean
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32


   Public Sub New()

   End Sub


   Public Property PaletAlmacenEntradaID() As Int32
       Get
           Return m_PaletAlmacenEntradaID
       End Get
       Set(ByVal value As Int32)
           m_PaletAlmacenEntradaID = value
       End Set
   End Property

   Public Property SSCC() As String
       Get
           Return m_SSCC
       End Get
       Set(ByVal value As String)
           m_SSCC = value
       End Set
   End Property

    Public Property Fecha() As Date
        Get
            Return m_Fecha
        End Get
        Set(ByVal value As Date)
            m_Fecha = value
        End Set
    End Property

   Public Property Articulo() As String
       Get
           Return m_Articulo
       End Get
       Set(ByVal value As String)
           m_Articulo = value
       End Set
   End Property

   Public Property Cajas() As Nullable(Of Int32)
       Get
           Return m_Cajas
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_Cajas = value
       End Set
   End Property

   Public Property ComentariosCarga() As String
       Get
           Return m_ComentariosCarga
       End Get
       Set(ByVal value As String)
           m_ComentariosCarga = value
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

   Public Property Vigente() As Boolean
       Get
           Return m_Vigente
       End Get
       Set(ByVal value As Boolean)
           m_Vigente = value
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


End Class
