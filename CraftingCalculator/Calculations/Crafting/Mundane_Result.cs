namespace CraftingCalculator.Crafting
{
    public class Mundane_Result
    {
        public int DC;
        public int CraftingTime;
        public bool Masterwork;
        public string CraftText;
        public int CraftCheck;
        public double Cost;

        public Mundane_Result(int dc, int time, bool masterwork, string crafttext, int craftcheck, double cost)
        {
            DC = dc;
            CraftingTime = time;
            Masterwork = masterwork;
            CraftText = crafttext;
            CraftCheck = craftcheck;
            Cost = cost;
        }
    }

}
