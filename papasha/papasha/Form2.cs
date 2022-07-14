using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace papasha
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string windowTittle, string message)
        {
            InitializeComponent();
            this.Text = windowTittle;
            label1.Text = message;
        }

        public static string Show(string windowTittle, string message)
        {
            using(Form2 inputDlg = new Form2(windowTittle, message)) {
                inputDlg.ShowDialog();
                return inputDlg.textBox1.Text;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
