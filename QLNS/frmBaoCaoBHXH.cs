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
    public partial class frmBaoCaoBHXH : Form
    {
        public frmBaoCaoBHXH()
        {
            InitializeComponent();
        }

        private void frmBaoCaoBHXH_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Conn.getDataTable("select * from tblBaoHiemXH");

            CrystalReportBHXH rp = new CrystalReportBHXH();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
