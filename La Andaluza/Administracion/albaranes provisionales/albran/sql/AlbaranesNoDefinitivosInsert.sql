use[la]
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
