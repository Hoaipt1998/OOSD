using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien1.DB_layer
{
    class DBMain
    {
        string ConnStr = "Data Source=(Local);Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DBMain() 
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public SqlConnection GetConnection
        {
            get
            {
                return conn;
            }
        }
        public void openconection()
        {
            if ((conn.State == System.Data.ConnectionState.Closed))
            {
                conn.Open();
            }
        }
        public void closeconnection()
        {
            if ((conn.State == System.Data.ConnectionState.Open))
            {
                conn.Close();
            }
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open) 
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds; 
        }

        public  DataTable ExecuteQueryDataTable(String sql, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = sql;
            comm.CommandType = ct;
            da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds.Tables[0];
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        { 
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct; 
            try { 
                comm.ExecuteNonQuery();
                f = true;
            } 
            catch (SqlException ex)
            {
                error = ex.Message;
            } 
            finally 
            { 
                conn.Close();
            } 
            return f; 
        }
        public DataTable ExecuteQuery(string sql)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            DataTable table = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(table);
            conn.Close();
            return table;
        }
    }
}
