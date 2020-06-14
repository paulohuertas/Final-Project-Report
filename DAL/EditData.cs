using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class EditData : DbConnection
    {
        public int EditExpense(ExpenseReport expense)
        {
            DataGridDAL dataGridDAL = new DataGridDAL();

            SqlCommand cmd = new SqlCommand("spEditExpense", OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ActionType", "Edit");
            cmd.Parameters.AddWithValue("@ExpName", expense.ExpName);
            cmd.Parameters.AddWithValue("@ExpTotal", expense.ExpTotal);
            cmd.Parameters.AddWithValue("@ExpCategory", expense.ExpCategory);
            cmd.Parameters.AddWithValue("@ReceiptNo", expense.ReceiptNo);
            cmd.Parameters.AddWithValue("@ReceiptDate", expense.receiptDate);
            cmd.Parameters.AddWithValue("@Image", expense.Image);
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
