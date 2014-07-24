use[la]
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AlbaranesNoDefinitivosSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AlbaranesNoDefinitivosSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlbaranesNoDefinitivosSelectDgv]
AS 
BEGIN
SELECT
      
     [dbo].[AlbaranCargaproMaestro].[AlbaranCargaProMaestroID] Id
     ,[dbo].[AlbaranCargaproMaestro].[Fecha]
     ,[dbo].[AlbaranCargaproMaestro].[Numero]
     ,[dbo].[AlbaranCargaproMaestro].[Observaciones]
     ,[dbo].[AlbaranCargaproMaestro].[Reserva1]
     ,[dbo].[AlbaranCargaproMaestro].[Reserva2]
     ,[dbo].[AlbaranCargaproMaestro].[Reserva3]
FROM
     [dbo].[AlbaranCargaproMaestro]
where [dbo].[AlbaranCargaproMaestro].[Numero] not in (select albarancargapromaestroid from AlbaranesCargaMaestro)
End
