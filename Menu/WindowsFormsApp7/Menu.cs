using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
                     
        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (topLevelMenuTextBox.Text == "")
            {
                addMenuItemButton.Enabled = false;
            }
            else
            {
                addMenuItemButton.Enabled = true;
            }
            if (menuTreeView.Nodes.Count == 0||!menuTreeView.Focused||subItemTextBox.Text=="")
            {               
                addSubmenuButton.Enabled = false;
            }
            else
            {
                addSubmenuButton.Enabled = true;
            }
        }

        private void AddMenuItemButton_Click(object sender, EventArgs e)
        {
            TreeNode menu = new TreeNode(topLevelMenuTextBox.Text);

            menuTreeView.Nodes.Add(menu);
        }

        private void AddSubmenuButton_Click(object sender, EventArgs e)
        {
            

            TreeNode addMenu = new TreeNode(subItemTextBox.Text);

            menuTreeView.SelectedNode.Nodes.Add(addMenu);
        }
    }
}
