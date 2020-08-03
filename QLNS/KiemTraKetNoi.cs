using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLNS
{
    static class KiemTraKetNoi
    {
        static SqlConnection conn = new SqlConnection();
        static public void KetNoi()
        {
            string connstring = "Data Source=ADMIN\\SA;Initial Catalog=QuanLiNhanSu;User ID=sa;Password=sa2012";
            conn.ConnectionString = connstring;
            try
            {
                conn.Open();
            }
            catch
            {

            }
        }
        static public DataTable getDatatable(string sql)
        {
            if (conn.State == ConnectionState.Closed)
                KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "QLNS");
            return ds.Tables["QLNS"];
        }
    }
}
