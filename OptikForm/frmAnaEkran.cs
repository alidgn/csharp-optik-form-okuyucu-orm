using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptikForm
{
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cOkunanlar._kontrol = 0;
            frmOptikOkuma frm = new frmOptikOkuma();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEskiKayitlar frm = new frmEskiKayitlar();
            frm.Show();
        }
    }
}
