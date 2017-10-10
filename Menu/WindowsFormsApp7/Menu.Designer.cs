namespace WindowsFormsApp7
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.menuTreeView = new System.Windows.Forms.TreeView();
            this.folderContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuItemButton = new System.Windows.Forms.Button();
            this.addSubmenuButton = new System.Windows.Forms.Button();
            this.topLevelMenuTextBox = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.subItemTextBox = new System.Windows.Forms.TextBox();
            this.folderContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTreeView
            // 
            this.menuTreeView.ContextMenuStrip = this.folderContextMenuStrip;
            this.menuTreeView.Location = new System.Drawing.Point(12, 12);
            this.menuTreeView.Name = "menuTreeView";
            this.menuTreeView.Size = new System.Drawing.Size(234, 289);
            this.menuTreeView.TabIndex = 0;
            // 
            // folderContextMenuStrip
            // 
            this.folderContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьПапкуToolStripMenuItem,
            this.удалитьПапкуToolStripMenuItem,
            this.переименоватьПапкуToolStripMenuItem});
            this.folderContextMenuStrip.Name = "folderContextMenuStrip";
            this.folderContextMenuStrip.Size = new System.Drawing.Size(197, 70);
            // 
            // создатьПапкуToolStripMenuItem
            // 
            this.создатьПапкуToolStripMenuItem.Name = "создатьПапкуToolStripMenuItem";
            this.создатьПапкуToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.создатьПапкуToolStripMenuItem.Text = "Создать папку";
            // 
            // удалитьПапкуToolStripMenuItem
            // 
            this.удалитьПапкуToolStripMenuItem.Name = "удалитьПапкуToolStripMenuItem";
            this.удалитьПапкуToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.удалитьПапкуToolStripMenuItem.Text = "Удалить папку";
            // 
            // переименоватьПапкуToolStripMenuItem
            // 
            this.переименоватьПапкуToolStripMenuItem.Name = "переименоватьПапкуToolStripMenuItem";
            this.переименоватьПапкуToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.переименоватьПапкуToolStripMenuItem.Text = "Переименовать папку";
            // 
            // addMenuItemButton
            // 
            this.addMenuItemButton.Location = new System.Drawing.Point(13, 405);
            this.addMenuItemButton.Name = "addMenuItemButton";
            this.addMenuItemButton.Size = new System.Drawing.Size(94, 39);
            this.addMenuItemButton.TabIndex = 2;
            this.addMenuItemButton.Text = "Добавить пункт меню";
            this.addMenuItemButton.UseVisualStyleBackColor = true;
            this.addMenuItemButton.Click += new System.EventHandler(this.AddMenuItemButton_Click);
            // 
            // addSubmenuButton
            // 
            this.addSubmenuButton.Location = new System.Drawing.Point(153, 405);
            this.addSubmenuButton.Name = "addSubmenuButton";
            this.addSubmenuButton.Size = new System.Drawing.Size(93, 39);
            this.addSubmenuButton.TabIndex = 3;
            this.addSubmenuButton.Text = "Добавить подменю";
            this.addSubmenuButton.UseVisualStyleBackColor = true;
            this.addSubmenuButton.Click += new System.EventHandler(this.AddSubmenuButton_Click);
            // 
            // topLevelMenuTextBox
            // 
            this.topLevelMenuTextBox.Location = new System.Drawing.Point(103, 308);
            this.topLevelMenuTextBox.Name = "topLevelMenuTextBox";
            this.topLevelMenuTextBox.Size = new System.Drawing.Size(143, 20);
            this.topLevelMenuTextBox.TabIndex = 4;
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Location = new System.Drawing.Point(12, 311);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(85, 13);
            this.first.TabIndex = 5;
            this.first.Text = "Top Level Menu";
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Location = new System.Drawing.Point(12, 339);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(46, 13);
            this.second.TabIndex = 6;
            this.second.Text = "SubItem";
            // 
            // subItemTextBox
            // 
            this.subItemTextBox.Location = new System.Drawing.Point(103, 332);
            this.subItemTextBox.Name = "subItemTextBox";
            this.subItemTextBox.Size = new System.Drawing.Size(143, 20);
            this.subItemTextBox.TabIndex = 7;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 456);
            this.Controls.Add(this.subItemTextBox);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.topLevelMenuTextBox);
            this.Controls.Add(this.addSubmenuButton);
            this.Controls.Add(this.addMenuItemButton);
            this.Controls.Add(this.menuTreeView);
            this.Name = "Menu";
            this.Text = "Menu";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.folderContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView menuTreeView;
        private System.Windows.Forms.ContextMenuStrip folderContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem создатьПапкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПапкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переименоватьПапкуToolStripMenuItem;
        private System.Windows.Forms.Button addMenuItemButton;
        private System.Windows.Forms.Button addSubmenuButton;
        private System.Windows.Forms.TextBox topLevelMenuTextBox;
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.TextBox subItemTextBox;
    }
}

