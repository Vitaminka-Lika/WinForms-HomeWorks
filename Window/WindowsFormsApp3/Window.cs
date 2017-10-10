using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        int border = 10;

        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if ((e.X == border || e.Y == border || e.X == this.Width - border || e.Y == this.Height - border))
                {
                    this.Text = "На границе";
                }
                else {
                    if (e.X < border || e.Y < border || e.X > this.Width - border || e.Y > this.Height - border)
                    {
                        this.Text = "За границей";
                    }
                    else
                    {
                        this.Text = "Внутри зоны";
                    }
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                this.Text = "Ширина окна: " + this.Width.ToString() + "; Длина окна: " + this.Height.ToString();            
            }          
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < border || e.Y < border || e.X > this.Width - border || e.Y > this.Height - border)
            {
                this.Text = "***Нет данных***";
            }

            else { this.Text = "x = " + e.X.ToString() + " " + "y = " + e.Y.ToString(); }
        }
    }
}
