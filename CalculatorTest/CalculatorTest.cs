using Microsoft.VisualStudio.TestTools.UnitTesting;
using CraftingCalculator;
using CraftingCalculator.Calculations.Invention;
using CraftingCalculator.Crafting;
using CraftingCalculator.Calculations.Gold;
using CraftingCalculator.Magic;
using CraftingCalculator.Alchemy;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InventionTest()
        {
            int level = 5;
            int improvements = 2;
            int expected = Invention_Result.Base_Price * level * improvements;
            Invention_Result actual = new(5, 2);

            Assert.AreEqual(expected, actual.Cost);
        }

        [TestMethod]
        public void MundaneTest() // TODO: Setup advanced testing
        {
            int value = 6;
            int expected = value / 3;
            Mundane_Result actual = new(2, 2, false, "test", 20, value);
            actual = Mundane_CostCalc.CostCalculator(actual);

            Assert.AreEqual(expected, actual.Cost);
        }

        [TestMethod]
        public void GoldTest()
        {
            int days = 1;
            int check = 10;
            int level = 5;
            int expected = days*check*level*10;
            Gold_Result actual = new Gold_Result(days, check, level, 500, 500);

            Assert.AreEqual(expected, actual.Result);

            days = 10;
            expected = Math.Min(days * check * level * 10, level * 1000);
            actual = new Gold_Result(days, check, level, 500, 500);

            Assert.AreEqual(expected, actual.Result);
        }

        [TestMethod]
        public void MagicTest()
        {
            int buy_cost = 2000;
            int expected_craft_cost = buy_cost / 2;
            int caster_level = 5;
            int missing_requirements = 1;
            int expected_dc = (missing_requirements*5)+caster_level+5;
            Magic_ResultForm actual = new(buy_cost);
            actual = Magic_CostCalc.CostCalculator(actual);
            actual = Magic_ReducedDC.EndDC(actual, 1, 5);

            Assert.AreEqual(expected_craft_cost, actual.Cost);
            Assert.AreEqual(expected_dc, actual.DC);
        }

        [TestMethod]
        public void AlchemyTest()
        {
            int dc = 15;
            int expected_time = 4; // 15 or less = 4
            int batches = 2;
            int expected_dc = 15+2; // 2 batches of DC 11 to 19 = 2
            int craftcheck = 20;
            int cost = 200;
            double expected_cost;
            Alchemy_ResultForm actual = new(dc, batches, craftcheck, cost);
            actual = Alchemy_Crafting.Crafting(actual);

            if (actual.CraftCheck >= actual.DC + 5)
            {
                actual = Alchemy_ReducedDC.EndDC(actual, false);
                expected_time /= 2; // cut in two due to high check result
            }
            expected_cost = (actual.Cost / 3) * actual.Batches; // TODO: Figure out why it only works when doing it this specific way. Math problem.
            actual = Alchemy_CostCalc.CostCalculator(actual, false);

            Assert.AreEqual(expected_time, actual.CraftingTime);
            Assert.AreEqual(expected_dc, actual.DC);
            Assert.AreEqual(expected_cost, actual.Cost);
        }
    }
}