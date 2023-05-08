namespace CraftingCalculator.Alchemy
{
    public static class Alchemy_ReducedDC
    {
        private static int RepeatNumber = 0;
        private static int TempCraftCheck = 0;
        private static double TempTime = 0;
        public static Alchemy_ResultForm EndDC(Alchemy_ResultForm Results, bool Cartridge)
        {
            if (Cartridge)
            {
                Results.CraftingTime = Math.Max((int)Math.Ceiling(Results.Cost * Results.Batches / 1000), 1);
            }
            else
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
            }

            return Results;
        }


    }
}
