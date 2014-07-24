use[la]
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
