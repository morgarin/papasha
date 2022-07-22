using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private bool isNumber = false;

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            isNumber = e.KeyCode >= Keys.D0 && e.KeyCode >= Keys.D9 || e.KeyCode >= Keys.NumPad0 && e.KeyCode >= Keys.NumPad9 || e.KeyCode >= Keys.Back;
        }
        private void texBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = (TextBox)sender;
            switch (e.KeyChar)
            {
                case '-':
                    if (box.Text.Length == 0)
                        isNumber = true;
                    break;
                case '.':
                    if (box.Text.Length == 0)
                        break;
                    if (box.Text[0] == '-' && box.Text.Length == 1)
                        break;
                    if (box.Text.IndexOf('.') == -1)
                        isNumber = true;
                    break;
            }
            if (!isNumber)
                e.Handled = true;
        }
        private double numFirst, numSecond, numResoult;

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {
            string strFirst = string.Copy(textBox1.Text);
            string strSecond = string.Copy(textBox2.Text);
            int pos = strFirst.IndexOf('.');
            if (pos != -1)
            {
                strFirst = strFirst.Substring(0, pos) + ',' + strFirst.Substring(pos + 1);
            }
            pos = strSecond.IndexOf('.');
            if (pos != -1)
            {
                strSecond = strSecond.Substring(0, pos) + ',' + strSecond.Substring(pos + 1);
            }
            if (textBox1.Text.Length > 0)
                numFirst = Convert.ToDouble(strFirst);
            else
                numFirst = 0.0D;
            if (textBox2.Text.Length > 0)
                numSecond = Convert.ToDouble(strSecond);
            else
                numSecond = 0.0D;

            string btnText = "";
            bool divideFlag = false;
            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "button1":
                    //+
                    btnText = "\" button1 \"";
                    numResoult = numFirst + numSecond;
                    label2.Text = numResoult.ToString();
                    break;
                case "button2":
                    //-
                    btnText = "\" button2 \"";
                    numResoult = numFirst - numSecond;
                    label2.Text = numResoult.ToString();
                    break;
                case "button3":
                    //*
                    btnText = "\" button3 \"";
                    numResoult = numFirst * numSecond;
                    label2.Text = numResoult.ToString();
                    break;
                case "button4":
                    //:
                    btnText = "\" button4 \"";
                    if (Math.Abs(numSecond) < 1.0E-30)
                    {
                        MessageBox.Show(
                        "Делить на ноль нельзя!", // Сообщение
                        "Ошибка", // Заголовок окна
                        MessageBoxButtons.OK, // Кнопка OK
                        MessageBoxIcon.Stop);// Критическая иконка
                        divideFlag = true;
                    }
                    else
                        numResoult = numFirst / numSecond;
                    label2.Text = numResoult.ToString();
                    break;
                case "button5":
                    //sin
                    btnText = "\" button5 \"";
                    numResoult = Math.Sin(numFirst) * 57.3;
                    label2.Text = numResoult.ToString();
                    break;
                case "button6":
                    //cos
                    btnText = "\" button6 \"";
                    numResoult = Math.Cos(numFirst) * 57.3;
                    label2.Text = numResoult.ToString();
                    break;
                case "button7":
                    //tg
                    btnText = "\" button7 \"";
                    numResoult = Math.Tan(numFirst) * 57.3;
                    label2.Text = numResoult.ToString();
                    break;
                case "button8":
                    //ctg
                    btnText = "\" button8 \"";
                    numResoult = 1 / Math.Tan(numFirst) * 57.3;
                    label2.Text = numResoult.ToString();
                    break;
                case "button9":
                    //sqrt
                    btnText = "\" button9 \"";
                    numResoult = Math.Sqrt(numFirst);
                    label2.Text = numResoult.ToString();
                    break;
                case "button10":
                    //Asin
                    btnText = "\" button10 \"";
                    numResoult = Math.Asin(numFirst);
                    label2.Text = numResoult.ToString();
                    break;
                case "button11":
                    //Acos
                    btnText = "\" button11 \"";
                    numResoult = Math.Acos(numFirst);
                    label2.Text = numResoult.ToString();
                    break;
                case "button12":
                    //Atg
                    btnText = "\" button12 \"";
                    numResoult = Math.Atan(numFirst);
                    label2.Text = numResoult.ToString();
                    break;
                case "button13":
                    //Actg
                    btnText = "\" button13 \"";
                    numResoult = Math.PI/2 - Math.Atan(numFirst);
                    label2.Text = numResoult.ToString();
                    break;
            }
            System.Diagnostics.Debug.WriteLine("Нажата кнопка " + btnText);
            if (!divideFlag)
            {
                label2.Text = Convert.ToString(numResoult);
                this.Validate();
            }
        }
    }
}