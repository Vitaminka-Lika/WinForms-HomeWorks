namespace Goods
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.goodsComboBox = new System.Windows.Forms.ComboBox();
            this.priceComboBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.informationRichBox = new System.Windows.Forms.RichTextBox();
            this.newPricelabel = new System.Windows.Forms.Label();
            this.newPriceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(124, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Наименование товара:";
            // 
            // goodsComboBox
            // 
            this.goodsComboBox.FormattingEnabled = true;
            this.goodsComboBox.Location = new System.Drawing.Point(11, 28);
            this.goodsComboBox.Name = "goodsComboBox";
            this.goodsComboBox.Size = new System.Drawing.Size(125, 21);
            this.goodsComboBox.TabIndex = 5;
            this.goodsComboBox.SelectedIndexChanged += new System.EventHandler(this.GoodsComboBox_SelectedIndexChanged);
            // 
            // priceComboBox
            // 
            this.priceComboBox.FormattingEnabled = true;
            this.priceComboBox.Location = new System.Drawing.Point(155, 28);
            this.priceComboBox.Name = "priceComboBox";
            this.priceComboBox.Size = new System.Drawing.Size(97, 21);
            this.priceComboBox.TabIndex = 8;
            this.priceComboBox.SelectedIndexChanged += new System.EventHandler(this.PriceComboBox_SelectedIndexChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(152, 9);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(65, 13);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Стоимость:";
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(11, 171);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(241, 23);
            this.doneButton.TabIndex = 10;
            this.doneButton.Text = "Подтвердить изменения";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // informationRichBox
            // 
            this.informationRichBox.Location = new System.Drawing.Point(11, 55);
            this.informationRichBox.Name = "informationRichBox";
            this.informationRichBox.Size = new System.Drawing.Size(241, 110);
            this.informationRichBox.TabIndex = 9;
            this.informationRichBox.Text = "";
            // 
            // newPricelabel
            // 
            this.newPricelabel.AutoSize = true;
            this.newPricelabel.Location = new System.Drawing.Point(269, 58);
            this.newPricelabel.Name = "newPricelabel";
            this.newPricelabel.Size = new System.Drawing.Size(66, 13);
            this.newPricelabel.TabIndex = 11;
            this.newPricelabel.Text = "Новая цена";
            // 
            // newPriceTextBox
            // 
            this.newPriceTextBox.Location = new System.Drawing.Point(258, 74);
            this.newPriceTextBox.Name = "newPriceTextBox";
            this.newPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.newPriceTextBox.TabIndex = 12;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 202);
            this.Controls.Add(this.newPriceTextBox);
            this.Controls.Add(this.newPricelabel);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.informationRichBox);
            this.Controls.Add(this.priceComboBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.goodsComboBox);
            this.Name = "EditForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox goodsComboBox;
        private System.Windows.Forms.ComboBox priceComboBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.RichTextBox informationRichBox;
        private System.Windows.Forms.Label newPricelabel;
        private System.Windows.Forms.TextBox newPriceTextBox;
    }
}