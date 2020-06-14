using BAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL : DbConnection
    {
        public bool AuthenticateUser()
        {
            //string username passado como parametro do AuthenticateUser
            //string password passado como parametro do AuthenticateUser
            bool isValid = false;
            SqlDataReader sdr;

            try
            {
                SqlCommand cmd = new SqlCommand("spAuthUserLogin", OpenConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", SessionManagement.Username);
                cmd.Parameters.AddWithValue("@Password", SessionManagement.Password);
                
                sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    isValid = true;
                    CloseConnection();
                }
                else
                {
                    isValid = false;
                    CloseConnection();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error..." + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return isValid;
        }
    }
}
