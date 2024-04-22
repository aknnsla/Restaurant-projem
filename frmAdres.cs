using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmAdres : Form
    {
        public static string Madi = "";
        public static string MSoayadi = "";
        public static string MTel = "";
        public static string MAdres = "";

        public frmAdres()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Madi = textBox1.Text;
            MSoayadi = textBox2.Text;
            MTel = textBox3.Text;
            MAdres = textBox4.Text;
            frmOdeme frm = new frmOdeme();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAnasayfa frm = new frmAnasayfa();
            frm.Show();
            this.Hide();

        }
    }
}
