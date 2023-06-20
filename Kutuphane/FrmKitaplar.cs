using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class FrmKitaplar : Form
    {
        public FrmKitaplar()
        {
            InitializeComponent();
        }

        private void FrmKitaplar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDataSet.TBL_KITAPLAR' table. You can move, or remove it, as needed.
            this.tBL_KITAPLARTableAdapter.Fill(this.kutuphaneDataSet.TBL_KITAPLAR);

        }
    }
}
