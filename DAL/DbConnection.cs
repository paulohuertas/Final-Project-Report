    using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DbConnection
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);

        //Opens the SQL Connection if it is closed;
        public SqlConnection OpenConnection()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        //Return the number of rows affected in the Transac-SQL statement;
        public int ExecNonQuery(SqlCommand sqlCmd)
        {
            sqlCmd.Connection = OpenConnection();
            int rowsAffected = -1;
            rowsAffected = sqlCmd.ExecuteNonQuery();
            sqlCmd.Connection = CloseConnection();
            return rowsAffected;
        }

        //Close the SQL connection if it is opened;
        public SqlConnection CloseConnection()
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            return conn;
        }

        //Return the first column of the first row in the result set;
        public object ExeScalar(SqlCommand sqlCmd)
        {
            sqlCmd.Connection = OpenConnection();
            object obj = -1;
            obj = sqlCmd.ExecuteScalar();
            sqlCmd.Connection = CloseConnection();
            return obj;
        }

        //Return the dataset of the query to  a datatable;
        public DataTable ExeReader(SqlCommand sqlCmd)
        {
            sqlCmd.Connection = OpenConnection();
            SqlDataReader sqlDataReader;
            DataTable dt = new DataTable();
            sqlDataReader = sqlCmd.ExecuteReader();
            dt.Load(sqlDataReader);
            sqlCmd.Connection = CloseConnection();
            return dt;
        }
    }
}
