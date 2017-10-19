using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goods
{
    public partial class MainForm : Form
    {
       
        List<Product> goods = new List<Product> {
            new Product{ Name="example 1", Price=100,Information="example info1" },
            new Product{ Name="example 2", Price=200,Information="example info2" },
            new Product{ Name="example 3", Price=300,Information="example info3" },
            new Product{ Name="example 4", Price=400,Information="example info4" },
            new Product{ Name="example 5", Price=500,Information="example info5" },
            };
        public MainForm()
        {
            InitializeComponent();
            

            for (int i = 0; i < goods.Count; i++)
            {
                goodsComboBox.Items.Add(goods[i].Name);               
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (goodsComboBox.SelectedItem != null)
            {
                addButton.Enabled = true;
            }
            else
            {
                addButton.Enabled=false;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            double totalPrice;
            bool isDone=Double.TryParse(totalPriceBox.Text,out totalPrice);
            
                string selectedProduct = goods[goodsComboBox.SelectedIndex].Name;
                double price = goods[goodsComboBox.SelectedIndex].Price;

                totalPriceBox.Text = price.ToString();
                allGoodsBox.Text += selectedProduct + " " + price + "$" + "\n";

                totalPriceBox.Text = (totalPrice + price).ToString();
            
        }

        private void GoodsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {           
            priceBox.Text= goods[goodsComboBox.SelectedIndex].Price.ToString();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.Show();
            editForm.SendList(ref goods);
        }
    }
}
