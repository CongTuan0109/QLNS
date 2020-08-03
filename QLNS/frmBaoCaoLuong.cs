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
    public partial class frmBaoCaoLuong : Form
    {
        public frmBaoCaoLuong()
        {
            InitializeComponent();
        }

        private void frmBaoCaoLuong_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Conn.getDataTable("select * from tblLuong");

            CrystalReportLuong rp = new CrystalReportLuong();
            rp.SetDataSource(dt);
            crystalReportViewer2.ReportSource = rp;
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
