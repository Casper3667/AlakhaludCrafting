namespace CraftingCalculator.Alchemy
{
    public static class Alchemy_Crafting
    {
        public static Alchemy_ResultForm Crafting(Alchemy_ResultForm Results)
        {
            if (Results.DC <= 15)
            {
                Results.CraftingTime = 4;
            }
            else if (Results.DC > 15 && Results.DC <= 20)
            {
                Results.CraftingTime = 7;
            }
            else
            {
                Results.CraftingTime = 14;
            }
            if (Results.Batches > 1)
            {
                Results = Alchemy_BatchMod.BatchCalc(Results);
            }

            return Results;
        }
    }
}
