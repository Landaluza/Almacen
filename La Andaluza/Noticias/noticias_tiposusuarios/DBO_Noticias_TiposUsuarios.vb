Public Class DBO_Noticias_TiposUsuarios
Inherits DataBussines

   Private m_Id As DataBussinesParameter
   Private m_Id_noticia As DataBussinesParameter
   Private m_Id_tipoUsuario As DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New DataBussinesParameter("@Id","Id")
       m_Id_noticia= New DataBussinesParameter("@Id_noticia","Id_noticia")
       m_Id_tipoUsuario= New DataBussinesParameter("@Id_tipoUsuario","Id_tipoUsuario")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub


   Public Property ID() As Int32
       Get
            Return if(Convert.IsDBNull(m_id.value), Nothing, Convert.ToInt32(m_Id.value))
        End Get
        Set(ByVal value As Int32)
            Me.primaryKey.value = value
            m_id.value = value
        End Set
    End Property

    Public Property Id_noticia() As Int32
        Get
            Return If(Convert.IsDBNull(m_Id_noticia.value), Nothing, Convert.ToInt32(m_Id_noticia.value))
        End Get
        Set(ByVal value As Int32)
            m_Id_noticia.value = value
        End Set
    End Property

    Public Property Id_tipoUsuario() As Int32
        Get
            Return If(Convert.IsDBNull(m_Id_tipoUsuario.value), Nothing, Convert.ToInt32(m_Id_tipoUsuario.value))
        End Get
        Set(ByVal value As Int32)
            m_Id_tipoUsuario.value = value
        End Set
    End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_noticia, m_Id_noticia.sqlName)
       MyBase.atributos.Add(m_Id_tipoUsuario, m_Id_tipoUsuario.sqlName)
   End Sub
End Class
