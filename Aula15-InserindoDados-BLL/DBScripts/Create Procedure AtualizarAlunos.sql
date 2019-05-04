
CREATE PROCEDURE dbo.AtualizarAluno

	@Id int,
	@Nome nvarchar(50) NULL,
	@Email nvarchar(50) NULL,
	@Idade int ,
	@DataInscricao datetime ,
	@Sexo nchar(1) 

as
BEGIN

	update Alunos
	set 
	Nome = @Nome,
	Email = @Email,
	Idade = @Idade,
	DataInscricao = @DataInscricao,
	Sexo = @Sexo
	WHERE
	Id = @Id

END
GO


