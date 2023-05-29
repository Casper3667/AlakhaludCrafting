namespace CraftingCalculator.Calculations.Gold
{
    public class Gold_Result
    {
        public int Result;
        public float CurrentCash;
        public float TotalCash;

        /// <summary>
        /// Gold earned weekly using gold downtime from Alakhalud.
        /// Gold is equal to the check * level * 10 * days
        /// Current cash & total cash each has the result added to them
        /// </summary>
        /// <param name="days">Days used to earn gold</param>
        /// <param name="check">The result of the skill check</param>
        /// <param name="level">Level of the character earning gold</param>
        /// <param name="currentCash">Current available gold the character is carrying</param>
        /// <param name="totalCash">Current total value of the character's gold and equipment</param>
        public Gold_Result(int days, int check, int level, float currentCash, float totalCash)
        {
            Result = Math.Min(level * 1000, check * level * 10);
            Result *= days;
            CurrentCash = currentCash + Result;
            TotalCash = totalCash + Result;
        }
    }
}
