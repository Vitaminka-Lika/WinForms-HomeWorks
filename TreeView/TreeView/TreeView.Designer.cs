namespace TreeView
{
    partial class FileSystemForm
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
            this.drivesSystemTreeView = new System.Windows.Forms.TreeView();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drivesSystemTreeView
            // 
            this.drivesSystemTreeView.Location = new System.Drawing.Point(12, 12);
            this.drivesSystemTreeView.Name = "drivesSystemTreeView";
            this.drivesSystemTreeView.Size = new System.Drawing.Size(260, 206);
            this.drivesSystemTreeView.TabIndex = 0;
            this.drivesSystemTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.DrivesSystemTreeView_BeforeExpand);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(13, 226);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(259, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // FileSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.drivesSystemTreeView);
            this.Name = "FileSystemForm";
            this.Text = "FileSystem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView drivesSystemTreeView;
        private System.Windows.Forms.Button showButton;
    }
}

