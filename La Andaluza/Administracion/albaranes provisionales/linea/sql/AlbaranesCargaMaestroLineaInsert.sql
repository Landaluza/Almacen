use[la]
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AlbaranesCargaMaestroLineaInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AlbaranesCargaMaestroLineaInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlbaranesCargaMaestroLineaInsert]
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
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[AlbaranesCargaProviDetalles]
     (
      AlbaranCargaProviMaestroID
     ,SCC
     ,CodigoQS
     ,AticuloDescripcion
     ,Cajas
     ,UnidadMedidaID
     ,Lote
     ,TipoPaletID
     ,Observaciones
     ,Reserva1
     ,Reserva2
     ,Reserva3
     ,LoteAlternativo
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
      @AlbaranCargaProviMaestroID
     ,@SCC
     ,@CodigoQS
     ,@AticuloDescripcion
     ,@Cajas
     ,@UnidadMedidaID
     ,@Lote
     ,@TipoPaletID
     ,@Observaciones
     ,@Reserva1
     ,@Reserva2
     ,@Reserva3
     ,@LoteAlternativo
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END
