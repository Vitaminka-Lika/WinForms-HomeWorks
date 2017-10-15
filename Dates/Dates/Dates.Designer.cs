namespace Dates
{
    partial class Dates
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
            this.startButton = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yearsRadioButton = new System.Windows.Forms.RadioButton();
            this.monthsRadioButton = new System.Windows.Forms.RadioButton();
            this.daysRadioButton = new System.Windows.Forms.RadioButton();
            this.minutesRadioButton = new System.Windows.Forms.RadioButton();
            this.secondsRadioButton = new System.Windows.Forms.RadioButton();
            this.finalTextBox = new System.Windows.Forms.TextBox();
            this.currentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.second = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(230, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(127, 119);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Узнать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Location = new System.Drawing.Point(12, 66);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(206, 13);
            this.first.TabIndex = 1;
            this.first.Text = "Сколько осталось до введенной даты?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.secondsRadioButton);
            this.panel1.Controls.Add(this.minutesRadioButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.daysRadioButton);
            this.panel1.Controls.Add(this.monthsRadioButton);
            this.panel1.Controls.Add(this.yearsRadioButton);
            this.panel1.Location = new System.Drawing.Point(15, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 126);
            this.panel1.TabIndex = 2;
            // 
            // yearsRadioButton
            // 
            this.yearsRadioButton.AutoSize = true;
            this.yearsRadioButton.Location = new System.Drawing.Point(4, 4);
            this.yearsRadioButton.Name = "yearsRadioButton";
            this.yearsRadioButton.Size = new System.Drawing.Size(49, 17);
            this.yearsRadioButton.TabIndex = 0;
            this.yearsRadioButton.TabStop = true;
            this.yearsRadioButton.Text = "Года";
            this.yearsRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthsRadioButton
            // 
            this.monthsRadioButton.AutoSize = true;
            this.monthsRadioButton.Location = new System.Drawing.Point(4, 28);
            this.monthsRadioButton.Name = "monthsRadioButton";
            this.monthsRadioButton.Size = new System.Drawing.Size(64, 17);
            this.monthsRadioButton.TabIndex = 1;
            this.monthsRadioButton.TabStop = true;
            this.monthsRadioButton.Text = "Месяца";
            this.monthsRadioButton.UseVisualStyleBackColor = true;
            // 
            // daysRadioButton
            // 
            this.daysRadioButton.AutoSize = true;
            this.daysRadioButton.Location = new System.Drawing.Point(4, 52);
            this.daysRadioButton.Name = "daysRadioButton";
            this.daysRadioButton.Size = new System.Drawing.Size(46, 17);
            this.daysRadioButton.TabIndex = 2;
            this.daysRadioButton.TabStop = true;
            this.daysRadioButton.Text = "Дни";
            this.daysRadioButton.UseVisualStyleBackColor = true;
            // 
            // minutesRadioButton
            // 
            this.minutesRadioButton.AutoSize = true;
            this.minutesRadioButton.Location = new System.Drawing.Point(4, 76);
            this.minutesRadioButton.Name = "minutesRadioButton";
            this.minutesRadioButton.Size = new System.Drawing.Size(64, 17);
            this.minutesRadioButton.TabIndex = 3;
            this.minutesRadioButton.TabStop = true;
            this.minutesRadioButton.Text = "Минуты";
            this.minutesRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondsRadioButton
            // 
            this.secondsRadioButton.AutoSize = true;
            this.secondsRadioButton.Location = new System.Drawing.Point(4, 100);
            this.secondsRadioButton.Name = "secondsRadioButton";
            this.secondsRadioButton.Size = new System.Drawing.Size(69, 17);
            this.secondsRadioButton.TabIndex = 4;
            this.secondsRadioButton.TabStop = true;
            this.secondsRadioButton.Text = "Секунды";
            this.secondsRadioButton.UseVisualStyleBackColor = true;
            // 
            // finalTextBox
            // 
            this.finalTextBox.Location = new System.Drawing.Point(16, 215);
            this.finalTextBox.Name = "finalTextBox";
            this.finalTextBox.ReadOnly = true;
            this.finalTextBox.Size = new System.Drawing.Size(359, 20);
            this.finalTextBox.TabIndex = 3;
            // 
            // currentDateTimePicker
            // 
            this.currentDateTimePicker.Location = new System.Drawing.Point(12, 34);
            this.currentDateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.currentDateTimePicker.MinDate = new System.DateTime(2017, 10, 10, 0, 0, 0, 0);
            this.currentDateTimePicker.Name = "currentDateTimePicker";
            this.currentDateTimePicker.Size = new System.Drawing.Size(357, 20);
            this.currentDateTimePicker.TabIndex = 4;
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Location = new System.Drawing.Point(8, 18);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(60, 13);
            this.second.TabIndex = 5;
            this.second.Text = "Ваша дата";
            // 
            // Dates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 247);
            this.Controls.Add(this.second);
            this.Controls.Add(this.currentDateTimePicker);
            this.Controls.Add(this.finalTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.first);
            this.Name = "Dates";
            this.Text = "Dates";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton secondsRadioButton;
        private System.Windows.Forms.RadioButton minutesRadioButton;
        private System.Windows.Forms.RadioButton daysRadioButton;
        private System.Windows.Forms.RadioButton monthsRadioButton;
        private System.Windows.Forms.RadioButton yearsRadioButton;
        private System.Windows.Forms.TextBox finalTextBox;
        private System.Windows.Forms.DateTimePicker currentDateTimePicker;
        private System.Windows.Forms.Label second;
    }
}

