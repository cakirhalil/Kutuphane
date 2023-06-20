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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MONSTER-HUMA;Initial Catalog=Kutuphane;Integrated Security=True");

        FrmKitaplar frm1;
        private void btnKitaplar_Click(object sender, EventArgs e)
        {
            if (frm1 == null)
            {
                frm1 = new FrmKitaplar();
                frm1.Show();

            }
        }
        FrmKitapAyarlar frm2;
        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            if (frm2 == null)
            {
                frm2 = new FrmKitapAyarlar();
                frm2.Show();

            }
        }
        FrmIstatistik frm3;
        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            if (frm3 == null)
            {
                frm3 = new FrmIstatistik();
                frm3.Show();

            }
        }
    }
}
