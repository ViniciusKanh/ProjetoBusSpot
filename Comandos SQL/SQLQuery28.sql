USE [BusSpot]
GO
/****** Object:  StoredProcedure [dbo].[Proc_Buscar_TipoLogradouro]    Script Date: 23/04/2022 22:54:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[Proc_Buscar_TipoLogradouro]  
@textobuscar  varchar(50)
as
select * from Tipo_logradouro  where Nome like @textobuscar +'%'
