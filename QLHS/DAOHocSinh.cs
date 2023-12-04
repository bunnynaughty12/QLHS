using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS
{
    class DAOHocSinh
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand comd;

        public DAOHocSinh()
        {
            con = new SqlConnection("Data Source=DESKTOP-I5D1GPP;Initial Catalog=QLHOCSINH;Integrated Security=True;Encrypt=False");
        }
        public DataTable LayDSHocSinh()
        {
            adapter = new SqlDataAdapter("Select * From HOCSINH", con);
            DataTable tbHocsinh = new DataTable();
            adapter.Fill(tbHocsinh);
            return tbHocsinh;
        }
        public DataTable LayDSHocSinh(string sMalop)
        {
            string sqlSelect = "Select * From HOCSINH where MaLop='" + sMalop + "'";
            adapter =   new SqlDataAdapter(sqlSelect, con);
            DataTable tbHocsinh = new DataTable();
            adapter.Fill(tbHocsinh);
            return tbHocsinh;
        }

        public void insert(HocSinhInfo hs)
        {
            con.Open();
            string sqlInsert = "INSERT INTO HOCSINH VALUES('"
                + hs.Mahs + "','" + hs.Hoten + "','" + hs.Gioitinh + "','"
                + hs.Ngaysinh + "','" + hs.Diachi + "'," + hs.Diemtb + ",'"
                + hs.Lophoc.Malop + "')";
            comd = new SqlCommand(sqlInsert, con);
            comd.ExecuteNonQuery();
            con.Close();
        }

        public void delete(string mahs)
        {
            con.Open();
            string sqlDelete = "DELETE FROM HOCSINH WHERE MaHS='" + mahs + "'";
            comd = new SqlCommand(sqlDelete, con);
            comd.ExecuteNonQuery();
            con.Close();
        }

        public void update(string mahs, string tenhs, string lop, string diachi, string sdt)
        {
            con.Open();
            string sqlUpdate = "UPDATE HOCSINH SET TenHS=@tenhs, Lop=@lop, DiaChi=@diachi, SDT=@sdt WHERE MaHS=@mahs";
            comd = new SqlCommand(sqlUpdate, con);

            // Sử dụng SqlParameter để tránh tình trạng SQL Injection
            comd.Parameters.AddWithValue("@mahs", mahs);
            comd.Parameters.AddWithValue("@tenhs", tenhs);
            comd.Parameters.AddWithValue("@lop", lop);
            comd.Parameters.AddWithValue("@diachi", diachi);
            comd.Parameters.AddWithValue("@sdt", sdt);

            comd.ExecuteNonQuery();
            con.Close();
        }

    }
}
