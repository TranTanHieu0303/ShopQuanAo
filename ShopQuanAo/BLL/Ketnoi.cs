using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopQuanAo
{
    class Ketnoi
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;

        public SqlConnection OpenDB()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-N1FFA5P\SQLEXPRESS;Initial Catalog=QL_SHOPQUANAO;Integrated Security=True");
            return con;
        }
        public static void OpenConnection()
        {
            string sql = @"Data Source=DESKTOP-N1FFA5P\SQLEXPRESS;Initial Catalog=QL_SHOPQUANAO;Integrated Security=True";
            try
            {
                con = new SqlConnection(sql);
                con.Open();
            }catch(SqlException ex){

            }
        }
        public static void DisConnection()
        {
            con.Close();
            con.Dispose();
            con = null;
        }
        public static DataTable getData(string sql)
        {
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable tb = new DataTable();
            da.Fill(tb);
            da.Dispose();
            cmd.Dispose();
            return tb;
        }
        public static void Excute(string sql)
        {
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }

    }
}
