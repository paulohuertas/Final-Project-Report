using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using Model;
using BAL;

namespace DAL
{
    public class AddData : DbConnection
    {
        ExpenseReport expenseReport = new ExpenseReport();

        public int AddNEwExpense(ExpenseReport expense)
        {
            SqlCommand cmd = new SqlCommand("spAddNewReport", OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ActionType", "Save");
            cmd.Parameters.AddWithValue("@ExpName", expense.ExpName);
            cmd.Parameters.AddWithValue("@ExpTotal", expense.ExpTotal);
            cmd.Parameters.AddWithValue("@ExpCategory", expense.ExpCategory);
            cmd.Parameters.AddWithValue("@ReceiptNo", expense.ReceiptNo);
            cmd.Parameters.AddWithValue("@ReceiptDate", expense.receiptDate);
            cmd.Parameters.AddWithValue("@Image", expense.Image);
            cmd.Parameters.AddWithValue("@FK_UserId", getUserId());

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

        public int getUserId()
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT UserId FROM tb_User WHERE Username = '" + SessionManagement.Username + "' AND Password = '" + SessionManagement.Password + "'";
            SessionManagement.UserId = (int) ExeScalar(cmd);
            return SessionManagement.UserId;
        }
    }

    
}

