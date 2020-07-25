namespace ExpenseManagementReport
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_DeleteExpense = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_EditExpense = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_EmailExpense = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_GenerateReport = new System.Windows.Forms.ToolStripButton();
            this.tsb_AddExpense = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_AddExpense,
            this.toolStripSeparator1,
            this.tsb_DeleteExpense,
            this.toolStripSeparator2,
            this.tsb_EditExpense,
            this.toolStripSeparator3,
            this.tsb_EmailExpense,
            this.toolStripSeparator4,
            this.tsb_GenerateReport,
            this.toolStripSeparator5,
            this.tsb_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(617, 100);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 100);
            // 
            // tsb_DeleteExpense
            // 
            this.tsb_DeleteExpense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_DeleteExpense.Image = ((System.Drawing.Image)(resources.GetObject("tsb_DeleteExpense.Image")));
            this.tsb_DeleteExpense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_DeleteExpense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_DeleteExpense.Name = "tsb_DeleteExpense";
            this.tsb_DeleteExpense.Size = new System.Drawing.Size(84, 97);
            this.tsb_DeleteExpense.Text = "Delete Expense";
            this.tsb_DeleteExpense.Click += new System.EventHandler(this.tsb_DeleteExpense_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 100);
            // 
            // tsb_EditExpense
            // 
            this.tsb_EditExpense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_EditExpense.Image = ((System.Drawing.Image)(resources.GetObject("tsb_EditExpense.Image")));
            this.tsb_EditExpense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_EditExpense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_EditExpense.Name = "tsb_EditExpense";
            this.tsb_EditExpense.Size = new System.Drawing.Size(84, 97);
            this.tsb_EditExpense.Text = "Edit An Expense";
            this.tsb_EditExpense.Click += new System.EventHandler(this.tsb_EditExpense_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 100);
            // 
            // tsb_EmailExpense
            // 
            this.tsb_EmailExpense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_EmailExpense.Image = ((System.Drawing.Image)(resources.GetObject("tsb_EmailExpense.Image")));
            this.tsb_EmailExpense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_EmailExpense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_EmailExpense.Name = "tsb_EmailExpense";
            this.tsb_EmailExpense.Size = new System.Drawing.Size(84, 97);
            this.tsb_EmailExpense.Text = "Email Expense";
            this.tsb_EmailExpense.Click += new System.EventHandler(this.tsb_EmailExpense_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 100);
            // 
            // tsb_GenerateReport
            // 
            this.tsb_GenerateReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_GenerateReport.Image = ((System.Drawing.Image)(resources.GetObject("tsb_GenerateReport.Image")));
            this.tsb_GenerateReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_GenerateReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_GenerateReport.Name = "tsb_GenerateReport";
            this.tsb_GenerateReport.Size = new System.Drawing.Size(84, 97);
            this.tsb_GenerateReport.Text = "Generate Report";
            this.tsb_GenerateReport.Click += new System.EventHandler(this.tsb_GenerateReport_Click);
            // 
            // tsb_AddExpense
            // 
            this.tsb_AddExpense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_AddExpense.Image = ((System.Drawing.Image)(resources.GetObject("tsb_AddExpense.Image")));
            this.tsb_AddExpense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_AddExpense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AddExpense.Name = "tsb_AddExpense";
            this.tsb_AddExpense.Size = new System.Drawing.Size(84, 97);
            this.tsb_AddExpense.Text = "Add New Expense";
            this.tsb_AddExpense.Click += new System.EventHandler(this.tsb_AddExpense_ButtonClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 100);
            // 
            // tsb_Exit
            // 
            this.tsb_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Exit.Image")));
            this.tsb_Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Exit.Name = "tsb_Exit";
            this.tsb_Exit.Size = new System.Drawing.Size(84, 97);
            this.tsb_Exit.Text = "Exit";
            this.tsb_Exit.Click += new System.EventHandler(this.tsb_Exit_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 212);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_DeleteExpense;
        private System.Windows.Forms.ToolStripButton tsb_EditExpense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_EmailExpense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsb_GenerateReport;
        private System.Windows.Forms.ToolStripButton tsb_AddExpense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsb_Exit;
    }
}