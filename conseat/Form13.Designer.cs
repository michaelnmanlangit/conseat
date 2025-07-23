namespace conseat
{
    partial class frmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.btnManageSales = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.flpConcerts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlNav.SuspendLayout();
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
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.picLogo.Click += new System.EventHandler(this.piclogo_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Transparent;
            this.pnlNav.Controls.Add(this.btnCreateEvent);
            this.pnlNav.Controls.Add(this.btnManageSales);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 66);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(445, 41);
            this.pnlNav.TabIndex = 2;
            this.pnlNav.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNav_Paint);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateEvent.Location = new System.Drawing.Point(208, 5);
            this.btnCreateEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(108, 28);
            this.btnCreateEvent.TabIndex = 3;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // btnManageSales
            // 
            this.btnManageSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageSales.Location = new System.Drawing.Point(324, 5);
            this.btnManageSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageSales.Name = "btnManageSales";
            this.btnManageSales.Size = new System.Drawing.Size(117, 28);
            this.btnManageSales.TabIndex = 2;
            this.btnManageSales.Text = "Manage Sales";
            this.btnManageSales.UseVisualStyleBackColor = true;
            this.btnManageSales.Click += new System.EventHandler(this.btnManageSales_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 6);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(97, 16);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Concert Events";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearch.Location = new System.Drawing.Point(229, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(136, 22);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbSort
            // 
            this.cmbSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(388, 4);
            this.cmbSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(52, 24);
            this.cmbSort.TabIndex = 9;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // flpConcerts
            // 
            this.flpConcerts.AutoScroll = true;
            this.flpConcerts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpConcerts.Location = new System.Drawing.Point(0, 44);
            this.flpConcerts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpConcerts.Name = "flpConcerts";
            this.flpConcerts.Size = new System.Drawing.Size(445, 490);
            this.flpConcerts.TabIndex = 10;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainContent.Controls.Add(this.flpConcerts);
            this.pnlMainContent.Controls.Add(this.cmbSort);
            this.pnlMainContent.Controls.Add(this.txtSearch);
            this.pnlMainContent.Controls.Add(this.lblTitle);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 107);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(445, 534);
            this.pnlMainContent.TabIndex = 3;
            this.pnlMainContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainContent_Paint);
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 641);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form13";
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlNav.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Button btnManageSales;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.FlowLayoutPanel flpConcerts;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.PictureBox picLogout;
    }
}