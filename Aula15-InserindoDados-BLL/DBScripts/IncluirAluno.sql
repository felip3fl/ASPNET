USE [Cadastro]
GO

/****** Object:  StoredProcedure [dbo].[IncluirAluno]    Script Date: 04/05/2019 12:15:13 ******/
DROP PROCEDURE [dbo].[IncluirAluno]
GO

/****** Object:  StoredProcedure [dbo].[IncluirAluno]    Script Date: 04/05/2019 12:15:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[IncluirAluno]
	@Nome nvarchar (50) = null,
	@Email nvarchar (100),
	@Idade int,
	@DataInscricao DateTime,
	@Sexo nchar(1)
as
Begin

	Insert into Alunos (Nome, Email, Idade, DataInscricao, Sexo)
	Values (@Nome, @Email, @Idade, @DataInscricao, @Sexo)

End
GO


