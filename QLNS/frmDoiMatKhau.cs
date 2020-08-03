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

    public partial class frmDoiMatKhau : Form
    {
        string username,password;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        public frmDoiMatKhau(string user,string pass)
        {
            InitializeComponent();
            username = user;
            password = pass;
        }
        
        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //MessageBox.Show(password);
            txtTaiKhoan.Text = username;
           // label5.Text = myTable.Rows[indexer]["password"].ToString();


        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.Hide();
            else if (dialog == DialogResult.No)
            {
                //
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string update = "update tblUser set Password='" + txtMatKhauMoi.Text + "' where(ID=N'" + txtTaiKhoan.Text + "' and Password='" + txtMatKhauCu.Text + "')";
            string ten = txtTaiKhoan.Text;
            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên truy cập");
            }
            else
            {
                if (txtMatKhauCu.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
                else
                {
                    if (txtMatKhauMoi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                    }
                    else
                    {
                        if (txtXacNhanMatKhau.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                        }
                        else
                        {
                            if ((txtMatKhauMoi.Text == txtXacNhanMatKhau.Text)&&txtMatKhauCu.Text==password)
                            {
                                DataTable dt = KiemTraKetNoi.getDatatable(update);
                                MessageBox.Show("Bạn đã thay đổi mật khẩu thành công");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Bạn nhập lại mật khẩu không đúng");
                            }
                        }
                    }
                }
            }
        }
                }
            }

