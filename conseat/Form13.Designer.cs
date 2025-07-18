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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.btnManageSales = new System.Windows.Forms.Button();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.flpConcerts = new System.Windows.Forms.FlowLayoutPanel();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlNav.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(334, 54);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::conseat.Properties.Resources._517238827_717085247981486_3205119874936882807_n;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Location = new System.Drawing.Point(0, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(62, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.piclogo_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(275, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(56, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Transparent;
            this.pnlNav.Controls.Add(this.btnCreateEvent);
            this.pnlNav.Controls.Add(this.btnManageSales);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 54);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(334, 33);
            this.pnlNav.TabIndex = 2;
            this.pnlNav.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNav_Paint);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(156, 4);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(81, 23);
            this.btnCreateEvent.TabIndex = 3;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // btnManageSales
            // 
            this.btnManageSales.Location = new System.Drawing.Point(243, 4);
            this.btnManageSales.Name = "btnManageSales";
            this.btnManageSales.Size = new System.Drawing.Size(88, 23);
            this.btnManageSales.TabIndex = 2;
            this.btnManageSales.Text = "Manage Sales";
            this.btnManageSales.UseVisualStyleBackColor = true;
            this.btnManageSales.Click += new System.EventHandler(this.btnManageSales_Click);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainContent.Controls.Add(this.flpConcerts);
            this.pnlMainContent.Controls.Add(this.cboSort);
            this.pnlMainContent.Controls.Add(this.btnSearch);
            this.pnlMainContent.Controls.Add(this.txtSearch);
            this.pnlMainContent.Controls.Add(this.lblTitle);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 87);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(334, 434);
            this.pnlMainContent.TabIndex = 3;
            this.pnlMainContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainContent_Paint);
            // 
            // flpConcerts
            // 
            this.flpConcerts.AutoScroll = true;
            this.flpConcerts.Location = new System.Drawing.Point(3, 43);
            this.flpConcerts.Name = "flpConcerts";
            this.flpConcerts.Size = new System.Drawing.Size(328, 400);
            this.flpConcerts.TabIndex = 10;
            // 
            // cboSort
            // 
            this.cboSort.FormattingEnabled = true;
            this.cboSort.Location = new System.Drawing.Point(267, 16);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(64, 21);
            this.cboSort.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(215, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "button1";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(115, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(103, 20);
            this.txtSearch.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 13);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Concert Events";
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 521);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form13";
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlNav.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Button btnManageSales;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.ComboBox cboSort;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flpConcerts;
        private System.Windows.Forms.PictureBox picLogo;
    }
}