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

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AlbaranesNoDefinitivosInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AlbaranesNoDefinitivosInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlbaranesNoDefinitivosInsert]
      @AlbaranCargaProMaestroID int
     ,@Fecha date
     ,@ClienteID int
     ,@SerieQSID int
     ,@NumeroQS int
     ,@AlmacenSalidaQSID int
     ,@AgenciaID int
     ,@PorteFormaPagoID int
     ,@PorteImporte int
     ,@Matricula varchar(15)
     ,@Conductor varchar(50)
     ,@ConductorDNI varchar(15)
     ,@ResponsableCargaID int
     ,@ResponsableAdministracionID int
     ,@HoraLlegada time
     ,@HoraSalida time
     ,@Observaciones varchar(250)
     ,@Reserva1 varchar(50)
     ,@Reserva2 varchar(50)
     ,@Reserva3 varchar(50)
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[AlbaranesCargaMaestro]
     (
      AlbaranCargaProMaestroID
     ,Fecha
     ,ClienteID
     ,SerieQSID
     ,NumeroQS
     ,AlmacenSalidaQSID
     ,AgenciaID
     ,PorteFormaPagoID
     ,PorteImporte
     ,Matricula
     ,Conductor
     ,ConductorDNI
     ,ResponsableCargaID
     ,ResponsableAdministracionID
     ,HoraLlegada
     ,HoraSalida
     ,Observaciones
     ,Reserva1
     ,Reserva2
     ,Reserva3
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
      @AlbaranCargaProMaestroID
     ,@Fecha
     ,@ClienteID
     ,@SerieQSID
     ,@NumeroQS
     ,@AlmacenSalidaQSID
     ,@AgenciaID
     ,@PorteFormaPagoID
     ,@PorteImporte
     ,@Matricula
     ,@Conductor
     ,@ConductorDNI
     ,@ResponsableCargaID
     ,@ResponsableAdministracionID
     ,@HoraLlegada
     ,@HoraSalida
     ,@Observaciones
     ,@Reserva1
     ,@Reserva2
     ,@Reserva3
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AlbaranesNoDefinitivosSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AlbaranesNoDefinitivosSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlbaranesNoDefinitivosSelect]
      @AlbaranCargaMaestroID int
AS 
BEGIN
SELECT
      AlbaranCargaMaestroID
     ,AlbaranCargaProMaestroID
     ,Fecha
     ,ClienteID
     ,SerieQSID
     ,NumeroQS
     ,AlmacenSalidaQSID
     ,AgenciaID
     ,PorteFormaPagoID
     ,PorteImporte
     ,Matricula
     ,Conductor
     ,ConductorDNI
     ,ResponsableCargaID
     ,ResponsableAdministracionID
     ,HoraLlegada
     ,HoraSalida
     ,Observaciones
     ,Reserva1
     ,Reserva2
     ,Reserva3
FROM
     [dbo].[AlbaranesCargaMaestro]
WHERE
    [AlbaranCargaMaestroID] = @AlbaranCargaMaestroID
End

GO
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
      [dbo].[AlbaranesCargaMaestro].[AlbaranCargaMaestroID] Id
     ,[dbo].[AlbaranesCargaMaestro].[AlbaranCargaProMaestroID]
     ,[dbo].[AlbaranesCargaMaestro].[Fecha]
     ,[dbo].[AlbaranesCargaMaestro].[ClienteID]
     ,[dbo].[AlbaranesCargaMaestro].[SerieQSID]
     ,[dbo].[AlbaranesCargaMaestro].[NumeroQS]
     ,[dbo].[AlbaranesCargaMaestro].[AlmacenSalidaQSID]
     ,[dbo].[AlbaranesCargaMaestro].[AgenciaID]
     ,[dbo].[AlbaranesCargaMaestro].[PorteFormaPagoID]
     ,[dbo].[AlbaranesCargaMaestro].[PorteImporte]
     ,[dbo].[AlbaranesCargaMaestro].[Matricula]
     ,[dbo].[AlbaranesCargaMaestro].[Conductor]
     ,[dbo].[AlbaranesCargaMaestro].[ConductorDNI]
     ,[dbo].[AlbaranesCargaMaestro].[ResponsableCargaID]
     ,[dbo].[AlbaranesCargaMaestro].[ResponsableAdministracionID]
     ,[dbo].[AlbaranesCargaMaestro].[HoraLlegada]
     ,[dbo].[AlbaranesCargaMaestro].[HoraSalida]
     ,[dbo].[AlbaranesCargaMaestro].[Observaciones]
     ,[dbo].[AlbaranesCargaMaestro].[Reserva1]
     ,[dbo].[AlbaranesCargaMaestro].[Reserva2]
     ,[dbo].[AlbaranesCargaMaestro].[Reserva3]
FROM
     [dbo].[AlbaranesCargaMaestro]
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AlbaranesNoDefinitivosUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AlbaranesNoDefinitivosUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlbaranesNoDefinitivosUpdate] 
      @AlbaranCargaProMaestroID int
     ,@Fecha date
     ,@ClienteID int
     ,@SerieQSID int
     ,@NumeroQS int
     ,@AlmacenSalidaQSID int
     ,@AgenciaID int
     ,@PorteFormaPagoID int
     ,@PorteImporte int
     ,@Matricula varchar(15)
     ,@Conductor varchar(50)
     ,@ConductorDNI varchar(15)
     ,@ResponsableCargaID int
     ,@ResponsableAdministracionID int
     ,@HoraLlegada time
     ,@HoraSalida time
     ,@Observaciones varchar(250)
     ,@Reserva1 varchar(50)
     ,@Reserva2 varchar(50)
     ,@Reserva3 varchar(50)
     ,@AlbaranCargaMaestroID int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[AlbaranesCargaMaestro]
SET
      [AlbaranCargaProMaestroID] = @AlbaranCargaProMaestroID
     ,[Fecha] = @Fecha
     ,[ClienteID] = @ClienteID
     ,[SerieQSID] = @SerieQSID
     ,[NumeroQS] = @NumeroQS
     ,[AlmacenSalidaQSID] = @AlmacenSalidaQSID
     ,[AgenciaID] = @AgenciaID
     ,[PorteFormaPagoID] = @PorteFormaPagoID
     ,[PorteImporte] = @PorteImporte
     ,[Matricula] = @Matricula
     ,[Conductor] = @Conductor
     ,[ConductorDNI] = @ConductorDNI
     ,[ResponsableCargaID] = @ResponsableCargaID
     ,[ResponsableAdministracionID] = @ResponsableAdministracionID
     ,[HoraLlegada] = @HoraLlegada
     ,[HoraSalida] = @HoraSalida
     ,[Observaciones] = @Observaciones
     ,[Reserva1] = @Reserva1
     ,[Reserva2] = @Reserva2
     ,[Reserva3] = @Reserva3
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [AlbaranCargaMaestroID] = @AlbaranCargaMaestroID

END

GO
