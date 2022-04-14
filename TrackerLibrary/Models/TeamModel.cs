using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// The unique identifier for the team.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the name of this particular team.
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// Represents the Team members part of this particular team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        
    }
}
