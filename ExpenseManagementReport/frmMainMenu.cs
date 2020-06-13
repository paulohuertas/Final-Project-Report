using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagementReport
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void tsb_AddExpense_ButtonClick(object sender, EventArgs e)
        {
            frmGeneral general = new frmGeneral();
            general.Show();
            Hide();
        }

        private void tsb_DeleteExpense_Click(object sender, EventArgs e)
        {
            frmGeneral general = new frmGeneral();
            general.Show();
            Hide();
        }

        private void tsb_EditExpense_Click(object sender, EventArgs e)
        {
            frmGeneral general = new frmGeneral();
            general.Show();
            Hide();
        }
    }
}
