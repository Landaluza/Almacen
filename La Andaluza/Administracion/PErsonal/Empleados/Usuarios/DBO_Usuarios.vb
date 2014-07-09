Public Class DBO_Usuarios
Inherits DataBussines

   Private m_Id As DataBussinesParameter
   Private m_Usuario As DataBussinesParameter
   Private m_TipoUsuarioID As DataBussinesParameter
   Private m_email As DataBussinesParameter
   Private m_pass As DataBussinesParameter
   Private m_servidorDeCorreo As DataBussinesParameter
   Private m_cryptedPassword As DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New DataBussinesParameter("@UsuarioID","UsuarioID")
       m_Usuario= New DataBussinesParameter("@Usuario","Usuario")
       m_TipoUsuarioID= New DataBussinesParameter("@TipoUsuarioID","TipoUsuarioID")
       m_email= New DataBussinesParameter("@email","email")
       m_pass= New DataBussinesParameter("@pass","pass")
       m_servidorDeCorreo= New DataBussinesParameter("@servidorDeCorreo","servidorDeCorreo")
       m_cryptedPassword= New DataBussinesParameter("@cryptedPassword","cryptedPassword")
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

   Public Property Usuario() As String
       Get
            Return If(IsDBNull(m_Usuario.value), String.Empty, m_Usuario.value.ToString)
       End Get
       Set(ByVal value As String)
           m_Usuario.value = value
       End Set
   End Property

   Public Property TipoUsuarioID() As Int32
       Get
            Return If(IsDBNull(m_TipoUsuarioID.value), Nothing, Convert.ToInt32(m_TipoUsuarioID.value))
       End Get
       Set(ByVal value As Int32)
           m_TipoUsuarioID.value = value
       End Set
   End Property

   Public Property email() As String
       Get
            Return If(IsDBNull(m_email.value), String.Empty, m_email.value.ToString)
       End Get
       Set(ByVal value As String)
           m_email.value = value
       End Set
   End Property

   Public Property pass() As String
       Get
            Return If(IsDBNull(m_pass.value), String.Empty, m_pass.value.ToString)
       End Get
       Set(ByVal value As String)
           m_pass.value = value
       End Set
   End Property

   Public Property servidorDeCorreo() As String
       Get
            Return If(IsDBNull(m_servidorDeCorreo.value), String.Empty, m_servidorDeCorreo.value.ToString)
       End Get
       Set(ByVal value As String)
           m_servidorDeCorreo.value = value
       End Set
   End Property

   Public Property cryptedPassword() As String
       Get
            Return If(IsDBNull(m_cryptedPassword.value), String.Empty, m_cryptedPassword.value.ToString)
       End Get
       Set(ByVal value As String)
           m_cryptedPassword.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Usuario, m_Usuario.sqlName)
       MyBase.atributos.Add(m_TipoUsuarioID, m_TipoUsuarioID.sqlName)
       MyBase.atributos.Add(m_email, m_email.sqlName)
       MyBase.atributos.Add(m_pass, m_pass.sqlName)
       MyBase.atributos.Add(m_servidorDeCorreo, m_servidorDeCorreo.sqlName)
       MyBase.atributos.Add(m_cryptedPassword, m_cryptedPassword.sqlName)
   End Sub
End Class
