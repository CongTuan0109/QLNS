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
using System.IO;

namespace QLNS
{
    public partial class frmMain : Form
    {
        string username,password;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain( string user,string pass)
        {
            InitializeComponent();
            username=user;
            password = pass;
        }

        // BackUp
        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool bBackUpStatus = true;

            Cursor.Current = Cursors.WaitCursor;

            if (Directory.Exists(@"c:\SQLBackup"))
            {
                if (File.Exists(@"c:\SQLBackup\QLNS.bak"))
                {
                    if (MessageBox.Show(@"Bạn có muốn thay thế nó?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Delete(@"c:\SQLBackup\QLNS.bak");
                    }
                    else
                        bBackUpStatus = false;
                }
            }
            else
                Directory.CreateDirectory(@"c:\SQLBackup");

            if (bBackUpStatus)
            {
                //Connect to DB
                SqlConnection connect;
                string con = @"Data Source=DESKTOP-KA710V7\SQLEXPRESS;Initial Catalog=QuanLiNhanSu;Integrated Security=True";
                connect = new SqlConnection(con);
                connect.Open();
                //----------------------------------------------------------------------------------------------------

                //Execute SQL---------------
                SqlCommand command;
                command = new SqlCommand(@"backup database QuanLiNhanSu to disk ='c:\SQLBackup\QLNS.bak' with init,stats=10", connect);
                command.ExecuteNonQuery();
                //-------------------------------------------------------------------------------------------------------------------------------

                connect.Close();

                MessageBox.Show("Backup dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //MessageBox.Show(username,password);
            //đổiMậtKhẩuToolStripMenuItem.Enabled = false;                      
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                Form login = new frmDangNhap();
                login.ShowDialog();
            }
            else if (dialog == DialogResult.No)
            {
                //
            }

        }
        private void ptboxNhanvien_Click(object sender, EventArgs e)
        {
            Form Luong = new frmTTNhanVien();
            Luong.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form DMK = new frmDoiMatKhau(username,password);
            DMK.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form Luong = new frmLuongNV();
            Luong.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form BHXH = new frmBHXH();
            BHXH.ShowDialog();
        }

        private void ptboxTimkiem_Click(object sender, EventArgs e)
        {
            Form TimKiem = new frmTimKiem();
            TimKiem.ShowDialog();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (File.Exists(@"c:\SQLBackup\QLNS.bak"))
                {
                    if (MessageBox.Show("Bạn có muốn khôi phục?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Connect SQL-----------
                        SqlConnection connect;
                        string con = @"Data Source=DESKTOP-KA710V7\SQLEXPRESS;Initial Catalog=QuanLiNhanSu;Integrated Security=True";
                        connect = new SqlConnection(con);
                        connect.Open();
                        //-----------------------------------------------------------------------------------------

                        //Excute SQL----------------
                        SqlCommand command;
                        command = new SqlCommand("use master", connect);
                        command.ExecuteNonQuery();
                        command = new SqlCommand(@"restore database QuanLyNhanSu from disk = 'c:\SQLBackup\QLNS.bak'", connect);
                        command.ExecuteNonQuery();
                        //--------------------------------------------------------------------------------------------------------
                        connect.Close();

                        MessageBox.Show("Khôi phục dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show(@"Không thực hiện bất kỳ sự chứng thực ở trên (hoặc không có trong đường dẫn chính xác )", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void NguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NguoiDung = new frmNguoiDung(username,password);
            NguoiDung.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NV = new frmTTNhanVien(username);
            NV.ShowDialog();
        }

        private void chiLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Luong = new frmLuongNV();
            Luong.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bảiHiểmXHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form BHXH = new frmBHXH();
            BHXH.ShowDialog();
        }

        private void đơnVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form QuanLy = new frmSapXep();
            QuanLy.ShowDialog();
        }

        private void chuyênMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form QuanLy = new frmSapXep();
            QuanLy.ShowDialog();
        }

        private void ptboxQuanli_Click(object sender, EventArgs e)
        {
            Form QuanLy = new frmSapXep();
            QuanLy.ShowDialog();
        }

        private void giớiThiệuPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form GioiThieu = new frmGioiThieu();
            GioiThieu.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form Thue = new frmThueTNCN();
            Thue.ShowDialog();
        }

        private void trìnhĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form QuanLy = new frmSapXep();
            QuanLy.ShowDialog();
        }

        private void ptboxThietlap_Click_1(object sender, EventArgs e)
        {
            Form ThietLap = new frmThietLap();
            ThietLap.ShowDialog();
        }

        private void thuếTNCNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Thue = new frmThueTNCN();
            Thue.ShowDialog();
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Luong = new frmLuongNV();
            Luong.ShowDialog();
        }

        private void ptboxThongke_Click(object sender, EventArgs e)
        {
            Form BC = new frmBaoCao();
            BC.ShowDialog();
        }

        private void thuếTNCNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form TT = new frmBaoCaoTTNV();
            TT.ShowDialog();
        }

        private void thuếThuNhậpCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Form Luong = new frmBaoCaoLuong();
             Luong.ShowDialog();
        }
    }
}
