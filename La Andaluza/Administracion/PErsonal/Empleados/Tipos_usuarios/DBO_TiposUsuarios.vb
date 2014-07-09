Public Class DBO_TiposUsuarios
Inherits DataBussines

   Private m_Id As DataBussinesParameter
   Private m_Descripcion As DataBussinesParameter
   Private m_permisos As DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New DataBussinesParameter("@TipoUsuarioID","TipoUsuarioID")
       m_Descripcion= New DataBussinesParameter("@Descripcion","Descripcion")
       m_permisos= New DataBussinesParameter("@permisos","permisos")
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

   Public Property Descripcion() As String
       Get
            Return If(IsDBNull(m_Descripcion.value), String.Empty, m_Descripcion.value.ToString)
       End Get
       Set(ByVal value As String)
           m_Descripcion.value = value
       End Set
   End Property

   Public Property permisos() As Int32
       Get
            Return If(IsDBNull(m_permisos.value), Nothing, Convert.ToInt32(m_permisos.value))
       End Get
       Set(ByVal value As Int32)
           m_permisos.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_permisos, m_permisos.sqlName)
   End Sub
End Class
