using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeleteData : DbConnection
    {
        public int DeleteExpense(int receiptNo)
        {
            DataGridDAL dataGridDAL = new DataGridDAL();

            SqlCommand cmd = new SqlCommand("spDeleteExpense", OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ActionType", "Delete");
            cmd.Parameters.AddWithValue("@ReceiptNo", receiptNo);
            cmd.Parameters.AddWithValue("@FK_UserId", dataGridDAL.getUserId());
            try
            {
                OpenConnection();
                int rowRes = ExecNonQuery(cmd);
                return rowRes;
            }
            catch (Exception ex)
            {

                throw new Exception("Error..." + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
