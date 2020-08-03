using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
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

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            else
                if (txtPass.Text != txtRePass.Text)
                    MessageBox.Show("Hai mật khẩu không khớp!");
                else
                {
                    string Adduser = @"INSERT INTO tblUser(ID,Password,PhanQuyen) VALUES('" + txtID.Text + "','" + txtPass.Text + "','3')";
                    Conn.executeQuery(Adduser);
                    MessageBox.Show("Bạn đã đăng kí thành công!");
                    this.Hide();
                    Form DN = new frmDangNhap();
                    DN.Show();
                    
                }



        }
    }
}
