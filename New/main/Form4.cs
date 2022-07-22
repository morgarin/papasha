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
    public partial class Form4 : Form

    {
        private Class1 mp3Player = new Class1();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    mp3Player.open(ofd.FileName);
                    label1.Text = System.IO.Path.GetFileNameWithoutExtension(ofd.SafeFileName);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mp3Player.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mp3Player.stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mp3Player.skip();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mp3Player.pause();
        }
    }
}
