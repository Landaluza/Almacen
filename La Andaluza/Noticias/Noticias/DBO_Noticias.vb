Public Class DBO_Noticias
Inherits DataBussines

   Private m_Id As DataBussinesParameter
   Private m_Titulo As DataBussinesParameter
   Private m_Texto As DataBussinesParameter
   Private m_Fecha As DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New DataBussinesParameter("@Id","Id")
       m_Titulo= New DataBussinesParameter("@Titulo","Titulo")
       m_Texto= New DataBussinesParameter("@Texto","Texto")
       m_Fecha= New DataBussinesParameter("@Fecha","Fecha")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub


   Public Property ID() As Int32
       Get
            Return If(Convert.IsDBNull(m_Id.value), Nothing, Convert.ToInt32(m_Id.value))
        End Get
        Set(ByVal value As Int32)
            Me.primaryKey.value = value
            m_id.value = value
        End Set
    End Property

    Public Property Titulo() As String
        Get
            Return If(Convert.IsDBNull(m_Titulo.value), String.Empty, m_Titulo.value.ToString)
        End Get
        Set(ByVal value As String)
            m_Titulo.value = value
        End Set
    End Property

    Public Property Texto() As String
        Get
            Return If(Convert.IsDBNull(m_Texto.value), String.Empty, m_Texto.value.ToString)
        End Get
        Set(ByVal value As String)
            m_Texto.value = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return If(Convert.IsDBNull(m_Fecha.value), DateTime.Now.Date, CDate(m_Fecha.value))
        End Get
        Set(ByVal value As Date)
            m_Fecha.value = value
        End Set
    End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Titulo, m_Titulo.sqlName)
       MyBase.atributos.Add(m_Texto, m_Texto.sqlName)
       MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
   End Sub
End Class
