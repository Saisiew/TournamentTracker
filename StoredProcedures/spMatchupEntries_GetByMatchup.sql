USE Tournaments
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spMatchupEntries_GetByMatchup] 
	@MatchupId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   select m.*
   from dbo.MatchupEntries m
   inner join dbo.Matchups u on m.MatchupId = u.id
   where m.MatchupId = @MatchupId;
END
GO
