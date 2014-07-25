Public Class ctlAlbaranesCargaProviDetalles
    Private clsAlbDet As clsAlbaranesCargaProviDetalles

    Public Sub New()
        clsAlbDet = New clsAlbaranesCargaProviDetalles
    End Sub
    Public Function GetAlbaranCargaProviDetalleID() As Integer
        Return clsAlbDet._AlbaranCargaProviDetalleID
    End Function

    Public Sub SetAlbaranCargaProviDetalleID(ByVal ID As Integer)
        clsAlbDet._AlbaranCargaProviDetalleID = ID
    End Sub

    Public Function GuardarAlbaranCargaProviDetalle( _
               ByVal AlbaranCargaProviMaestroID As Integer, _
               ByVal SCC As Integer, _
               ByVal CodigoQS As Integer, _
               ByVal AticuloDescripcion As String, _
               ByVal Cajas As Integer, _
               ByVal UnidadMedidaID As Integer, _
               ByVal Lote As String, _
               ByVal TipoPaletID As Integer, _
               ByVal Observaciones As String, _
               ByVal Reserva1 As String, _
               ByVal Reserva2 As String, _
               ByVal Reserva3 As String,
               ByVal LoteAlternativo As String, ByRef dtb As DataBase) As Boolean

        clsAlbDet = New clsAlbaranesCargaProviDetalles
        clsAlbDet._AlbaranCargaProviMaestroID = AlbaranCargaProviMaestroID
        clsAlbDet._SCC = SCC
        clsAlbDet._CodigoQS = CodigoQS
        clsAlbDet._AticuloDescripcion = AticuloDescripcion
        clsAlbDet._Cajas = Cajas
        clsAlbDet._UnidadMedidaID = UnidadMedidaID

        If Lote.Contains(",") Then
            Dim axu As String() = Lote.Replace("Multilote:", "").Split(","c)
            Lote = axu(1)
        End If

        clsAlbDet._Lote = Lote
        clsAlbDet._TipoPaletID = TipoPaletID
        clsAlbDet._Observaciones = Observaciones
        clsAlbDet._Reserva1 = Reserva1
        clsAlbDet._Reserva2 = Reserva2
        clsAlbDet._Reserva3 = Reserva3
        clsAlbDet._LoteAlternativo = LoteAlternativo

        Try
            If Not dtb.ConsultaAlteraciones( _
                "insert into AlbaranesCargaProviDetalles ([AlbaranCargaProviMaestroID],[SCC] ,[CodigoQS] ,[AticuloDescripcion] ,[Cajas] ,[UnidadMedidaID] ,[Lote],[TipoPaletID] ,[Observaciones] ,[Reserva1] ,[Reserva2] ,[Reserva3], LoteAlternativo, FechaModificacion, UsuarioModificacion)" & _
                       "values(" & Convert.ToString(AlbaranCargaProviMaestroID) & "," & _
                       "" & Convert.ToString(SCC) & "," & _
                       "" & Convert.ToString(CodigoQS) & "," & _
                       "'" & AticuloDescripcion & "'," & _
                       "" & Convert.ToString(Cajas) & "," & _
                       "" & Convert.ToString(UnidadMedidaID) & "," & _
                       "'" & Lote & "'," & _
                       "" & Convert.ToString(TipoPaletID) & "," & _
                       "'" & Observaciones & "'," & _
                       "'" & Reserva1 & "'," & _
                       "'" & Reserva2 & "'," & _
                       "'" & Reserva3 & "'," & _
                       "'" & LoteAlternativo & "'," & _
                       "CURRENT_TIMESTAMP," & _
                       "" & Config.User & "" & _
                       ")") Then Return False
            clsAlbDet._AlbaranCargaProviDetalleID = Convert.ToInt32(dtb.Consultar("select max(AlbaranCargaProviDetalleID) from AlbaranesCargaProviDetalles", False).Rows(0).Item(0))
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
