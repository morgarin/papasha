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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string password = Form2.Show("Аутентификация", "Введите пароль");

            if (password != "qwerty45")
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show("Пароль неверный", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            Form frm = new Form3();
            frm.Show();
        }

        private void linkLabel2_LinkClicked(object sender, EventArgs e)
        {
            Form frm = new Form4();
            frm.Show();
        }

       

    }
}
