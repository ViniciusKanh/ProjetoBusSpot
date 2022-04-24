select * from Estado
order by Nome

select* from CIDADE
order by Nome

select* from Bairro order by Nome

select Estado.ID, Estado.Nome, Estado.Sigla from Estado order by Estado.Sigla

select CIDADE.ID, CIDADE.Nome as Cidade, Estado.Sigla as Estado from CIDADE, Estado where Cidade.ID_ESTADO = Estado.ID order by CIDADE.Nome

insert CIDADE (Nome,ID_ESTADO) values ('Salvador',5)

use BusSpot
go
Create Procedure Proc_Mostrar_Logradouro 
as
select* from Logradouro  order by Nome
go

use BusSpot
go
Create Procedure Proc_Inserir_Logradouro  
@NOME varchar(50)
as
insert Logradouro (Nome) values (@NOME)
go

use BusSpot
go
Create Procedure Proc_Alterar_Logradouro 
@ID int,
@NOME varchar(50)
as
Update Logradouro  set Nome = @NOME where ID = @ID
go

use BusSpot
go
Create Procedure Proc_Buscar_Logradouro 
@textobuscar  varchar(2)
as
select * from Logradouro  where Nome like @textobuscar +'%'
go

use BusSpot
go
Create Procedure Proc_Remover_Logradouro 
@ID int
as
Delete from Logradouro  where ID = @ID
go

