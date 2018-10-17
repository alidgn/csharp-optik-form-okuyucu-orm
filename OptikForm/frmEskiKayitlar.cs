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
    public partial class frmEskiKayitlar : Form
    {
        public frmEskiKayitlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEskiKayitlar_Load(object sender, EventArgs e)
        {
            cOkunanlar o = new cOkunanlar();
            o.eskiKayitlariGetir(lvKayitlar);
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            cOkunanlar o = new cOkunanlar();
            o.eskiKayitlariGetir(lvKayitlar, txtArama.Text);
        }

        private void lvKayitlar_DoubleClick(object sender, EventArgs e)
        {
            cOkunanlar._kontrol = 1;
            cOkunanlar._str = lvKayitlar.SelectedItems[0].SubItems[7].Text;
            frmOptikOkuma frm = new frmOptikOkuma();
            this.Close();
            frm.Show();
        }
    }
}
