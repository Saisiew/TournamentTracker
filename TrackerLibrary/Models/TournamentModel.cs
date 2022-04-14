using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        public event EventHandler<DateTime> OnTournamentComplete;

        /// <summary>
        /// The unique identifier for the tournament.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the Tournament Name for the Tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the Required Tournament fee to enter this tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the List of Teams who have Entered themselves into the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents the list of Prizes available for each placement.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the number of rounds that this tournament will have.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        public void CompleteTournament()
        {
            OnTournamentComplete?.Invoke(this,DateTime.Now);
        }
    }
}
