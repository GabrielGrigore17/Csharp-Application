using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one prize.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier used for storage
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the place number of the player to which this prize is
        /// directed.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the name of the place of the player to which this prize is
        /// directed. (e.g. First Runner Up)
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the prize amount as a fixed sum of money. 
        /// (Can only be active when PrizePercentage is not active)
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the prize as a percentage of the total tournament income.
        /// (Can only be active when the PrizeAmount is not active)
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
