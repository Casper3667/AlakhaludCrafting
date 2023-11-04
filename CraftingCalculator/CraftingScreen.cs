using CraftingCalculator.Alchemy;
using CraftingCalculator.Calculations.Gold;
using CraftingCalculator.Calculations.Invention;
using CraftingCalculator.Crafting;
using CraftingCalculator.Magic;

namespace CraftingCalculator
{
    public partial class CraftingScreen : Form
    {
        public CraftingScreen()
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

            Label_SaturdayResult.Text = $"Saturdays in the month: {count} days.";
        }

        private readonly int MundaneTab = 0;
        private readonly int AlchemyTab = 1;
        private readonly int MagicTab = 2;
        private readonly int InventionTab = 3;
        private readonly int GoldTab = 4;
        // CraftingTabs.TabPages[0]
        private void CraftItem(object sender, EventArgs e)
        {
            if (Tab_Crafting.SelectedTab == Tab_Crafting.TabPages[MundaneTab])
                MundaneCrafting();
            else if (Tab_Crafting.SelectedTab == Tab_Crafting.TabPages[AlchemyTab])
                AlchemyCrafting();
            else if (Tab_Crafting.SelectedTab == Tab_Crafting.TabPages[MagicTab])
                MagicCrafting();
            else if (Tab_Crafting.SelectedTab == Tab_Crafting.TabPages[InventionTab])
                InventionCrafting();
            else if (Tab_Crafting.SelectedTab == Tab_Crafting.TabPages[GoldTab])
                GoldCrafting();
            else
                MundaneCrafting();
        }

        #region Crafting
        private void MundaneCrafting()
        {
            Mundane_Result Results = new(0, 0, Check_Masterwork.Checked, Input_CraftingDC.Text, int.Parse(Input_CraftCheckResult.Text), int.Parse(Input_Cost.Text));

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
            Alchemy_ResultForm Results = new(int.Parse(Input_AlchemyDC.Text), int.Parse(Check_Batch.Text), int.Parse(Input_CraftCheckResult.Text), int.Parse(Input_Cost.Text));

            Results = Alchemy_Crafting.Crafting(Results);

            if (Results.CraftCheck >= Results.DC + 5 || Check_Cartridge.Checked)
            {
                Results = Alchemy_ReducedDC.EndDC(Results, Check_Cartridge.Checked);
            }
            Results = Alchemy_CostCalc.CostCalculator(Results, Check_Cartridge.Checked);
            Alchemy_ShowResult(Results);
        }

        private void MagicCrafting()
        {
            Magic_ResultForm Results = new(int.Parse(Input_Cost.Text));

            Results = Magic_ReducedDC.EndDC(Results, int.Parse(Input_MagicRequirement.Text), int.Parse(Input_MagicCaster.Text));

            Results = Magic_CostCalc.CostCalculator(Results);
            Magic_ShowResult(Results);
        }

        private void InventionCrafting()
        {
            Invention_Result Results = new(int.Parse(Input_InventionLevel.Text), int.Parse(Input_InventionImprovement.Text));

            Invention_ShowResult(Results);
        }

        private void GoldCrafting()
        {
            Gold_Result Results = new(int.Parse(Input_GoldDays.Text), int.Parse(Input_GoldCheck.Text), int.Parse(Input_GoldLevel.Text), int.Parse(Input_GoldCurrentCash.Text), int.Parse(Input_GoldTotalCash.Text));

            Gold_ShowResult(Results);
        }
        #endregion

        #region ShowResults
        internal void Magic_ShowResult(Magic_ResultForm Results)
        {
            Label_Result_Time.Text = $"Crafting time: {Results.CraftingTime.ToString()} days.";
            Label_Result_Cost.Text = $"Cost: {Results.Cost.ToString()} GP.";
            Label_Result_DC.Text = $"DC: {Results.DC.ToString()}.";
            Label_Result_Type.Text = "Type: Magical.";
        }

        internal void Alchemy_ShowResult(Alchemy_ResultForm Results)
        {
            if (Results.CraftCheck < Results.DC && !Check_Cartridge.Checked)
                Label_Result_Time.Text = $"Crafting time: Failed to craft.";
            else
                Label_Result_Time.Text = $"Crafting time: {Results.CraftingTime.ToString()} days.";
            Label_Result_Cost.Text = $"Cost: {Results.Cost.ToString()} GP.";
            if (Check_Cartridge.Checked)
            {
                Label_Result_Type.Text = "Type: Alchemical cartridge.";
                Label_Result_DC.Text = $"DC: No DC.";
            }
            else
            {
                Label_Result_Type.Text = "Type: Alchemical.";
                Label_Result_DC.Text = $"DC: {Results.DC.ToString()}.";
            }
        }

