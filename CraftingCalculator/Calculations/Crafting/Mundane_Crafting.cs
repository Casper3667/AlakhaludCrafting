namespace CraftingCalculator.Crafting
{
    public static class Mundane_Crafting
    {
        public static Mundane_Result Craft(Mundane_Result Results)
        {
            if (Results.CraftText == "Very simple")
            {
                Results.DC = 10;
                Results.CraftingTime = 1;
            }
            else if (Results.CraftText == "Simple")
            {
                Results.DC = 12;
                Results.CraftingTime = 2;
            }
            else if (Results.CraftText == "Moderate")
            {
                Results.DC = 14;
                Results.CraftingTime = 4;
            }
            else if (Results.CraftText == "Complex")
            {
                Results.DC = 18;
                Results.CraftingTime = 7;
            }
            else if (Results.CraftText == "Very complex")
            {
                Results.DC = 20;
                Results.CraftingTime = 14;
            }
            if (Results.Masterwork)
            {
                Results.CraftingTime = (int)Math.Round(Results.CraftingTime * 1.5);
                Results.DC += 4;
            }

            return Results;
        }
    }
}
