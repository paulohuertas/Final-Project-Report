namespace ExpenseManagementReport
{
    partial class frmGeneral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneral));
            this.lbl_Search = new System.Windows.Forms.Label();
            this.txt_SearchDelete = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.txt_ReceiptRefNo = new System.Windows.Forms.TextBox();
            this.txt_TotalSpent = new System.Windows.Forms.TextBox();
            this.txt_ExpenseName = new System.Windows.Forms.TextBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_ReceiptRefNo = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_ExpenseName = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.btn_AttachFile = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.expenseManagementReportAppDataSet = new ExpenseManagementReport.ExpenseManagementReportAppDataSet();
            this.expenseManagementReportAppDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dg_ExpenseData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseManagementReportAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseManagementReportAppDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ExpenseData)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.Location = new System.Drawing.Point(30, 14);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(59, 17);
            this.lbl_Search.TabIndex = 1;
            this.lbl_Search.Text = "Search";
            // 
            // txt_SearchDelete
            // 
            this.txt_SearchDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchDelete.Location = new System.Drawing.Point(96, 8);
            this.txt_SearchDelete.Name = "txt_SearchDelete";
            this.txt_SearchDelete.Size = new System.Drawing.Size(283, 26);
            this.txt_SearchDelete.TabIndex = 0;
            this.txt_SearchDelete.TextChanged += new System.EventHandler(this.txt_SearchDelete_TextChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(397, 8);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 25);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refresh.Location = new System.Drawing.Point(490, 8);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 25);
            this.btn_Refresh.TabIndex = 2;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cb_Category
            // 
            this.cb_Category.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Items.AddRange(new object[] {
            "Airfare",
            "Taxi",
            "Bus",
            "Subway",
            "Car Hire",
            "Toll",
            "Parking",
            "Personal Car",
            "Hotel",
            "Communications",
            "Meals",
            "Client Entertainment",
            "Employee Entertainment",
            "System Support",
            "Subscriptions",
            "IT Periphereals",
            "Purchase Stationery",
            "Other expenses"});
            this.cb_Category.Location = new System.Drawing.Point(33, 312);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(301, 26);
            this.cb_Category.TabIndex = 5;
            // 
            // txt_ReceiptRefNo
            // 
            this.txt_ReceiptRefNo.Font = new System.Drawing.Font("Georgia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReceiptRefNo.Location = new System.Drawing.Point(407, 312);
            this.txt_ReceiptRefNo.Name = "txt_ReceiptRefNo";
            this.txt_ReceiptRefNo.Size = new System.Drawing.Size(301, 26);
            this.txt_ReceiptRefNo.TabIndex = 6;
            // 
            // txt_TotalSpent
            // 
            this.txt_TotalSpent.Font = new System.Drawing.Font("Georgia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalSpent.Location = new System.Drawing.Point(407, 250);
            this.txt_TotalSpent.Name = "txt_TotalSpent";
            this.txt_TotalSpent.Size = new System.Drawing.Size(301, 26);
            this.txt_TotalSpent.TabIndex = 4;
            this.txt_TotalSpent.Text = "€";
            // 
            // txt_ExpenseName
            // 
            this.txt_ExpenseName.Font = new System.Drawing.Font("Georgia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExpenseName.Location = new System.Drawing.Point(33, 250);
            this.txt_ExpenseName.Name = "txt_ExpenseName";
            this.txt_ExpenseName.Size = new System.Drawing.Size(301, 26);
            this.txt_ExpenseName.TabIndex = 3;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Category.Location = new System.Drawing.Point(37, 287);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(84, 22);
            this.lbl_Category.TabIndex = 4;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_ReceiptRefNo
            // 
            this.lbl_ReceiptRefNo.AutoSize = true;
            this.lbl_ReceiptRefNo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ReceiptRefNo.Location = new System.Drawing.Point(411, 287);
            this.lbl_ReceiptRefNo.Name = "lbl_ReceiptRefNo";
            this.lbl_ReceiptRefNo.Size = new System.Drawing.Size(178, 22);
            this.lbl_ReceiptRefNo.TabIndex = 5;
            this.lbl_ReceiptRefNo.Text = "Receipt Ref. Number";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Total.Location = new System.Drawing.Point(411, 221);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(52, 22);
            this.lbl_Total.TabIndex = 6;
            this.lbl_Total.Text = "Total";
            // 
            // lbl_ExpenseName
            // 
            this.lbl_ExpenseName.AutoSize = true;
            this.lbl_ExpenseName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ExpenseName.Location = new System.Drawing.Point(37, 221);
            this.lbl_ExpenseName.Name = "lbl_ExpenseName";
            this.lbl_ExpenseName.Size = new System.Drawing.Size(128, 22);
            this.lbl_ExpenseName.TabIndex = 7;
            this.lbl_ExpenseName.Text = "Expense Name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 375);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(301, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Date.Location = new System.Drawing.Point(37, 350);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(113, 22);
            this.lbl_Date.TabIndex = 12;
            this.lbl_Date.Text = "Receipt Date";
            // 
            // btn_AttachFile
            // 
            this.btn_AttachFile.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_AttachFile.Image = ((System.Drawing.Image)(resources.GetObject("btn_AttachFile.Image")));
            this.btn_AttachFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AttachFile.Location = new System.Drawing.Point(407, 583);
            this.btn_AttachFile.Name = "btn_AttachFile";
            this.btn_AttachFile.Size = new System.Drawing.Size(301, 35);
            this.btn_AttachFile.TabIndex = 8;
            this.btn_AttachFile.Text = "Attach File";
            this.btn_AttachFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AttachFile.UseVisualStyleBackColor = true;
            this.btn_AttachFile.Click += new System.EventHandler(this.btn_AttachFile_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Image = ((System.Drawing.Image)(resources.GetObject("btn_Send.Image")));
            this.btn_Send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Send.Location = new System.Drawing.Point(33, 573);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(306, 42);
            this.btn_Send.TabIndex = 9;
            this.btn_Send.Text = "Apply";
            this.btn_Send.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.Image")));
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.Location = new System.Drawing.Point(33, 505);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(306, 42);
            this.btn_Edit.TabIndex = 10;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(33, 429);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(306, 42);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(407, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // expenseManagementReportAppDataSet
            // 
            this.expenseManagementReportAppDataSet.DataSetName = "ExpenseManagementReportAppDataSet";
            this.expenseManagementReportAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenseManagementReportAppDataSetBindingSource
            // 
            this.expenseManagementReportAppDataSetBindingSource.DataSource = this.expenseManagementReportAppDataSet;
            this.expenseManagementReportAppDataSetBindingSource.Position = 0;
            // 
            // dg_ExpenseData
            // 
            this.dg_ExpenseData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dg_ExpenseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ExpenseData.Location = new System.Drawing.Point(33, 40);
            this.dg_ExpenseData.Name = "dg_ExpenseData";
            this.dg_ExpenseData.ReadOnly = true;
            this.dg_ExpenseData.Size = new System.Drawing.Size(675, 176);
            this.dg_ExpenseData.TabIndex = 17;
            this.dg_ExpenseData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_ExpenseData_CellClick);
            // 
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 627);
            this.Controls.Add(this.dg_ExpenseData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_AttachFile);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.txt_ReceiptRefNo);
            this.Controls.Add(this.txt_TotalSpent);
            this.Controls.Add(this.txt_ExpenseName);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.lbl_ReceiptRefNo);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_ExpenseName);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_SearchDelete);
            this.Controls.Add(this.lbl_Search);
            this.Name = "frmGeneral";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORT";
            this.Load += new System.EventHandler(this.frmGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseManagementReportAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseManagementReportAppDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ExpenseData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox txt_SearchDelete;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.TextBox txt_ReceiptRefNo;
        private System.Windows.Forms.TextBox txt_TotalSpent;
        private System.Windows.Forms.TextBox txt_ExpenseName;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_ReceiptRefNo;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_ExpenseName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Button btn_AttachFile;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource expenseManagementReportAppDataSetBindingSource;
        private ExpenseManagementReportAppDataSet expenseManagementReportAppDataSet;
        private System.Windows.Forms.DataGridView dg_ExpenseData;
    }
}