using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// this tells us the tournament name
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// this tells us the amount to pay to entry
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// this gives us a list of the teams that entered the tournament
        /// </summary>
        public List <TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// this is a list of the prizes to be won be each place 
        /// </summary>

        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// this is  a list of rounds to be played
        /// </summary>

        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
