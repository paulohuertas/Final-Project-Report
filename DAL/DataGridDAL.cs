using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using Model;

namespace DAL
{
    public class DataGridDAL : DbConnection
    {
        public object FetchAllExpensesRecords(ExpenseReport expense)
        {
            OpenConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            string sqlSelect = "SELECT ReportId, ExpName, ExpTotal, ExpCategory, ReceiptNo, ReceiptDate, Username FROM tb_Report LEFT JOIN tb_User ON UserId = FK_UserId WHERE Username = '" + SessionManagement.Username + "' AND Password = '" + SessionManagement.Password + "'";
            dataAdapter.SelectCommand = new SqlCommand(sqlSelect, OpenConnection());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            BindingSource bSource = new BindingSource();
            return bSource.DataSource = dataTable;
        }

        public int getUserId()
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT UserId FROM tb_User WHERE Username = '" + SessionManagement.Username + "' AND Password = '" + SessionManagement.Password + "'";
            SessionManagement.UserId = (int)ExeScalar(cmd);
            return SessionManagement.UserId;
        }
    }
}