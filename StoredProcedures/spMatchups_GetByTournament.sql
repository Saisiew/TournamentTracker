USE Tournaments
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spMatchups_GetByTournament] 
	@TournamentId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   select m.*
   from dbo.Matchups m
   inner join dbo.MatchupEntries u on m.id = u.MatchupId
   inner join dbo.Teams t on u.TeamCompetingId = t.id
   inner join dbo.TournamentEntries e on t.id = e.TeamId 
   where e.TournamentId = @TournamentId;
END
GO
