using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS
{
    class DAOLop
    {
        SqlConnection con;

        public DAOLop()
        {
            con = new SqlConnection("Data Source=DESKTOP-I5D1GPP;Initial Catalog=QLHOCSINH;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }

        public DataTable LayDSLop()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM LOP", con);
            DataTable tbLop = new DataTable();
            adapter.Fill(tbLop);
            return tbLop;
        }


        public void Insert(LopInfo lop)
        {
            con.Open();
            string sqlInsert = "INSERT INTO LOP VALUES('" + lop.Malop + "','" + lop.Tenlop + "')";
            SqlCommand comd = new SqlCommand(sqlInsert, con);
            comd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(string maLop)
        {
            con.Open();
            string sqlDelete = "DELETE FROM LOP WHERE MaLop='" + maLop + "'";
            SqlCommand comd = new SqlCommand(sqlDelete, con);
            comd.ExecuteNonQuery();
            con.Close();
        }

        public void Update(string maLop, string tenLop)
        {
            con.Open();
            string sqlUpdate = "UPDATE LOP SET TenLop=@tenLop WHERE MaLop=@maLop";
            SqlCommand comd = new SqlCommand(sqlUpdate, con);

            comd.Parameters.AddWithValue("@maLop", maLop);
            comd.Parameters.AddWithValue("@tenLop", tenLop);

            comd.ExecuteNonQuery();
            con.Close();
        }
    }

}
