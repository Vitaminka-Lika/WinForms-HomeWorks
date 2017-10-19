namespace WinFormHomeDZ5_17_10_17
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.fuelBox = new System.Windows.Forms.GroupBox();
            this.fuelPriceComboBox = new System.Windows.Forms.ComboBox();
            this.fuelValueBox = new System.Windows.Forms.GroupBox();
            this.totalFuelLabel = new System.Windows.Forms.Label();
            this.moneyCountBox = new System.Windows.Forms.TextBox();
            this.litersCountBox = new System.Windows.Forms.TextBox();
            this.typeOfPrice = new System.Windows.Forms.Panel();
            this.moneyRadioButton = new System.Windows.Forms.RadioButton();
            this.litersRadioButton = new System.Windows.Forms.RadioButton();
            this.priceLabel = new System.Windows.Forms.Label();
            this.fuelLabel = new System.Windows.Forms.Label();
            this.fuelTypeComboBox = new System.Windows.Forms.ComboBox();
            this.foodBox = new System.Windows.Forms.GroupBox();
            this.foodValueBox = new System.Windows.Forms.GroupBox();
            this.totalFoodLabel = new System.Windows.Forms.Label();
            this.itemsCount = new System.Windows.Forms.Label();
            this.cocaColaCount = new System.Windows.Forms.TextBox();
            this.friesCount = new System.Windows.Forms.TextBox();
            this.hamburgerCount = new System.Windows.Forms.TextBox();
            this.hotDogCount = new System.Windows.Forms.TextBox();
            this.cocaColaPrice = new System.Windows.Forms.TextBox();
            this.friesPrice = new System.Windows.Forms.TextBox();
            this.hamburgerPrice = new System.Windows.Forms.TextBox();
            this.hotDogPrice = new System.Windows.Forms.TextBox();
            this.shopPrice = new System.Windows.Forms.Label();
            this.cocaColaBox = new System.Windows.Forms.CheckBox();
            this.friesBox = new System.Windows.Forms.CheckBox();
            this.hamburgerBox = new System.Windows.Forms.CheckBox();
            this.hotDogBox = new System.Windows.Forms.CheckBox();
            this.totalCostBox = new System.Windows.Forms.GroupBox();
            this.totalCostButton = new System.Windows.Forms.Button();
            this.sumLabel = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.stripDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.сменитьЦветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayOfTheWeekItem = new System.Windows.Forms.ToolStripMenuItem();
            this.английскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentDate = new System.Windows.Forms.ToolStripLabel();
            this.fuelBox.SuspendLayout();
            this.fuelValueBox.SuspendLayout();
            this.typeOfPrice.SuspendLayout();
            this.foodBox.SuspendLayout();
            this.foodValueBox.SuspendLayout();
            this.totalCostBox.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fuelBox
            // 
            this.fuelBox.Controls.Add(this.fuelPriceComboBox);
            this.fuelBox.Controls.Add(this.fuelValueBox);
            this.fuelBox.Controls.Add(this.moneyCountBox);
            this.fuelBox.Controls.Add(this.litersCountBox);
            this.fuelBox.Controls.Add(this.typeOfPrice);
            this.fuelBox.Controls.Add(this.priceLabel);
            this.fuelBox.Controls.Add(this.fuelLabel);
            this.fuelBox.Controls.Add(this.fuelTypeComboBox);
            this.fuelBox.Location = new System.Drawing.Point(13, 13);
            this.fuelBox.Name = "fuelBox";
            this.fuelBox.Size = new System.Drawing.Size(226, 206);
            this.fuelBox.TabIndex = 0;
            this.fuelBox.TabStop = false;
            this.fuelBox.Text = "Бензин:";
            // 
            // fuelPriceComboBox
            // 
            this.fuelPriceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fuelPriceComboBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.fuelPriceComboBox.Items.AddRange(new object[] {
            "150",
            "158",
            "120",
            "153",
            "167",
            "198"});
            this.fuelPriceComboBox.Location = new System.Drawing.Point(85, 47);
            this.fuelPriceComboBox.Name = "fuelPriceComboBox";
            this.fuelPriceComboBox.Size = new System.Drawing.Size(121, 21);
            this.fuelPriceComboBox.TabIndex = 10;
            this.fuelPriceComboBox.SelectedIndexChanged += new System.EventHandler(this.OilCost_SelectedIndexChanged);
            // 
            // fuelValueBox
            // 
            this.fuelValueBox.Controls.Add(this.totalFuelLabel);
            this.fuelValueBox.Location = new System.Drawing.Point(17, 136);
            this.fuelValueBox.Name = "fuelValueBox";
            this.fuelValueBox.Size = new System.Drawing.Size(200, 51);
            this.fuelValueBox.TabIndex = 9;
            this.fuelValueBox.TabStop = false;
            this.fuelValueBox.Text = "Итого:";
            // 
            // totalFuelLabel
            // 
            this.totalFuelLabel.AutoSize = true;
            this.totalFuelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalFuelLabel.Location = new System.Drawing.Point(79, 16);
            this.totalFuelLabel.Name = "totalFuelLabel";
            this.totalFuelLabel.Size = new System.Drawing.Size(24, 25);
            this.totalFuelLabel.TabIndex = 0;
            this.totalFuelLabel.Text = "0";
            // 
            // moneyCountBox
            // 
            this.moneyCountBox.Enabled = false;
            this.moneyCountBox.Location = new System.Drawing.Point(107, 103);
            this.moneyCountBox.Name = "moneyCountBox";
            this.moneyCountBox.Size = new System.Drawing.Size(77, 20);
            this.moneyCountBox.TabIndex = 6;
            this.moneyCountBox.Text = "0";
            this.moneyCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.moneyCountBox.TextChanged += new System.EventHandler(this.MoneyBox_Changed);
            // 
            // litersCountBox
            // 
            this.litersCountBox.Enabled = false;
            this.litersCountBox.Location = new System.Drawing.Point(108, 77);
            this.litersCountBox.Name = "litersCountBox";
            this.litersCountBox.Size = new System.Drawing.Size(76, 20);
            this.litersCountBox.TabIndex = 5;
            this.litersCountBox.Text = "0";
            this.litersCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.litersCountBox.TextChanged += new System.EventHandler(this.LitCountBox_Changed);
            // 
            // typeOfPrice
            // 
            this.typeOfPrice.Controls.Add(this.moneyRadioButton);
            this.typeOfPrice.Controls.Add(this.litersRadioButton);
            this.typeOfPrice.Location = new System.Drawing.Point(17, 70);
            this.typeOfPrice.Name = "typeOfPrice";
            this.typeOfPrice.Size = new System.Drawing.Size(78, 57);
            this.typeOfPrice.TabIndex = 4;
            // 
            // moneyRadioButton
            // 
            this.moneyRadioButton.AutoSize = true;
            this.moneyRadioButton.Location = new System.Drawing.Point(7, 30);
            this.moneyRadioButton.Name = "moneyRadioButton";
            this.moneyRadioButton.Size = new System.Drawing.Size(63, 17);
            this.moneyRadioButton.TabIndex = 1;
            this.moneyRadioButton.Text = "Деньги";
            this.moneyRadioButton.UseVisualStyleBackColor = true;
            this.moneyRadioButton.CheckedChanged += new System.EventHandler(this.MoneyRadioButton_CheckedChanged);
            // 
            // litersRadioButton
            // 
            this.litersRadioButton.AutoSize = true;
            this.litersRadioButton.Location = new System.Drawing.Point(6, 7);
            this.litersRadioButton.Name = "litersRadioButton";
            this.litersRadioButton.Size = new System.Drawing.Size(58, 17);
            this.litersRadioButton.TabIndex = 0;
            this.litersRadioButton.Text = "Литры";
            this.litersRadioButton.UseVisualStyleBackColor = true;
            this.litersRadioButton.CheckedChanged += new System.EventHandler(this.LitRadioButton_CheckedChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(14, 47);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(65, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Стоимость:";
            // 
            // fuelLabel
            // 
            this.fuelLabel.AutoSize = true;
            this.fuelLabel.Location = new System.Drawing.Point(14, 24);
            this.fuelLabel.Name = "fuelLabel";
            this.fuelLabel.Size = new System.Drawing.Size(29, 13);
            this.fuelLabel.TabIndex = 1;
            this.fuelLabel.Text = "Тип:";
            // 
            // fuelTypeComboBox
            // 
            this.fuelTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fuelTypeComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.fuelTypeComboBox.Items.AddRange(new object[] {
            "АИ-92",
            "АИ-95",
            "АИ-98",
            "Газ",
            "ДТ",
            "ДТ-Зима"});
            this.fuelTypeComboBox.Location = new System.Drawing.Point(85, 24);
            this.fuelTypeComboBox.Name = "fuelTypeComboBox";
            this.fuelTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.fuelTypeComboBox.TabIndex = 0;
            this.fuelTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.OilType_SelectedIndexChanged);
            // 
            // foodBox
            // 
            this.foodBox.Controls.Add(this.foodValueBox);
            this.foodBox.Controls.Add(this.itemsCount);
            this.foodBox.Controls.Add(this.cocaColaCount);
            this.foodBox.Controls.Add(this.friesCount);
            this.foodBox.Controls.Add(this.hamburgerCount);
            this.foodBox.Controls.Add(this.hotDogCount);
            this.foodBox.Controls.Add(this.cocaColaPrice);
            this.foodBox.Controls.Add(this.friesPrice);
            this.foodBox.Controls.Add(this.hamburgerPrice);
            this.foodBox.Controls.Add(this.hotDogPrice);
            this.foodBox.Controls.Add(this.shopPrice);
            this.foodBox.Controls.Add(this.cocaColaBox);
            this.foodBox.Controls.Add(this.friesBox);
            this.foodBox.Controls.Add(this.hamburgerBox);
            this.foodBox.Controls.Add(this.hotDogBox);
            this.foodBox.Location = new System.Drawing.Point(246, 13);
            this.foodBox.Name = "foodBox";
            this.foodBox.Size = new System.Drawing.Size(241, 206);
            this.foodBox.TabIndex = 1;
            this.foodBox.TabStop = false;
            this.foodBox.Text = "Еда:";
            // 
            // foodValueBox
            // 
            this.foodValueBox.Controls.Add(this.totalFoodLabel);
            this.foodValueBox.Location = new System.Drawing.Point(7, 136);
            this.foodValueBox.Name = "foodValueBox";
            this.foodValueBox.Size = new System.Drawing.Size(219, 51);
            this.foodValueBox.TabIndex = 14;
            this.foodValueBox.TabStop = false;
            this.foodValueBox.Text = "Итого:";
            // 
            // totalFoodLabel
            // 
            this.totalFoodLabel.AutoSize = true;
            this.totalFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalFoodLabel.Location = new System.Drawing.Point(109, 13);
            this.totalFoodLabel.Name = "totalFoodLabel";
            this.totalFoodLabel.Size = new System.Drawing.Size(24, 25);
            this.totalFoodLabel.TabIndex = 1;
            this.totalFoodLabel.Text = "0";
            // 
            // itemsCount
            // 
            this.itemsCount.AutoSize = true;
            this.itemsCount.Location = new System.Drawing.Point(166, 16);
            this.itemsCount.Name = "itemsCount";
            this.itemsCount.Size = new System.Drawing.Size(60, 13);
            this.itemsCount.TabIndex = 13;
            this.itemsCount.Text = "Колчество";
            // 
            // cocaColaCount
            // 
            this.cocaColaCount.Enabled = false;
            this.cocaColaCount.Location = new System.Drawing.Point(165, 107);
            this.cocaColaCount.Name = "cocaColaCount";
            this.cocaColaCount.Size = new System.Drawing.Size(60, 20);
            this.cocaColaCount.TabIndex = 12;
            this.cocaColaCount.Text = "0";
            this.cocaColaCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cocaColaCount.TextChanged += new System.EventHandler(this.Count_TextChanged);
            // 
            // friesCount
            // 
            this.friesCount.Enabled = false;
            this.friesCount.Location = new System.Drawing.Point(166, 83);
            this.friesCount.Name = "friesCount";
            this.friesCount.Size = new System.Drawing.Size(60, 20);
            this.friesCount.TabIndex = 11;
            this.friesCount.Text = "0";
            this.friesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.friesCount.TextChanged += new System.EventHandler(this.Count_TextChanged);
            // 
            // hamburgerCount
            // 
            this.hamburgerCount.Enabled = false;
            this.hamburgerCount.Location = new System.Drawing.Point(166, 60);
            this.hamburgerCount.Name = "hamburgerCount";
            this.hamburgerCount.Size = new System.Drawing.Size(60, 20);
            this.hamburgerCount.TabIndex = 10;
            this.hamburgerCount.Text = "0";
            this.hamburgerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hamburgerCount.TextChanged += new System.EventHandler(this.Count_TextChanged);
            // 
            // hotDogCount
            // 
            this.hotDogCount.Enabled = false;
            this.hotDogCount.Location = new System.Drawing.Point(166, 37);
            this.hotDogCount.Name = "hotDogCount";
            this.hotDogCount.Size = new System.Drawing.Size(60, 20);
            this.hotDogCount.TabIndex = 9;
            this.hotDogCount.Text = "0";
            this.hotDogCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hotDogCount.TextChanged += new System.EventHandler(this.Count_TextChanged);
            // 
            // cocaColaPrice
            // 
            this.cocaColaPrice.Enabled = false;
            this.cocaColaPrice.Location = new System.Drawing.Point(113, 107);
            this.cocaColaPrice.Name = "cocaColaPrice";
            this.cocaColaPrice.Size = new System.Drawing.Size(47, 20);
            this.cocaColaPrice.TabIndex = 8;
            this.cocaColaPrice.Text = "260";
            this.cocaColaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // friesPrice
            // 
            this.friesPrice.Enabled = false;
            this.friesPrice.Location = new System.Drawing.Point(113, 83);
            this.friesPrice.Name = "friesPrice";
            this.friesPrice.Size = new System.Drawing.Size(47, 20);
            this.friesPrice.TabIndex = 7;
            this.friesPrice.Text = "200";
            this.friesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hamburgerPrice
            // 
            this.hamburgerPrice.Enabled = false;
            this.hamburgerPrice.Location = new System.Drawing.Point(113, 60);
            this.hamburgerPrice.Name = "hamburgerPrice";
            this.hamburgerPrice.Size = new System.Drawing.Size(47, 20);
            this.hamburgerPrice.TabIndex = 6;
            this.hamburgerPrice.Text = "500";
            this.hamburgerPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hotDogPrice
            // 
            this.hotDogPrice.Enabled = false;
            this.hotDogPrice.Location = new System.Drawing.Point(113, 37);
            this.hotDogPrice.Name = "hotDogPrice";
            this.hotDogPrice.Size = new System.Drawing.Size(47, 20);
            this.hotDogPrice.TabIndex = 5;
            this.hotDogPrice.Text = "250";
            this.hotDogPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // shopPrice
            // 
            this.shopPrice.AutoSize = true;
            this.shopPrice.Location = new System.Drawing.Point(110, 16);
            this.shopPrice.Name = "shopPrice";
            this.shopPrice.Size = new System.Drawing.Size(33, 13);
            this.shopPrice.TabIndex = 4;
            this.shopPrice.Text = "Цена";
            // 
            // cocaColaBox
            // 
            this.cocaColaBox.AutoSize = true;
            this.cocaColaBox.Location = new System.Drawing.Point(6, 106);
            this.cocaColaBox.Name = "cocaColaBox";
            this.cocaColaBox.Size = new System.Drawing.Size(51, 17);
            this.cocaColaBox.TabIndex = 3;
            this.cocaColaBox.Text = "Кола";
            this.cocaColaBox.UseVisualStyleBackColor = true;
            this.cocaColaBox.CheckedChanged += new System.EventHandler(this.CocaColaBox_CheckedChanged);
            // 
            // friesBox
            // 
            this.friesBox.AutoSize = true;
            this.friesBox.Location = new System.Drawing.Point(6, 83);
            this.friesBox.Name = "friesBox";
            this.friesBox.Size = new System.Drawing.Size(105, 17);
            this.friesBox.TabIndex = 2;
            this.friesBox.Text = "Картофель-фри";
            this.friesBox.UseVisualStyleBackColor = true;
            this.friesBox.CheckedChanged += new System.EventHandler(this.FreeBox_CheckedChanged);
            // 
            // hamburgerBox
            // 
            this.hamburgerBox.AutoSize = true;
            this.hamburgerBox.Location = new System.Drawing.Point(6, 60);
            this.hamburgerBox.Name = "hamburgerBox";
            this.hamburgerBox.Size = new System.Drawing.Size(80, 17);
            this.hamburgerBox.TabIndex = 1;
            this.hamburgerBox.Text = "Гамбургер";
            this.hamburgerBox.UseVisualStyleBackColor = true;
            this.hamburgerBox.CheckedChanged += new System.EventHandler(this.HamburgerBox_CheckedChanged);
            // 
            // hotDogBox
            // 
            this.hotDogBox.AutoSize = true;
            this.hotDogBox.Location = new System.Drawing.Point(6, 37);
            this.hotDogBox.Name = "hotDogBox";
            this.hotDogBox.Size = new System.Drawing.Size(67, 17);
            this.hotDogBox.TabIndex = 0;
            this.hotDogBox.Text = "Хот-Дог";
            this.hotDogBox.UseVisualStyleBackColor = true;
            this.hotDogBox.CheckedChanged += new System.EventHandler(this.HotDogBox_CheckedChanged);
            // 
            // totalCostBox
            // 
            this.totalCostBox.Controls.Add(this.totalCostButton);
            this.totalCostBox.Controls.Add(this.sumLabel);
            this.totalCostBox.Location = new System.Drawing.Point(13, 226);
            this.totalCostBox.Name = "totalCostBox";
            this.totalCostBox.Size = new System.Drawing.Size(474, 100);
            this.totalCostBox.TabIndex = 2;
            this.totalCostBox.TabStop = false;
            this.totalCostBox.Text = "Итого:";
            // 
            // totalCostButton
            // 
            this.totalCostButton.Location = new System.Drawing.Point(7, 20);
            this.totalCostButton.Name = "totalCostButton";
            this.totalCostButton.Size = new System.Drawing.Size(219, 74);
            this.totalCostButton.TabIndex = 2;
            this.totalCostButton.Text = "Подсчитать общую стоимость";
            this.totalCostButton.UseVisualStyleBackColor = true;
            this.totalCostButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonPrepare_MouseClick);
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumLabel.Location = new System.Drawing.Point(339, 33);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(35, 37);
            this.sumLabel.TabIndex = 1;
            this.sumLabel.Text = "0";
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(12, 332);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(475, 39);
            this.payButton.TabIndex = 0;
            this.payButton.Text = "Оплатить";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonPay_MouseClick);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripDownButton,
            this.currentDate});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 387);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(508, 25);
            this.mainToolStrip.TabIndex = 3;
            // 
            // stripDownButton
            // 
            this.stripDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьЦветToolStripMenuItem,
            this.dayOfTheWeekItem,
            this.английскийToolStripMenuItem,
            this.русскийToolStripMenuItem});
            this.stripDownButton.Image = ((System.Drawing.Image)(resources.GetObject("stripDownButton.Image")));
            this.stripDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripDownButton.Name = "stripDownButton";
            this.stripDownButton.Size = new System.Drawing.Size(29, 22);
            this.stripDownButton.Text = "toolStripDropDownButton1";
            // 
            // сменитьЦветToolStripMenuItem
            // 
            this.сменитьЦветToolStripMenuItem.Name = "сменитьЦветToolStripMenuItem";
            this.сменитьЦветToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.сменитьЦветToolStripMenuItem.Text = "Сменить цвет";
            this.сменитьЦветToolStripMenuItem.Click += new System.EventHandler(this.ChangeColorToolStripMenuItem_Click);
            // 
            // dayOfTheWeekItem
            // 
            this.dayOfTheWeekItem.Name = "dayOfTheWeekItem";
            this.dayOfTheWeekItem.Size = new System.Drawing.Size(149, 22);
            this.dayOfTheWeekItem.Text = "День недели";
            // 
            // английскийToolStripMenuItem
            // 
            this.английскийToolStripMenuItem.Name = "английскийToolStripMenuItem";
            this.английскийToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.английскийToolStripMenuItem.Text = "Английский";
            this.английскийToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItem_Click);
            // 
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.русскийToolStripMenuItem.Text = "Русский";
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.RussianToolStripMenuItem_Click);
            // 
            // currentDate
            // 
            this.currentDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(0, 22);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 412);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.totalCostBox);
            this.Controls.Add(this.foodBox);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.fuelBox);
            this.Name = "mainForm";
            this.Text = "Главное Меню";
            this.fuelBox.ResumeLayout(false);
            this.fuelBox.PerformLayout();
            this.fuelValueBox.ResumeLayout(false);
            this.fuelValueBox.PerformLayout();
            this.typeOfPrice.ResumeLayout(false);
            this.typeOfPrice.PerformLayout();
            this.foodBox.ResumeLayout(false);
            this.foodBox.PerformLayout();
            this.foodValueBox.ResumeLayout(false);
            this.foodValueBox.PerformLayout();
            this.totalCostBox.ResumeLayout(false);
            this.totalCostBox.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox fuelBox;
        private System.Windows.Forms.GroupBox fuelValueBox;
        private System.Windows.Forms.TextBox moneyCountBox;
        private System.Windows.Forms.TextBox litersCountBox;
        private System.Windows.Forms.Panel typeOfPrice;
        private System.Windows.Forms.RadioButton moneyRadioButton;
        private System.Windows.Forms.RadioButton litersRadioButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label fuelLabel;
        private System.Windows.Forms.ComboBox fuelTypeComboBox;
        private System.Windows.Forms.Label totalFuelLabel;
        private System.Windows.Forms.GroupBox foodBox;
        private System.Windows.Forms.Label itemsCount;
        private System.Windows.Forms.TextBox cocaColaCount;
        private System.Windows.Forms.TextBox friesCount;
        private System.Windows.Forms.TextBox hamburgerCount;
        private System.Windows.Forms.TextBox hotDogCount;
        private System.Windows.Forms.TextBox cocaColaPrice;
        private System.Windows.Forms.TextBox friesPrice;
        private System.Windows.Forms.TextBox hamburgerPrice;
        private System.Windows.Forms.TextBox hotDogPrice;
        private System.Windows.Forms.Label shopPrice;
        private System.Windows.Forms.CheckBox cocaColaBox;
        private System.Windows.Forms.CheckBox friesBox;
        private System.Windows.Forms.CheckBox hamburgerBox;
        private System.Windows.Forms.CheckBox hotDogBox;
        private System.Windows.Forms.ComboBox fuelPriceComboBox;
        private System.Windows.Forms.GroupBox foodValueBox;
        private System.Windows.Forms.Label totalFoodLabel;
        private System.Windows.Forms.GroupBox totalCostBox;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button totalCostButton;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton stripDownButton;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem английскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayOfTheWeekItem;
        private System.Windows.Forms.ToolStripLabel currentDate;
        private System.Windows.Forms.ToolStripMenuItem сменитьЦветToolStripMenuItem;
    }
}

