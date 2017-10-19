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
    public partial class EditForm : Form
    {
        List<Product> goods = new List<Product> { };
        public EditForm()
        {
            InitializeComponent();
        }
        public void SendList(ref List<Product> items)
        {
            goods = items;

            for (int i = 0; i < items.Count; i++)
            {
                goodsComboBox.Items.Add(items[i].Name);
                priceComboBox.Items.Add(items[i].Price);
            }            
        }

        private void GoodsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceComboBox.SelectedIndex = goodsComboBox.SelectedIndex;
        }

        private void PriceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            goodsComboBox.SelectedIndex = priceComboBox.SelectedIndex;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            double newPrice;
            int listIndex = goodsComboBox.SelectedIndex;
            bool isCorrect = Double.TryParse(newPriceTextBox.Text, out newPrice);
            if (isCorrect)
            {
                goods[listIndex].Price = newPrice;
            }
        }
    }
}
