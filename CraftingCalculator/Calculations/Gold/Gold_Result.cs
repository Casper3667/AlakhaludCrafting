using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingCalculator.Calculations.Gold
{
    internal class Gold_Result
    {
        public int Result;
        public float CurrentCash;
        public float TotalCash;
        public Gold_Result(int days, int check, int level, float currentCash, float totalCash)
        {
            Result = (check * level) * 10;
            Result *= days;
            CurrentCash = currentCash + Result;
            TotalCash = totalCash + Result;
        }
    }
}
