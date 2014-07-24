Public Class DBO_AlbaranesCargaMaestroLinea
    Inherits DataBussines

    Private m_Id As DataBussinesParameter
    Private m_AlbaranCargaProviMaestroID As DataBussinesParameter
    Private m_SCC As DataBussinesParameter
    Private m_CodigoQS As DataBussinesParameter
    Private m_AticuloDescripcion As DataBussinesParameter
    Private m_Cajas As DataBussinesParameter
    Private m_UnidadMedidaID As DataBussinesParameter
    Private m_Lote As DataBussinesParameter
    Private m_TipoPaletID As DataBussinesParameter
    Private m_Observaciones As DataBussinesParameter
    Private m_Reserva1 As DataBussinesParameter
    Private m_Reserva2 As DataBussinesParameter
    Private m_Reserva3 As DataBussinesParameter
    Private m_LoteAlternativo As DataBussinesParameter

    Public Sub New()
        MyBase.New()
        m_Id = New DataBussinesParameter("@AlbaranCargaProviDetalleID", "AlbaranCargaProviDetalleID")
        m_AlbaranCargaProviMaestroID = New DataBussinesParameter("@AlbaranCargaProviMaestroID", "AlbaranCargaProviMaestroID")
        m_SCC = New DataBussinesParameter("@SCC", "SCC")
        m_CodigoQS = New DataBussinesParameter("@CodigoQS", "CodigoQS")
        m_AticuloDescripcion = New DataBussinesParameter("@AticuloDescripcion", "AticuloDescripcion")
        m_Cajas = New DataBussinesParameter("@Cajas", "Cajas")
        m_UnidadMedidaID = New DataBussinesParameter("@UnidadMedidaID", "UnidadMedidaID")
        m_Lote = New DataBussinesParameter("@Lote", "Lote")
        m_TipoPaletID = New DataBussinesParameter("@TipoPaletID", "TipoPaletID")
        m_Observaciones = New DataBussinesParameter("@Observaciones", "Observaciones")
        m_Reserva1 = New DataBussinesParameter("@Reserva1", "Reserva1")
        m_Reserva2 = New DataBussinesParameter("@Reserva2", "Reserva2")
        m_Reserva3 = New DataBussinesParameter("@Reserva3", "Reserva3")
        m_LoteAlternativo = New DataBussinesParameter("@LoteAlternativo", "LoteAlternativo")
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

   Public Property AlbaranCargaProviMaestroID() As Integer
       Get
           if m_AlbaranCargaProviMaestroID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_AlbaranCargaProviMaestroID.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_AlbaranCargaProviMaestroID.value = value
       End Set
   End Property

   Public Property SCC() As Integer
       Get
           if m_SCC.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_SCC.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_SCC.value = value
       End Set
   End Property

   Public Property CodigoQS() As Integer
       Get
           if m_CodigoQS.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_CodigoQS.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_CodigoQS.value = value
       End Set
   End Property

   Public Property AticuloDescripcion() As String
       Get
           if m_AticuloDescripcion.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_AticuloDescripcion.value,string)
       End Get
       Set(ByVal value As String)
           m_AticuloDescripcion.value = value
       End Set
   End Property

   Public Property Cajas() As Integer
       Get
           if m_Cajas.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Cajas.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Cajas.value = value
       End Set
   End Property

   Public Property UnidadMedidaID() As Integer
       Get
           if m_UnidadMedidaID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_UnidadMedidaID.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_UnidadMedidaID.value = value
       End Set
   End Property

   Public Property Lote() As String
       Get
           if m_Lote.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Lote.value,string)
       End Get
       Set(ByVal value As String)
           m_Lote.value = value
       End Set
   End Property

   Public Property TipoPaletID() As Integer
       Get
           if m_TipoPaletID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_TipoPaletID.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_TipoPaletID.value = value
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

   Public Property LoteAlternativo() As String
       Get
           if m_LoteAlternativo.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_LoteAlternativo.value,string)
       End Get
       Set(ByVal value As String)
           m_LoteAlternativo.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_AlbaranCargaProviMaestroID, m_AlbaranCargaProviMaestroID.sqlName)
       MyBase.atributos.Add(m_SCC, m_SCC.sqlName)
       MyBase.atributos.Add(m_CodigoQS, m_CodigoQS.sqlName)
       MyBase.atributos.Add(m_AticuloDescripcion, m_AticuloDescripcion.sqlName)
       MyBase.atributos.Add(m_Cajas, m_Cajas.sqlName)
       MyBase.atributos.Add(m_UnidadMedidaID, m_UnidadMedidaID.sqlName)
       MyBase.atributos.Add(m_Lote, m_Lote.sqlName)
       MyBase.atributos.Add(m_TipoPaletID, m_TipoPaletID.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_Reserva1, m_Reserva1.sqlName)
       MyBase.atributos.Add(m_Reserva2, m_Reserva2.sqlName)
       MyBase.atributos.Add(m_Reserva3, m_Reserva3.sqlName)
       MyBase.atributos.Add(m_LoteAlternativo, m_LoteAlternativo.sqlName)
   End Sub
End Class
