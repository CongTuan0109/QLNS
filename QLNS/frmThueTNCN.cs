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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Diagnostics;
namespace QLNS
{
    public partial class frmThueTNCN : Form
    {
        public frmThueTNCN()
        {
            InitializeComponent();
        }
        //Load Luong
        public void Load_Luong()
        {
            string str_ = "select LuongCoBan from tblLuong where MaLuong='" + txtMaLuong.Text + "'";
            System.Data.DataTable dt = Conn.getDataTable(str_);
            dataLuong.DataSource = dt;
        }
        //Load Thue
        public void Load_Thue()
        {
            string str = "select * from tblThueThuNhapCaNhan";
            System.Data.DataTable dt = Conn.getDataTable(str);
            dataThue.DataSource = dt;
        }
        public void TinhThue()
        {
            try
            {
                int TienPhaiNop = 0, ThuNhapTinhThue = 0, ThuNhapChiuThue = 0, CacKhoangGiamTru = 0, GiaDinh = 0, BaoHiem = 0;
                ThuNhapTinhThue = ThuNhapChiuThue - CacKhoangGiamTru;
                ThuNhapChiuThue = Int32.Parse(txtLuong.Text);
                if (checkGiaTruGiaDinh.Checked == true)
                    GiaDinh = 9000000;
                if (checkBaoHiem.Checked == true)
                    BaoHiem = 950000;
                CacKhoangGiamTru = (GiaDinh + BaoHiem);
                ThuNhapTinhThue = ThuNhapChiuThue - CacKhoangGiamTru;
                if (ThuNhapTinhThue <= 5000000)
                    TienPhaiNop = (ThuNhapChiuThue * 5) / 100;
                if (ThuNhapTinhThue <= 10000000 && ThuNhapTinhThue > 5000000)
                    TienPhaiNop = (ThuNhapChiuThue * 10) / 100 - 250000;
                if (ThuNhapTinhThue <= 18000000 && ThuNhapTinhThue > 10000000)
                    TienPhaiNop = (ThuNhapChiuThue * 15) / 100 - 750000;
                if (ThuNhapTinhThue <= 32000000 && ThuNhapTinhThue > 18000000)
                    TienPhaiNop = (ThuNhapChiuThue * 20) / 100 - 1650000;
                if (ThuNhapTinhThue <= 52000000 && ThuNhapTinhThue > 32000000)
                    TienPhaiNop = (ThuNhapChiuThue * 25) / 100 - 3250000;
                if (ThuNhapTinhThue <= 80000000 && ThuNhapTinhThue > 52000000)
                    TienPhaiNop = (ThuNhapChiuThue * 30) / 100 - 5850000;
                if (ThuNhapTinhThue > 80000000)
                    TienPhaiNop = (ThuNhapTinhThue * 35) / 100 - 9850000;
                if (check10.Checked == true && check20.Checked == false)
                    TienPhaiNop = TienPhaiNop / 10 * 9;
                if (check20.Checked == true && check10.Checked == false)
                    TienPhaiNop = TienPhaiNop / 10 * 8;
                if (check20.Checked == true && check10.Checked == true)
                    TienPhaiNop = TienPhaiNop / 10 * 7;
                txtSoTien.Text = TienPhaiNop.ToString();
            }
            catch (Exception)
            {
            }
        }
        private void exprotExcel(DataGridView g, string path, string fileName)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(path + fileName + ".xlsx");
            obj.ActiveWorkbook.Saved = true;

        }
        private void ThueTNCN_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            Load_Thue();
            btnThem.Enabled = false;
            //



        }

        private void cboxMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataThue_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataThue.Rows[e.RowIndex];
                txtMaThue.Text = row.Cells[0].Value.ToString();
                txtMaNV.Text = row.Cells[1].Value.ToString();
                txtCoQuanThue.Text = row.Cells[2].Value.ToString();
                txtMaLuong.Text = row.Cells[3].Value.ToString();
                dateNgayDangKiThue.Text = row.Cells[5].Value.ToString();
                txtSoTien.Text = row.Cells[4].Value.ToString();
                txtGhiChu.Text = row.Cells[6].Value.ToString();
                Load_Luong();
            }
            catch (Exception)
            { }
        }

        private void check10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataLuong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataLuong.Rows[e.RowIndex];
                txtLuong.Text = row.Cells[0].Value.ToString();
            }
            catch (Exception)
            { }
        }

        private void btnTInhThue_Click(object sender, EventArgs e)
        {
            TinhThue();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            // --- Xóa ở bảng TTNV
            string delTTNV = "DELETE FROM tblTTNhanVien WHERE MaNV='" + txtMaNV.Text + "'";
            // --- Xóa ở bảng Thuế
            string delTTThue = "DELETE FROM tblThueThuNhapCaNhan WHERE MaNV='" + txtMaNV.Text + "'";
            // --- Xóa nhân viên ở bảng BHXH
            string delBH = "DELETE FROM tblBaoHiemXH WHERE MaNV='" + txtMaNV.Text + "'";
            // --- Xóa nhân viên ở bảng Lương
            string delLuong = "DELETE FROM tblLuong WHERE MaNV='" + txtMaNV.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa nhân viên:" + txtMaNV.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    Conn.executeQuery(delTTNV);
                    Conn.executeQuery(delTTThue);
                    Conn.executeQuery(delBH);
                    Conn.executeQuery(delLuong);
                    Load_Thue();
                }
                catch (Exception)
                {
                }
            }
            else if (dialog == DialogResult.No)
            {
                //
            }
        }

        private void bntXuatExcel_Click(object sender, EventArgs e)
        {
            exprotExcel(dataThue, @"D:\", "ThueTHuNhapCaNhan");
            DialogResult dialog = MessageBox.Show("Xuất thành công. Bạn có muốn mở file Exel?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                System.Diagnostics.Process.Start(@"D:\");
            else if (dialog == DialogResult.No)
            {
                //
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaBH = "BH"+txtMaNV.Text;
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Lỗi", "Không thể thêm nhân viên.");
            }
            else
            {
                try
                {
                    //--- Thêm nhân viên vào bảng Thuế
                    string AddThue = @"INSERT INTO tblThueThuNhapCaNhan(MaThue,MaNV,CoQuanQuanLyThue,MaLuong,SoTien,NgayDangKi,GhiChu) VALUES('" + txtMaThue.Text + "','" + txtMaNV.Text + "',N'" + txtCoQuanThue.Text + "','" + txtMaLuong.Text + "','" + txtSoTien.Text + "','" + dateNgayDangKiThue.Text + "',N'" + txtGhiChu.Text + "')";
                    // --- Thêm nhân viên vào bảng lương
                    string AddLuong = @"INSERT INTO tblLuong(MaNV,MaLuong) VALUES('" + txtMaNV.Text + "','" + txtMaLuong.Text + "')";
                    // --- Thêm nhân viên vào bảng BHXH
                    string AddBH = @"INSERT INTO tblBaoHiemXH(MaNV,MaSoBH) VALUES('" + txtMaNV.Text + "','"+MaBH+"')";
                    // --- Thêm nhân viên vào bảng TTNV
                    string AddTTNV = @"INSERT INTO tblTTNhanVien(MaNV,MaLuong,MaThue) VALUES('" + txtMaNV.Text + "','" + txtMaLuong.Text + "','"+txtMaThue.Text+"')";
                    Conn.executeQuery(AddThue);
                    Conn.executeQuery(AddLuong);
                    Conn.executeQuery(AddBH);
                    Conn.executeQuery(AddTTNV);
                    bntXoa.Enabled = true;
                    btnCapNhat.Enabled = true;
                    bntXuatExcel.Enabled = true;
                    btnMoi.Enabled = true;

                    Load_Thue();
                }
                catch (Exception)
                {

                }
            }

            btnThem.Enabled = false;
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            
            txtMaNV.Enabled = true;           
            btnThem.Enabled = true;
            bntXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            bntXuatExcel.Enabled = false;
            btnMoi.Enabled = false;
            Load_Thue();
            txtMaNV.Text = "";
            txtMaThue.Text = "";
            txtCoQuanThue.Text = "";
            txtMaLuong.Text = "";
            txtSoTien.Text = "";
            txtGhiChu.Text = "";
            txtMaNV.Focus();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            txtMaLuong.Text = "L" + txtMaNV.Text;
            txtMaThue.Text = "T" + txtMaNV.Text;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // ---Cập nhật nhân viên trong bảng Thuế
            string upThue = "UPDATE tblThueThuNhapCaNhan SET MaThue='" + txtMaThue.Text + "',MaNV='" + txtMaNV.Text + "',CoQuanQuanLyThue=N'" + txtCoQuanThue.Text + "',MaLuong='" + txtMaLuong.Text + "',SoTien='" + txtSoTien.Text + "',NgayDangKi=N'" + dateNgayDangKiThue.Text + "',GhiChu=N'" + txtGhiChu.Text + "' WHERE(MaNV=N'" + txtMaNV.Text + "')";
            string upNhanVien = "UPDATE tblTTNhanVien SET MaNV='" + txtMaNV.Text + "',MaLuong='" + txtMaLuong.Text + "' WHERE MaNV='" + txtMaNV.Text + "'";
            string upLuong = "UPDATE tblTTNhanVien SET MaNV='" + txtMaNV.Text + "',MaLuong='" + txtMaLuong.Text + "' WHERE MaNV='" + txtMaNV.Text + "'";
            Conn.executeQuery(upThue);
            Conn.executeQuery(upNhanVien);
            Conn.executeQuery(upLuong);
            Load_Thue();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
