namespace CraftingCalculator.Crafting
{
    public static class Mundane_CostCalc
    {
        public static Mundane_Result CostCalculator(Mundane_Result Results)
        {
            Results.Cost = Results.Cost / 3;
            return Results;
        }
    }
}