        internal void Mundane_ShowResult(Mundane_Result Results)
        {
            if (Results.CraftCheck < Results.DC)
                Label_Result_Time.Text = $"Crafting time: Failed to craft.";
            else
                Label_Result_Time.Text = $"Crafting time: {Results.CraftingTime.ToString()} days.";
            Label_Result_Cost.Text = $"Cost: {Results.Cost.ToString()} GP.";
            Label_Result_DC.Text = $"DC: {Results.DC.ToString()}.";
            Label_Result_Type.Text = "Type: Mundane.";
        }

        internal void Invention_ShowResult(Invention_Result Results)
        {
            Label_Result_Time.Text = $"Crafting time: {Results.CraftingTime.ToString()} days.";
            Label_Result_Cost.Text = $"Cost: {Results.Cost.ToString()} GP and {Results.Sell} purchase.";
            Label_Result_Type.Text = "Type: Invention.";
            Label_Result_DC.Text = $"DC:";
        }

        internal void Gold_ShowResult(Gold_Result Results)
        {
            Label_GoldResult.Text = $"Result: {Results.Result.ToString()} GP.";
            Label_GoldCurrentCashResult.Text = $"Current cash: {Results.CurrentCash.ToString()} GP.";
            Label_GoldTotalCashResult.Text = $"Total cash: {Results.TotalCash.ToString()} GP.";
            Label_Result_Type.Text = "Type: Gold earning.";
            Label_Result_Time.Text = $"Crafting time:";
            Label_Result_Cost.Text = $"Cost:";
            Label_Result_DC.Text = $"DC:";
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
            Input_AlchemyDC.Text = ValidateInput(Input_AlchemyDC.Text);
        }

        private void CraftCheckResultInput_TextChanged(object sender, EventArgs e)
        {
            Input_CraftCheckResult.Text = ValidateInput(Input_CraftCheckResult.Text);
        }

        private void CostInput_TextChanged(object sender, EventArgs e)
        {
            Input_Cost.Text = ValidateInput(Input_Cost.Text);
        }

        private void MagicRequirementInput_Leave(object sender, EventArgs e)
        {
            Input_MagicRequirement.Text = ValidateInput(Input_MagicRequirement.Text);
        }

        private void MagicCasterInput_Leave(object sender, EventArgs e)
        {
            Input_MagicCaster.Text = ValidateInput(Input_MagicCaster.Text);
        }
        #endregion

        #region CraftingInput

        private void CraftingDCInput_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Input_CraftingDC.SelectedIndex == 0)
            {
                Desc_Complexity.Text = "Very simple" +
                "\nThese items are composed of a single piece, made of a single material, and contain no moving parts. " +
                "\n\nVery Simple items include simple weapons in the Hammer, Monk, Spear, " +
                "and Thrown weapon groups, and all items made with Craft (Blacksmithing), " +
                "Craft (Baskets), and Craft (Cloth).";
            }
            else if (Input_CraftingDC.SelectedIndex == 1)
            {
                Desc_Complexity.Text = "Simple" +
                    "\nThese items are composed of one or more pieces that are " +
                    "individually easy to make, and contain no moving parts." +
                    "\n" +
                    "\nSimple items include all simple weapons that aren’t Very Simple, " +
                    "ammunition, caltrops, and all items made with Craft (Clothing), " +
                    "Craft (Glass), Craft (Leather), Craft (Pottery), and Craft (Shoes).";
            }
            else if (Input_CraftingDC.SelectedIndex == 2)
            {
                Desc_Complexity.Text = "Moderate" +
                    "\nThese items are made of several parts (including moving parts) " +
                    "and diverse materials that must be integrated into a whole. " +
                    "\n" +
                    "\nModerate items include all martial and exotic weapons except " +
                    "for crossbows and firearms, all shields, and all items made with " +
                    "Craft (Carpentry), Craft (Jewelry), Craft (Instruments), " +
                    "Craft (Stonemasonry), Craft (Taxidermy), and Craft (Tools). ";
            }
            else if (Input_CraftingDC.SelectedIndex == 3)
            {
                Desc_Complexity.Text = "Complex" +
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
            else if (Input_CraftingDC.SelectedIndex == 4)
            {
                Desc_Complexity.Text = "Very complex" +
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