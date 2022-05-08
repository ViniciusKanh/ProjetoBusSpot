

use BusSpot
go
Create Procedure Proc_Mostrar_Parada 
as
select* from Paradas order by Nome
go

use BusSpot
go
Create Procedure Proc_Inserir_Parada 
@Latitude varchar(50),
@Longitude varchar(50),
@NOME varchar(50),
@ID_ENDERECO int
as
insert Paradas(Latitude,Longitude,Nome,ID_ENDERECO) values (@Latitude,@Longitude,@NOME,@ID_ENDERECO)
go

use BusSpot
go
Create Procedure Proc_Alterar_Parada 
@ID int,
@Latitude varchar(50),
@Longitude varchar(50),
@NOME varchar(50),
@ID_ENDERECO int
as
Update Paradas set Latitude = @Latitude, Longitude = @Longitude, Nome = @NOME, ID_ENDERECO = @ID_ENDERECO where ID = @ID
go

use BusSpot
go
Create Procedure Proc_Buscar_Parada 
@textobuscar  varchar(2)
as
select * from Paradas where Nome like @textobuscar +'%'
go

use BusSpot
go
Create Procedure Proc_Remover_Parada
@ID int
as
Delete from Paradas where ID = @ID
go

