use[la]
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AlbaranesCargaMaestroLineaSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AlbaranesCargaMaestroLineaSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlbaranesCargaMaestroLineaSelectDgv] @AlbaranCargaProMaestroID int
AS 
BEGIN
SELECT
      [dbo].[AlbaranesCargaProviDetalles].[AlbaranCargaProviDetalleID] Id
     ,[dbo].[AlbaranesCargaProviDetalles].[AlbaranCargaProviMaestroID]
     ,[dbo].[AlbaranesCargaProviDetalles].[SCC]
     ,[dbo].[AlbaranesCargaProviDetalles].[CodigoQS]
     ,[dbo].[AlbaranesCargaProviDetalles].[AticuloDescripcion]
     ,[dbo].[AlbaranesCargaProviDetalles].[Cajas]
     ,[dbo].[AlbaranesCargaProviDetalles].[UnidadMedidaID]
     ,[dbo].[AlbaranesCargaProviDetalles].[Lote]
     ,[dbo].[AlbaranesCargaProviDetalles].[TipoPaletID]
     ,[dbo].[AlbaranesCargaProviDetalles].[Observaciones]
     ,[dbo].[AlbaranesCargaProviDetalles].[Reserva1]
     ,[dbo].[AlbaranesCargaProviDetalles].[Reserva2]
     ,[dbo].[AlbaranesCargaProviDetalles].[Reserva3]
     ,[dbo].[AlbaranesCargaProviDetalles].[LoteAlternativo]
FROM
     [dbo].[AlbaranesCargaProviDetalles]
where [AlbaranCargaProviMaestroID]=@AlbaranCargaProMaestroID
End
