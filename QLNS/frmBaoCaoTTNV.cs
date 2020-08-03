using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLNS
{
    public partial class frmBaoCaoTTNV : Form
    {
        public frmBaoCaoTTNV()
        {
            InitializeComponent();
        }

        private void frmBaoCaoTTNV_Load(object sender, EventArgs e)
        {
            DataTable dt =new DataTable();
            dt = Conn.getDataTable("select * from tblTTNhanVien");

            CrystalReport1 rp = new CrystalReport1();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;


        }
    }
}
