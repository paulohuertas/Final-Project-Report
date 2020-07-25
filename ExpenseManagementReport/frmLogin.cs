using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BLL;
using DAL;
using Model;

namespace ExpenseManagementReport
{
    public partial class frm_Login : Form
    {

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            txt_username.Text = username.Trim();
            txt_password.Text = password.Trim();
            try
            {
                if(!username.Equals(" ") && !password.Equals(" "))
                {
                    MessageBox.Show("Fields have been cleared", "Success");
                }
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Would you like to exit the application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            EncryptPassword encrypt = new EncryptPassword();
            SessionManagement.Username = txt_username.Text.Trim();
            SessionManagement.Password = txt_password.Text.Trim();

            LoginDAL loginDAL = new LoginDAL();
            if(loginDAL.AuthenticateUser())
            {
                MessageBox.Show("Successfully logged in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMainMenu mainMenu = new frmMainMenu();
                mainMenu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Fail to login. Please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txt_username.Clear();
            txt_password.Clear();
        }
    }
}
