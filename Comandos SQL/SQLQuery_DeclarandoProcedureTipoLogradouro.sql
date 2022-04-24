

use BusSpot
go
Create Procedure Proc_Mostrar_TipoLogradouro 
as
select ID, Nome as 'Tipo Logradouro' from Tipo_logradouro  order by Nome
go

use BusSpot
go
Create Procedure Proc_Inserir_TipoLogradouro   
@NOME varchar(50)
as
insert Tipo_logradouro(Nome) values (@NOME)
go

use BusSpot
go
Create Procedure Proc_Alterar_TipoLogradouro 
@ID int,
@NOME varchar(50)
as
Update Tipo_logradouro set Nome = @NOME where ID = @ID
go

use BusSpot
go
Create Procedure Proc_Buscar_TipoLogradouro  
@textobuscar  varchar(2)
as
select * from Tipo_logradouro  where Nome like @textobuscar +'%'
go

use BusSpot
go
Create Procedure Proc_Remover_TipoLogradouro  
@ID int
as
Delete from Tipo_logradouro  where ID = @ID
go

