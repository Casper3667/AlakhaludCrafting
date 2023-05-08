namespace CraftingCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AlchemyDCInput = new TextBox();
            CraftingDCInput = new ComboBox();
            AlchemyDCLabel = new Label();
            CraftButton = new Button();
            ResultTime = new Label();
            CraftCheckResultInput = new TextBox();
            CraftResultLabel = new Label();
            MasterworkCheck = new CheckBox();
            BatchInput = new ComboBox();
            CraftLabelDC = new Label();
            BatchLabel = new Label();
            CostInput = new TextBox();
            CostLabel = new Label();
            ResultDC = new Label();
            ResultCost = new Label();
            CartridgeCheck = new CheckBox();
            ResultType = new Label();
            CraftingTabs = new TabControl();
            CraftPage = new TabPage();
            ComplexityDescBox = new RichTextBox();
            AlchPage = new TabPage();
            MagicPage = new TabPage();
            MagicCasterInput = new TextBox();
            magicCasterLabel = new Label();
            MagicRequirementInput = new TextBox();
            MagicRequirementLabel = new Label();
            InventionPage = new TabPage();
            Invention_improvement = new TextBox();
            label2 = new Label();
            Invention_level = new TextBox();
            label1 = new Label();
            GoldPage = new TabPage();
            Gold_total_cash_label = new Label();
            Gold_total_cash = new TextBox();
            GoldCashLabel2 = new Label();
            Gold_current_cash = new TextBox();
            Gold_current_cash_label = new Label();
            GoldCashLabel = new Label();
            saturday_label = new Label();
            Gold_check = new TextBox();
            Gold_result_label = new Label();
            label5 = new Label();
            Gold_days = new TextBox();
            label4 = new Label();
            Gold_level = new TextBox();
            label3 = new Label();
            CraftImages = new ImageList(components);
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            CraftingTabs.SuspendLayout();
            CraftPage.SuspendLayout();
            AlchPage.SuspendLayout();
            MagicPage.SuspendLayout();
            InventionPage.SuspendLayout();
            GoldPage.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // AlchemyDCInput
            // 
            AlchemyDCInput.Location = new Point(6, 28);
            AlchemyDCInput.Margin = new Padding(3, 2, 3, 2);
            AlchemyDCInput.Name = "AlchemyDCInput";
            AlchemyDCInput.RightToLeft = RightToLeft.No;
            AlchemyDCInput.Size = new Size(72, 23);
            AlchemyDCInput.TabIndex = 0;
            AlchemyDCInput.Text = "10";
            AlchemyDCInput.Leave += AlchemyDCInput_TextChanged;
            // 
            // CraftingDCInput
            // 
            CraftingDCInput.FormattingEnabled = true;
            CraftingDCInput.Items.AddRange(new object[] { "Very simple", "Simple", "Moderate", "Complex", "Very complex" });
            CraftingDCInput.Location = new Point(6, 5);
            CraftingDCInput.Margin = new Padding(3, 2, 3, 2);
            CraftingDCInput.Name = "CraftingDCInput";
            CraftingDCInput.Size = new Size(133, 23);
            CraftingDCInput.TabIndex = 2;
            CraftingDCInput.Text = "Very simple";
            CraftingDCInput.SelectionChangeCommitted += CraftingDCInput_SelectionChangeCommitted;
            // 
            // AlchemyDCLabel
            // 
            AlchemyDCLabel.AutoSize = true;
            AlchemyDCLabel.Location = new Point(84, 32);
            AlchemyDCLabel.Name = "AlchemyDCLabel";
            AlchemyDCLabel.Size = new Size(73, 15);
            AlchemyDCLabel.TabIndex = 3;
            AlchemyDCLabel.Text = "Alchemy DC";
            // 
            // CraftButton
            // 
            CraftButton.Location = new Point(5, 11);
            CraftButton.Margin = new Padding(3, 2, 3, 2);
            CraftButton.Name = "CraftButton";
            CraftButton.Size = new Size(82, 22);
            CraftButton.TabIndex = 4;
            CraftButton.Text = "Craft";
            CraftButton.UseVisualStyleBackColor = true;
            CraftButton.Click += CraftItem;
            // 
            // ResultTime
            // 
            ResultTime.AutoSize = true;
            ResultTime.Location = new Point(5, 18);
            ResultTime.Name = "ResultTime";
            ResultTime.Size = new Size(80, 15);
            ResultTime.TabIndex = 6;
            ResultTime.Text = "Crafting time:";
            // 
            // CraftCheckResultInput
            // 
            CraftCheckResultInput.Location = new Point(5, 37);
            CraftCheckResultInput.Margin = new Padding(3, 2, 3, 2);
            CraftCheckResultInput.Name = "CraftCheckResultInput";
            CraftCheckResultInput.Size = new Size(110, 23);
            CraftCheckResultInput.TabIndex = 7;
            CraftCheckResultInput.Text = "10";
            CraftCheckResultInput.Leave += CraftCheckResultInput_TextChanged;
            // 
            // CraftResultLabel
            // 
            CraftResultLabel.AutoSize = true;
            CraftResultLabel.Location = new Point(120, 40);
            CraftResultLabel.Name = "CraftResultLabel";
            CraftResultLabel.Size = new Size(86, 15);
            CraftResultLabel.TabIndex = 8;
            CraftResultLabel.Text = "Crafting Check";
            // 
            // MasterworkCheck
            // 
            MasterworkCheck.AutoSize = true;
            MasterworkCheck.Location = new Point(9, 34);
            MasterworkCheck.Margin = new Padding(3, 2, 3, 2);
            MasterworkCheck.Name = "MasterworkCheck";
            MasterworkCheck.Size = new Size(88, 19);
            MasterworkCheck.TabIndex = 9;
            MasterworkCheck.Text = "Masterwork";
            MasterworkCheck.UseVisualStyleBackColor = true;
            // 
            // BatchInput
            // 
            BatchInput.FormattingEnabled = true;
            BatchInput.Items.AddRange(new object[] { "1", "2", "4", "8", "16", "32" });
            BatchInput.Location = new Point(6, 55);
            BatchInput.Margin = new Padding(3, 2, 3, 2);
            BatchInput.Name = "BatchInput";
            BatchInput.Size = new Size(72, 23);
            BatchInput.TabIndex = 10;
            BatchInput.Text = "1";
            // 
            // CraftLabelDC
            // 
            CraftLabelDC.AutoSize = true;
            CraftLabelDC.Location = new Point(145, 9);
            CraftLabelDC.Name = "CraftLabelDC";
            CraftLabelDC.Size = new Size(69, 15);
            CraftLabelDC.TabIndex = 11;
            CraftLabelDC.Text = "Crafting DC";
            // 
            // BatchLabel
            // 
            BatchLabel.AutoSize = true;
            BatchLabel.Location = new Point(84, 59);
            BatchLabel.Name = "BatchLabel";
            BatchLabel.Size = new Size(48, 15);
            BatchLabel.TabIndex = 12;
            BatchLabel.Text = "Batches";
            // 
            // CostInput
            // 
            CostInput.Location = new Point(5, 62);
            CostInput.Margin = new Padding(3, 2, 3, 2);
            CostInput.Name = "CostInput";
            CostInput.Size = new Size(110, 23);
            CostInput.TabIndex = 13;
            CostInput.Text = "9";
            CostInput.Leave += CostInput_TextChanged;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(120, 64);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(60, 15);
            CostLabel.TabIndex = 14;
            CostLabel.Text = "Base Price";
            // 
            // ResultDC
            // 
            ResultDC.AutoSize = true;
            ResultDC.Location = new Point(5, 48);
            ResultDC.Name = "ResultDC";
            ResultDC.Size = new Size(26, 15);
            ResultDC.TabIndex = 15;
            ResultDC.Text = "DC:";
            // 
            // ResultCost
            // 
            ResultCost.AutoSize = true;
            ResultCost.Location = new Point(5, 34);
            ResultCost.Name = "ResultCost";
            ResultCost.Size = new Size(34, 15);
            ResultCost.TabIndex = 16;
            ResultCost.Text = "Cost:";
            // 
            // CartridgeCheck
            // 
            CartridgeCheck.AutoSize = true;
            CartridgeCheck.Location = new Point(6, 5);
            CartridgeCheck.Margin = new Padding(3, 2, 3, 2);
            CartridgeCheck.Name = "CartridgeCheck";
            CartridgeCheck.Size = new Size(102, 19);
            CartridgeCheck.TabIndex = 17;
            CartridgeCheck.Text = "Alch Cartridge";
            CartridgeCheck.UseVisualStyleBackColor = true;
            // 
            // ResultType
            // 
            ResultType.AutoSize = true;
            ResultType.Location = new Point(5, 64);
            ResultType.Name = "ResultType";
            ResultType.Size = new Size(34, 15);
            ResultType.TabIndex = 18;
            ResultType.Text = "Type:";
            // 
            // CraftingTabs
            // 
            CraftingTabs.Appearance = TabAppearance.FlatButtons;
            CraftingTabs.Controls.Add(CraftPage);
            CraftingTabs.Controls.Add(AlchPage);
            CraftingTabs.Controls.Add(MagicPage);
            CraftingTabs.Controls.Add(InventionPage);
            CraftingTabs.Controls.Add(GoldPage);
            CraftingTabs.Dock = DockStyle.Right;
            CraftingTabs.ImageList = CraftImages;
            CraftingTabs.ImeMode = ImeMode.NoControl;
            CraftingTabs.Location = new Point(419, 0);
            CraftingTabs.Multiline = true;
            CraftingTabs.Name = "CraftingTabs";
            CraftingTabs.RightToLeft = RightToLeft.No;
            CraftingTabs.SelectedIndex = 0;
            CraftingTabs.Size = new Size(281, 338);
            CraftingTabs.TabIndex = 19;
            // 
            // CraftPage
            // 
            CraftPage.Controls.Add(ComplexityDescBox);
            CraftPage.Controls.Add(CraftingDCInput);
            CraftPage.Controls.Add(CraftLabelDC);
            CraftPage.Controls.Add(MasterworkCheck);
            CraftPage.ImageIndex = 0;
            CraftPage.Location = new Point(4, 83);
            CraftPage.Name = "CraftPage";
            CraftPage.Padding = new Padding(3);
            CraftPage.Size = new Size(273, 251);
            CraftPage.TabIndex = 0;
            CraftPage.Text = "Craft";
            CraftPage.ToolTipText = "Mundane";
            CraftPage.UseVisualStyleBackColor = true;
            // 
            // ComplexityDescBox
            // 
            ComplexityDescBox.BackColor = SystemColors.Window;
            ComplexityDescBox.BorderStyle = BorderStyle.None;
            ComplexityDescBox.DetectUrls = false;
            ComplexityDescBox.Location = new Point(9, 58);
            ComplexityDescBox.Name = "ComplexityDescBox";
            ComplexityDescBox.ReadOnly = true;
            ComplexityDescBox.Size = new Size(246, 228);
            ComplexityDescBox.TabIndex = 15;
            ComplexityDescBox.Text = resources.GetString("ComplexityDescBox.Text");
            // 
            // AlchPage
            // 
            AlchPage.Controls.Add(AlchemyDCInput);
            AlchPage.Controls.Add(CartridgeCheck);
            AlchPage.Controls.Add(AlchemyDCLabel);
            AlchPage.Controls.Add(BatchInput);
            AlchPage.Controls.Add(BatchLabel);
            AlchPage.ImageIndex = 1;
            AlchPage.Location = new Point(4, 83);
            AlchPage.Name = "AlchPage";
            AlchPage.Padding = new Padding(3);
            AlchPage.RightToLeft = RightToLeft.No;
            AlchPage.Size = new Size(273, 251);
            AlchPage.TabIndex = 1;
            AlchPage.Text = "Alchemy";
            AlchPage.ToolTipText = "Alchemy";
            AlchPage.UseVisualStyleBackColor = true;
            // 
            // MagicPage
            // 
            MagicPage.Controls.Add(MagicCasterInput);
            MagicPage.Controls.Add(magicCasterLabel);
            MagicPage.Controls.Add(MagicRequirementInput);
            MagicPage.Controls.Add(MagicRequirementLabel);
            MagicPage.ImageIndex = 2;
            MagicPage.Location = new Point(4, 83);
            MagicPage.Name = "MagicPage";
            MagicPage.Padding = new Padding(3);
            MagicPage.Size = new Size(273, 251);
            MagicPage.TabIndex = 2;
            MagicPage.Text = "Magic";
            MagicPage.ToolTipText = "Magic";
            MagicPage.UseVisualStyleBackColor = true;
            // 
            // MagicCasterInput
            // 
            MagicCasterInput.Location = new Point(6, 32);
            MagicCasterInput.Margin = new Padding(3, 2, 3, 2);
            MagicCasterInput.Name = "MagicCasterInput";
            MagicCasterInput.RightToLeft = RightToLeft.No;
            MagicCasterInput.Size = new Size(72, 23);
            MagicCasterInput.TabIndex = 6;
            MagicCasterInput.Text = "10";
            MagicCasterInput.Leave += MagicCasterInput_Leave;
            // 
            // magicCasterLabel
            // 
            magicCasterLabel.AutoSize = true;
            magicCasterLabel.Location = new Point(84, 36);
            magicCasterLabel.Name = "magicCasterLabel";
            magicCasterLabel.Size = new Size(70, 15);
            magicCasterLabel.TabIndex = 7;
            magicCasterLabel.Text = "Caster Level";
            // 
            // MagicRequirementInput
            // 
            MagicRequirementInput.Location = new Point(6, 5);
            MagicRequirementInput.Margin = new Padding(3, 2, 3, 2);
            MagicRequirementInput.Name = "MagicRequirementInput";
            MagicRequirementInput.RightToLeft = RightToLeft.No;
            MagicRequirementInput.Size = new Size(72, 23);
            MagicRequirementInput.TabIndex = 4;
            MagicRequirementInput.Text = "10";
            MagicRequirementInput.Leave += MagicRequirementInput_Leave;
            // 
            // MagicRequirementLabel
            // 
            MagicRequirementLabel.AutoSize = true;
            MagicRequirementLabel.Location = new Point(84, 9);
            MagicRequirementLabel.Name = "MagicRequirementLabel";
            MagicRequirementLabel.Size = new Size(124, 15);
            MagicRequirementLabel.TabIndex = 5;
            MagicRequirementLabel.Text = "Missing Requirements";
            // 
            // InventionPage
            // 
            InventionPage.Controls.Add(Invention_improvement);
            InventionPage.Controls.Add(label2);
            InventionPage.Controls.Add(Invention_level);
            InventionPage.Controls.Add(label1);
            InventionPage.ImageIndex = 3;
            InventionPage.Location = new Point(4, 83);
            InventionPage.Name = "InventionPage";
            InventionPage.Padding = new Padding(3);
            InventionPage.Size = new Size(273, 251);
            InventionPage.TabIndex = 3;
            InventionPage.Text = "Invention";
            InventionPage.ToolTipText = "Invention";
            InventionPage.UseVisualStyleBackColor = true;
            // 
            // Invention_improvement
            // 
            Invention_improvement.Location = new Point(6, 32);
            Invention_improvement.Margin = new Padding(3, 2, 3, 2);
            Invention_improvement.Name = "Invention_improvement";
            Invention_improvement.Size = new Size(110, 23);
            Invention_improvement.TabIndex = 17;
            Invention_improvement.Text = "3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 35);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 18;
            label2.Text = "Improvements";
            // 
            // Invention_level
            // 
            Invention_level.Location = new Point(6, 5);
            Invention_level.Margin = new Padding(3, 2, 3, 2);
            Invention_level.Name = "Invention_level";
            Invention_level.Size = new Size(110, 23);
            Invention_level.TabIndex = 15;
            Invention_level.Text = "9";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 8);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 16;
            label1.Text = "Level";
            // 
            // GoldPage
            // 
            GoldPage.Controls.Add(Gold_total_cash_label);
            GoldPage.Controls.Add(Gold_total_cash);
            GoldPage.Controls.Add(GoldCashLabel2);
            GoldPage.Controls.Add(Gold_current_cash);
            GoldPage.Controls.Add(Gold_current_cash_label);
            GoldPage.Controls.Add(GoldCashLabel);
            GoldPage.Controls.Add(saturday_label);
            GoldPage.Controls.Add(Gold_check);
            GoldPage.Controls.Add(Gold_result_label);
            GoldPage.Controls.Add(label5);
            GoldPage.Controls.Add(Gold_days);
            GoldPage.Controls.Add(label4);
            GoldPage.Controls.Add(Gold_level);
            GoldPage.Controls.Add(label3);
            GoldPage.ImageIndex = 4;
            GoldPage.Location = new Point(4, 83);
            GoldPage.Name = "GoldPage";
            GoldPage.Padding = new Padding(3);
            GoldPage.Size = new Size(273, 251);
            GoldPage.TabIndex = 4;
            GoldPage.Text = "Gold";
            GoldPage.UseVisualStyleBackColor = true;
            // 
            // Gold_total_cash_label
            // 
            Gold_total_cash_label.AutoSize = true;
            Gold_total_cash_label.Location = new Point(6, 186);
            Gold_total_cash_label.Name = "Gold_total_cash_label";
            Gold_total_cash_label.Size = new Size(65, 15);
            Gold_total_cash_label.TabIndex = 28;
            Gold_total_cash_label.Text = "Total cash: ";
            // 
            // Gold_total_cash
            // 
            Gold_total_cash.Location = new Point(6, 113);
            Gold_total_cash.Margin = new Padding(3, 2, 3, 2);
            Gold_total_cash.Name = "Gold_total_cash";
            Gold_total_cash.Size = new Size(110, 23);
            Gold_total_cash.TabIndex = 21;
            Gold_total_cash.Text = "10";
            // 
            // GoldCashLabel2
            // 
            GoldCashLabel2.AutoSize = true;
            GoldCashLabel2.Location = new Point(121, 116);
            GoldCashLabel2.Name = "GoldCashLabel2";
            GoldCashLabel2.Size = new Size(59, 15);
            GoldCashLabel2.TabIndex = 22;
            GoldCashLabel2.Text = "Total cash";
            // 
            // Gold_current_cash
            // 
            Gold_current_cash.Location = new Point(6, 86);
            Gold_current_cash.Margin = new Padding(3, 2, 3, 2);
            Gold_current_cash.Name = "Gold_current_cash";
            Gold_current_cash.Size = new Size(110, 23);
            Gold_current_cash.TabIndex = 19;
            Gold_current_cash.Text = "10";
            // 
            // Gold_current_cash_label
            // 
            Gold_current_cash_label.AutoSize = true;
            Gold_current_cash_label.Location = new Point(6, 172);
            Gold_current_cash_label.Name = "Gold_current_cash_label";
            Gold_current_cash_label.Size = new Size(80, 15);
            Gold_current_cash_label.TabIndex = 27;
            Gold_current_cash_label.Text = "Current cash: ";
            // 
            // GoldCashLabel
            // 
            GoldCashLabel.AutoSize = true;
            GoldCashLabel.Location = new Point(121, 89);
            GoldCashLabel.Name = "GoldCashLabel";
            GoldCashLabel.Size = new Size(74, 15);
            GoldCashLabel.TabIndex = 20;
            GoldCashLabel.Text = "Current cash";
            // 
            // saturday_label
            // 
            saturday_label.AutoSize = true;
            saturday_label.Location = new Point(6, 138);
            saturday_label.Name = "saturday_label";
            saturday_label.Size = new Size(136, 15);
            saturday_label.TabIndex = 18;
            saturday_label.Text = "Saturdays in the month: ";
            // 
            // Gold_check
            // 
            Gold_check.Location = new Point(6, 59);
            Gold_check.Margin = new Padding(3, 2, 3, 2);
            Gold_check.Name = "Gold_check";
            Gold_check.Size = new Size(110, 23);
            Gold_check.TabIndex = 13;
            Gold_check.Text = "10";
            // 
            // Gold_result_label
            // 
            Gold_result_label.AutoSize = true;
            Gold_result_label.Location = new Point(6, 157);
            Gold_result_label.Name = "Gold_result_label";
            Gold_result_label.Size = new Size(45, 15);
            Gold_result_label.TabIndex = 26;
            Gold_result_label.Text = "Result: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 62);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 14;
            label5.Text = "Check";
            // 
            // Gold_days
            // 
            Gold_days.Location = new Point(6, 32);
            Gold_days.Margin = new Padding(3, 2, 3, 2);
            Gold_days.Name = "Gold_days";
            Gold_days.Size = new Size(110, 23);
            Gold_days.TabIndex = 11;
            Gold_days.Text = "4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 35);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 12;
            label4.Text = "Days";
            // 
            // Gold_level
            // 
            Gold_level.Location = new Point(6, 5);
            Gold_level.Margin = new Padding(3, 2, 3, 2);
            Gold_level.Name = "Gold_level";
            Gold_level.Size = new Size(110, 23);
            Gold_level.TabIndex = 9;
            Gold_level.Text = "10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 8);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 10;
            label3.Text = "Level";
            // 
            // CraftImages
            // 
            CraftImages.ColorDepth = ColorDepth.Depth32Bit;
            CraftImages.ImageStream = (ImageListStreamer)resources.GetObject("CraftImages.ImageStream");
            CraftImages.TransparentColor = Color.Transparent;
            CraftImages.Images.SetKeyName(0, "hammer_3.png");
            CraftImages.Images.SetKeyName(1, "potions.png");
            CraftImages.Images.SetKeyName(2, "dyes.PNG");
            CraftImages.Images.SetKeyName(3, "goggles.PNG");
            CraftImages.Images.SetKeyName(4, "coins.png");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ResultTime);
            groupBox1.Controls.Add(ResultType);
            groupBox1.Controls.Add(ResultDC);
            groupBox1.Controls.Add(ResultCost);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 246);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(419, 92);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(CraftButton);
            panel2.Controls.Add(CostInput);
            panel2.Controls.Add(CraftCheckResultInput);
            panel2.Controls.Add(CostLabel);
            panel2.Controls.Add(CraftResultLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(419, 246);
            panel2.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(CraftingTabs);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Crafting Calculator";
            CraftingTabs.ResumeLayout(false);
            CraftPage.ResumeLayout(false);
            CraftPage.PerformLayout();
            AlchPage.ResumeLayout(false);
            AlchPage.PerformLayout();
            MagicPage.ResumeLayout(false);
            MagicPage.PerformLayout();
            InventionPage.ResumeLayout(false);
            InventionPage.PerformLayout();
            GoldPage.ResumeLayout(false);
            GoldPage.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox AlchemyDCInput;
        private ComboBox CraftingDCInput;
        private Label AlchemyDCLabel;
        private Button CraftButton;
        private Label ResultTime;
        private TextBox CraftCheckResultInput;
        private Label CraftResultLabel;
        private CheckBox MasterworkCheck;
        private ComboBox BatchInput;
        private Label CraftLabelDC;
        private Label BatchLabel;
        private TextBox CostInput;
        private Label CostLabel;
        private Label ResultDC;
        private Label ResultCost;
        private CheckBox CartridgeCheck;
        private Label ResultType;
        private TabControl CraftingTabs;
        private TabPage CraftPage;
        private TabPage AlchPage;
        private ImageList CraftImages;
        private TabPage MagicPage;
        private GroupBox groupBox1;
        private Panel panel2;
        private RichTextBox ComplexityDescBox;
        private TextBox MagicCasterInput;
        private Label magicCasterLabel;
        private TextBox MagicRequirementInput;
        private Label MagicRequirementLabel;
        private TabPage InventionPage;
        private TabPage GoldPage;
        private TextBox Invention_improvement;
        private Label label2;
        private TextBox Invention_level;
        private Label label1;
        private Label saturday_label;
        private TextBox Gold_check;
        private Label label5;
        private TextBox Gold_days;
        private Label label4;
        private TextBox Gold_level;
        private Label label3;
        private TextBox Gold_total_cash;
        private Label GoldCashLabel2;
        private TextBox Gold_current_cash;
        private Label GoldCashLabel;
        private Label Gold_total_cash_label;
        private Label Gold_current_cash_label;
        private Label Gold_result_label;
    }
}