namespace conseat
{
    partial class frmCustomHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomHome));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlSearchSort = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.flpConcerts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlSearchSort.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.picLogout);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(445, 66);
            this.pnlHeader.TabIndex = 2;
            // 
            // picLogout
            // 
            this.picLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogout.Image = global::conseat.Properties.Resources.sign_out_svgrepo_com__1_;
            this.picLogout.Location = new System.Drawing.Point(388, 9);
            this.picLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(53, 49);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 0;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::conseat.Properties.Resources._517238827_717085247981486_3205119874936882807_n;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Location = new System.Drawing.Point(0, 4);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(83, 62);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // pnlSearchSort
            // 
            this.pnlSearchSort.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearchSort.Controls.Add(this.txtSearch);
            this.pnlSearchSort.Controls.Add(this.cmbSort);
            this.pnlSearchSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchSort.Location = new System.Drawing.Point(0, 66);
            this.pnlSearchSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSearchSort.Name = "pnlSearchSort";
            this.pnlSearchSort.Size = new System.Drawing.Size(445, 53);
            this.pnlSearchSort.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearch.Location = new System.Drawing.Point(231, 9);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(136, 22);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbSort
            // 
            this.cmbSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(376, 7);
            this.cmbSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(52, 24);
            this.cmbSort.TabIndex = 11;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainContent.Controls.Add(this.flpConcerts);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 119);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(445, 522);
            this.pnlMainContent.TabIndex = 4;
            // 
            // flpConcerts
            // 
            this.flpConcerts.AutoScroll = true;
            this.flpConcerts.BackColor = System.Drawing.Color.Transparent;
            this.flpConcerts.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpConcerts.Location = new System.Drawing.Point(0, 0);
            this.flpConcerts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpConcerts.Name = "flpConcerts";
            this.flpConcerts.Size = new System.Drawing.Size(445, 522);
            this.flpConcerts.TabIndex = 0;
            this.flpConcerts.Paint += new System.Windows.Forms.PaintEventHandler(this.flpConcerts_Paint);
            // 
            // frmCustomHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 641);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlSearchSort);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCustomHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlSearchSort.ResumeLayout(false);
            this.pnlSearchSort.PerformLayout();
            this.pnlMainContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlSearchSort;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.FlowLayoutPanel flpConcerts;
    }
}