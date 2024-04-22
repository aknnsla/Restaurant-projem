using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmOdeme : Form
    {
        public frmOdeme()
        {
            InitializeComponent();
        }

        private void frmOdeme_Load(object sender, EventArgs e)
        {
            textBox1.Text = frmSiparis.tutar.ToString();
            numericUpDown1.Value = frmSiparis.menu1;
            numericUpDown2.Value = frmSiparis.menu2;
            numericUpDown3.Value = frmSiparis.menu3;
            numericUpDown4.Value = frmSiparis.menu4;
            numericUpDown5.Value = frmSiparis.menu5;
            numericUpDown1.Controls[0].Visible = false;
            numericUpDown2.Controls[0].Visible = false;
            numericUpDown3.Controls[0].Visible = false;
            numericUpDown4.Controls[0].Visible = false;
            numericUpDown5.Controls[0].Visible = false;

            textBox5.Text = frmAdres.Madi;
            textBox2.Text = frmAdres.MSoayadi;
            textBox3.Text = frmAdres.MTel;
            textBox4.Text = frmAdres.MAdres;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAnasayfa frm = new frmAnasayfa();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Restorant;Integrated Security=True");

            baglanti.Open();
            string kayit = "insert into SiparisIslemleri (Menu1Adet,Menu2Adet,Menu3Adet,Menu4Adet,Menu5Adet,Tutar,OdemeTipi,MusteriAdi,MusteriSoyadi,MusteriTel,MusteriAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)";
            SqlCommand ekle = new SqlCommand(kayit, baglanti);
            ekle.Parameters.AddWithValue("@p1", numericUpDown1.Value);
            ekle.Parameters.AddWithValue("@p2", numericUpDown2.Value);
            ekle.Parameters.AddWithValue("@p3", numericUpDown3.Value);
            ekle.Parameters.AddWithValue("@p4", numericUpDown4.Value);
            ekle.Parameters.AddWithValue("@p5", numericUpDown5.Value);
            ekle.Parameters.AddWithValue("@p6", textBox1.Text);
            ekle.Parameters.AddWithValue("@p7", comboBox1.Text);
            ekle.Parameters.AddWithValue("@p8", textBox5.Text);
            ekle.Parameters.AddWithValue("@p9", textBox2.Text);
            ekle.Parameters.AddWithValue("@p10", textBox3.Text);
            ekle.Parameters.AddWithValue("@p11", textBox4.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Sipariş oluşturuldu.");

            frmAnasayfa frm = new frmAnasayfa();
            frm.Show();
            this.Hide();
        }
    }
}
