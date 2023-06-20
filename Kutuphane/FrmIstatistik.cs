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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MONSTER-HUMA;Initial Catalog=Kutuphane;Integrated Security=True");

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            //KİTAP SAYISINI BULMA
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select COUNT(ID) from TBL_KITAPLAR", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblKitapSayı.Text = dr1[0].ToString();
            }
            baglanti.Close();

            //ROMAN SAYISINI BULMA
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select COUNT(*) from TBL_KITAPLAR where TURU='ROMAN'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblRoman.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //HİKAYE SAYISINI BULMA
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select COUNT(*) from TBL_KITAPLAR where TURU='HİKAYE'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblHikaye.Text = dr3[0].ToString();
            }
            baglanti.Close();

            //ANSİKLOPEDİ SAYISINI BULMA
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select COUNT(*) from TBL_KITAPLAR where TURU='ANSİKLOPEDİ'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblAnsiklopedi.Text = dr4[0].ToString();
            }
            baglanti.Close();
        }
    }
}
