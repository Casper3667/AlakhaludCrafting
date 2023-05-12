namespace CraftingCalculator.Calculations.Invention
{
    /// <summary>
    /// Creates permament inventions. 
    /// Calculation: Cost is equal to the base price * level * improvements.
    /// Sell price is the cost, rounded to nearest 1k and multiplied by 1.5.
    /// Time is equal to 1 day per 1k.
    /// </summary>
    public class Invention_Result
    {
        public static readonly int Base_Price = 500;
        public int CraftingTime;
        public double Cost;
        public double Sell;
        public Invention_Result(int level, int improvement)
        {
            Cost = Base_Price * level * improvement;
            CraftingTime = (int)Math.Ceiling(Cost / 1000);
            Sell = Cost * 1.5;
        }
    }
}
