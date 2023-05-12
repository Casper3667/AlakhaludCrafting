using CraftingCalculator.Alchemy;
using CraftingCalculator.Calculations.Gold;
using CraftingCalculator.Calculations.Invention;
using CraftingCalculator.Crafting;
using CraftingCalculator.Magic;

namespace CraftingCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SaturdayCheck();
        }

        private void SaturdayCheck()
        {
            int year = DateTime.Today.Year;
            int month = DateTime.Today.Month;
            int day = DateTime.DaysInMonth(year, month);
            int count = 0;

            for (int i = 0; i < day; ++i)
            {
                DateTime d = new(year, month, i + 1);

                if (d.DayOfWeek == DayOfWeek.Saturday)
                {
                    count += 1;
                }
            }

            saturday_label.Text = $"Saturdays in the month: {count} days.";
        }

        private readonly int MundaneTab = 0;
        private readonly int AlchemyTab = 1;
        private readonly int MagicTab = 2;
        private readonly int InventionTab = 3;
        private readonly int GoldTab = 4;
        // CraftingTabs.TabPages[0]
        private void CraftItem(object sender, EventArgs e)
        {
            if (CraftingTabs.SelectedTab == CraftingTabs.TabPages[MundaneTab])
                MundaneCrafting();
            else if (CraftingTabs.SelectedTab == CraftingTabs.TabPages[AlchemyTab])
                AlchemyCrafting();
            else if (CraftingTabs.SelectedTab == CraftingTabs.TabPages[MagicTab])
                MagicCrafting();
            else if (CraftingTabs.SelectedTab == CraftingTabs.TabPages[InventionTab])
                InventionCrafting();
            else if (CraftingTabs.SelectedTab == CraftingTabs.TabPages[GoldTab])
                GoldCrafting();
            else
                MundaneCrafting();
        }

        #region Crafting
        private void MundaneCrafting()
        {
            Mundane_Result Results = new(0, 0, MasterworkCheck.Checked, CraftingDCInput.Text, int.Parse(CraftCheckResultInput.Text), int.Parse(CostInput.Text));

            Results = Mundane_Crafting.Craft(Results); // Time, DC, Masterwork

            if (Results.CraftCheck >= Results.DC + 5)
            {
                Results = Mundane_ReducedDC.EndDC(Results);
            }

            Results = Mundane_CostCalc.CostCalculator(Results);
            Mundane_ShowResult(Results);
        }

        private void AlchemyCrafting()
        {
            Alchemy_ResultForm Results = new(int.Parse(AlchemyDCInput.Text), int.Parse(BatchInput.Text), int.Parse(CraftCheckResultInput.Text), int.Parse(CostInput.Text));

            Results = Alchemy_Crafting.Crafting(Results);

            if (Results.CraftCheck >= Results.DC + 5 || CartridgeCheck.Checked)
            {
                Results = Alchemy_ReducedDC.EndDC(Results, CartridgeCheck.Checked);
            }
            Results = Alchemy_CostCalc.CostCalculator(Results, CartridgeCheck.Checked);
            Alchemy_ShowResult(Results);
        }

        private void MagicCrafting()
        {
            Magic_ResultForm Results = new(int.Parse(CostInput.Text));

            Results = Magic_ReducedDC.EndDC(Results, int.Parse(MagicRequirementInput.Text), int.Parse(MagicCasterInput.Text));

            Results = Magic_CostCalc.CostCalculator(Results);
            Magic_ShowResult(Results);
        }

        private void InventionCrafting()
        {
            Invention_Result Results = new(int.Parse(Invention_level.Text), int.Parse(Invention_improvement.Text));

            Invention_ShowResult(Results);
        }

        private void GoldCrafting()
        {
            Gold_Result Results = new(int.Parse(Gold_days.Text), int.Parse(Gold_check.Text), int.Parse(Gold_level.Text), int.Parse(Gold_current_cash.Text), int.Parse(Gold_total_cash.Text));

            Gold_ShowResult(Results);
        }
        #endregion

        #region ShowResults
        internal void Magic_ShowResult(Magic_ResultForm Results)
        {
            ResultTime.Text = $"Crafting time: {Results.CraftingTime.ToString()} days.";
            ResultCost.Text = $"Cost: {Results.Cost.ToString()} GP.";
            ResultDC.Text = $"DC: {Results.DC.ToString()}.";
            ResultType.Text = "Type: Magical.";
        }

        internal void Alchemy_ShowResult(Alchemy_ResultForm Results)
        {
            if (Results.CraftCheck < Results.DC && !CartridgeCheck.Checked)
                ResultTime.Text = $"Crafting time: Failed to craft.";
            else
                ResultTime.Text = $"Crafting time: {Results.CraftingTime.ToString()} days.";
            ResultCost.Text = $"Cost: {Results.Cost.ToString()} GP.";
            if (CartridgeCheck.Checked)
            {
                ResultType.Text = "Type: Alchemical cartridge.";
                ResultDC.Text = $"DC: No DC.";
            }
            else
            {
                ResultType.Text = "Type: Alchemical.";
                ResultDC.Text = $"DC: {Results.DC.ToString()}.";
            }
        }

        internal void Mundane_ShowResult(Mundane_Result Results)
        {
            if (Results.CraftCheck < Results.DC)
                ResultTime.Text = $"Crafting time: Failed to craft.";
            else
                ResultTime.Text = $"Crafting time: {Results.CraftingTime.ToString()} days.";
            ResultCost.Text = $"Cost: {Results.Cost.ToString()} GP.";
            ResultDC.Text = $"DC: {Results.DC.ToString()}.";
            ResultType.Text = "Type: Mundane.";
        }

        internal void Invention_ShowResult(Invention_Result Results)
        {
            ResultTime.Text = $"Crafting time: {Results.CraftingTime.ToString()} days.";
            ResultCost.Text = $"Cost: {Results.Cost.ToString()} GP and {Results.Sell} purchase.";
            ResultType.Text = "Type: Invention.";
            ResultDC.Text = $"DC:";
        }

        internal void Gold_ShowResult(Gold_Result Results)
        {
            Gold_result_label.Text = $"Result: {Results.Result.ToString()} GP.";
            Gold_current_cash_label.Text = $"Current cash: {Results.CurrentCash.ToString()} GP.";
            Gold_total_cash_label.Text = $"Total cash: {Results.TotalCash.ToString()} GP.";
            ResultType.Text = "Type: Gold earning.";
            ResultTime.Text = $"Crafting time:";
            ResultCost.Text = $"Cost:";
            ResultDC.Text = $"DC:";
        }

        #endregion

        #region Input Validation
        private string ValidateInput(string input)
        {
            if (int.TryParse(input, out _))
            {
                return input;
            }
            return "10";
        }

        private void AlchemyDCInput_TextChanged(object sender, EventArgs e)
        {
            AlchemyDCInput.Text = ValidateInput(AlchemyDCInput.Text);
        }

        private void CraftCheckResultInput_TextChanged(object sender, EventArgs e)
        {
            CraftCheckResultInput.Text = ValidateInput(CraftCheckResultInput.Text);
        }

        private void CostInput_TextChanged(object sender, EventArgs e)
        {
            CostInput.Text = ValidateInput(CostInput.Text);
        }

        private void MagicRequirementInput_Leave(object sender, EventArgs e)
        {
            MagicRequirementInput.Text = ValidateInput(MagicRequirementInput.Text);
        }

        private void MagicCasterInput_Leave(object sender, EventArgs e)
        {
            MagicCasterInput.Text = ValidateInput(MagicCasterInput.Text);
        }
        #endregion

        #region CraftingInput

        private void CraftingDCInput_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CraftingDCInput.SelectedIndex == 0)
            {
                ComplexityDescBox.Text = "Very simple" +
                "\nThese items are composed of a single piece, made of a single material, and contain no moving parts. " +
                "\n\nVery Simple items include simple weapons in the Hammer, Monk, Spear, " +
                "and Thrown weapon groups, and all items made with Craft (Blacksmithing), " +
                "Craft (Baskets), and Craft (Cloth).";
            }
            else if (CraftingDCInput.SelectedIndex == 1)
            {
                ComplexityDescBox.Text = "Simple" +
                    "\nThese items are composed of one or more pieces that are " +
                    "individually easy to make, and contain no moving parts." +
                    "\n" +
                    "\nSimple items include all simple weapons that aren’t Very Simple, " +
                    "ammunition, caltrops, and all items made with Craft (Clothing), " +
                    "Craft (Glass), Craft (Leather), Craft (Pottery), and Craft (Shoes).";
            }
            else if (CraftingDCInput.SelectedIndex == 2)
            {
                ComplexityDescBox.Text = "Moderate" +
                    "\nThese items are made of several parts (including moving parts) " +
                    "and diverse materials that must be integrated into a whole. " +
                    "\n" +
                    "\nModerate items include all martial and exotic weapons except " +
                    "for crossbows and firearms, all shields, and all items made with " +
                    "Craft (Carpentry), Craft (Jewelry), Craft (Instruments), " +
                    "Craft (Stonemasonry), Craft (Taxidermy), and Craft (Tools). ";
            }
            else if (CraftingDCInput.SelectedIndex == 3)
            {
                ComplexityDescBox.Text = "Complex" +
                    "\nThese items have many parts (including moving parts) " +
                    "composed of diverse materials that take skill to integrate into a " +
                    "whole. Alternatively, these items require a great degree of " +
                    "artistry to create. " +
                    "\n" +
                    "\nComplex items include all armor and animal barding, crossbows, " +
                    "firearms, all non-powered land vehicles, siege weapons, and all items " +
                    "made with Craft (Books), Craft (Calligraphy), Craft (Paintings), " +
                    "Craft (Sculptures), and Craft (Tattoos)";
            }
            else if (CraftingDCInput.SelectedIndex == 4)
            {
                ComplexityDescBox.Text = "Very complex" +
                    "\nThese items contain a great number of moving parts that " +
                    "require advanced engineering knowledge to integrate into a whole." +
                    "\n" +
                    "\nVery Complex items include all water and air vehicles, " +
                    "all powered vehicles, and all items made with Craft (Clockwork) " +
                    "and Craft (Mechanical).";
            }
        }

        #endregion
    }
}