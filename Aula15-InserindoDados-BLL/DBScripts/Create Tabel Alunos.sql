USE [Cadastro]
GO

/****** Object:  Table [dbo].[Alunos]    Script Date: 04/05/2019 12:19:02 ******/
DROP TABLE [dbo].[Alunos]
GO

/****** Object:  Table [dbo].[Alunos]    Script Date: 04/05/2019 12:19:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Alunos](
	[Id] [int] NULL,
	[Nome] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Idade] [int] NULL,
	[DataInscricao] [datetime] NULL,
	[Sexo] [nchar](1) NULL
) ON [PRIMARY]
GO


