using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// This tells us the place someone finished in
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// this tells us the name of the person that finished in a particular place
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// this tells us the prize amount
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// this tells us the percentage of the total to calculate the prize amount
        /// </summary>
        public double PrizePercentage { get; set; }

    }
}
