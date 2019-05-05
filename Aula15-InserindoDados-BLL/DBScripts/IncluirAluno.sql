USE [Cadastro]
GO

/****** Object:  StoredProcedure [dbo].[IncluirAluno]    Script Date: 05/05/2019 14:37:26 ******/
DROP PROCEDURE [dbo].[IncluirAluno]
GO

/****** Object:  StoredProcedure [dbo].[IncluirAluno]    Script Date: 05/05/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[IncluirAluno]
	@Nome nvarchar (50) = null,
	@Email nvarchar (100),
	@Idade int,
	@DataInscricao DateTime,
	@Sexo nchar(1),
	@Foto nvarchar (100),
	@Texto nvarchar (100)
as
Begin

	Insert into Alunos (Nome, Email, Idade, DataInscricao, Sexo, Foto, Texto)
	Values (@Nome, @Email, @Idade, @DataInscricao, @Sexo,@Foto,@Texto)

End
GO


