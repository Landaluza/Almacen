use[la]
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
