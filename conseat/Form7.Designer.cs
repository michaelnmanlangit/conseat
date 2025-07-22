namespace conseat
{
    partial class frmCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckOut));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnProceedPayment = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBlockSeatNo = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(17, 6);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 19);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnProceedPayment
            // 
            this.btnProceedPayment.BackColor = System.Drawing.SystemColors.Control;
            this.btnProceedPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceedPayment.Location = new System.Drawing.Point(65, 478);
            this.btnProceedPayment.Name = "btnProceedPayment";
            this.btnProceedPayment.Size = new System.Drawing.Size(195, 37);
            this.btnProceedPayment.TabIndex = 17;
            this.btnProceedPayment.Text = "PROCEED TO PAYMENT";
            this.btnProceedPayment.UseVisualStyleBackColor = false;
            this.btnProceedPayment.Click += new System.EventHandler(this.btnProceedPayment_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(0, 440);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(333, 17);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblBlockSeatNo
            // 
            this.lblBlockSeatNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockSeatNo.Location = new System.Drawing.Point(0, 414);
            this.lblBlockSeatNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBlockSeatNo.Name = "lblBlockSeatNo";
            this.lblBlockSeatNo.Size = new System.Drawing.Size(333, 17);
            this.lblBlockSeatNo.TabIndex = 15;
            this.lblBlockSeatNo.Text = "Block and Seat No.";
            this.lblBlockSeatNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBlockSeatNo.Click += new System.EventHandler(this.lblBlockSeatNo_Click);
            // 
            // lblVenue
            // 
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(0, 391);
            this.lblVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(333, 17);
            this.lblVenue.TabIndex = 14;
            this.lblVenue.Text = "Venue";
            this.lblVenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVenue.Click += new System.EventHandler(this.lblVenue_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(3, 367);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(330, 17);
            this.lblDateTime.TabIndex = 13;
            this.lblDateTime.Text = "Date and Time";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDateTime.Click += new System.EventHandler(this.lblDateTime_Click);
            // 
            // lblArtistName
            // 
            this.lblArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistName.Location = new System.Drawing.Point(-3, 344);
            this.lblArtistName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(336, 17);
            this.lblArtistName.TabIndex = 12;
            this.lblArtistName.Text = "Artist Name";
            this.lblArtistName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblArtistName.Click += new System.EventHandler(this.lblArtistName_Click);
            // 
            // picImage
            // 
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.Location = new System.Drawing.Point(65, 120);
            this.picImage.Margin = new System.Windows.Forms.Padding(2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(195, 209);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 11;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.picImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "CHECK OUT";
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 521);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnProceedPayment);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblBlockSeatNo);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblArtistName);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnProceedPayment;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblBlockSeatNo;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label label1;
    }
}