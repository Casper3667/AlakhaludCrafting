using CraftingCalculator.Calculations.Invention;
using CraftingCalculator.Crafting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CraftingCalculator
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
            Invention_Result actual = new Invention_Result(5, 2);

            Assert.AreEqual(expected, actual.Cost);
        }

        [TestMethod]
        public void TestMethod1()
        {
            int expected = 2;
            int value = 6;
            Mundane_Result actual = new Mundane_Result(2, 2, false, "test", 20, value);
            actual = Mundane_CostCalc.CostCalculator(actual);

            Assert.AreEqual(expected, actual.Cost);
        }
    }
}
