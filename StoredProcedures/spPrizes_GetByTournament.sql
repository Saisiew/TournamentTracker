USE Tournaments
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spPrizes_GetByTournament] 
	@TournamentId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   select p.*
   from dbo.Prizes p
   inner join dbo.TournamentPrizes t on p.id = t.PrizeId
   where t.TournamentId = @TournamentId;
END
GO
