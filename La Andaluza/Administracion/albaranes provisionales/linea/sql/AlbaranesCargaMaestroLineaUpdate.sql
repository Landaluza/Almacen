IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AlbaranesCargaMaestroLineaUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AlbaranesCargaMaestroLineaUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlbaranesCargaMaestroLineaUpdate] 
      @AlbaranCargaProviMaestroID int
     ,@SCC int
     ,@CodigoQS int
     ,@AticuloDescripcion varchar(150)
     ,@Cajas int
     ,@UnidadMedidaID int
     ,@Lote varchar(20)
     ,@TipoPaletID int
     ,@Observaciones varchar(250)
     ,@Reserva1 varchar(50)
     ,@Reserva2 varchar(50)
     ,@Reserva3 varchar(50)
     ,@LoteAlternativo varchar(300)
     ,@AlbaranCargaProviDetalleID int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[AlbaranesCargaProviDetalles]
SET
      [AlbaranCargaProviMaestroID] = @AlbaranCargaProviMaestroID
     ,[SCC] = @SCC
     ,[CodigoQS] = @CodigoQS
     ,[AticuloDescripcion] = @AticuloDescripcion
     ,[Cajas] = @Cajas
     ,[UnidadMedidaID] = @UnidadMedidaID
     ,[Lote] = @Lote
     ,[TipoPaletID] = @TipoPaletID
     ,[Observaciones] = @Observaciones
     ,[Reserva1] = @Reserva1
     ,[Reserva2] = @Reserva2
     ,[Reserva3] = @Reserva3
     ,[LoteAlternativo] = @LoteAlternativo
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [AlbaranCargaProviDetalleID] = @AlbaranCargaProviDetalleID

END
