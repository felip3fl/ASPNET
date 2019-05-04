USE [Cadastro]
GO

/****** Object:  StoredProcedure [dbo].[GetAlunos]    Script Date: 04/05/2019 12:18:23 ******/
DROP PROCEDURE [dbo].[GetAlunos]
GO

/****** Object:  StoredProcedure [dbo].[GetAlunos]    Script Date: 04/05/2019 12:18:23 ******/
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
  FROM [Cadastro].[dbo].[Alunos]

END
GO


