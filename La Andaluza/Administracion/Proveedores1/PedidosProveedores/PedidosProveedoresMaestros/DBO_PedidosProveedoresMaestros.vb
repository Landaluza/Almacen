Public Class DBO_PedidosProveedoresMaestros

   Private m_PedidoProveedorMaestroID As Int32
   Private m_Numero As Int32
   Private m_ProveedorID As Int32
    Private m_FechaEmision As Date
    Private m_FechaServicio As Date
   Private m_EstadoID As Int32
   Private m_Observaciones As String
   Private m_Observaciones_IsDBNull As Boolean
   Private m_SolicitanteID As Int32
   Private m_PedidosProveedoresEstados_PedidoProveedorEstadoID As Int32

   Public Sub New()

   End Sub

   Public Property PedidoProveedorMaestroID() As Int32
       Get
           Return m_PedidoProveedorMaestroID
       End Get
       Set(ByVal value As Int32)
           m_PedidoProveedorMaestroID = value
       End Set
   End Property

   Public Property Numero() As Int32
       Get
           Return m_Numero
       End Get
       Set(ByVal value As Int32)
           m_Numero = value
       End Set
   End Property

   Public Property ProveedorID() As Int32
       Get
           Return m_ProveedorID
       End Get
       Set(ByVal value As Int32)
           m_ProveedorID = value
       End Set
   End Property

    Public Property FechaEmision() As Date
        Get
            Return m_FechaEmision
        End Get
        Set(ByVal value As Date)
            m_FechaEmision = value
        End Set
    End Property

    Public Property FechaServicio() As Date
        Get
            Return m_FechaServicio
        End Get
        Set(ByVal value As Date)
            m_FechaServicio = value
        End Set
    End Property

   Public Property EstadoID() As Int32
       Get
           Return m_EstadoID
       End Get
       Set(ByVal value As Int32)
           m_EstadoID = value
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

   Public Property Observaciones_IsDBNull() As Boolean
       Get
           Return m_Observaciones_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_Observaciones_IsDBNull = value
       End Set
   End Property

   Public Property SolicitanteID() As Int32
       Get
           Return m_SolicitanteID
       End Get
       Set(ByVal value As Int32)
           m_SolicitanteID = value
       End Set
   End Property

   Public Property PedidosProveedoresEstados_PedidoProveedorEstadoID() As Int32
       Get
           Return m_PedidosProveedoresEstados_PedidoProveedorEstadoID
       End Get
       Set(ByVal value As Int32)
           m_PedidosProveedoresEstados_PedidoProveedorEstadoID = value
       End Set
   End Property

End Class
