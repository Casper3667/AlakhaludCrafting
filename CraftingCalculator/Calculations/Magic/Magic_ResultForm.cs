namespace CraftingCalculator.Magic
{
    public class Magic_ResultForm
    {
        public int DC;
        public int CraftingTime;
        public double Cost;

        public Magic_ResultForm(int dc, int time, double cost)
        {
            DC = dc;
            CraftingTime = time;
            Cost = cost;
        }
    }
}
