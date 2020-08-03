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


namespace QLNS
{
    public partial class frmSapXep : Form
    {
        public frmSapXep()
        {
            InitializeComponent();
        }

        private void frmDonVi_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Height = 340;
        }
        private void cboxTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cboxTenDV.SelectedItem.ToString();
            if (selected == "Văn Phòng")
                txtMaDV.Text = "DV001";
            if (selected == "Phòng Tổ chức lao động")
                txtMaDV.Text = "DV002";
            if (selected == "Phòng Kế toán - Tài chính")
                txtMaDV.Text = "DV003";
            if (selected == "Phòng Vật tư")
                txtMaDV.Text = "DV004";
            if (selected == "Phòng Kế hoạch - Tiêu thụ")
                txtMaDV.Text = "DV005";
            if (selected == "Phòng Điều hành sản xuất")
                txtMaDV.Text = "DV006";
            if (selected == "Phòng Thanh tra BVQS")
                txtMaDV.Text = "DV007";
            this.Height = 736;
            string DV = "SELECT MaNV, HoTen FROM tblTTNhanVien WHERE MaDonVi=N'" + txtMaDV.Text + "'";
            System.Data.DataTable dt = Conn.getDataTable(DV);
            dataHienThiDV.DataSource = dt;
            int count = dataHienThiDV.Rows.Count - 1;
            txtTongSo.Text = count.ToString();
        }

        private void btnXoaCM_Click(object sender, EventArgs e)
        {

            
            string delTTNV = "DELETE FROM tblTTNhanVien WHERE MaNV='" + lbMaNV.Text + "'";
            try
            {
                Conn.executeQuery(delTTNV);
                string CM = "SELECT MaNV, HoTen, ChuyenMon FROM tblTTNhanVien WHERE ChuyenMon=N'" + cboxChuyenMon.Text + "'";
                System.Data.DataTable dt = Conn.getDataTable(CM);
                dataHienThiCM.DataSource = dt;
            }
            catch (Exception)
            {
            }
            
        }

        private void dataHienThiCM_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                lbMaNV.Text =dataHienThiCM.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception)
            { 
            }
        }

        private void btnSuaCM_Click(object sender, EventArgs e)
        {
            string upCM = "UPDATE tblTTNhanVien SET ChuyenMon=N'" + cboxChuyenMon.Text + "'WHERE(MaNV='" + lbMaNV.Text + "')";
            try
            {
                System.Data.DataTable dt = Conn.getDataTable(upCM);
                dataHienThiCM.DataSource = dt;
            }
            catch (Exception)
            { 
            }


        }

        private void bntXoa__Click(object sender, EventArgs e)
        {
            string delTTNV = "DELETE FROM tblTTNhanVien WHERE MaNV='" + lbMaNV.Text + "'";
            try
            {
                Conn.executeQuery(delTTNV);
                string CM = "SELECT MaNV, HoTen, ChuyenMon FROM tblTTNhanVien WHERE MaDonVi=N'" + txtMaDV.Text + "'";
                System.Data.DataTable dt = Conn.getDataTable(CM);
                dataHienThiDV.DataSource = dt;
            }
            catch (Exception)
            {
            }
        }

        private void bntSua__Click(object sender, EventArgs e)
        {
            string upCM = "UPDATE tblTTNhanVien SET MaDOnVi=N'" + txtMaDV.Text + "'WHERE(MaNV='" + lbMaNV.Text + "')";
            try
            {
                System.Data.DataTable dt = Conn.getDataTable(upCM);
                dataHienThiDV.DataSource = dt;
            }
            catch (Exception)
            {
            }

        }

        private void dataHienThiDV_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                lbMaNV.Text = dataHienThiDV.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void cboxChuyenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cboxChuyenMon.SelectedItem.ToString();
            if (selected == "CEO")
                txtMaChuyenMon.Text = "CM001";
            if (selected == "Quản Lý")
                txtMaChuyenMon.Text = "CM002";
            if (selected == "Bán Hàng")
                txtMaChuyenMon.Text = "CM003";
            if (selected == "Kế Toán")
                txtMaChuyenMon.Text = "CM004";
            this.Height = 736;
            string CM = "SELECT MaNV, HoTen, ChuyenMon FROM tblTTNhanVien WHERE ChuyenMon=N'" + cboxChuyenMon.Text + "'";
            System.Data.DataTable dt = Conn.getDataTable(CM);
            dataHienThiCM.DataSource = dt;
            int count = dataHienThiCM.Rows.Count - 1;
            txtTongSo.Text = count.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Height = 736;
            string CM = "SELECT MaNV, HoTen FROM tblTTNhanVien WHERE TDHV=N'" + cboxTrinhDo.Text + "'";
            System.Data.DataTable dt = Conn.getDataTable(CM);
            dataTrinhDo.DataSource = dt;
            int count = dataTrinhDo.Rows.Count - 1;
            txtTongSo.Text = count.ToString();

        }

        private void dataTrinhDo_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                lbMaNV.Text = dataTrinhDo.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void bntXoaTD_Click(object sender, EventArgs e)
        {
            string delTTNV = "DELETE FROM tblTTNhanVien WHERE MaNV='" + lbMaNV.Text + "'";
            try
            {
                Conn.executeQuery(delTTNV);
                string TD = "SELECT MaNV, HoTen FROM tblTTNhanVien WHERE TDHV=N'" + cboxTrinhDo.Text + "'";
                System.Data.DataTable dt = Conn.getDataTable(TD);
                dataTrinhDo.DataSource = dt;
            }
            catch (Exception)
            {
            }
        }

        private void bntSuaTD_Click(object sender, EventArgs e)
        {
            string upTD = "UPDATE tblTTNhanVien SET TDHV=N'" + cboxTrinhDo.Text + "'WHERE(MaNV='" + lbMaNV.Text + "')";
            try
            {
                System.Data.DataTable dt = Conn.getDataTable(upTD);
                dataTrinhDo.DataSource = dt;
            }
            catch (Exception)
            {
            }
        }

    }
}
