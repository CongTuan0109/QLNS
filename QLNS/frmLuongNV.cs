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
    public partial class frmLuongNV : Form
    {
        public frmLuongNV()
        {
            InitializeComponent();
        }

        private void frmLuongNV_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            string str = "select * from tblLuong";
            System.Data.DataTable dt = KiemTraKetNoi.getDatatable(str);
            dataLuong.DataSource = dt;
            btnThem.Enabled = false;
        }
        public void Load_data()
        {
            string str = "select * from tblLuong";
            System.Data.DataTable dt = KiemTraKetNoi.getDatatable(str);
            dataLuong.DataSource = dt;
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataLuong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataLuong.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtMaLuong.Text = row.Cells[2].Value.ToString();
                cboxMaCM.Text = row.Cells[3].Value.ToString();
                txtLuongCB.Text = row.Cells[4].Value.ToString();
                txtPCCV.Text = row.Cells[5].Value.ToString();
                dateNgayNhap.Text = row.Cells[6].Value.ToString();
                txtLuongCBMoi.Text = row.Cells[7].Value.ToString();
                dateNgaySua.Text = row.Cells[8].Value.ToString();
                txtLyDo.Text = row.Cells[9].Value.ToString();
                btnXoa.Enabled = true;
                btnCapNhat.Enabled = true;
                btnXuatExcel.Enabled = true;
                btnMoi.Enabled = true;
            }
            catch (Exception)
            { }
        }

        private void txtLuongCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXuatExcel.Enabled = false;
            btnMoi.Enabled = false;
            Load_data();
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            cboxMaCM.Text = "";
            txtLuongCB.Text = "";
            txtPCCV.Text = "";
            dateNgayNhap.Text = "1/1/2016";
            txtLuongCBMoi.Text = "";
            dateNgaySua.Text = "1/1/2016";
            txtLyDo.Text = "";
            txtMaNV.Enabled = true;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            exprotExcel(dataLuong, @"D:\", "LuongNhanVien");
            DialogResult dialog = MessageBox.Show("Xuất thành công. Bạn có muốn mở thư mục?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                System.Diagnostics.Process.Start(@"D:\");
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string delLuong = "DELETE FROM tblLuong WHERE MaNV='" + txtMaNV.Text + "'";
            // ---Xóa NV ở bảng NV
            string delNV = "DELETE FROM tblTTNhanVien WHERE MaNV='" + txtMaNV.Text + "'";
            // ---Xóa NV ở bảng BHXH
            string delBH = "DELETE FROM tblBaoHiemXH WHERE MaNV='" + txtMaNV.Text + "'";
            string delThue = "DELETE FROM tblThueThuNhapCaNhan WHERE MaNV='" + txtMaNV.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa lương nhân viên: "+txtMaNV.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {

                    Conn.executeQuery(delLuong);
                    Conn.executeQuery(delNV);
                    Conn.executeQuery(delBH);
                    Conn.executeQuery(delThue);

                    Load_data();
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string Chuyen_Mon="";
            if (cboxMaCM.Text == "CM001")
                Chuyen_Mon = "CEO";
            if (cboxMaCM.Text == "CM002")
                Chuyen_Mon = "Quản Lý";
            if (cboxMaCM.Text == "CM003")
                Chuyen_Mon = "Bán Hàng";
            if (cboxMaCM.Text == "CM004")
                Chuyen_Mon = "Kế Toán";
            string upLuonng = "UPDATE tblLuong SET HoTen=N'" + txtHoTen.Text + "',MaLuong='" + txtMaLuong.Text + "',MaChuyenMon='" + cboxMaCM.Text + "',LuongCoBan='" + txtLuongCB.Text + "',PCChucVu='" + txtPCCV.Text + "',NgayNhap='" + dateNgayNhap.Text + "',LuongCBMoi='" + txtLuongCBMoi.Text + "',NgaySua='" + dateNgaySua.Text + "',LyDo=N'" + txtLyDo.Text + "'WHERE(MaNV=N'" + txtMaNV.Text + "')";
            string upTTNV = "UPDATE tblTTNhanVien SET MaNV='"+txtMaNV.Text+"',HoTen=N'"+txtHoTen.Text+"',MaLuong='"+txtMaLuong.Text+"',ChuyenMon='"+Chuyen_Mon+"' WHERE (MaNV='"+txtMaNV.Text+"')";
            string upTHue = "UPDATE tblThueThuNhapCaNhan SET MaNV='" + txtMaNV.Text + "',MaLuong='" + txtMaLuong.Text + "' WHERE MaNV='" + txtMaNV.Text + "'";
            Conn.executeQuery(upLuonng);
            Conn.executeQuery(upTTNV);
            Conn.executeQuery(upTHue);
            Load_data();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Lỗi", "Mã NV không được để trống.");
            }
            else
            {
                try
                {
                    // --Thêm thông tin vào bảng lương
                    string addLuong = @"INSERT INTO tblLuong(MaNV, HoTen,MaLuong, MaChuyenMon, LuongCoBan, PCChucVu, NgayNhap, LuongCBMoi, NgaySua, LyDo) VALUES ('" + txtMaNV.Text + "',N'" + txtHoTen.Text + "','" + txtMaLuong.Text + "','" + cboxMaCM.Text + "','" + txtLuongCB.Text + "','" + txtPCCV.Text + "','" + dateNgayNhap.Text + "','" + txtLuongCBMoi.Text + "','" + dateNgaySua.Text + "',N'" + txtLyDo.Text + "')";
                    // --Thêm thông tin vào bảng TT Nhân viên
                    string addNV = @"INSERT INTO tblTTNhanVien(MaNV,HoTen,MaLuong) VALUES('" + txtMaNV.Text + "',N'" + txtHoTen.Text + "','" + txtMaLuong.Text + "')";
                    // --Thêm thông tin vào bảng bảo hiểm XH
                    string addBHXH = @"INSERT INTO tblBaoHiemXH(MaNV) VALUES('" + txtMaNV.Text + "')";
                    string addThue = @"INSERT INTO tblThueThuNhapCaNhan(MaNV,MaLuong) VALUES('" + txtMaNV.Text + "','" + txtMaLuong.Text + "')";
                    Conn.executeQuery(addLuong);
                    Conn.executeQuery(addNV);
                    Conn.executeQuery(addBHXH);
                    Conn.executeQuery(addThue);

                    txtMaNV.Enabled = false;
                    btnThem.Enabled = true;
                    btnCapNhat.Enabled = true;
                    btnXuatExcel.Enabled = true;
                    btnXoa.Enabled = true;
                    btnMoi.Enabled = true;
                    Load_data();
                }
                catch (Exception)
                {

                }
            }
            btnThem.Enabled = false;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            txtMaLuong.Text = "L" + txtMaNV.Text;
        }
    }
}
