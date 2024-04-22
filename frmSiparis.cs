using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }
        public static int menu1 = 0;
        public static int menu2 = 0;
        public static int menu3 = 0;
        public static int menu4 = 0;
        public static int menu5 = 0;
        public static int tutar = 0;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int tutarEski = menu1 * 10;
            textBox1.Text = (Convert.ToInt32(textBox1.Text) - tutarEski).ToString();

            int tutarYeni = Convert.ToInt32(numericUpDown1.Value) * 10;
            textBox1.Text = (Convert.ToInt32(textBox1.Text) + tutarYeni).ToString();

            menu1 = Convert.ToInt32(numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int tutarEski = menu2 * 20;
            textBox1.Text = (Convert.ToInt32(textBox1.Text) - tutarEski).ToString();

            int tutarYeni = Convert.ToInt32(numericUpDown2.Value) * 20;
            textBox1.Text = (Convert.ToInt32(textBox1.Text) + tutarYeni).ToString();

            menu2 = Convert.ToInt32(numericUpDown2.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            int tutarEski = menu3 * 30;
            textBox1.Text = (Convert.ToInt32(textBox1.Text) - tutarEski).ToString();

            int tutarYeni = Convert.ToInt32(numericUpDown3.Value) * 30;
            textBox1.Text = (Convert.ToInt32(textBox1.Text) + tutarYeni).ToString();

            menu3 = Convert.ToInt32(numericUpDown3.Value);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            int tutarEski = menu4 * 40;
            textBox1.Text = (Convert.ToInt32(textBox1.Text) - tutarEski).ToString();

            int tutarYeni = Convert.ToInt32(numericUpDown4.Value) * 40;
            textBox1.Text = (Convert.ToInt32(textBox1.Text) + tutarYeni).ToString();

            menu4 = Convert.ToInt32(numericUpDown4.Value);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            int tutarEski = menu5 * 50;
            textBox1.Text = (Convert.ToInt32(textBox1.Text) - tutarEski).ToString();

            int tutarYeni = Convert.ToInt32(numericUpDown5.Value) * 50;
            textBox1.Text = (Convert.ToInt32(textBox1.Text) + tutarYeni).ToString();

            menu5 = Convert.ToInt32(numericUpDown5.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tutar = Convert.ToInt32(textBox1.Text);
            frmAdres frm = new frmAdres();
            frm.Show();
            this.Hide();
        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            menu1 = 0;
            menu2 = 0;
            menu3 = 0;
            menu4 = 0;
            menu5 = 0;
            textBox1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            menu1 = 0;
            menu2 = 0;
            menu3 = 0;
            menu4 = 0;
            menu5 = 0;
            textBox1.Text = "0";
            frmAnasayfa frm = new frmAnasayfa();
            frm.Show();
            this.Hide();
        }
    }
}
