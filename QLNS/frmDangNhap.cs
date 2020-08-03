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


    public partial class frmDangNhap : Form
    {

        
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Height = 435;
            txtID.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
            else if (dialog == DialogResult.No)
            {
                //
            }
            

        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc mật khẩu!", "Thông báo");
                return;
            }
            DataTable dt = KiemTraKetNoi.getDatatable("Select * from tblUser where ID = '" + txtID.Text + "' and Password = '" + txtPass.Text + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Xin chào "+txtID.Text+"! Bạn đã đăng nhập thành công!", "Thông báo");
                this.Hide();
                Form main = new frmMain(txtID.Text,txtPass.Text);
                main.Show();
            }
                
            else
            {
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo");
                txtID.Clear();
                txtPass.Clear();
                txtID.Focus();
            }
                
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*
            this.Hide();
            Form DK = new frmDangKy();
            DK.Show();
             */
            this.Height = 751;

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoanDK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }
            if (txtMatKhauDK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            else
                if (txtMatKhauDK.Text != txtReMatKhauDK.Text)
                    MessageBox.Show("Hai mật khẩu không khớp!");
                else
                {
                    string Adduser = @"INSERT INTO tblUser(ID,Password,PhanQuyen) VALUES('" + txtTaiKhoanDK.Text + "','" + txtMatKhauDK.Text + "','3')";
                    Conn.executeQuery(Adduser);
                    MessageBox.Show("Bạn đã đăng kí thành công!");
                    this.Height = 435;

                }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Height = 435;
            txtID.Focus();
        }
    }
    }

