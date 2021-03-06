﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        AddData add = new AddData();
        DeleteData delete = new DeleteData();
        EditData edit = new EditData();
        frmMainMenu frmMain = new frmMainMenu();

        double total = 0f;
        int receiptRefNo = 0;

        public frmGeneral()
        {
            InitializeComponent();
            dg_ExpenseData.Refresh();
            dg_ExpenseData.DataSource = fetchData.FetchAllExpensesRecords(expense);
            dg_ExpenseData.Columns[2].DefaultCellStyle.Format = "C2";

        }

        private void btn_AttachFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Choose image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void frmGeneral_Load(object sender, EventArgs e)
        {
            dg_ExpenseData.DataSource = fetchData.FetchAllExpensesRecords(expense);
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (validationAddField() == false)
            {
            }
            else
            {
                ImageConverter image = new ImageConverter();
                byte[] img = (byte[])image.ConvertTo(pictureBox1.Image, Type.GetType("System.Byte[]"));

                expense.ExpName = txt_ExpenseName.Text;
                expense.ExpTotal = Math.Round(total, 2);
                expense.ExpCategory = cb_Category.Text;
                expense.ReceiptNo = receiptRefNo;
                expense.receiptDate = dateTimePicker1.Value;
                expense.Image = img;

                int numRes = add.AddNEwExpense(expense);
                if (numRes > 0)
                {
                    MessageBox.Show("Record added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dg_ExpenseData.Update();
                    dg_ExpenseData.Refresh();
                    clearFields();
                    dg_ExpenseData.DataSource = fetchData.FetchAllExpensesRecords(expense);
                    dg_ExpenseData.Columns[2].DefaultCellStyle.Format = "C2";
                }
            }
        }

        private bool validationAddField()
        {
            bool isValid = false;

            double.TryParse(txt_TotalSpent.Text, out total);
            int.TryParse(txt_ReceiptRefNo.Text, out receiptRefNo);

            if (txt_ExpenseName.Text == string.Empty)
            {
                MessageBox.Show("Please, receipt needs to have a name", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ExpenseName.Focus();
                return isValid;
            }
            else if (total <= 0 || (!double.TryParse(txt_TotalSpent.Text, out total)))
            {
                MessageBox.Show("Please, review receipt total", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TotalSpent.Focus();
                return isValid;

            }
            else if (cb_Category.Text == string.Empty)
            {
                MessageBox.Show("Please, review receipt category", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_Category.Focus();
                return isValid;
            }
            else if (receiptRefNo < 0 || !int.TryParse(txt_ReceiptRefNo.Text, out receiptRefNo))
            {
                MessageBox.Show("Please, review receipt reference number", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ReceiptRefNo.Focus();
                return isValid;
            }
            else if (dateTimePicker1.Value.ToString() == string.Empty || dateTimePicker1.Value > DateTime.Now)
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
            txt_SearchDelete.Text = "";
            txt_ExpenseName.Text = "";
            txt_TotalSpent.Text = "";
            cb_Category.Text = "";
            txt_ReceiptRefNo.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            pictureBox1.Image = pictureBox1.ErrorImage;
            txt_ReceiptRefNo.Enabled = true;

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int receiptNo;
            if (int.TryParse(txt_SearchDelete.Text, out receiptNo))
            {
                try
                {
                    int numRes = delete.DeleteExpense(receiptNo);
                    if (numRes > 0)
                    {
                        MessageBox.Show("Receipt deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Refresh();
                        dg_ExpenseData.Update();
                        dg_ExpenseData.Refresh();
                        clearFields();
                        dg_ExpenseData.DataSource = fetchData.FetchAllExpensesRecords(expense);
                        dg_ExpenseData.Columns[2].DefaultCellStyle.Format = "C2";
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid receipt number", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Error..." + ex.Message);
                }
            }
        }

        private void txt_SearchDelete_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dataView = new DataView(fetchData.FetchAllExpensesRecords(expense));
                dataView.RowFilter = "Convert(ReceiptNo, 'System.String') LIKE '%" + txt_SearchDelete.Text + "%'";
                dg_ExpenseData.DataSource = dataView;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error...", ex.Message);
            }
            
        }

        private void dg_ExpenseData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = dg_ExpenseData.Rows[index];
                    txt_ExpenseName.Text = selectedRow.Cells[1].Value.ToString();
                    txt_TotalSpent.Text = selectedRow.Cells[2].Value.ToString();
                    cb_Category.Text = selectedRow.Cells[3].Value.ToString();
                    txt_ReceiptRefNo.Text = selectedRow.Cells[4].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells[5].Value.ToString());
                    

                    txt_ReceiptRefNo.Enabled = false;

                    txt_SearchDelete.Text = txt_ReceiptRefNo.Text;

                    dg_ExpenseData.Columns[2].DefaultCellStyle.Format = "C2";
                }
                catch (Exception ex)
                {

                    MessageBox.Show("A cell within the grid should be selected", ex.Message);
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (validationAddField() == false)
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

                int numRes = edit.EditExpense(expense);
                if (numRes > 0)
                {
                    MessageBox.Show("Record updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();

                    dg_ExpenseData.Update();
                    dg_ExpenseData.Refresh();
                    dg_ExpenseData.DataSource = fetchData.FetchAllExpensesRecords(expense);
                    dg_ExpenseData.Columns[2].DefaultCellStyle.Format = "C2";

                    txt_ReceiptRefNo.Enabled = true;

                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
            clearFields();
            dg_ExpenseData.Update();
            dg_ExpenseData.Refresh();
            dg_ExpenseData.DataSource = fetchData.FetchAllExpensesRecords(expense);
            dg_ExpenseData.Columns[2].DefaultCellStyle.Format = "C2";
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            frmMainMenu menu = new frmMainMenu();
            this.Hide();
            menu.Show();
        }

        private void btn_generateReport_Click(object sender, EventArgs e)
        {
            dg_ExpenseData.DataSource = fetchData.FetchAllExpensesRecords(expense);
            if (dg_ExpenseData.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.CSV)| *.csv";
                sfd.FileName = "newFile.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {

                            fileError = true;
                            MessageBox.Show("Unable to process your request", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dg_ExpenseData.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dg_ExpenseData.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dg_ExpenseData.Columns[i].HeaderText.ToString() + ", ";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dg_ExpenseData.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dg_ExpenseData.Rows[i - 1].Cells[j].Value.ToString() + ", ";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data exported successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error..." + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No record to export!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void txt_TotalSpent_TextChanged(object sender, EventArgs e)
        {
        }
    }
}