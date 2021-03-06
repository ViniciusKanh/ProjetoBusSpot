USE [BusSpot]
GO
/****** Object:  StoredProcedure [dbo].[Proc_Buscar_Endereco]    Script Date: 23/04/2022 22:55:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[Proc_Buscar_Endereco] 
@textobuscar  varchar(50)
as
select Endereco.ID, Endereco.CEP,Tipo_logradouro.Nome as 'Tipo de Logradouro', Logradouro.Nome as 'Logradouro', Bairro.Nome as 'Bairro', CIDADE.Nome as 'Cidade', Estado.Sigla as 'Estado'
from Endereco, CIDADE, Estado, Bairro, Tipo_logradouro, Logradouro   
where Endereco.CEP like @textobuscar +'%' and Endereco.ID_Bairro = Bairro.ID and Endereco.ID_Cidade = CIDADE.ID and Endereco.ID_Logradouro = Logradouro.ID and Endereco.ID_TipoLogradouro = Tipo_logradouro.ID and CIDADE.ID_ESTADO = Estado.ID
