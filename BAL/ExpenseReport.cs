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
    public class ExpenseReport
    {
        public int ReportId { get; set; }
        public string ExpName { get; set; }
        public float ExpTotal { get; set; }
        public string ExpCategory { get; set; }
        public int ReceiptNo { get; set; }
        public DateTime receiptDate { get; set; }
        public byte[] Image { get; set; }

        public ExpenseReport() { }
    }
}
