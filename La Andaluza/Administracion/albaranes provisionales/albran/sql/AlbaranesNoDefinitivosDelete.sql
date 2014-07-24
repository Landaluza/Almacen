use[la]
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AlbaranesNoDefinitivosDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AlbaranesNoDefinitivosDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlbaranesNoDefinitivosDelete] 
      @AlbaranCargaMaestroID int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[AlbaranesCargaMaestro]
WHERE
    [AlbaranCargaMaestroID] = @AlbaranCargaMaestroID

END
