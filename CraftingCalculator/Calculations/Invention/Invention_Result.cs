namespace CraftingCalculator.Calculations.Invention
{
    public class Invention_Result
    {
        private static readonly int Base_Price = 500;
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
