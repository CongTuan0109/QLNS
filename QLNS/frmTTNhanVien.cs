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
    public partial class frmTTNhanVien : Form
    {
        string username;
        public frmTTNhanVien()
        {
            InitializeComponent();
        }
        public frmTTNhanVien(string user)
        {
            InitializeComponent();
            username = user;
        }
        public void Load_data()
        {
            string str = "select * from tblTTNhanVien";
            System.Data.DataTable dt = KiemTraKetNoi.getDatatable(str);
            dataNhanVien.DataSource = dt;
        }
        private void frmTTNhanVien_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Load_data();
            btnAdd.Enabled = false;
            
        }
        private void exprotExcel(DataGridView g, string path, string fileName)
        {
            app obj=new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count+1; i++)
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
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cboxDanToc.SelectedItem.ToString());
            //MessageBox.Show("" + txtHoTen.Text + cboxNhomMau.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string GioiTinh;
            if (radNam.Checked == true)
                GioiTinh = "Nam";
            else
                GioiTinh = "Nữ";
            string upTTNV = "UPDATE tblTTNhanVien SET HoTen=N'" + txtHoTen.Text + "',NgaySinh='" + dateNgaySinh.Text + "',GioiTinh=N'" + GioiTinh + "',CMND='" + txtCMND.Text + "',NoiSinh=N'" + txtNoiSinh.Text + "',DiaChi=N'" + txtDiaChi.Text + "',SDT='" + txtSDT.Text + "',TDHV=N'" + txtTDHV.Text + "',MaBHXH='" + txtMaBHXH.Text + "',MaLuong='" + txtMaLuong.Text + "',MaDonVi='" + cboxMaDV.Text + "',MaThue='" + txtMaThue.Text + "',ChuyenMon=N'" + cboxChuyenMon.Text + "',Email='" + txtEmail.Text + "',GhiChu=N'" + txtGhiChu.Text + "',DanToc=N'" + cboxDanToc.Text + "',TonGiao=N'" + cboxTonGiao.Text + "',QuocTich=N'" + cboxQuocTich.Text + "'WHERE(MaNV=N'" + txtMaNV.Text + "')";
            // ---Cập nhật nhân viên trong form Lương
            string upLuong = "UPDATE tblLuong SET HoTen=N'" + txtHoTen.Text + "',MaLuong='" + txtMaLuong.Text + "' WHERE(MaNV='" + txtMaNV.Text + "')";
            // ---Cập nhật nhân viên trong form BHXH
            string upBH = "UPDATE tblBaoHiemXH SET MaSoBH='" + txtMaBHXH.Text + "' WHERE(MaNV='" + txtMaNV.Text + "')";
            string upThue = "UPDATE  tblThueThuNhapCaNhan SET MaLuong='" + txtMaLuong.Text + "',MaThue='" + txtMaThue.Text + "' WHERE(MaNV='" + txtMaNV.Text + "')";
            Conn.executeQuery(upTTNV);
            Conn.executeQuery(upBH);
            Conn.executeQuery(upLuong);
            Conn.executeQuery(upThue);
            Load_data();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text=="")
            {
               // MessageBox.Show("Lỗi", "Không thể thêm nhân viên.");
            }
            else
            {             
                try
                {
                    string GioiTinh;
                    if (radNam.Checked == true)
                        GioiTinh = "Nam";
                    else
                        GioiTinh = "Nữ";
                    string addTTNV = @"INSERT INTO tblTTNhanVien(MaNV, HoTen, NgaySinh, GioiTinh, CMND, NoiSinh, DiaChi, SDT, TDHV, MaBHXH, MaLuong, MaDonVi, MaThue, ChuyenMon, Email, GhiChu, DanToc, TonGiao, QuocTich) VALUES ('" + txtMaNV.Text + "',N'" + txtHoTen.Text + "','" + dateNgaySinh.Text + "',N'" + GioiTinh + "','" + txtCMND.Text + "',N'" + txtNoiSinh.Text + "',N'" + txtDiaChi.Text + "','" + txtSDT.Text + "',N'" + txtTDHV.Text + "','" + txtMaBHXH.Text + "','" + txtMaLuong.Text + "','" + cboxMaDV.Text + "','" + txtMaThue.Text + "',N'" + cboxChuyenMon.Text + "','" + txtEmail.Text + "',N'" + txtGhiChu.Text + "',N'" + cboxDanToc.Text + "',N'" + cboxTonGiao.Text + "',N'" + cboxQuocTich.Text + "')";                    
                    txtMaNV.Enabled = false;
                    // --- Thêm nhân viên vào bảng lương
                    string AddLuong = @"INSERT INTO tblLuong(MaNV,HoTen,MaLuong) VALUES('" + txtMaNV.Text + "',N'" + txtHoTen.Text + "','" + txtMaLuong.Text + "')";
                    // --- Thêm nhân viên vào bảng BHXH
                    string AddBH = @"INSERT INTO tblBaoHiemXH(MaNV,MaSoBH) VALUES('" + txtMaNV.Text + "','" + txtMaBHXH.Text + "')";
                    string addThue = @"INSERT INTO tblThueThuNhapCaNhan(MaNV,MaLuong,MaThue) VALUES('" + txtMaNV.Text + "','" + txtMaLuong.Text + "','"+txtMaThue.Text+"')";
                    Conn.executeQuery(addTTNV);
                    Conn.executeQuery(AddLuong);
                    Conn.executeQuery(AddBH);
                    Conn.executeQuery(addThue);
                    MessageBox.Show("Thành Công", "Thêm");
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnExport.Enabled = true;
                    button1.Enabled = true;                
                    Load_data();
                }           
                catch (Exception)
                {

                }
            }

            btnAdd.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string delTTNV = "DELETE FROM tblTTNhanVien WHERE MaNV='" + txtMaNV.Text+"'";
            // --- Xóa nhân viên ở bảng BHXH
            string delBH = "DELETE FROM tblBaoHiemXH WHERE MaNV='" + txtMaNV.Text + "'";
            // --- Xóa nhân viên ở bảng Lương
            string delLuong = "DELETE FROM tblLuong WHERE MaNV='" + txtMaNV.Text + "'";
            string delThue = "DELETE FROM tblThueThuNhapCaNhan WHERE MaNV='" + txtMaNV.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa nhân viên:"+txtMaNV.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    Conn.executeQuery(delTTNV);
                    Conn.executeQuery(delBH);
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dataNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                dateNgaySinh.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value.ToString() == "Nam")
                    radNam.Checked = true;
                else
                    radNu.Checked = true;
                txtCMND.Text = row.Cells[4].Value.ToString();
                txtNoiSinh.Text = row.Cells[5].Value.ToString();
                txtDiaChi.Text = row.Cells[6].Value.ToString();
                txtSDT.Text = row.Cells[7].Value.ToString();
                txtTDHV.Text = row.Cells[8].Value.ToString();
                txtMaBHXH.Text = row.Cells[9].Value.ToString();
                txtMaLuong.Text = row.Cells[10].Value.ToString();
                cboxMaDV.Text = row.Cells[11].Value.ToString();
                txtMaThue.Text = row.Cells[12].Value.ToString();
                cboxChuyenMon.Text = row.Cells[13].Value.ToString();
                txtEmail.Text = row.Cells[14].Value.ToString();
                txtGhiChu.Text = row.Cells[15].Value.ToString();
                cboxDanToc.Text = row.Cells[16].Value.ToString();
                cboxTonGiao.Text = row.Cells[17].Value.ToString();
                cboxQuocTich.Text = row.Cells[18].Value.ToString();
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnExport.Enabled = true;
                button1.Enabled = true;
            }
            catch (Exception) { }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {

        }

        private void btnSapXepNV_Click(object sender, EventArgs e)
        {
            Form sx = new frmSapXep();
            sx.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnExport.Enabled = false;
            button1.Enabled = false;
            Load_data();
            txtMaNV.Enabled = true;
            txtMaLuong.Enabled = true;
            txtMaBHXH.Enabled = true;
            txtMaThue.Enabled = true;
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            dateNgaySinh.Text = "1/1/1990";
            radNam.Checked = true;
            txtCMND.Text = "";
            txtTDHV.Text = "";
            txtMaLuong.Text = "";
            txtMaBHXH.Text = ""; ;
            txtEmail.Text = "";
            txtHoTen.Text = "";
            txtNoiSinh.Text = "";
            txtDiaChi.Text = "";
            txtMaThue.Text = "";
            cboxMaDV.Text = "";
            cboxChuyenMon.Text = "";
            cboxDanToc.Text = "";
            cboxTonGiao.Text = "";
            cboxQuocTich.Text = "";
            txtSDT.Text = "";
            txtGhiChu.Text = "";
            txtMaNV.Focus();
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            exprotExcel(dataNhanVien, @"D:\", "ThongTinNhanVien");
            DialogResult dialog = MessageBox.Show("Xuất thành công. Bạn có muốn mở file Exel?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                System.Diagnostics.Process.Start(@"D:\");
            else if (dialog == DialogResult.No)
            {
                //
            }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            txtMaLuong.Text = "L" + txtMaNV.Text;
            txtMaBHXH.Text = "BH" + txtMaNV.Text;
            txtMaThue.Text = "T" + txtMaNV.Text;
        }
    }
}
