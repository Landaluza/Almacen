use[la]
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AlbaranesNoDefinitivosSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AlbaranesNoDefinitivosSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlbaranesNoDefinitivosSelect]
      @AlbaranCargaProMaestroID int
AS 
BEGIN
SELECT [AlbaranCargaProMaestroID]
      ,[Numero]
      ,[Fecha]
      ,[ResponsableCargaID]
      ,[Observaciones]
      ,[Reserva1]
      ,[Reserva2]
      ,[Reserva3]
      ,[FechaModificacion]
      ,[UsuarioModificacion]
      ,[e1]
      ,[e2]
      ,[e3]
      ,[e4]
      ,[e5]
      ,[e6]
      ,[h1]
      ,[m1]
      ,[m2]
      ,[c1]
      ,[c2]
      ,[ObservacionControl]
  FROM [dbo].[AlbaranCargaProMaestro]
WHERE
    [AlbaranCargaProMaestroID] = @AlbaranCargaProMaestroID
End
