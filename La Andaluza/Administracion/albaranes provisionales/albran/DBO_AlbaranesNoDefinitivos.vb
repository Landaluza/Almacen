Public Class DBO_AlbaranesNoDefinitivos
    Inherits DataBussines

    Private m_Id As DataBussinesParameter
    Private m_Numero As DataBussinesParameter
    Private m_Fecha As DataBussinesParameter
    Private m_ResponsableCargaID As DataBussinesParameter
    Private m_Observaciones As DataBussinesParameter
    Private m_Reserva1 As DataBussinesParameter
    Private m_Reserva2 As DataBussinesParameter
    Private m_Reserva3 As DataBussinesParameter
    Private m_e1 As DataBussinesParameter
    Private m_e2 As DataBussinesParameter
    Private m_e3 As DataBussinesParameter
    Private m_e4 As DataBussinesParameter
    Private m_e5 As DataBussinesParameter
    Private m_e6 As DataBussinesParameter
    Private m_h1 As DataBussinesParameter
    Private m_m1 As DataBussinesParameter
    Private m_m2 As DataBussinesParameter
    Private m_c1 As DataBussinesParameter
    Private m_c2 As DataBussinesParameter
    Private m_ObservacionControl As DataBussinesParameter

    Public Sub New()
        MyBase.New()
        m_Id = New DataBussinesParameter("@AlbaranCargaProMaestroID", "AlbaranCargaProMaestroID")
        m_Numero = New DataBussinesParameter("@Numero", "Numero")
        m_Fecha = New DataBussinesParameter("@Fecha", "Fecha")
        m_ResponsableCargaID = New DataBussinesParameter("@ResponsableCargaID", "ResponsableCargaID")
        m_Observaciones = New DataBussinesParameter("@Observaciones", "Observaciones")
        m_Reserva1 = New DataBussinesParameter("@Reserva1", "Reserva1")
        m_Reserva2 = New DataBussinesParameter("@Reserva2", "Reserva2")
        m_Reserva3 = New DataBussinesParameter("@Reserva3", "Reserva3")
        m_e1 = New DataBussinesParameter("@e1", "e1")
        m_e2 = New DataBussinesParameter("@e2", "e2")
        m_e3 = New DataBussinesParameter("@e3", "e3")
        m_e4 = New DataBussinesParameter("@e4", "e4")
        m_e5 = New DataBussinesParameter("@e5", "e5")
        m_e6 = New DataBussinesParameter("@e6", "e6")
        m_h1 = New DataBussinesParameter("@h1", "h1")
        m_m1 = New DataBussinesParameter("@m1", "m1")
        m_m2 = New DataBussinesParameter("@m2", "m2")
        m_c1 = New DataBussinesParameter("@c1", "c1")
        m_c2 = New DataBussinesParameter("@c2", "c2")
        m_ObservacionControl = New DataBussinesParameter("@ObservacionControl", "ObservacionControl")
        MyBase.primaryKey = m_Id
        añadirParametros()
    End Sub

   Public Property ID() As Integer
       Get
           if m_id.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id.value,integer)
       End Get
       Set(ByVal value As Integer)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Public Property Numero() As Integer
       Get
           if m_Numero.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Numero.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Numero.value = value
       End Set
   End Property

   Public Property Fecha() As DateTime
       Get
           if m_Fecha.value is convert.dbnull then
             Return nothing 
           End if
            Return CType(m_Fecha.value, Date)
       End Get
       Set(ByVal value As DateTime)
           m_Fecha.value = value
       End Set
   End Property

   Public Property ResponsableCargaID() As Integer
       Get
           if m_ResponsableCargaID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_ResponsableCargaID.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_ResponsableCargaID.value = value
       End Set
   End Property

   Public Property Observaciones() As String
       Get
           if m_Observaciones.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Observaciones.value,string)
       End Get
       Set(ByVal value As String)
           m_Observaciones.value = value
       End Set
   End Property

   Public Property Reserva1() As String
       Get
           if m_Reserva1.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Reserva1.value,string)
       End Get
       Set(ByVal value As String)
           m_Reserva1.value = value
       End Set
   End Property

   Public Property Reserva2() As String
       Get
           if m_Reserva2.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Reserva2.value,string)
       End Get
       Set(ByVal value As String)
           m_Reserva2.value = value
       End Set
   End Property

   Public Property Reserva3() As String
       Get
           if m_Reserva3.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Reserva3.value,string)
       End Get
       Set(ByVal value As String)
           m_Reserva3.value = value
       End Set
   End Property

   Public Property e1() As Boolean
       Get
           if m_e1.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_e1.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_e1.value = value
       End Set
   End Property

   Public Property e2() As Boolean
       Get
           if m_e2.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_e2.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_e2.value = value
       End Set
   End Property

   Public Property e3() As Boolean
       Get
           if m_e3.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_e3.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_e3.value = value
       End Set
   End Property

   Public Property e4() As Boolean
       Get
           if m_e4.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_e4.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_e4.value = value
       End Set
   End Property

   Public Property e5() As Boolean
       Get
           if m_e5.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_e5.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_e5.value = value
       End Set
   End Property

   Public Property e6() As Boolean
       Get
           if m_e6.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_e6.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_e6.value = value
       End Set
   End Property

   Public Property h1() As Boolean
       Get
           if m_h1.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_h1.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_h1.value = value
       End Set
   End Property

   Public Property m1() As Boolean
       Get
           if m_m1.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_m1.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_m1.value = value
       End Set
   End Property

   Public Property m2() As Boolean
       Get
           if m_m2.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_m2.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_m2.value = value
       End Set
   End Property

   Public Property c1() As Boolean
       Get
           if m_c1.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_c1.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_c1.value = value
       End Set
   End Property

   Public Property c2() As Boolean
       Get
           if m_c2.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_c2.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_c2.value = value
       End Set
   End Property

   Public Property ObservacionControl() As String
       Get
           if m_ObservacionControl.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_ObservacionControl.value,string)
       End Get
       Set(ByVal value As String)
           m_ObservacionControl.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Numero, m_Numero.sqlName)
       MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
       MyBase.atributos.Add(m_ResponsableCargaID, m_ResponsableCargaID.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_Reserva1, m_Reserva1.sqlName)
       MyBase.atributos.Add(m_Reserva2, m_Reserva2.sqlName)
       MyBase.atributos.Add(m_Reserva3, m_Reserva3.sqlName)
       MyBase.atributos.Add(m_e1, m_e1.sqlName)
       MyBase.atributos.Add(m_e2, m_e2.sqlName)
       MyBase.atributos.Add(m_e3, m_e3.sqlName)
       MyBase.atributos.Add(m_e4, m_e4.sqlName)
       MyBase.atributos.Add(m_e5, m_e5.sqlName)
       MyBase.atributos.Add(m_e6, m_e6.sqlName)
       MyBase.atributos.Add(m_h1, m_h1.sqlName)
       MyBase.atributos.Add(m_m1, m_m1.sqlName)
       MyBase.atributos.Add(m_m2, m_m2.sqlName)
       MyBase.atributos.Add(m_c1, m_c1.sqlName)
       MyBase.atributos.Add(m_c2, m_c2.sqlName)
       MyBase.atributos.Add(m_ObservacionControl, m_ObservacionControl.sqlName)
   End Sub
End Class
