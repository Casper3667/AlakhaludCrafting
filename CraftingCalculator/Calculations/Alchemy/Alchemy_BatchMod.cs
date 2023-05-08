namespace CraftingCalculator.Alchemy
{
    public static class Alchemy_BatchMod
    {
        private static int BatchModifier = 1;
        private static int TempBatch = 1;
        public static Alchemy_ResultForm BatchCalc(Alchemy_ResultForm Results)
        {
            if (Results.DC <= 10)
            {
                TempBatch = 1;
            }
            else if (Results.DC > 10 && Results.DC <= 20)
            {
                TempBatch = 2;
            }
            else if (Results.DC > 20 && Results.DC <= 30)
            {
                TempBatch = 3;
            }
            else if (Results.DC > 30)
            {
                TempBatch = 4;
            }

            if (Results.Batches == 2)
            {
                BatchModifier = 1;
            }
            else if (Results.Batches <= 4)
            {
                BatchModifier = 2;
            }
            else if (Results.Batches <= 8)
            {
                BatchModifier = 3;
            }
            else if (Results.Batches <= 16)
            {
                BatchModifier = 4;
            }
            else if (Results.Batches <= 32)
            {
                BatchModifier = 5;
            }

            Results.DC += BatchModifier * TempBatch;

            return Results;
        }
    }
}
