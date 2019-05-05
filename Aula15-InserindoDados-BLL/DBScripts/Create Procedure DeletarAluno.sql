

CREATE PROCEDURE [dbo].[DeletarAluno]

	@Id int

as
BEGIN

	DELETE Alunos
	WHERE
	Id = @Id

END
GO


