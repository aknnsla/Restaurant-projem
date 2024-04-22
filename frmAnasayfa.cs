using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            frm.Show();
            this.Hide();
        }
        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Restorant;Integrated Security=True");

            baglanti.Open();
            string kayit = "SELECT SUM(Menu1Adet) AS Menu1Adet" +
                ", SUM(Menu2Adet) AS Menu2Adet" +
                ", SUM(Menu3Adet) AS Menu3Adet" +
                ", SUM(Menu4Adet) AS Menu4Adet" +
                ", SUM(Menu5Adet) AS Menu5Adet" +
                ", SUM(Tutar) AS Tutar" +
                "  FROM SiparisIslemleri";
            SqlDataAdapter da = new SqlDataAdapter(kayit, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            textBox1.Text = tablo.Rows[0]["Menu1Adet"].ToString();
            textBox2.Text = tablo.Rows[0]["Menu2Adet"].ToString();
            textBox3.Text = tablo.Rows[0]["Menu3Adet"].ToString();
            textBox4.Text = tablo.Rows[0]["Menu4Adet"].ToString();
            textBox5.Text = tablo.Rows[0]["Menu5Adet"].ToString();
            textBox6.Text = tablo.Rows[0]["Tutar"].ToString();
            baglanti.Close();
        }

        private void btnSiparis_Click_1(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            frm.Show();
            this.Hide();
        }

        private void Adres_Click_1(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            frm.Show();
            this.Hide();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            frmOdemelerRapor frm = new frmOdemelerRapor();
            frm.Show();
            this.Hide();
        }
    }
}
