using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using Model;
using CsvHelper.Configuration;
using CsvHelper.Expressions;
using DAL;

namespace ExpenseManagementReport
{
    public partial class frmMainMenu : Form
    {
        DataGridDAL fetchData = new DataGridDAL();
        ExpenseReport report = new ExpenseReport();
        ExpenseReport expense = new ExpenseReport();
        frmGeneral frmGeneral;

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

        private void tsb_GenerateReport_Click(object sender, EventArgs e)
        {
            frmGeneral = new frmGeneral();
            frmGeneral.dg_ExpenseData.DataSource = fetchData.FetchAllExpensesRecords(expense);
            if(frmGeneral.dg_ExpenseData.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.CSV)| *.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if(sfd.ShowDialog() == DialogResult.OK)
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
                            int columnCount = frmGeneral.dg_ExpenseData.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[frmGeneral.dg_ExpenseData.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += frmGeneral.dg_ExpenseData.Columns[i].HeaderText.ToString() + ", ";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < frmGeneral.dg_ExpenseData.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += frmGeneral.dg_ExpenseData.Rows[i - 1].Cells[j].Value.ToString() + ", ";
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
                else
                {
                    MessageBox.Show("Cancelled!");
                }
            }
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {}

        private void tsb_EmailExpense_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("OUTLOOK");
        }

        private void tsb_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
