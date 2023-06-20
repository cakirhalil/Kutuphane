using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kutuphane
{
    public partial class FrmKitapAyarlar : Form
    {
        public FrmKitapAyarlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MONSTER-HUMA;Initial Catalog=Kutuphane;Integrated Security=True");


        private void FrmKitapAyarlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDataSet.TBL_KITAPLAR' table. You can move, or remove it, as needed.
            this.tBL_KITAPLARTableAdapter.Fill(this.kutuphaneDataSet.TBL_KITAPLAR);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutEkle = new SqlCommand("insert into TBL_KITAPLAR(ID,KITAPAD,KITAPYAZAR,TURU,SAYFA) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komutEkle.Parameters.AddWithValue("@p1", txtId.Text);
            komutEkle.Parameters.AddWithValue("@p2", txtKitapAd.Text);
            komutEkle.Parameters.AddWithValue("@p3", txtYazar.Text);
            komutEkle.Parameters.AddWithValue("@p4", txtTuru.Text);
            komutEkle.Parameters.AddWithValue("@p5", txtSayfa.Text);
            komutEkle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitabı eklendiniz", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tBL_KITAPLARTableAdapter.Fill(this.kutuphaneDataSet.TBL_KITAPLAR);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("DELETE FROM TBL_KITAPLAR WHERE ID=@p1", baglanti);
            komutsil.Parameters.AddWithValue("@p1", txtId.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitabı sildiniz", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tBL_KITAPLARTableAdapter.Fill(this.kutuphaneDataSet.TBL_KITAPLAR);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("update TBL_KITAPLAR set KITAPAD=@P1,KITAPYAZAR=@P2,TURU=@P3,SAYFA=@P4 where ID=@P5", baglanti);
            komutguncelle.Parameters.AddWithValue("@p1", txtKitapAd.Text);
            komutguncelle.Parameters.AddWithValue("@p2", txtYazar.Text);
            komutguncelle.Parameters.AddWithValue("@p3", txtTuru.Text);
            komutguncelle.Parameters.AddWithValue("@p4", txtSayfa.Text);
            komutguncelle.Parameters.AddWithValue("@p5", txtId.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitabı güncellediniz", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tBL_KITAPLARTableAdapter.Fill(this.kutuphaneDataSet.TBL_KITAPLAR);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtKitapAd.Text = "";
            txtYazar.Text = "";
            txtTuru.Text = "";
            txtSayfa.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtTuru.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }
    }
}
