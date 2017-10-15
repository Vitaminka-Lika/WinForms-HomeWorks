using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dates
{
    public partial class Dates : Form
    {
        DateTime givenDate = new DateTime();
        DateTime currentDate = new DateTime();
        int daysInMonth = 31;
        int monthInYear = 12;
        public Dates()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            currentDate = DateTime.Now;
            givenDate = currentDateTimePicker.Value;

            if (yearsRadioButton.Checked)
            {
                finalTextBox.Text = (((givenDate.Subtract(currentDate).TotalDays)/daysInMonth)/monthInYear).ToString();
            }
            if (monthsRadioButton.Checked)
            {
                finalTextBox.Text = ((givenDate.Subtract(currentDate).TotalDays)/daysInMonth).ToString();
            }
            if (daysRadioButton.Checked)
            {
                finalTextBox.Text = givenDate.Subtract(currentDate).TotalDays.ToString();
            }
            if (minutesRadioButton.Checked)
            {
                finalTextBox.Text = givenDate.Subtract(currentDate).TotalMinutes.ToString();
            }
            if (secondsRadioButton.Checked)
            {
                finalTextBox.Text = givenDate.Subtract(currentDate).TotalSeconds.ToString();
            }
        }
    }
}
