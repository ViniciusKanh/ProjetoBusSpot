

use BusSpot
go
Create Procedure Proc_Mostrar_Linha 
as
select* from Linha order by Numero_Linha
go

use BusSpot
go
Create Procedure Proc_Inserir_Linha 
@Numero_Linha varchar(50),
@Descricao_Linha varchar(50),
@ID_EMPRESA int,
@ID_PONTO int
as
insert Linha(Numero_Linha,Descricao_Linha,ID_EMPRESA,ID_PONTO) values (@Numero_Linha,@Descricao_Linha,@ID_EMPRESA,@ID_PONTO)
go

use BusSpot
go
Create Procedure Proc_Alterar_Linha 
@ID int,
@Numero_Linha varchar(50),
@Descricao_Linha varchar(50),
@ID_EMPRESA int,
@ID_PONTO int
as
Update Linha set Numero_Linha = @Numero_Linha, Descricao_Linha = @Descricao_Linha, ID_EMPRESA = @ID_EMPRESA, ID_PONTO = @ID_PONTO where ID = @ID
go

use BusSpot
go
Create Procedure Proc_Buscar_Linha 
@textobuscar  varchar(2)
as
select * from Linha where Numero_Linha like @textobuscar +'%'
go

use BusSpot
go
Create Procedure Proc_Remover_Linha 
@ID int
as
Delete from Linha where ID = @ID
go

