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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (radMaNV.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE MaNV='" +txtTimKiem.Text+ "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radTenNV.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE HoTen LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNoiSinh.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE NoiSinh LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radDiaChi.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE DiaChi LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radChuyenMon.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE ChuyenMon LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radTDHV.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE TDHV LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radDanToc.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE DanToc LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radTonGiao.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE TonGiao LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radQuocTich.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE QuocTich LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radLuongCB.Checked == true)
                {
                    string Search = "SELECT * FROM tblLuong WHERE LuongCoBan='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radDonVi.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE MaDonVi='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNoiCapBHXH.Checked == true)
                {
                    string Search = "SELECT * FROM tblBaoHiemXH WHERE NoiCap LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNoiDKKCB.Checked == true)
                {
                    string Search = "SELECT * FROM tblBaoHiemXH WHERE NoiDKKCB LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radGioiTinh.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE GioiTinh=N'" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radSDT.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE SDT LIKE'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radEmail.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE Email='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNgaySinh.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE NgaySinh='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNgayNhapLuong.Checked == true)
                {
                    string Search = "SELECT * FROM tblLuong WHERE NgayNhap='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNgaySuaLuong.Checked == true)
                {
                    string Search = "SELECT * FROM tblLuong WHERE NgaySua='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNgayCapBHXH.Checked == true)
                {
                    string Search = "SELECT * FROM tblBaoHiemXH WHERE NgayCap='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (txtTimKiem.Text == "Nhân viên nào có lương cao nhất?" || txtTimKiem.Text == "nhân viên nào có lương cao nhất?" || txtTimKiem.Text == "lương cao nhất?")
                {
                    string Search = "SELECT * FROM tblLuong  where LuongCoBan = (select max(LuongCoBan) from tblLuong )";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (txtTimKiem.Text == "Nhân viên nào có lương thấp nhất?" || txtTimKiem.Text == "nhân viên nào có lương thấp nhất?" || txtTimKiem.Text == "lương thấp nhất?")
                {
                    string Search = "SELECT * FROM tblLuong  where LuongCoBan = (select min(LuongCoBan) from tblLuong )";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //

            }
            catch (Exception)
            { }
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            txtTimKiem.Focus();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtTimKiem.Text = "Nhân viên nào có lương cao nhất?";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtTimKiem.Text = "Nhân viên nào có lương thấp nhất?";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (radMaNV.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE MaNV='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radTenNV.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE HoTen LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNoiSinh.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE NoiSinh LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radDiaChi.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE DiaChi LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radChuyenMon.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE ChuyenMon LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radTDHV.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE TDHV LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radDanToc.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE DanToc LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radTonGiao.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE TonGiao LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radQuocTich.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE QuocTich LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radLuongCB.Checked == true)
                {
                    string Search = "SELECT * FROM tblLuong WHERE LuongCoBan='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radDonVi.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE MaDonVi='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNoiCapBHXH.Checked == true)
                {
                    string Search = "SELECT * FROM tblBaoHiemXH WHERE NoiCap LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNoiDKKCB.Checked == true)
                {
                    string Search = "SELECT * FROM tblBaoHiemXH WHERE NoiDKKCB LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radGioiTinh.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE GioiTinh=N'" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radSDT.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE SDT LIKE'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radEmail.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE Email='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNgaySinh.Checked == true)
                {
                    string Search = "SELECT * FROM tblTTNhanVien WHERE NgaySinh='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNgayNhapLuong.Checked == true)
                {
                    string Search = "SELECT * FROM tblLuong WHERE NgayNhap='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNgaySuaLuong.Checked == true)
                {
                    string Search = "SELECT * FROM tblLuong WHERE NgaySua='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNgayCapBHXH.Checked == true)
                {
                    string Search = "SELECT * FROM tblBaoHiemXH WHERE NgayCap='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (txtTimKiem.Text == "Nhân viên nào có lương cao nhất?" || txtTimKiem.Text == "nhân viên nào có lương cao nhất?" || txtTimKiem.Text == "lương cao nhất?")
                {
                    string Search = "SELECT * FROM tblLuong  where LuongCoBan = (select max(LuongCoBan) from tblLuong )";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (txtTimKiem.Text == "Nhân viên nào có lương thấp nhất?" || txtTimKiem.Text == "nhân viên nào có lương thấp nhất?" || txtTimKiem.Text == "lương thấp nhất?")
                {
                    string Search = "SELECT * FROM tblLuong  where LuongCoBan = (select min(LuongCoBan) from tblLuong )";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search);
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //

            }
            catch (Exception)
            { }
        }
    }
}
