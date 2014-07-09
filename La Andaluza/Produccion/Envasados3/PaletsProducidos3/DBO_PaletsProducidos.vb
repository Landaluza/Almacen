Public Class DBO_PaletsProducidos
Inherits DataBussines

   Private m_Id As DataBussinesParameter
   Private m_SCC As DataBussinesParameter
   Private m_FormatoID As DataBussinesParameter
   Private m_ObservacionesPalets As DataBussinesParameter
   Private m_Terminado As DataBussinesParameter
   Private m_EnAlmacen As DataBussinesParameter
   Private m_Id_Estado As DataBussinesParameter
   Private m_Multilote As DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New DataBussinesParameter("@PaletProducidoID","PaletProducidoID")
       m_SCC= New DataBussinesParameter("@SCC","SCC")
       m_FormatoID= New DataBussinesParameter("@FormatoID","FormatoID")
       m_ObservacionesPalets= New DataBussinesParameter("@ObservacionesPalets","ObservacionesPalets")
       m_Terminado= New DataBussinesParameter("@Terminado","Terminado")
       m_EnAlmacen= New DataBussinesParameter("@EnAlmacen","EnAlmacen")
       m_Id_Estado= New DataBussinesParameter("@Id_Estado","Id_Estado")
       m_Multilote= New DataBussinesParameter("@Multilote","Multilote")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub


   Public Property ID() As Int32
       Get
            Return If(IsDBNull(m_Id.value), Nothing, Convert.ToInt32(m_Id.value))
       End Get
       Set(ByVal value As Int32)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Public Property SCC() As Int32
       Get
            Return If(IsDBNull(m_SCC.value), Nothing, Convert.ToInt32(m_SCC.value))
       End Get
       Set(ByVal value As Int32)
           m_SCC.value = value
       End Set
   End Property

   Public Property FormatoID() As Int32
       Get
            Return If(IsDBNull(m_FormatoID.value), Nothing, Convert.ToInt32(m_FormatoID.value))
       End Get
       Set(ByVal value As Int32)
           m_FormatoID.value = value
       End Set
   End Property

   Public Property ObservacionesPalets() As String
       Get
            Return If(IsDBNull(m_ObservacionesPalets.value), String.Empty, m_ObservacionesPalets.ToString)
       End Get
       Set(ByVal value As String)
           m_ObservacionesPalets.value = value
       End Set
   End Property

   Public Property Terminado() As Boolean
       Get
            Return If(IsDBNull(m_Terminado.value), False, Convert.ToBoolean(m_Terminado.value))
       End Get
       Set(ByVal value As Boolean)
           m_Terminado.value = value
       End Set
   End Property

   Public Property EnAlmacen() As Boolean
       Get
            Return If(IsDBNull(m_EnAlmacen.value), False, Convert.ToBoolean(m_EnAlmacen.value))
       End Get
       Set(ByVal value As Boolean)
           m_EnAlmacen.value = value
       End Set
   End Property

   Public Property Id_Estado() As Int32
       Get
            Return If(IsDBNull(m_Id_Estado.value), Nothing, Convert.ToInt32(m_Id_Estado.value))
       End Get
       Set(ByVal value As Int32)
           m_Id_Estado.value = value
       End Set
   End Property

   Public Property Multilote() As Boolean
       Get
            Return If(IsDBNull(m_Multilote.value), False, Convert.ToBoolean(m_Multilote.value))
       End Get
       Set(ByVal value As Boolean)
           m_Multilote.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_SCC, m_SCC.sqlName)
       MyBase.atributos.Add(m_FormatoID, m_FormatoID.sqlName)
       MyBase.atributos.Add(m_ObservacionesPalets, m_ObservacionesPalets.sqlName)
       MyBase.atributos.Add(m_Terminado, m_Terminado.sqlName)
       MyBase.atributos.Add(m_EnAlmacen, m_EnAlmacen.sqlName)
       MyBase.atributos.Add(m_Id_Estado, m_Id_Estado.sqlName)
       MyBase.atributos.Add(m_Multilote, m_Multilote.sqlName)
   End Sub
End Class
