using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHomeDZ5_17_10_17
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            Thread secondThread = new Thread(LabelControl);
            secondThread.Start();
            dayOfTheWeekItem.Text = DateTime.Now.DayOfWeek.ToString();
        }

        public void LabelControl()
        {
            while (true)
            {
                currentDate.Text = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
                Thread.Sleep(10000);
                currentDate.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
                Thread.Sleep(10000);
            }
        }

        private void OilType_SelectedIndexChanged(object sender, EventArgs e)
        {
            fuelPriceComboBox.SelectedIndex = fuelTypeComboBox.SelectedIndex;
        }

        private void OilCost_SelectedIndexChanged(object sender, EventArgs e)
        {
            fuelTypeComboBox.SelectedIndex = fuelPriceComboBox.SelectedIndex;
        }

        private void LitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
                litersCountBox.Enabled = true;
                moneyCountBox.Enabled = false;
        }

        private void MoneyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
                litersCountBox.Enabled = false;
                moneyCountBox.Enabled = true;
        }

        private void LitCountBox_Changed(object sender, EventArgs e)
        {
            bool isDone = true;

            if (litersCountBox.Text != "")
            {
                for (; isDone;)
                {
                    int selectedPrice;
                    bool isParsed = Int32.TryParse(fuelPriceComboBox.Text, out selectedPrice);

                    if (isParsed)
                    {
                        int oilCost;
                        isParsed = Int32.TryParse(litersCountBox.Text, out oilCost);
                        if (isParsed)
                        {
                            totalFuelLabel.Text = (selectedPrice * oilCost).ToString();
                            moneyCountBox.Text = totalFuelLabel.Text;
                            isDone = false;
                        }
                        else
                        {
                            litersCountBox.Text = "0";
                        }
                    }
                    else
                    {
                        fuelPriceComboBox.SelectedIndex = 0;
                    }
                }
            }
        }

        private void MoneyBox_Changed(object sender, EventArgs e)
        {
            bool isDone = true;

            if (moneyCountBox.Text != "")
            {
                for(;isDone;)
                {
                    int selectedPrice;
                    bool isParsed = Int32.TryParse(fuelPriceComboBox.Text, out selectedPrice);

                    if (isParsed)
                    {
                        int moneyCount;
                        isParsed=Int32.TryParse(moneyCountBox.Text,out moneyCount);

                        if (isParsed)
                        {
                            totalFuelLabel.Text = moneyCountBox.Text;
                            litersCountBox.Text = ((double)moneyCount / selectedPrice).ToString();
                            isDone = false;
                        }
                        else
                        {
                            moneyCountBox.Text = "0";
                        }
                    }
                    else
                    {
                        fuelPriceComboBox.SelectedIndex = 0;
                    }
                }
            }
        }

        private void HotDogBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hotDogBox.Checked)
            {
                hotDogCount.Enabled = true;
            }
            else
            {
                hotDogCount.Enabled = false;
                hotDogCount.Text = "0";
            }
        }

        private void HamburgerBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hamburgerBox.Checked)
            {
                hamburgerCount.Enabled = true;
            }
            else
            {
                hamburgerCount.Enabled = false;
                hamburgerCount.Text = "0";
            }
        }

        private void FreeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (friesBox.Checked)
            {
                friesCount.Enabled = true;
            }
            else
            {
                friesCount.Enabled = false;
                friesCount.Text = "0";
            }
        }

        private void CocaColaBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cocaColaBox.Checked)
            {
                cocaColaCount.Enabled = true;
            }
            else
            {
                cocaColaCount.Enabled = false;
                cocaColaCount.Text = "0";
            }
        }

        private void Count_TextChanged(object sender, EventArgs e)
        {
            int allCost = 0;
            bool isParsed;

            if(hotDogBox.Checked && hotDogCount.Text != "")
            {
                bool isDone = true;
                for(;isDone; )
                {
                    int hotDogCounts;
                    isParsed = Int32.TryParse(hotDogCount.Text,out hotDogCounts);
                    if(isParsed)
                    {
                        allCost += hotDogCounts*Int32.Parse(hotDogPrice.Text);
                        isDone = false;
                    }
                    else
                    {
                        hotDogCount.Text = "0";
                    }
                }
            }

            if (hamburgerBox.Checked && hamburgerCount.Text != "")
            {
                bool isDone = true;
                for (; isDone;)
                {
                    int hamburgerCounts;
                    isParsed = Int32.TryParse(hamburgerCount.Text,out hamburgerCounts);
                    if (isParsed)
                    {
                        allCost += hamburgerCounts * Int32.Parse(hamburgerPrice.Text);
                        isDone = false;
                    }
                    else
                    {
                        hamburgerCount.Text = "0";
                    }
                }
            }

            if (friesBox.Checked && friesCount.Text != "")
            {
                bool isDone = true;
                for (; isDone;)
                {
                    int freeCounts;
                    isParsed = Int32.TryParse(friesCount.Text,out freeCounts);
                    if (isParsed)
                    {
                        allCost += freeCounts * Int32.Parse(friesPrice.Text);
                        isDone = false;
                    }
                    else
                    {
                        friesCount.Text = "0";
                    }
                }
            }

            if (cocaColaBox.Checked && cocaColaCount.Text != "")
            {
                bool isDone = true;
                for (; isDone;)
                {
                    int colaCounts;
                    isParsed = Int32.TryParse(cocaColaCount.Text,out colaCounts);
                    if (isParsed)
                    {
                        allCost += colaCounts * Int32.Parse(cocaColaPrice.Text);
                        isDone = false;
                    }
                    else
                    {
                        cocaColaCount.Text = "0";
                    }
                }
            }

            totalFoodLabel.Text=allCost.ToString();
        }

        private void ButtonPrepare_MouseClick(object sender, MouseEventArgs e)
        {
            sumLabel.Text = (Int32.Parse(totalFuelLabel.Text) + Int32.Parse(totalFoodLabel.Text)).ToString();
        }

        private void ButtonPay_MouseClick(object sender, MouseEventArgs e)
        {
            fuelTypeComboBox.SelectedIndex = -1;
            litersRadioButton.Checked = false;
            moneyRadioButton.Checked = false;
            hotDogBox.Checked = false;
            hamburgerBox.Checked = false;
            friesBox.Checked = false;
            cocaColaBox.Checked = false;
            sumLabel.Text = "0";
            fuelLabel.Text = "";
            
        }

        private void RussianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru");

            ComponentResourceManager recources = new ComponentResourceManager(this.GetType());
            recources.ApplyResources(this,"$this");
            foreach(Control c in this.Controls)
            {
                recources.ApplyResources(c, c.Name);
            }
        }

        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");

            ComponentResourceManager recources = new ComponentResourceManager(this.GetType());
            recources.ApplyResources(this, "$this");
            foreach (Control c in this.Controls)
            {
                recources.ApplyResources(c, c.Name);
            }
        }

        private void ChangeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
