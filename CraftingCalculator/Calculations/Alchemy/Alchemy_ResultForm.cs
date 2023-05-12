namespace CraftingCalculator.Alchemy
{
    public class Alchemy_ResultForm
    {
        public int DC;
        public int CraftingTime = 0;
        public int Batches;
        public int CraftCheck;
        public double Cost;

        public Alchemy_ResultForm(int dc, int batches, int craftcheck, double cost)
        {
            DC = dc;
            Batches = batches;
            CraftCheck = craftcheck;
            Cost = cost;
        }
    }
}
