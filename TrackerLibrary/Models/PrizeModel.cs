namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the Numerical place number for prize allocation
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the colloquial term for that place number in the prize pool.
        /// </summary>
        public string PlaceName { get; set; }
        
        /// <summary>
        /// Represents the prize amount for this particular placing (optional vs Percentage allocation)
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the prize percentage for this particular placing (optional vs Prize amount)
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {
        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;


        }
    }
}