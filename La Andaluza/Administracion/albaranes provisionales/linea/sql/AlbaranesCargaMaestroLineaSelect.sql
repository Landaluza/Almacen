use[la]
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AlbaranesCargaMaestroLineaSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AlbaranesCargaMaestroLineaSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlbaranesCargaMaestroLineaSelect]
      @AlbaranCargaProviDetalleID int
AS 
BEGIN
SELECT
      AlbaranCargaProviDetalleID
     ,AlbaranCargaProviMaestroID
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
FROM
     [dbo].[AlbaranesCargaProviDetalles]
WHERE
    [AlbaranCargaProviDetalleID] = @AlbaranCargaProviDetalleID
End
