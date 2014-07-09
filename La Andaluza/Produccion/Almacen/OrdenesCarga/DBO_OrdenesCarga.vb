Public Class DBO_OrdenesCarga

    Private m_OrdenCargaID As Int32
    Private m_Fecha As Date
    Private m_Ruta As String
    Private m_Observaciones As String
    Private m_FechaModificacion As Date
    Private m_UsuarioModificacion As Int32

    Public Sub New()

    End Sub

    Public Property OrdenCargaID() As Int32
        Get
            Return m_OrdenCargaID
        End Get
        Set(ByVal value As Int32)
            m_OrdenCargaID = value
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

   Public Property Ruta() As String
       Get
           Return m_Ruta
       End Get
       Set(ByVal value As String)
           m_Ruta = value
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

End Class
