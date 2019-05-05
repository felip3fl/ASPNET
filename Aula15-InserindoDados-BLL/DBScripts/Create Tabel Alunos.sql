USE [Cadastro]
GO

/****** Object:  Table [dbo].[Alunos]    Script Date: 05/05/2019 14:32:49 ******/
DROP TABLE [dbo].[Alunos]
GO

/****** Object:  Table [dbo].[Alunos]    Script Date: 05/05/2019 14:32:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Alunos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Idade] [int] NULL,
	[DataInscricao] [datetime] NULL,
	[Sexo] [nchar](1) NULL,
	[Foto] [nvarchar](150) NULL,
	[Texto] [nvarchar](100) NULL
) ON [PRIMARY]
GO


