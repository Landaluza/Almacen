Public Class DBO_PaletsTipos
Inherits DataBussines

   Private m_Id As DataBussinesParameter
   Private m_Descripcion As DataBussinesParameter
   Private m_CodigoQS As DataBussinesParameter
   Private m_Largo As DataBussinesParameter
   Private m_Ancho As DataBussinesParameter
   Private m_Alto As DataBussinesParameter
   Private m_Peso As DataBussinesParameter
   Private m_Material As DataBussinesParameter
   Private m_Tratado As DataBussinesParameter
   Private m_Alias As DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New DataBussinesParameter("@PaletTipoID","PaletTipoID")
       m_Descripcion= New DataBussinesParameter("@Descripcion","Descripcion")
       m_CodigoQS= New DataBussinesParameter("@CodigoQS","CodigoQS")
       m_Largo= New DataBussinesParameter("@Largo","Largo")
       m_Ancho= New DataBussinesParameter("@Ancho","Ancho")
       m_Alto= New DataBussinesParameter("@Alto","Alto")
       m_Peso= New DataBussinesParameter("@Peso","Peso")
       m_Material= New DataBussinesParameter("@Material","Material")
       m_Tratado= New DataBussinesParameter("@Tratado","Tratado")
       m_Alias= New DataBussinesParameter("@Alias","Alias")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub

   Public Property ID() As Int32
       Get
           if m_id.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id.value,int32)
       End Get
       Set(ByVal value As Int32)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Public Property Descripcion() As String
       Get
           if m_Descripcion.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Descripcion.value,string)
       End Get
       Set(ByVal value As String)
           m_Descripcion.value = value
       End Set
   End Property

   Public Property CodigoQS() As Int32
       Get
           if m_CodigoQS.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_CodigoQS.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_CodigoQS.value = value
       End Set
   End Property

    Public Property Largo() As Double
        Get
            If m_Largo.value Is Convert.DBNull Then
                Return 0
            End If
            Return CType(m_Largo.value, Double)
        End Get
        Set(ByVal value As Double)
            m_Largo.value = value
        End Set
    End Property

    Public Property Ancho() As Double
        Get
            If m_Ancho.value Is Convert.DBNull Then
                Return 0
            End If
            Return CType(m_Ancho.value, Double)
        End Get
        Set(ByVal value As Double)
            m_Ancho.value = value
        End Set
    End Property

    Public Property Alto() As Double
        Get
            If m_Alto.value Is Convert.DBNull Then
                Return 0
            End If
            Return CType(m_Alto.value, Double)
        End Get
        Set(ByVal value As Double)
            m_Alto.value = value
        End Set
    End Property

    Public Property Peso() As Double
        Get
            If m_Peso.value Is Convert.DBNull Then
                Return 0
            End If
            Return CType(m_Peso.value, Double)
        End Get
        Set(ByVal value As Double)
            m_Peso.value = value
        End Set
    End Property

   Public Property Material() As String
       Get
           if m_Material.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Material.value,string)
       End Get
       Set(ByVal value As String)
           m_Material.value = value
       End Set
   End Property

   Public Property Tratado() As Boolean
       Get
           if m_Tratado.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_Tratado.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_Tratado.value = value
       End Set
   End Property

    Public Property Aliass() As String
        Get
            If m_Alias.value Is convert.dbnull Then
                Return String.empty
            End If
            Return CType(m_Alias.value, String)
        End Get
        Set(ByVal value As String)
            m_Alias.value = value
        End Set
    End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_CodigoQS, m_CodigoQS.sqlName)
       MyBase.atributos.Add(m_Largo, m_Largo.sqlName)
       MyBase.atributos.Add(m_Ancho, m_Ancho.sqlName)
       MyBase.atributos.Add(m_Alto, m_Alto.sqlName)
       MyBase.atributos.Add(m_Peso, m_Peso.sqlName)
       MyBase.atributos.Add(m_Material, m_Material.sqlName)
       MyBase.atributos.Add(m_Tratado, m_Tratado.sqlName)
       MyBase.atributos.Add(m_Alias, m_Alias.sqlName)
   End Sub
End Class
