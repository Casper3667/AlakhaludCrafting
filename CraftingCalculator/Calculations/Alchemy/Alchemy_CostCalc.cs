namespace CraftingCalculator.Alchemy
{
    public static class Alchemy_CostCalc
    {
        public static Alchemy_ResultForm CostCalculator(Alchemy_ResultForm Results, bool Cartridge)
        {
            if (Cartridge)
                Results.Cost = Results.Cost / 2 * Results.Batches;
            else
                Results.Cost = (Results.Cost / 3) * Results.Batches;

            return Results;
        }
    }
}
