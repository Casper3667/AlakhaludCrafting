namespace CraftingCalculator.Crafting
{
    public static class Mundane_ReducedDC
    {
        private static int RepeatNumber = 0;
        private static int TempCraftCheck = 0;
        private static double TempTime = 0;
        public static Mundane_Result EndDC(Mundane_Result Results)
        {
            RepeatNumber = 0;
            TempCraftCheck = Results.CraftCheck;
            do
            {
                RepeatNumber += 1;
                TempCraftCheck -= 5;

            } while (TempCraftCheck >= Results.DC + 5 && RepeatNumber < 4);

            TempTime = Results.CraftingTime;

            for (int i = 0; i < RepeatNumber; i++)
            {
                TempTime = TempTime / 2;
            }
            Results.CraftingTime = Math.Max((int)Math.Ceiling(TempTime), 1);

            return Results;
        }


    }
}
