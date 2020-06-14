using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;

namespace ExpenseManagementReport
{
    public partial class frmGeneral : Form
    {
        DataGridDAL fetchData = new DataGridDAL();
        ExpenseReport expense = new ExpenseReport();
        SqlDataAdapter dataAdapter;
        AddData add = new AddData();
         

        float total = 0;
        int receiptRefNo = 0;

        public frmGeneral()
        {
            InitializeComponent();
            dg_ExpenseData.Refresh();
            dg_ExpenseData.DataSource = fetchData.FetchAllExpensesRecords(expense);
            
        }

        private void btn_AttachFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Choose image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void frmGeneral_Load(object sender, EventArgs e)
        {
            /*DataTable dt = new DataTable();
            dt = fetchData.FetchAllExpensesRecords(expense);
            dg_ExpenseData.DataSource = dt;*/

            dg_ExpenseData.DataSource = fetchData.FetchAllExpensesRecords(expense);
            
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if(validationAddField() == false)
            {
            }
            else
            {
                ImageConverter image = new ImageConverter();
                byte[] img = (byte[])image.ConvertTo(pictureBox1.Image, Type.GetType("System.Byte[]"));

                expense.ExpName = txt_ExpenseName.Text;
                expense.ExpTotal = total;
                expense.ExpCategory = cb_Category.Text;
                expense.ReceiptNo = receiptRefNo;
                expense.receiptDate = dateTimePicker1.Value;
                expense.Image = img;

                int numRes = add.AddNEwExpense(expense);
                if (numRes > 0)
                {
                    MessageBox.Show("Record added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    
                    dg_ExpenseData.Update();
                    dg_ExpenseData.Refresh();
                    dg_ExpenseData.DataSource = fetchData.FetchAllExpensesRecords(expense);

                }
            }
        }

        private bool validationAddField()
        {
            bool isValid = false;

            float.TryParse(txt_TotalSpent.Text, out total);
            int.TryParse(txt_ReceiptRefNo.Text, out receiptRefNo);

            if(txt_ExpenseName.Text == string.Empty)
            {
                MessageBox.Show("Please, receipt needs to have a name", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ExpenseName.Focus();
                return isValid;
            }
            else if(total <= 0)
            {
                MessageBox.Show("Please, review receipt total", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TotalSpent.Focus();
                return isValid;

            }
            else if(cb_Category.Text == string.Empty)
            {
                MessageBox.Show("Please, review receipt category", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_Category.Focus();
                return isValid;
            }
            else if(receiptRefNo < 0)
            {
                MessageBox.Show("Please, review receipt reference number", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ReceiptRefNo.Focus();
                return isValid;
            }
            else if(dateTimePicker1.Value.ToString() == string.Empty || dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Please, review receipt date", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker1.Focus();
                return isValid;
            }
            else
            {
                isValid = true;
            }
            return isValid;
        }

        private void clearFields()
        {
            txt_ExpenseName.Text = "";
            txt_TotalSpent.Text = "";
            cb_Category.Text = "";
            txt_ReceiptRefNo.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            pictureBox1.Image = pictureBox1.ErrorImage;

        }
    }
}
