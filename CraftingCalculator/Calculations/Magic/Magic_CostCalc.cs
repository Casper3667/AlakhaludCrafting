namespace CraftingCalculator.Magic
{
    public static class Magic_CostCalc
    {
        public static Magic_ResultForm CostCalculator(Magic_ResultForm Results)
        {
            Results.Cost = Results.Cost / 2;

            return Results;
        }
    }
}
