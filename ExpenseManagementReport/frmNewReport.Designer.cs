namespace ExpenseManagementReport
{
    partial class frmNewReport
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
            this.lbl_ExpensesTitle = new System.Windows.Forms.Label();
            this.lbl_ExpenseName = new System.Windows.Forms.Label();
            this.txt_ExpenseName = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_TotalSpent = new System.Windows.Forms.TextBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_ReceiptRefNo = new System.Windows.Forms.Label();
            this.txt_ReceiptRefNo = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Send = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ExpensesTitle
            // 
            this.lbl_ExpensesTitle.AutoSize = true;
            this.lbl_ExpensesTitle.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExpensesTitle.Location = new System.Drawing.Point(202, 9);
            this.lbl_ExpensesTitle.Name = "lbl_ExpensesTitle";
            this.lbl_ExpensesTitle.Size = new System.Drawing.Size(206, 36);
            this.lbl_ExpensesTitle.TabIndex = 0;
            this.lbl_ExpensesTitle.Text = "ADD EXPENSE";
            // 
            // lbl_ExpenseName
            // 
            this.lbl_ExpenseName.AutoSize = true;
            this.lbl_ExpenseName.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExpenseName.Location = new System.Drawing.Point(50, 45);
            this.lbl_ExpenseName.Name = "lbl_ExpenseName";
            this.lbl_ExpenseName.Size = new System.Drawing.Size(153, 26);
            this.lbl_ExpenseName.TabIndex = 0;
            this.lbl_ExpenseName.Text = "Expense Name";
            // 
            // txt_ExpenseName
            // 
            this.txt_ExpenseName.Font = new System.Drawing.Font("Georgia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExpenseName.Location = new System.Drawing.Point(46, 74);
            this.txt_ExpenseName.Name = "txt_ExpenseName";
            this.txt_ExpenseName.Size = new System.Drawing.Size(490, 26);
            this.txt_ExpenseName.TabIndex = 1;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(50, 113);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(61, 26);
            this.lbl_Total.TabIndex = 0;
            this.lbl_Total.Text = "Total";
            // 
            // txt_TotalSpent
            // 
            this.txt_TotalSpent.Font = new System.Drawing.Font("Georgia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalSpent.Location = new System.Drawing.Point(46, 142);
            this.txt_TotalSpent.Name = "txt_TotalSpent";
            this.txt_TotalSpent.Size = new System.Drawing.Size(490, 26);
            this.txt_TotalSpent.TabIndex = 1;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(50, 187);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(99, 26);
            this.lbl_Category.TabIndex = 0;
            this.lbl_Category.Text = "Category";
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
            this.cb_Category.Location = new System.Drawing.Point(46, 216);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(490, 26);
            this.cb_Category.TabIndex = 2;
            // 
            // lbl_ReceiptRefNo
            // 
            this.lbl_ReceiptRefNo.AutoSize = true;
            this.lbl_ReceiptRefNo.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReceiptRefNo.Location = new System.Drawing.Point(50, 260);
            this.lbl_ReceiptRefNo.Name = "lbl_ReceiptRefNo";
            this.lbl_ReceiptRefNo.Size = new System.Drawing.Size(212, 26);
            this.lbl_ReceiptRefNo.TabIndex = 0;
            this.lbl_ReceiptRefNo.Text = "Receipt Ref. Number";
            // 
            // txt_ReceiptRefNo
            // 
            this.txt_ReceiptRefNo.Font = new System.Drawing.Font("Georgia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReceiptRefNo.Location = new System.Drawing.Point(46, 289);
            this.txt_ReceiptRefNo.Name = "txt_ReceiptRefNo";
            this.txt_ReceiptRefNo.Size = new System.Drawing.Size(490, 26);
            this.txt_ReceiptRefNo.TabIndex = 1;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(50, 352);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(135, 26);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "Receipt Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 396);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(693, 396);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(108, 42);
            this.btn_Send.TabIndex = 4;
            this.btn_Send.Text = "Apply";
            this.btn_Send.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F);
            this.button1.Location = new System.Drawing.Point(295, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Attach File";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.txt_ReceiptRefNo);
            this.Controls.Add(this.txt_TotalSpent);
            this.Controls.Add(this.txt_ExpenseName);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.lbl_ReceiptRefNo);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_ExpenseName);
            this.Controls.Add(this.lbl_ExpensesTitle);
            this.Name = "NewReport";
            this.Text = "NewReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ExpensesTitle;
        private System.Windows.Forms.Label lbl_ExpenseName;
        private System.Windows.Forms.TextBox txt_ExpenseName;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txt_TotalSpent;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.Label lbl_ReceiptRefNo;
        private System.Windows.Forms.TextBox txt_ReceiptRefNo;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button button1;
    }
}