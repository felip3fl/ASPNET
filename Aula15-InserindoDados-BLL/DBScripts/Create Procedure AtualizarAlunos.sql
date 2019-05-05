USE [Cadastro]
GO

/****** Object:  StoredProcedure [dbo].[AtualizarAluno]    Script Date: 05/05/2019 14:39:57 ******/
DROP PROCEDURE [dbo].[AtualizarAluno]
GO

/****** Object:  StoredProcedure [dbo].[AtualizarAluno]    Script Date: 05/05/2019 14:39:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[AtualizarAluno]

	@Id int,
	@Nome nvarchar(50) NULL,
	@Email nvarchar(50) NULL,
	@Idade int ,
	@DataInscricao datetime ,
	@Sexo nchar(1),
	@Foto nvarchar (150),
	@Texto nvarchar (100)

as
BEGIN

	update Alunos
	set 
	Nome = @Nome,
	Email = @Email,
	Idade = @Idade,
	DataInscricao = @DataInscricao,
	Sexo = @Sexo,
	Foto = @Foto,
	Texto = @Texto
	WHERE
	Id = @Id

END
GO


