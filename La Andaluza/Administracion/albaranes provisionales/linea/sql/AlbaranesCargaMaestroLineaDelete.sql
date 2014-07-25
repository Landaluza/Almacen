use[la]
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AlbaranesCargaMaestroLineaDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AlbaranesCargaMaestroLineaDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlbaranesCargaMaestroLineaDelete] 
      @AlbaranCargaProviDetalleID int
AS
BEGIN

SET NOCOUNT ON

update paletsproducidos set enAlmacen = 'true' where scc = (select scc  
															FROM [dbo].[AlbaranesCargaProviDetalles]
															WHERE
																[AlbaranCargaProviDetalleID] = @AlbaranCargaProviDetalleID)

DELETE FROM [dbo].[AlbaranesCargaProviDetalles]
WHERE
    [AlbaranCargaProviDetalleID] = @AlbaranCargaProviDetalleID

END
