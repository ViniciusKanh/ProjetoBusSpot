

use BusSpot
go
Create Procedure Proc_Mostrar_Reclamacao 
as
select Reclamacao.ID as 'ID', Reclamacao.Nome as 'Nome', Reclamacao.Email as 'Email', Reclamacao.Telefone as 'Telefone', Reclamacao.Desc_Rec as 'Descrição', Reclamacao.Data_Rec as 'Data da Reclamação', Reclamacao.Retorno as 'Reposta Empresa', Empresa.Fantasia as 'Empresa'
from Reclamacao,Empresa where Reclamacao.ID_EMPRESA = Empresa.ID order by Nome
go

use BusSpot
go
Create Procedure Proc_Inserir_Reclamacao 
@NOME varchar(50),
@EMAIL varchar(50),
@TELEFONE varchar(11),
@DESCRICAO varchar(50),
@DATA_REC date,
@RETORNO varchar(50),
@ID_EMPRESA int
as
insert Reclamacao(Nome,Email,Telefone,Desc_Rec,Data_Rec,Retorno, ID_EMPRESA) values (@NOME,@EMAIL,@TELEFONE,@DESCRICAO,@DATA_REC,@RETORNO, @ID_EMPRESA)
go

use BusSpot
go
Create Procedure Proc_Alterar_Reclamacao  
@ID int,
@NOME varchar(50),
@EMAIL varchar(50),
@TELEFONE varchar(11),
@DESCRICAO varchar(50),
@DATA_REC date,
@RETORNO varchar(50),
@ID_EMPRESA int
as
Update Reclamacao set Nome = @NOME, Email = @EMAIL, Telefone = @TELEFONE, Desc_Rec = @DESCRICAO,Data_Rec=@DATA_REC,Retorno=@RETORNO, ID_EMPRESA = @ID_EMPRESA where ID = @ID
go

use BusSpot
go
Create Procedure Proc_Buscar_Reclamacao  
@textobuscar  varchar(2)
as
select * from Reclamacao where Nome like @textobuscar +'%'
go

use BusSpot
go
Create Procedure Proc_Remover_Reclamacao  
@ID int
as
Delete from Reclamacao where ID = @ID
go

