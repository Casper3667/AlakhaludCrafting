namespace CraftingCalculator.Magic
{
    public static class Magic_ReducedDC
    {
        public static Magic_ResultForm EndDC(Magic_ResultForm Results, int RequirementMissing, int CasterLevel)
        {
            Results.DC = 5 + CasterLevel;
            Results.DC += 5 * RequirementMissing;
            Results.CraftingTime = Math.Max((int)Math.Ceiling(Results.Cost / 1000), 1);

            return Results;
        }


    }
}
