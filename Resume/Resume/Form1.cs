using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resume
{
    public partial class Form1 : Form
    {
        StringBuilder dolphin = new StringBuilder(
            "  _../|_\n"+
            "='__   _~-.\n"+
            "     \'  ~-`._\n"+
            "            |/~`\n"+
            "..   ..   ..   ..\n"+
            "(._.`(._.`(._.`(.\n");
        int countOfWords = 0;
        int formsCount = 0;
        string firstContent = "Краткое резюме\n Фамилия: Сарбасова \n Имя: Алика \n Отчество: Болатовна \n Возраст: 16 лет";
        string secondContent = "О себе: Безработная школьница.";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            formsCount++;
            DialogResult result=MessageBox.Show(firstContent, "Резюме",MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                formsCount++;
                DialogResult secondResult = MessageBox.Show(secondContent, "Резюме №2", MessageBoxButtons.OK);
                if (secondResult == DialogResult.OK)
                {
                    formsCount++;
                    DialogResult thirdResult=MessageBox.Show(dolphin.ToString(), "Дельфин", MessageBoxButtons.OK);
                    if (thirdResult == DialogResult.OK)
                    {
                        formsCount++;
                        countOfWords = firstContent.Length + secondContent.Length + dolphin.Length;
                        MessageBox.Show("Количество слов:"+countOfWords+"\n Количество сообщений:"+formsCount, "Итог", MessageBoxButtons.OK); }
                }
            }
        }

         Random randomNumber = new Random();
         DialogResult finalResult=DialogResult.No;
         int tries = 0;
        int currentNumber;
        string question = "Ваше число: ";
        private void Button2_Click(object sender, EventArgs e)
        {
            tries++;
            while (finalResult==DialogResult.No)
            {
                currentNumber=randomNumber.Next(1,2000);
                DialogResult currentResult=MessageBox.Show(question+currentNumber, "Попытка №"+tries, MessageBoxButtons.YesNo);
                if (currentResult == DialogResult.Yes)
                {
                    MessageBox.Show("Всего попыток:" + tries, "Итог", MessageBoxButtons.OK);
                    finalResult = DialogResult.Yes;
                }
                else { tries++; }
            }
        }
    }
}
