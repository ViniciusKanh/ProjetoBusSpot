

use BusSpot
go
Create Procedure Proc_Mostrar_Empresa 
as
select* from Empresa order by Fantasia
go

use BusSpot
go
Create Procedure Proc_Inserir_Empresa 
@Fantasia varchar(50),
@CNPJ varchar(50),
@ID_ENDERECO int,
@NUMERAL varchar(50),
@Usuario varchar(50),
@Senha varchar(50)
as
insert Empresa(Fantasia,CNPJ,ID_ENDERECO,Numeral,Usuario,Senha) values (@Fantasia,@CNPJ,@ID_ENDERECO,@NUMERAL,@Usuario,@Senha)
go

use BusSpot
go
Create Procedure Proc_Alterar_Empresa 
@ID int,
@Fantasia varchar(50),
@CNPJ varchar(50),
@ID_ENDERECO int,
@NUMERAL varchar(50),
@Usuario varchar(50),
@Senha varchar(50)
as
Update Empresa set Fantasia = @Fantasia, CNPJ = @CNPJ, ID_ENDERECO = @ID_ENDERECO, Numeral = @NUMERAL,Usuario=@Usuario,Senha=@Senha where ID = @ID
go

use BusSpot
go
Create Procedure Proc_Buscar_Empresa 
@textobuscar  varchar(2)
as
select * from Empresa where Fantasia like @textobuscar +'%'
go

use BusSpot
go
Create Procedure Proc_Remover_Empresa 
@ID int
as
Delete from Empresa where ID = @ID
go

