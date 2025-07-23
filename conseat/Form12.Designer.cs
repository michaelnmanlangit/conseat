namespace conseat
{
    partial class frmThanks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanks));
            this.picHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkBuy = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.Transparent;
            this.picHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
            this.picHome.Location = new System.Drawing.Point(371, 13);
            this.picHome.Margin = new System.Windows.Forms.Padding(4);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(38, 36);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 1;
            this.picHome.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-1, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thank You!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkBuy
            // 
            this.lnkBuy.AutoSize = true;
            this.lnkBuy.Location = new System.Drawing.Point(159, 513);
            this.lnkBuy.Name = "lnkBuy";
            this.lnkBuy.Size = new System.Drawing.Size(112, 16);
            this.lnkBuy.TabIndex = 3;
            this.lnkBuy.TabStop = true;
            this.lnkBuy.Text = "Buy more tickets?";
            this.lnkBuy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBuy_LinkClicked_1);
            // 
            // frmThanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(422, 642);
            this.Controls.Add(this.lnkBuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThanks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form12";
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkBuy;
    }
}