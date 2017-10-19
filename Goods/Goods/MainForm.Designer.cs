namespace Goods
{
    partial class MainForm
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.goodsComboBox = new System.Windows.Forms.ComboBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.listLabel = new System.Windows.Forms.Label();
            this.totalPriceBox = new System.Windows.Forms.TextBox();
            this.allGoodsBox = new System.Windows.Forms.RichTextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(136, 9);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(65, 13);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "Стоимость:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(124, 13);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Наименование товара:";
            // 
            // goodsComboBox
            // 
            this.goodsComboBox.Location = new System.Drawing.Point(12, 25);
            this.goodsComboBox.Name = "goodsComboBox";
            this.goodsComboBox.Size = new System.Drawing.Size(121, 21);
            this.goodsComboBox.TabIndex = 9;
            this.goodsComboBox.SelectedIndexChanged += new System.EventHandler(this.GoodsComboBox_SelectedIndexChanged);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(139, 25);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(100, 20);
            this.priceBox.TabIndex = 8;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(126, 304);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(40, 13);
            this.totalCostLabel.TabIndex = 15;
            this.totalCostLabel.Text = "Итого:";
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Location = new System.Drawing.Point(12, 49);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(91, 13);
            this.listLabel.TabIndex = 14;
            this.listLabel.Text = "Список товаров:";
            // 
            // totalPriceBox
            // 
            this.totalPriceBox.Location = new System.Drawing.Point(172, 301);
            this.totalPriceBox.Name = "totalPriceBox";
            this.totalPriceBox.ReadOnly = true;
            this.totalPriceBox.Size = new System.Drawing.Size(100, 20);
            this.totalPriceBox.TabIndex = 13;
            // 
            // allGoodsBox
            // 
            this.allGoodsBox.Location = new System.Drawing.Point(12, 68);
            this.allGoodsBox.Name = "allGoodsBox";
            this.allGoodsBox.Size = new System.Drawing.Size(260, 227);
            this.allGoodsBox.TabIndex = 12;
            this.allGoodsBox.Text = "";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(278, 97);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 23);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(278, 68);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 23);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 335);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.totalPriceBox);
            this.Controls.Add(this.allGoodsBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.goodsComboBox);
            this.Controls.Add(this.priceBox);
            this.Name = "MainForm";
            this.Text = "Товары";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox goodsComboBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.TextBox totalPriceBox;
        private System.Windows.Forms.RichTextBox allGoodsBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
    }
}

