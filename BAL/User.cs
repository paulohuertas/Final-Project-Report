using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public DataTable getUserId(User user)
        {
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            if(sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT UserId FROM tb_User WHERE Username = '" + user.Username + " '" + user.Password + "' ";
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            return dt;
        }


        public static class LoginInformation
        {
            public static string UserId;
        }
    }
}
