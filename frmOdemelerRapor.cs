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
    public partial class frmOdemelerRapor : Form
    {
        public frmOdemelerRapor()
        {
            InitializeComponent();
        }

        private void frmOdemelerRapor_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Restorant;Integrated Security=True");
            baglanti.Open();
            string kayit = "SELECT Menu1Adet" +
                ", Menu2Adet" +
                ", Menu3Adet" +
                ", Menu4Adet" +
                ", Menu5Adet" +
                ", Tutar" +
                ", OdemeTipi" +
                " FROM SiparisIslemleri";
            SqlDataAdapter da = new SqlDataAdapter(kayit, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAnasayfa frm = new frmAnasayfa();
            frm.Show();
            this.Hide();
        }
    }
}
