namespace CraftingCalculator
{
    partial class CraftingScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CraftingScreen));
            Input_AlchemyDC = new TextBox();
            Input_CraftingDC = new ComboBox();
            Label_AlchemyDC = new Label();
            Button_Craft = new Button();
            Label_Result_Time = new Label();
            Input_CraftCheckResult = new TextBox();
            Label_CraftResult = new Label();
            Check_Masterwork = new CheckBox();
            Check_Batch = new ComboBox();
            Label_CraftDC = new Label();
            Label_Batch = new Label();
            Input_Cost = new TextBox();
            Label_Cost = new Label();
            Label_Result_DC = new Label();
            Label_Result_Cost = new Label();
            Check_Cartridge = new CheckBox();
            Label_Result_Type = new Label();
            Tab_Crafting = new TabControl();
            Page_Craft = new TabPage();
            Desc_Complexity = new RichTextBox();
            Page_Alch = new TabPage();
            Page_Magic = new TabPage();
            Input_MagicCaster = new TextBox();
            Label_MagicCaster = new Label();
            Input_MagicRequirement = new TextBox();
            Label_MagicRequirement = new Label();
            Page_Invention = new TabPage();
            Input_InventionImprovement = new TextBox();
            Label_InventionImprovement = new Label();
            Input_InventionLevel = new TextBox();
            Label_InventionLevel = new Label();
            Page_Gold = new TabPage();
            Label_GoldTotalCashResult = new Label();
            Input_GoldTotalCash = new TextBox();
            Label_GoldTotalCash = new Label();
            Input_GoldCurrentCash = new TextBox();
            Label_GoldCurrentCashResult = new Label();
            Label_GoldCurrentCash = new Label();
            Label_SaturdayResult = new Label();
            Input_GoldCheck = new TextBox();
            Label_GoldResult = new Label();
            Label_GoldCheck = new Label();
            Input_GoldDays = new TextBox();
            Label_GoldDays = new Label();
            Input_GoldLevel = new TextBox();
            Label_GoldLevel = new Label();
            Image_Craft = new ImageList(components);
            Panel_Result = new GroupBox();
            Panel_Basic = new Panel();
            Label_TimeUsed = new Label();
            Input_DaysUsed = new TextBox();
            Desc_DT_Text = new RichTextBox();
            Tab_Crafting.SuspendLayout();
            Page_Craft.SuspendLayout();
            Page_Alch.SuspendLayout();
            Page_Magic.SuspendLayout();
            Page_Invention.SuspendLayout();
            Page_Gold.SuspendLayout();
            Panel_Result.SuspendLayout();
            Panel_Basic.SuspendLayout();
            SuspendLayout();
            // 
            // Input_AlchemyDC
            // 
            Input_AlchemyDC.Location = new Point(6, 28);
            Input_AlchemyDC.Margin = new Padding(3, 2, 3, 2);
            Input_AlchemyDC.Name = "Input_AlchemyDC";
            Input_AlchemyDC.RightToLeft = RightToLeft.No;
            Input_AlchemyDC.Size = new Size(72, 23);
            Input_AlchemyDC.TabIndex = 0;
            Input_AlchemyDC.Text = "10";
            Input_AlchemyDC.Leave += AlchemyDCInput_TextChanged;
            // 
            // Input_CraftingDC
            // 
            Input_CraftingDC.FormattingEnabled = true;
            Input_CraftingDC.Items.AddRange(new object[] { "Very simple", "Simple", "Moderate", "Complex", "Very complex" });
            Input_CraftingDC.Location = new Point(6, 5);
            Input_CraftingDC.Margin = new Padding(3, 2, 3, 2);
            Input_CraftingDC.Name = "Input_CraftingDC";
            Input_CraftingDC.Size = new Size(133, 23);
            Input_CraftingDC.TabIndex = 2;
            Input_CraftingDC.Text = "Very simple";
            Input_CraftingDC.SelectionChangeCommitted += CraftingDCInput_SelectionChangeCommitted;
            // 
            // Label_AlchemyDC
            // 
            Label_AlchemyDC.AutoSize = true;
            Label_AlchemyDC.Location = new Point(84, 32);
            Label_AlchemyDC.Name = "Label_AlchemyDC";
            Label_AlchemyDC.Size = new Size(73, 15);
            Label_AlchemyDC.TabIndex = 3;
            Label_AlchemyDC.Text = "Alchemy DC";
            // 
            // Button_Craft
            // 
            Button_Craft.Location = new Point(5, 11);
            Button_Craft.Margin = new Padding(3, 2, 3, 2);
            Button_Craft.Name = "Button_Craft";
            Button_Craft.Size = new Size(82, 22);
            Button_Craft.TabIndex = 4;
            Button_Craft.Text = "Craft";
            Button_Craft.UseVisualStyleBackColor = true;
            Button_Craft.Click += CraftItem;
            // 
            // Label_Result_Time
            // 
            Label_Result_Time.AutoSize = true;
            Label_Result_Time.Location = new Point(5, 18);
            Label_Result_Time.Name = "Label_Result_Time";
            Label_Result_Time.Size = new Size(80, 15);
            Label_Result_Time.TabIndex = 6;
            Label_Result_Time.Text = "Crafting time:";
            // 
            // Input_CraftCheckResult
            // 
            Input_CraftCheckResult.Location = new Point(5, 37);
            Input_CraftCheckResult.Margin = new Padding(3, 2, 3, 2);
            Input_CraftCheckResult.Name = "Input_CraftCheckResult";
            Input_CraftCheckResult.Size = new Size(110, 23);
            Input_CraftCheckResult.TabIndex = 7;
            Input_CraftCheckResult.Text = "10";
            Input_CraftCheckResult.Leave += CraftCheckResultInput_TextChanged;
            // 
            // Label_CraftResult
            // 
            Label_CraftResult.AutoSize = true;
            Label_CraftResult.Location = new Point(120, 40);
            Label_CraftResult.Name = "Label_CraftResult";
            Label_CraftResult.Size = new Size(86, 15);
            Label_CraftResult.TabIndex = 8;
            Label_CraftResult.Text = "Crafting Check";
            // 
            // Check_Masterwork
            // 
            Check_Masterwork.AutoSize = true;
            Check_Masterwork.Location = new Point(9, 34);
            Check_Masterwork.Margin = new Padding(3, 2, 3, 2);
            Check_Masterwork.Name = "Check_Masterwork";
            Check_Masterwork.Size = new Size(88, 19);
            Check_Masterwork.TabIndex = 9;
            Check_Masterwork.Text = "Masterwork";
            Check_Masterwork.UseVisualStyleBackColor = true;
            // 
            // Check_Batch
            // 
            Check_Batch.FormattingEnabled = true;
            Check_Batch.Items.AddRange(new object[] { "1", "2", "4", "8", "16", "32" });
            Check_Batch.Location = new Point(6, 55);
            Check_Batch.Margin = new Padding(3, 2, 3, 2);
            Check_Batch.Name = "Check_Batch";
            Check_Batch.Size = new Size(72, 23);
            Check_Batch.TabIndex = 10;
            Check_Batch.Text = "1";
            // 
            // Label_CraftDC
            // 
            Label_CraftDC.AutoSize = true;
            Label_CraftDC.Location = new Point(145, 9);
            Label_CraftDC.Name = "Label_CraftDC";
            Label_CraftDC.Size = new Size(69, 15);
            Label_CraftDC.TabIndex = 11;
            Label_CraftDC.Text = "Crafting DC";
            // 
            // Label_Batch
            // 
            Label_Batch.AutoSize = true;
            Label_Batch.Location = new Point(84, 59);
            Label_Batch.Name = "Label_Batch";
            Label_Batch.Size = new Size(48, 15);
            Label_Batch.TabIndex = 12;
            Label_Batch.Text = "Batches";
            // 
            // Input_Cost
            // 
            Input_Cost.Location = new Point(5, 62);
            Input_Cost.Margin = new Padding(3, 2, 3, 2);
            Input_Cost.Name = "Input_Cost";
            Input_Cost.Size = new Size(110, 23);
            Input_Cost.TabIndex = 13;
            Input_Cost.Text = "9";
            Input_Cost.Leave += CostInput_TextChanged;
            // 
            // Label_Cost
            // 
            Label_Cost.AutoSize = true;
            Label_Cost.Location = new Point(120, 64);
            Label_Cost.Name = "Label_Cost";
            Label_Cost.Size = new Size(60, 15);
            Label_Cost.TabIndex = 14;
            Label_Cost.Text = "Base Price";
            // 
            // Label_Result_DC
            // 
            Label_Result_DC.AutoSize = true;
            Label_Result_DC.Location = new Point(5, 48);
            Label_Result_DC.Name = "Label_Result_DC";
            Label_Result_DC.Size = new Size(26, 15);
            Label_Result_DC.TabIndex = 15;
            Label_Result_DC.Text = "DC:";
            // 
            // Label_Result_Cost
            // 
            Label_Result_Cost.AutoSize = true;
            Label_Result_Cost.Location = new Point(5, 34);
            Label_Result_Cost.Name = "Label_Result_Cost";
            Label_Result_Cost.Size = new Size(34, 15);
            Label_Result_Cost.TabIndex = 16;
            Label_Result_Cost.Text = "Cost:";
            // 
            // Check_Cartridge
            // 
            Check_Cartridge.AutoSize = true;
            Check_Cartridge.Location = new Point(6, 5);
            Check_Cartridge.Margin = new Padding(3, 2, 3, 2);
            Check_Cartridge.Name = "Check_Cartridge";
            Check_Cartridge.Size = new Size(102, 19);
            Check_Cartridge.TabIndex = 17;
            Check_Cartridge.Text = "Alch Cartridge";
            Check_Cartridge.UseVisualStyleBackColor = true;
            // 
            // Label_Result_Type
            // 
            Label_Result_Type.AutoSize = true;
            Label_Result_Type.Location = new Point(5, 64);
            Label_Result_Type.Name = "Label_Result_Type";
            Label_Result_Type.Size = new Size(34, 15);
            Label_Result_Type.TabIndex = 18;
            Label_Result_Type.Text = "Type:";
            // 
            // Tab_Crafting
            // 
            Tab_Crafting.Appearance = TabAppearance.FlatButtons;
            Tab_Crafting.Controls.Add(Page_Craft);
            Tab_Crafting.Controls.Add(Page_Alch);
            Tab_Crafting.Controls.Add(Page_Magic);
            Tab_Crafting.Controls.Add(Page_Invention);
            Tab_Crafting.Controls.Add(Page_Gold);
            Tab_Crafting.Dock = DockStyle.Right;
            Tab_Crafting.ImageList = Image_Craft;
            Tab_Crafting.ImeMode = ImeMode.NoControl;
            Tab_Crafting.Location = new Point(253, 0);
            Tab_Crafting.Multiline = true;
            Tab_Crafting.Name = "Tab_Crafting";
            Tab_Crafting.RightToLeft = RightToLeft.No;
            Tab_Crafting.SelectedIndex = 0;
            Tab_Crafting.Size = new Size(447, 338);
            Tab_Crafting.TabIndex = 19;
            // 
            // Page_Craft
            // 
            Page_Craft.Controls.Add(Desc_Complexity);
            Page_Craft.Controls.Add(Input_CraftingDC);
            Page_Craft.Controls.Add(Label_CraftDC);
            Page_Craft.Controls.Add(Check_Masterwork);
            Page_Craft.ImageIndex = 0;
            Page_Craft.Location = new Point(4, 83);
            Page_Craft.Name = "Page_Craft";
            Page_Craft.Padding = new Padding(3);
            Page_Craft.Size = new Size(439, 251);
            Page_Craft.TabIndex = 0;
            Page_Craft.Text = "Craft";
            Page_Craft.ToolTipText = "Mundane";
            Page_Craft.UseVisualStyleBackColor = true;
            // 
            // Desc_Complexity
            // 
            Desc_Complexity.BackColor = SystemColors.Window;
            Desc_Complexity.BorderStyle = BorderStyle.None;
            Desc_Complexity.DetectUrls = false;
            Desc_Complexity.Location = new Point(9, 58);
            Desc_Complexity.Name = "Desc_Complexity";
            Desc_Complexity.ReadOnly = true;
            Desc_Complexity.Size = new Size(422, 184);
            Desc_Complexity.TabIndex = 15;
            Desc_Complexity.Text = resources.GetString("Desc_Complexity.Text");
            // 
            // Page_Alch
            // 
            Page_Alch.Controls.Add(Input_AlchemyDC);
            Page_Alch.Controls.Add(Check_Cartridge);
            Page_Alch.Controls.Add(Label_AlchemyDC);
            Page_Alch.Controls.Add(Check_Batch);
            Page_Alch.Controls.Add(Label_Batch);
            Page_Alch.ImageIndex = 1;
            Page_Alch.Location = new Point(4, 83);
            Page_Alch.Name = "Page_Alch";
            Page_Alch.Padding = new Padding(3);
            Page_Alch.RightToLeft = RightToLeft.No;
            Page_Alch.Size = new Size(439, 251);
            Page_Alch.TabIndex = 1;
            Page_Alch.Text = "Alchemy";
            Page_Alch.ToolTipText = "Alchemy";
            Page_Alch.UseVisualStyleBackColor = true;
            // 
            // Page_Magic
            // 
            Page_Magic.Controls.Add(Input_MagicCaster);
            Page_Magic.Controls.Add(Label_MagicCaster);
            Page_Magic.Controls.Add(Input_MagicRequirement);
            Page_Magic.Controls.Add(Label_MagicRequirement);
            Page_Magic.ImageIndex = 2;
            Page_Magic.Location = new Point(4, 83);
            Page_Magic.Name = "Page_Magic";
            Page_Magic.Padding = new Padding(3);
            Page_Magic.Size = new Size(439, 251);
            Page_Magic.TabIndex = 2;
            Page_Magic.Text = "Magic";
            Page_Magic.ToolTipText = "Magic";
            Page_Magic.UseVisualStyleBackColor = true;
            // 
            // Input_MagicCaster
            // 
            Input_MagicCaster.Location = new Point(6, 32);
            Input_MagicCaster.Margin = new Padding(3, 2, 3, 2);
            Input_MagicCaster.Name = "Input_MagicCaster";
            Input_MagicCaster.RightToLeft = RightToLeft.No;
            Input_MagicCaster.Size = new Size(72, 23);
            Input_MagicCaster.TabIndex = 6;
            Input_MagicCaster.Text = "10";
            Input_MagicCaster.Leave += MagicCasterInput_Leave;
            // 
            // Label_MagicCaster
            // 
            Label_MagicCaster.AutoSize = true;
            Label_MagicCaster.Location = new Point(84, 36);
            Label_MagicCaster.Name = "Label_MagicCaster";
            Label_MagicCaster.Size = new Size(70, 15);
            Label_MagicCaster.TabIndex = 7;
            Label_MagicCaster.Text = "Caster Level";
            // 
            // Input_MagicRequirement
            // 
            Input_MagicRequirement.Location = new Point(6, 5);
            Input_MagicRequirement.Margin = new Padding(3, 2, 3, 2);
            Input_MagicRequirement.Name = "Input_MagicRequirement";
            Input_MagicRequirement.RightToLeft = RightToLeft.No;
            Input_MagicRequirement.Size = new Size(72, 23);
            Input_MagicRequirement.TabIndex = 4;
            Input_MagicRequirement.Text = "10";
            Input_MagicRequirement.Leave += MagicRequirementInput_Leave;
            // 
            // Label_MagicRequirement
            // 
            Label_MagicRequirement.AutoSize = true;
            Label_MagicRequirement.Location = new Point(84, 9);
            Label_MagicRequirement.Name = "Label_MagicRequirement";
            Label_MagicRequirement.Size = new Size(124, 15);
            Label_MagicRequirement.TabIndex = 5;
            Label_MagicRequirement.Text = "Missing Requirements";
            // 
            // Page_Invention
            // 
            Page_Invention.Controls.Add(Input_InventionImprovement);
            Page_Invention.Controls.Add(Label_InventionImprovement);
            Page_Invention.Controls.Add(Input_InventionLevel);
            Page_Invention.Controls.Add(Label_InventionLevel);
            Page_Invention.ImageIndex = 3;
            Page_Invention.Location = new Point(4, 83);
            Page_Invention.Name = "Page_Invention";
            Page_Invention.Padding = new Padding(3);
            Page_Invention.Size = new Size(439, 251);
            Page_Invention.TabIndex = 3;
            Page_Invention.Text = "Invention";
            Page_Invention.ToolTipText = "Invention";
            Page_Invention.UseVisualStyleBackColor = true;
            // 
            // Input_InventionImprovement
            // 
            Input_InventionImprovement.Location = new Point(6, 32);
            Input_InventionImprovement.Margin = new Padding(3, 2, 3, 2);
            Input_InventionImprovement.Name = "Input_InventionImprovement";
            Input_InventionImprovement.Size = new Size(110, 23);
            Input_InventionImprovement.TabIndex = 17;
            Input_InventionImprovement.Text = "3";
            // 
            // Label_InventionImprovement
            // 
            Label_InventionImprovement.AutoSize = true;
            Label_InventionImprovement.Location = new Point(121, 35);
            Label_InventionImprovement.Name = "Label_InventionImprovement";
            Label_InventionImprovement.Size = new Size(84, 15);
            Label_InventionImprovement.TabIndex = 18;
            Label_InventionImprovement.Text = "Improvements";
            // 
            // Input_InventionLevel
            // 
            Input_InventionLevel.Location = new Point(6, 5);
            Input_InventionLevel.Margin = new Padding(3, 2, 3, 2);
            Input_InventionLevel.Name = "Input_InventionLevel";
            Input_InventionLevel.Size = new Size(110, 23);
            Input_InventionLevel.TabIndex = 15;
            Input_InventionLevel.Text = "9";
            // 
            // Label_InventionLevel
            // 
            Label_InventionLevel.AutoSize = true;
            Label_InventionLevel.Location = new Point(121, 8);
            Label_InventionLevel.Name = "Label_InventionLevel";
            Label_InventionLevel.Size = new Size(34, 15);
            Label_InventionLevel.TabIndex = 16;
            Label_InventionLevel.Text = "Level";
            // 
            // Page_Gold
            // 
            Page_Gold.Controls.Add(Label_GoldTotalCashResult);
            Page_Gold.Controls.Add(Input_GoldTotalCash);
            Page_Gold.Controls.Add(Label_GoldTotalCash);
            Page_Gold.Controls.Add(Input_GoldCurrentCash);
            Page_Gold.Controls.Add(Label_GoldCurrentCashResult);
            Page_Gold.Controls.Add(Label_GoldCurrentCash);
            Page_Gold.Controls.Add(Label_SaturdayResult);
            Page_Gold.Controls.Add(Input_GoldCheck);
            Page_Gold.Controls.Add(Label_GoldResult);
            Page_Gold.Controls.Add(Label_GoldCheck);
            Page_Gold.Controls.Add(Input_GoldDays);
            Page_Gold.Controls.Add(Label_GoldDays);
            Page_Gold.Controls.Add(Input_GoldLevel);
            Page_Gold.Controls.Add(Label_GoldLevel);
            Page_Gold.ImageIndex = 4;
            Page_Gold.Location = new Point(4, 83);
            Page_Gold.Name = "Page_Gold";
            Page_Gold.Padding = new Padding(3);
            Page_Gold.Size = new Size(439, 251);
            Page_Gold.TabIndex = 4;
            Page_Gold.Text = "Gold";
            Page_Gold.UseVisualStyleBackColor = true;
            // 
            // Label_GoldTotalCashResult
            // 
            Label_GoldTotalCashResult.AutoSize = true;
            Label_GoldTotalCashResult.Location = new Point(6, 186);
            Label_GoldTotalCashResult.Name = "Label_GoldTotalCashResult";
            Label_GoldTotalCashResult.Size = new Size(65, 15);
            Label_GoldTotalCashResult.TabIndex = 28;
            Label_GoldTotalCashResult.Text = "Total cash: ";
            // 
            // Input_GoldTotalCash
            // 
            Input_GoldTotalCash.Location = new Point(6, 113);
            Input_GoldTotalCash.Margin = new Padding(3, 2, 3, 2);
            Input_GoldTotalCash.Name = "Input_GoldTotalCash";
            Input_GoldTotalCash.Size = new Size(110, 23);
            Input_GoldTotalCash.TabIndex = 21;
            Input_GoldTotalCash.Text = "10";
            // 
            // Label_GoldTotalCash
            // 
            Label_GoldTotalCash.AutoSize = true;
            Label_GoldTotalCash.Location = new Point(121, 116);
            Label_GoldTotalCash.Name = "Label_GoldTotalCash";
            Label_GoldTotalCash.Size = new Size(59, 15);
            Label_GoldTotalCash.TabIndex = 22;
            Label_GoldTotalCash.Text = "Total cash";
            // 
            // Input_GoldCurrentCash
            // 
            Input_GoldCurrentCash.Location = new Point(6, 86);
            Input_GoldCurrentCash.Margin = new Padding(3, 2, 3, 2);
            Input_GoldCurrentCash.Name = "Input_GoldCurrentCash";
            Input_GoldCurrentCash.Size = new Size(110, 23);
            Input_GoldCurrentCash.TabIndex = 19;
            Input_GoldCurrentCash.Text = "10";
            // 
            // Label_GoldCurrentCashResult
            // 
            Label_GoldCurrentCashResult.AutoSize = true;
            Label_GoldCurrentCashResult.Location = new Point(6, 172);
            Label_GoldCurrentCashResult.Name = "Label_GoldCurrentCashResult";
            Label_GoldCurrentCashResult.Size = new Size(80, 15);
            Label_GoldCurrentCashResult.TabIndex = 27;
            Label_GoldCurrentCashResult.Text = "Current cash: ";
            // 
            // Label_GoldCurrentCash
            // 
            Label_GoldCurrentCash.AutoSize = true;
            Label_GoldCurrentCash.Location = new Point(121, 89);
            Label_GoldCurrentCash.Name = "Label_GoldCurrentCash";
            Label_GoldCurrentCash.Size = new Size(74, 15);
            Label_GoldCurrentCash.TabIndex = 20;
            Label_GoldCurrentCash.Text = "Current cash";
            // 
            // Label_SaturdayResult
            // 
            Label_SaturdayResult.AutoSize = true;
            Label_SaturdayResult.Location = new Point(6, 138);
            Label_SaturdayResult.Name = "Label_SaturdayResult";
            Label_SaturdayResult.Size = new Size(136, 15);
            Label_SaturdayResult.TabIndex = 18;
            Label_SaturdayResult.Text = "Saturdays in the month: ";
            // 
            // Input_GoldCheck
            // 
            Input_GoldCheck.Location = new Point(6, 59);
            Input_GoldCheck.Margin = new Padding(3, 2, 3, 2);
            Input_GoldCheck.Name = "Input_GoldCheck";
            Input_GoldCheck.Size = new Size(110, 23);
            Input_GoldCheck.TabIndex = 13;
            Input_GoldCheck.Text = "10";
            // 
            // Label_GoldResult
            // 
            Label_GoldResult.AutoSize = true;
            Label_GoldResult.Location = new Point(6, 157);
            Label_GoldResult.Name = "Label_GoldResult";
            Label_GoldResult.Size = new Size(45, 15);
            Label_GoldResult.TabIndex = 26;
            Label_GoldResult.Text = "Result: ";
            // 
            // Label_GoldCheck
            // 
            Label_GoldCheck.AutoSize = true;
            Label_GoldCheck.Location = new Point(121, 62);
            Label_GoldCheck.Name = "Label_GoldCheck";
            Label_GoldCheck.Size = new Size(40, 15);
            Label_GoldCheck.TabIndex = 14;
            Label_GoldCheck.Text = "Check";
            // 
            // Input_GoldDays
            // 
            Input_GoldDays.Location = new Point(6, 32);
            Input_GoldDays.Margin = new Padding(3, 2, 3, 2);
            Input_GoldDays.Name = "Input_GoldDays";
            Input_GoldDays.Size = new Size(110, 23);
            Input_GoldDays.TabIndex = 11;
            Input_GoldDays.Text = "4";
            // 
            // Label_GoldDays
            // 
            Label_GoldDays.AutoSize = true;
            Label_GoldDays.Location = new Point(121, 35);
            Label_GoldDays.Name = "Label_GoldDays";
            Label_GoldDays.Size = new Size(32, 15);
            Label_GoldDays.TabIndex = 12;
            Label_GoldDays.Text = "Days";
            // 
            // Input_GoldLevel
            // 
            Input_GoldLevel.Location = new Point(6, 5);
            Input_GoldLevel.Margin = new Padding(3, 2, 3, 2);
            Input_GoldLevel.Name = "Input_GoldLevel";
            Input_GoldLevel.Size = new Size(110, 23);
            Input_GoldLevel.TabIndex = 9;
            Input_GoldLevel.Text = "10";
            // 
            // Label_GoldLevel
            // 
            Label_GoldLevel.AutoSize = true;
            Label_GoldLevel.Location = new Point(121, 8);
            Label_GoldLevel.Name = "Label_GoldLevel";
            Label_GoldLevel.Size = new Size(34, 15);
            Label_GoldLevel.TabIndex = 10;
            Label_GoldLevel.Text = "Level";
            // 
            // Image_Craft
            // 
            Image_Craft.ColorDepth = ColorDepth.Depth32Bit;
            Image_Craft.ImageStream = (ImageListStreamer)resources.GetObject("Image_Craft.ImageStream");
            Image_Craft.TransparentColor = Color.Transparent;
            Image_Craft.Images.SetKeyName(0, "hammer_3.png");
            Image_Craft.Images.SetKeyName(1, "potions.png");
            Image_Craft.Images.SetKeyName(2, "dyes.PNG");
            Image_Craft.Images.SetKeyName(3, "goggles.PNG");
            Image_Craft.Images.SetKeyName(4, "coins.png");
            // 
            // Panel_Result
            // 
            Panel_Result.Controls.Add(Desc_DT_Text);
            Panel_Result.Controls.Add(Label_Result_Time);
            Panel_Result.Controls.Add(Label_Result_Type);
            Panel_Result.Controls.Add(Label_Result_DC);
            Panel_Result.Controls.Add(Label_Result_Cost);
            Panel_Result.Dock = DockStyle.Bottom;
            Panel_Result.Location = new Point(0, 141);
            Panel_Result.Name = "Panel_Result";
            Panel_Result.Padding = new Padding(2);
            Panel_Result.Size = new Size(253, 197);
            Panel_Result.TabIndex = 21;
            Panel_Result.TabStop = false;
            // 
            // Panel_Basic
            // 
            Panel_Basic.Controls.Add(Label_TimeUsed);
            Panel_Basic.Controls.Add(Input_DaysUsed);
            Panel_Basic.Controls.Add(Button_Craft);
            Panel_Basic.Controls.Add(Input_Cost);
            Panel_Basic.Controls.Add(Input_CraftCheckResult);
            Panel_Basic.Controls.Add(Label_Cost);
            Panel_Basic.Controls.Add(Label_CraftResult);
            Panel_Basic.Dock = DockStyle.Fill;
            Panel_Basic.Location = new Point(0, 0);
            Panel_Basic.Name = "Panel_Basic";
            Panel_Basic.Size = new Size(253, 141);
            Panel_Basic.TabIndex = 23;
            // 
            // Label_TimeUsed
            // 
            Label_TimeUsed.AutoSize = true;
            Label_TimeUsed.Location = new Point(121, 91);
            Label_TimeUsed.Name = "Label_TimeUsed";
            Label_TimeUsed.Size = new Size(60, 15);
            Label_TimeUsed.TabIndex = 16;
            Label_TimeUsed.Text = "Base Price";
            // 
            // Input_DaysUsed
            // 
            Input_DaysUsed.Location = new Point(5, 88);
            Input_DaysUsed.Margin = new Padding(3, 2, 3, 2);
            Input_DaysUsed.Name = "Input_DaysUsed";
            Input_DaysUsed.Size = new Size(110, 23);
            Input_DaysUsed.TabIndex = 15;
            Input_DaysUsed.Text = "9";
            // 
            // Desc_DT_Text
            // 
            Desc_DT_Text.BackColor = SystemColors.Window;
            Desc_DT_Text.BorderStyle = BorderStyle.None;
            Desc_DT_Text.DetectUrls = false;
            Desc_DT_Text.Location = new Point(5, 82);
            Desc_DT_Text.Name = "Desc_DT_Text";
            Desc_DT_Text.ReadOnly = true;
            Desc_DT_Text.Size = new Size(242, 112);
            Desc_DT_Text.TabIndex = 16;
            Desc_DT_Text.Text = resources.GetString("Desc_DT_Text.Text");
            // 
            // CraftingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(Panel_Basic);
            Controls.Add(Panel_Result);
            Controls.Add(Tab_Crafting);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "CraftingScreen";
            Text = "Crafting Calculator";
            Tab_Crafting.ResumeLayout(false);
            Page_Craft.ResumeLayout(false);
            Page_Craft.PerformLayout();
            Page_Alch.ResumeLayout(false);
            Page_Alch.PerformLayout();
            Page_Magic.ResumeLayout(false);
            Page_Magic.PerformLayout();
            Page_Invention.ResumeLayout(false);
            Page_Invention.PerformLayout();
            Page_Gold.ResumeLayout(false);
            Page_Gold.PerformLayout();
            Panel_Result.ResumeLayout(false);
            Panel_Result.PerformLayout();
            Panel_Basic.ResumeLayout(false);
            Panel_Basic.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        #region Alchemy
        private TextBox Input_AlchemyDC;
        private Label Label_AlchemyDC;
        private ComboBox Check_Batch;
        private Label Label_Batch;
        private CheckBox Check_Cartridge;
        private TabPage Page_Alch;
        #endregion
        #region Crafting
        private TabControl Tab_Crafting;
        private ComboBox Input_CraftingDC;
        private Button Button_Craft;
        private CheckBox Check_Masterwork;
        private Label Label_CraftDC;
        private TabPage Page_Craft;
        private ImageList Image_Craft;
        private RichTextBox Desc_Complexity;
        #endregion
        #region Gold
        private TabPage Page_Gold;
        private Label Label_SaturdayResult;
        private TextBox Input_GoldCheck;
        private Label Label_GoldCheck;
        private TextBox Input_GoldDays;
        private Label Label_GoldDays;
        private TextBox Input_GoldLevel;
        private Label Label_GoldLevel;
        private TextBox Input_GoldTotalCash;
        private Label Label_GoldTotalCash;
        private TextBox Input_GoldCurrentCash;
        private Label Label_GoldCurrentCash;
        private Label Label_GoldTotalCashResult;
        private Label Label_GoldCurrentCashResult;
        private Label Label_GoldResult;
        #endregion
        #region Invention
        private TabPage Page_Invention;
        private TextBox Input_InventionImprovement;
        private TextBox Input_InventionLevel;
        private Label Label_InventionImprovement;
        private Label Label_InventionLevel;
        #endregion
        #region Magic
        private TabPage Page_Magic;
        private TextBox Input_MagicCaster;
        private Label Label_MagicCaster;
        private TextBox Input_MagicRequirement;
        private Label Label_MagicRequirement;
        #endregion
        #region Result
        private Label Label_Result_Time;
        private Label Label_Result_DC;
        private Label Label_Result_Cost;
        private Label Label_Result_Type;
        private RichTextBox Desc_DT_Text;
        #endregion
        #region General
        private TextBox Input_CraftCheckResult;
        private Label Label_CraftResult;
        private TextBox Input_Cost;
        private Label Label_Cost;
        private Label Label_TimeUsed;
        private TextBox Input_DaysUsed;
        private GroupBox Panel_Result;
        private Panel Panel_Basic;
        #endregion

    }
}