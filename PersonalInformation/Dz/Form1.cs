using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Person person = new Person()
            {
                SecondName = textBox1.Text,
                FirstName = textBox2.Text,
                LastName=textBox3.Text
            };

            string json = JsonConvert.SerializeObject(person);
            System.IO.File.WriteAllText(saveFileDialog1.FileName, json);
        }
    }
}
