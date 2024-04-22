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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Restorant;Integrated Security=True");
            baglanti.Open();
            string kayit = "SELECT [MusteriAdi]" +
                ",[MusteriSoyadi]" +
                ",[MusteriTel]" +
                ",[MusteriAdres]" +
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
