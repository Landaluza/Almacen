

Public Class spAlbaranesCarga
    Private dtb As DataBase

    Public Sub New()
        dtb = New DataBase(Config.Server)
    End Sub
    Public Function spDeleteAlbaranCargaSeguridadAllPedido(ByVal pedido As Integer, ByRef transactDtb As DataBase) As Boolean
        Return spDeleteAlbaranCargaSeguridadAll(pedido, Nothing, transactDtb)
    End Function

    Public Function spDeleteAlbaranCargaSeguridadAllOrdenCarga(ByVal OrdenCarga As Integer, ByRef transactDtb As DataBase) As Boolean
        Return spDeleteAlbaranCargaSeguridadAll(Nothing, OrdenCarga, transactDtb)
    End Function

    Public Function spDeleteAlbaranCargaSeguridad(ByVal ValorSCC As Integer) As Boolean

        Try
            Return dtb.ConsultaAlteraciones("DeleteAlbaranCargaSeguridad " & ValorSCC)
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Function spDeleteAlbaranCargaSeguridadAll(ByVal pedido As Integer, ByVal ordenCarga As Integer, ByRef transactDtb As DataBase) As Boolean
        If ordenCarga = Nothing Then
            transactDtb.Conectar()
            Try
                Dim cmd As System.Data.SqlClient.SqlCommand = transactDtb.Comando("DeleteAlbaranCargaSeguridadAllPedido")
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@pedido", pedido)

                cmd.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                MessageBox.Show("Error en BD.spDeleteAlbaranCargaSeguridadAllPedido" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                transactDtb.Desconectar()
            End Try
        Else
            dtb.Conectar()
            Try
                Dim cmd As System.Data.SqlClient.SqlCommand = transactDtb.Comando("DeleteAlbaranCargaSeguridadAllOC")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@orden", pedido)

                cmd.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                MessageBox.Show("Error en BD.spDeleteAlbaranCargaSeguridadAllOC" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                transactDtb.Desconectar()
            End Try
        End If
    End Function

    Public Function spInsertAlbaranCargaSeguridad(ByVal ValorSCC As Integer, _
                                           ByVal ValorCodigoQS As Integer, _
                                           ByVal ValorArticuloDescripcion As String, _
                                           ByVal ValorCajas As Integer, _
                                           ByVal ValorUnidadMedidaID As Integer, _
                                           ByVal ValorLote As String, _
                                           ByVal ValorTipoPaletID As Integer, _
                                           ByVal Peso As String, _
                                           ByVal ValorObservaciones As String, _
                                           ByVal ValorReserva1 As String, _
                                           ByVal ValorReserva2 As String, _
                                           ByVal ValorReserva3 As String, _
                                           ByVal ValorFechaModificacion As Date, _
                                           ByVal ValorUsuarioModificacion As Integer, _
                                           ByVal pedido As Integer, _
                                           ByVal ordenCarga As Integer, _
                                           ByVal loteAlternativo As String,
                                           ByVal sinpalet As Boolean) As Boolean

        dtb.Conectar()
        Try
            Dim cmd As System.Data.SqlClient.SqlCommand = dtb.Comando("InsertAlbaranCargaSeguridad4")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@pedido", If(pedido = 0, Convert.DBNull, pedido))
            cmd.Parameters.AddWithValue("@ordenCarga", ordenCarga)
            cmd.Parameters.AddWithValue("@SCC", ValorSCC)
            cmd.Parameters.AddWithValue("@CodigoQS", ValorCodigoQS)
            cmd.Parameters.AddWithValue("@ArticuloDescripcion", ValorArticuloDescripcion)
            cmd.Parameters.AddWithValue("@Cajas", ValorCajas)
            cmd.Parameters.AddWithValue("@UnidadMedidaID", ValorUnidadMedidaID)
            cmd.Parameters.AddWithValue("@Lote", ValorLote)
            cmd.Parameters.AddWithValue("@TipoPaletID", ValorTipoPaletID)
            cmd.Parameters.AddWithValue("@Peso", Peso)
            cmd.Parameters.AddWithValue("@Observaciones", ValorObservaciones)
            cmd.Parameters.AddWithValue("@Reserva1", ValorReserva1)
            cmd.Parameters.AddWithValue("@Reserva2", ValorReserva2)
            cmd.Parameters.AddWithValue("@Reserva3", ValorReserva3)
            cmd.Parameters.AddWithValue("@LoteAlternativo", loteAlternativo)
            cmd.Parameters.AddWithValue("@FechaModificacion", ValorFechaModificacion)
            cmd.Parameters.AddWithValue("@UsuarioModificacion", Config.User)
            cmd.Parameters.AddWithValue("@sinpalet", sinpalet)

            cmd.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function spMaxAlbaranCargaProMaestro(ByRef transacDtb As DataBase) As Integer
        Dim MaxID As Integer = 0

        Try
            Dim cmd As System.Data.SqlClient.SqlCommand = transacDtb.Comando("MaxAlbaranCargaProMaestro")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "MaxAlbaranCargaProMaestro"

            MaxID = Convert.ToInt32(cmd.ExecuteScalar())

            Return MaxID
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
