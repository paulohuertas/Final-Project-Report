namespace ExpenseManagementReport
{
    partial class frmLoadingCover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadingCover));
            this.picbox_cover = new System.Windows.Forms.PictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.prgbar_loading = new System.Windows.Forms.ProgressBar();
            this.timer_loading = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cover)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_cover
            // 
            this.picbox_cover.Image = ((System.Drawing.Image)(resources.GetObject("picbox_cover.Image")));
            this.picbox_cover.Location = new System.Drawing.Point(47, 59);
            this.picbox_cover.Name = "picbox_cover";
            this.picbox_cover.Size = new System.Drawing.Size(225, 225);
            this.picbox_cover.TabIndex = 0;
            this.picbox_cover.TabStop = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(297, 24);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "EXPENSES MANAGEMENT REPORT";
            // 
            // prgbar_loading
            // 
            this.prgbar_loading.Location = new System.Drawing.Point(47, 307);
            this.prgbar_loading.Name = "prgbar_loading";
            this.prgbar_loading.Size = new System.Drawing.Size(225, 29);
            this.prgbar_loading.TabIndex = 2;
            // 
            // timer_loading
            // 
            this.timer_loading.Enabled = true;
            this.timer_loading.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoadingCover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 361);
            this.Controls.Add(this.prgbar_loading);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.picbox_cover);
            this.Name = "LoadingCover";
            this.Text = "LoadingCover";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_cover;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ProgressBar prgbar_loading;
        private System.Windows.Forms.Timer timer_loading;
    }
}