using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form NV = new frmBaoCaoTTNV();
            NV.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form Lg = new frmBaoCaoLuong();
            Lg.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form BH = new frmBaoCaoBHXH();
            BH.ShowDialog();
        }
    }
}
