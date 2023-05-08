namespace CraftingCalculator.Alchemy
{
    public class Alchemy_ResultForm
    {
        public int DC;
        public int CraftingTime;
        public int Batches;
        public int CraftCheck;
        public double Cost;

        public Alchemy_ResultForm(int dc, int time, int batches, int craftcheck, double cost)
        {
            DC = dc;
            CraftingTime = time;
            Batches = batches;
            CraftCheck = craftcheck;
            Cost = cost;
        }
    }
}
