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
            this.btnProceedPayment = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBlockSeatNo = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProceedPayment
            // 
            this.btnProceedPayment.BackColor = System.Drawing.Color.LimeGreen;
            this.btnProceedPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceedPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceedPayment.ForeColor = System.Drawing.Color.Black;
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
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
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
            this.lblBlockSeatNo.BackColor = System.Drawing.Color.Transparent;
            this.lblBlockSeatNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockSeatNo.ForeColor = System.Drawing.Color.White;
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
            this.lblVenue.BackColor = System.Drawing.Color.Transparent;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.ForeColor = System.Drawing.Color.White;
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
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
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
            this.lblArtistName.BackColor = System.Drawing.Color.Transparent;
            this.lblArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistName.ForeColor = System.Drawing.Color.White;
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
            this.picImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "CHECK OUT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 521);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProceedPayment;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblBlockSeatNo;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}