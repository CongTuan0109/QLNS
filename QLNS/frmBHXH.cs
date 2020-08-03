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
    public partial class frmBHXH : Form
    {
        public frmBHXH()
        {
            InitializeComponent();
        }
        public void Load_data()
        {
            string str = "select * from tblBaoHiemXH";
            System.Data.DataTable dt = KiemTraKetNoi.getDatatable(str);
            dataBaoHiem.DataSource = dt;
        }
        private void frmBHXH_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            btnThem.Enabled = false;
            Load_data();
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
                    //
                    string addBHXH = "INSERT INTO tblBaoHiemXH(MaNV, MaSoBH, NgayCap, NoiCap, NoiDKKCB, GhiChu) VALUES ('" + txtMaNV.Text + "','" + txtMaSBH.Text + "','" + dateNgayCap.Text + "',N'" + txtNoiCap.Text + "',N'" + txtNoiDKKCB.Text + "',N'" + txtGhiChu.Text + "')";
                    // Add nhân viên vào bảng TTNV
                    string addNV = "INSERT INTO tblTTNhanVien(MaNV,MaBHXH) VALUES ('" + txtMaNV.Text + "','" + txtMaSBH.Text + "')";
                    // Add nhân viên vào bảng Lương
                    string addLuong = "INSERT INTO tblLuong(MaNV) VALUES ('" + txtMaNV.Text + "')";
                    Conn.executeQuery(addBHXH);
                    Conn.executeQuery(addNV);
                    Conn.executeQuery(addLuong);
                    Load_data();
                    txtMaNV.Enabled = false;
                    btnThem.Enabled = true;
                    btnCapNhat.Enabled = true;
                    btnXuatExcel.Enabled = true;
                    btnMoi.Enabled = true;
                    btnXoa.Enabled = true;
                    txtMaNV.Enabled = false;
                }
                catch (Exception)
                {

                }
            }
            btnThem.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string upLuonng = "UPDATE tblBaoHiemXH SET MaSoBH=N'" + txtMaSBH.Text + "',NgayCap='" + dateNgayCap.Text + "',NoiCap=N'" + txtNoiCap.Text + "',NoiDKKCB=N'" + txtNoiDKKCB.Text + "',GhiChu=N'" + txtGhiChu.Text +"'WHERE(MaNV=N'" + txtMaNV.Text + "')";
            string upTTNV = "update tblTTNhanVien set MaBHXH='" + txtMaSBH.Text + "' where MaNV='" + txtMaNV.Text + "'";
            Conn.executeQuery(upLuonng);
            Conn.executeQuery(upTTNV);
            Load_data();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            exprotExcel(dataBaoHiem, @"D:\", "BaoHiemXaHoi");
            DialogResult dialog = MessageBox.Show("Xuất thành công. Bạn có muốn mở thư mục?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                System.Diagnostics.Process.Start(@"D:\");
            else if (dialog == DialogResult.No)
            {

            }
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
            txtMaSBH.Text = "BH";
            dateNgayCap.Text = "1/1/2016";
            txtNoiCap.Text = "";
            txtNoiDKKCB.Text = "";
            txtGhiChu.Text = "";
            txtMaNV.Enabled = true;
        }

        private void dataBaoHiem_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataBaoHiem.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtMaSBH.Text = row.Cells[1].Value.ToString();
                dateNgayCap.Text = row.Cells[2].Value.ToString();
                txtNoiCap.Text = row.Cells[3].Value.ToString();
                txtNoiDKKCB.Text = row.Cells[4].Value.ToString();
                txtGhiChu.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception)
            { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // --- Xóa nhân viên ở bảng BHXH
            string delBH = "DELETE FROM tblBaoHiemXH WHERE MaNV='" + txtMaNV.Text + "'";
            // --- Xóa nhân viên ở bảng Nhân Viên
            string delTTNV = "DELETE FROM tblTTNhanVien WHERE MaNV='" + txtMaNV.Text + "'";
            // --- Xóa nhân viên ở bảng Lương
            string delLuong = "DELETE FROM tblLuong WHERE MaNV='" + txtMaNV.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa BHXH nhân viên: "+txtMaNV.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string delThue = "delete from tblThueThuNhapCaNhan where MaNV='" + txtMaNV.Text + "'";
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    Conn.executeQuery(delBH);
                    Conn.executeQuery(delTTNV);
                    Conn.executeQuery(delLuong);
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

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            txtMaSBH.Text = "BH" + txtMaNV.Text;
        }
    }
}
