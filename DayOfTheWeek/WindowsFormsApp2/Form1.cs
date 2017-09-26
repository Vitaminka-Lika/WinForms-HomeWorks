using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            DateTime current = new DateTime();
            bool isOperationDone = DateTime.TryParse(textBoxWithDate.Text, out current);
            if (isOperationDone)
            {
                textBoxWithDayOfTheWeek.Text = current.ToString("dddd");
            }
            else {
                textBoxWithDayOfTheWeek.Text = "Ошибка ввода";
            }
        }
    }
}
