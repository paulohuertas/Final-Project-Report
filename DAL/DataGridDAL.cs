using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;
using Model;

namespace DAL
{
    public class DataGridDAL : DbConnection
    {
        public DataTable FetchAllExpensesRecords(ExpenseReport expense)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ReportId, ExpName, ExpTotal, ExpCategory, ReceiptNo, ReceiptDate, Username FROM tb_Report LEFT JOIN tb_User ON UserId = ReportId WHERE Username = '" + SessionManagement.Username + "' AND Password = '" + SessionManagement.Password + "'";
            return ExeReader(cmd);
        }
    }
}