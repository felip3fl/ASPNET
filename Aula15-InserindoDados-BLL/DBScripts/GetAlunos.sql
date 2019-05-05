USE [Cadastro]
GO

/****** Object:  StoredProcedure [dbo].[GetAlunos]    Script Date: 05/05/2019 14:36:33 ******/
DROP PROCEDURE [dbo].[GetAlunos]
GO

/****** Object:  StoredProcedure [dbo].[GetAlunos]    Script Date: 05/05/2019 14:36:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[GetAlunos]
as
BEGIN

SELECT  [Id]
      ,[Nome]
      ,[Email]
      ,[Idade]
      ,[DataInscricao]
      ,[Sexo]
	  ,[Foto]
	  ,[Texto]
  FROM [Cadastro].[dbo].[Alunos]

END
GO


