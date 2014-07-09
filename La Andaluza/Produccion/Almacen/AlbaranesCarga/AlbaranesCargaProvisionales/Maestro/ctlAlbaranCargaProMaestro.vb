Public Class ctlAlbaranCargaProMaestro
    Private clsAlb As clsAlbaranCargaProMaestro


    Private Function GuardarAlbaranCargaProMaestro( _
               ByVal Numero As Integer, _
               ByVal Fecha As DateTime, _
               ByVal ResponsableCargaID As Integer, _
               ByVal Observaciones As String, _
               ByVal Reserva1 As String, _
               ByVal Reserva2 As String, _
               ByVal Reserva3 As String, _
               ByVal codigoPedido As Integer, _
               ByVal ordenCarga As Integer, ByRef dtb As DataBase) As Boolean

        clsAlb = New clsAlbaranCargaProMaestro
        clsAlb._Numero = Numero
        clsAlb._Fecha = Fecha
        clsAlb._ResponsableCargaID = ResponsableCargaID
        clsAlb._Observaciones = Observaciones
        clsAlb._Reserva1 = Reserva1
        clsAlb._Reserva2 = Reserva2
        clsAlb._Reserva3 = Reserva3
        clsAlb._CodigoPedidoMaestro = codigoPedido
        clsAlb._OrdenCarga = ordenCarga



        If Not dtb.ConsultaAlteraciones("insert into AlbaranCargaProMaestro" & _
                    "([Numero] ,[Fecha],[ResponsableCargaID] ,[Observaciones] ,[Reserva1] ,[Reserva2] ,[Reserva3] ,[FechaModificacion] ,[UsuarioModificacion] ) values(" & _
                   "" & Convert.ToString(Numero) & "," & _
                   "'" & Calendar.ArmarFecha(Fecha.Date) & "'," & _
                   "" & Convert.ToString(ResponsableCargaID) & "," & _
                   "'" & Observaciones & "'," & _
                   "'" & Reserva1 & "'," & _
                   "'" & Reserva2 & "'," & _
                    "'" & Reserva3 & "'," & _
                    "CURRENT_TIMESTAMP," & _
                    "" & Config.User & ")") Then Return False
        Try
            clsAlb._AlbaranCargaProMaestroID = Convert.ToInt32(dtb.Consultar("select max(AlbaranCargaProMaestroID) from AlbaranCargaProMaestro", False).Rows(0).Item(0))

            If clsAlb._CodigoPedidoMaestro <> 0 Then
                If Not dtb.ConsultaAlteraciones("update PedidosClientesMaestros set " & _
                          "id_albaranCargaProMaestro= " & Convert.ToString(clsAlb._AlbaranCargaProMaestroID) & "" & _
                          "where PedidoClienteMaestroID=" & Convert.ToString(clsAlb._CodigoPedidoMaestro)) Then Return False
            Else
                If Not dtb.ConsultaAlteraciones("update OrdenesCarga set " & _
                       "id_albaranCargaProMaestro=" & Convert.ToString(clsAlb._AlbaranCargaProMaestroID) & "" & _
                       "where OrdenCargaID=" & Convert.ToString(clsAlb._OrdenCarga)) Then Return False
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function GuardarAlbaranCargaProMaestroParaPedido( _
              ByVal Numero As Integer, _
              ByVal Fecha As DateTime, _
              ByVal ResponsableCargaID As Integer, _
              ByVal Observaciones As String, _
              ByVal Reserva1 As String, _
              ByVal Reserva2 As String, _
              ByVal Reserva3 As String, _
              ByVal codigoPedido As Integer, ByRef dtb As DataBase) As Boolean

        Return GuardarAlbaranCargaProMaestro(Numero, _
               Fecha, _
               ResponsableCargaID, _
               Observaciones, _
               Reserva1, _
               Reserva2, _
               Reserva3, _
               codigoPedido, Nothing, dtb)
    End Function

    Public Function GuardarAlbaranCargaProMaestroParaOrdenCarga( _
              ByVal Numero As Integer, _
              ByVal Fecha As DateTime, _
              ByVal ResponsableCargaID As Integer, _
              ByVal Observaciones As String, _
              ByVal Reserva1 As String, _
              ByVal Reserva2 As String, _
              ByVal Reserva3 As String, _
              ByVal ordenCarga As Integer, ByRef dtb As DataBase) As Boolean

        Return GuardarAlbaranCargaProMaestro(Numero, _
               Fecha, _
               ResponsableCargaID, _
               Observaciones, _
               Reserva1, _
               Reserva2, _
               Reserva3, _
               Nothing, ordenCarga, dtb)
    End Function

End Class
