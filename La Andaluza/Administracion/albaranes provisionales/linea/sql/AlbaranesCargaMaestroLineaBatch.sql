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


DELETE FROM [dbo].[AlbaranesCargaProviDetalles]
WHERE
    [AlbaranCargaProviDetalleID] = @AlbaranCargaProviDetalleID

END

GO
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

GO
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

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AlbaranesCargaMaestroLineaSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AlbaranesCargaMaestroLineaSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlbaranesCargaMaestroLineaSelectDgv]
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
End

GO
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

GO
