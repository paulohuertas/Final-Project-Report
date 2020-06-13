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
    public partial class frmLoadingCover : Form
    {
        public frmLoadingCover()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(prgbar_loading.Value < 100)
            {
                prgbar_loading.Value = prgbar_loading.Value + 2;
            }
            else
            {
                timer_loading.Enabled = false;
                frm_Login login = new frm_Login();
                login.Show();
                this.Visible = false;
            }
        }
    }
}
