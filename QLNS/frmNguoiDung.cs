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
    public partial class frmNguoiDung : Form
    {
        string username, password;
        public frmNguoiDung()
        {
            InitializeComponent();
        }
        public frmNguoiDung(string user, string pass)
        {
            InitializeComponent();
            username = user;
            password = pass;
        }
        public void Load_data()
        {
            string str = "select * from tblUser";
            System.Data.DataTable dt = KiemTraKetNoi.getDatatable(str);
            dataNguoiDung.DataSource = dt;
        }
        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //MessageBox.Show(username + password);
            string str = "select * from tblUser";
            System.Data.DataTable dt = KiemTraKetNoi.getDatatable(str);
            dataNguoiDung.DataSource = dt;
        }

        private void dataNguoiDung_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtTaiKhoan.Text = dataNguoiDung.SelectedRows[0].Cells[0].Value.ToString();
                txtMatKhau.Text = dataNguoiDung.SelectedRows[0].Cells[1].Value.ToString();
                if (dataNguoiDung.SelectedRows[0].Cells[2].Value.ToString() == "1")
                    cboxPhanQuyen.Text = "Quản Trị";
                if (dataNguoiDung.SelectedRows[0].Cells[2].Value.ToString() == "2")
                    cboxPhanQuyen.Text = "VIP";
                if (dataNguoiDung.SelectedRows[0].Cells[2].Value.ToString() == "3")
                    cboxPhanQuyen.Text = "Thành Viên";
            }
            catch (Exception)
            {

            }
        }

        private void bntDoiMK_Click(object sender, EventArgs e)
        {
            string update = "update tblUser set Password='" + txtMatKhau.Text + "' where(ID=N'" + txtTaiKhoan.Text +"')";
            Conn.executeQuery(update);
            Load_data();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string _PhanQuyen="";
            if (cboxPhanQuyen.Text == "Quản Trị")
                _PhanQuyen = "1";
            if (cboxPhanQuyen.Text == "VIP")
                _PhanQuyen = "2";
            if (cboxPhanQuyen.Text == "Thành Viên")
                _PhanQuyen = "3";
            string update = "update tblUser set PhanQuyen=N'" + _PhanQuyen + "' where(ID=N'" + txtTaiKhoan.Text + "')";
            Conn.executeQuery(update);
            Load_data();


        }
    }
}
