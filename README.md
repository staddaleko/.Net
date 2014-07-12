.Net

GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION F_KsiazkaAutorzy
(	
	@Identyfikator_K int
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT dbo.Autor.Imie, dbo.Autor.Nazwisko, dbo.Autor.Data_ur
	FROM   dbo.Autor
	INNER JOIN dbo.KsiazkaAutor ON dbo.Autor.Id_A = dbo.KsiazkaAutor.Id_a
	WHERE dbo.KsiazkaAutor.Id_k = @Identyfikator_K
)
GO
