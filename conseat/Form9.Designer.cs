namespace conseat
{
    partial class frmSelectGenAd
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
            if (disposing)
            {
                // Unsubscribe from events to prevent memory leaks
                frmSendPayment.SeatReserved -= OnSeatReserved;
                
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectGenAd));
            this.btnReserve = new System.Windows.Forms.Button();
            this.picC5 = new System.Windows.Forms.PictureBox();
            this.picC4 = new System.Windows.Forms.PictureBox();
            this.picC3 = new System.Windows.Forms.PictureBox();
            this.picC2 = new System.Windows.Forms.PictureBox();
            this.picC1 = new System.Windows.Forms.PictureBox();
            this.panelSeats = new System.Windows.Forms.Panel();
            this.picB3 = new System.Windows.Forms.PictureBox();
            this.picA1 = new System.Windows.Forms.PictureBox();
            this.picA2 = new System.Windows.Forms.PictureBox();
            this.picA3 = new System.Windows.Forms.PictureBox();
            this.picA4 = new System.Windows.Forms.PictureBox();
            this.picA5 = new System.Windows.Forms.PictureBox();
            this.picB1 = new System.Windows.Forms.PictureBox();
            this.picB2 = new System.Windows.Forms.PictureBox();
            this.picB5 = new System.Windows.Forms.PictureBox();
            this.picB4 = new System.Windows.Forms.PictureBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.picD5 = new System.Windows.Forms.PictureBox();
            this.picD4 = new System.Windows.Forms.PictureBox();
            this.picD3 = new System.Windows.Forms.PictureBox();
            this.picD2 = new System.Windows.Forms.PictureBox();
            this.picD1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picC5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC1)).BeginInit();
            this.panelSeats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picA3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picA4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picA5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(144, 456);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(75, 23);
            this.btnReserve.TabIndex = 41;
            this.btnReserve.Text = "button1";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // picC5
            // 
            this.picC5.BackColor = System.Drawing.Color.LightGray;
            this.picC5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picC5.Image = ((System.Drawing.Image)(resources.GetObject("picC5.Image")));
            this.picC5.Location = new System.Drawing.Point(192, 124);
            this.picC5.Margin = new System.Windows.Forms.Padding(2);
            this.picC5.Name = "picC5";
            this.picC5.Size = new System.Drawing.Size(31, 32);
            this.picC5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picC5.TabIndex = 31;
            this.picC5.TabStop = false;
            // 
            // picC4
            // 
            this.picC4.BackColor = System.Drawing.Color.LightGray;
            this.picC4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picC4.Image = ((System.Drawing.Image)(resources.GetObject("picC4.Image")));
            this.picC4.Location = new System.Drawing.Point(149, 124);
            this.picC4.Margin = new System.Windows.Forms.Padding(2);
            this.picC4.Name = "picC4";
            this.picC4.Size = new System.Drawing.Size(31, 32);
            this.picC4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picC4.TabIndex = 30;
            this.picC4.TabStop = false;
            // 
            // picC3
            // 
            this.picC3.BackColor = System.Drawing.Color.LightGray;
            this.picC3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picC3.Image = ((System.Drawing.Image)(resources.GetObject("picC3.Image")));
            this.picC3.Location = new System.Drawing.Point(104, 124);
            this.picC3.Margin = new System.Windows.Forms.Padding(2);
            this.picC3.Name = "picC3";
            this.picC3.Size = new System.Drawing.Size(31, 32);
            this.picC3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picC3.TabIndex = 29;
            this.picC3.TabStop = false;
            // 
            // picC2
            // 
            this.picC2.BackColor = System.Drawing.Color.LightGray;
            this.picC2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picC2.Image = ((System.Drawing.Image)(resources.GetObject("picC2.Image")));
            this.picC2.Location = new System.Drawing.Point(61, 124);
            this.picC2.Margin = new System.Windows.Forms.Padding(2);
            this.picC2.Name = "picC2";
            this.picC2.Size = new System.Drawing.Size(31, 32);
            this.picC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picC2.TabIndex = 28;
            this.picC2.TabStop = false;
            // 
            // picC1
            // 
            this.picC1.BackColor = System.Drawing.Color.LightGray;
            this.picC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picC1.Image = ((System.Drawing.Image)(resources.GetObject("picC1.Image")));
            this.picC1.Location = new System.Drawing.Point(18, 124);
            this.picC1.Margin = new System.Windows.Forms.Padding(2);
            this.picC1.Name = "picC1";
            this.picC1.Size = new System.Drawing.Size(31, 32);
            this.picC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picC1.TabIndex = 27;
            this.picC1.TabStop = false;
            // 
            // panelSeats
            // 
            this.panelSeats.Controls.Add(this.picD5);
            this.panelSeats.Controls.Add(this.picD4);
            this.panelSeats.Controls.Add(this.picD3);
            this.panelSeats.Controls.Add(this.picD2);
            this.panelSeats.Controls.Add(this.picD1);
            this.panelSeats.Controls.Add(this.picB3);
            this.panelSeats.Controls.Add(this.picA1);
            this.panelSeats.Controls.Add(this.picA2);
            this.panelSeats.Controls.Add(this.picC5);
            this.panelSeats.Controls.Add(this.picA3);
            this.panelSeats.Controls.Add(this.picC4);
            this.panelSeats.Controls.Add(this.picA4);
            this.panelSeats.Controls.Add(this.picC3);
            this.panelSeats.Controls.Add(this.picA5);
            this.panelSeats.Controls.Add(this.picC2);
            this.panelSeats.Controls.Add(this.picB1);
            this.panelSeats.Controls.Add(this.picC1);
            this.panelSeats.Controls.Add(this.picB2);
            this.panelSeats.Controls.Add(this.picB5);
            this.panelSeats.Controls.Add(this.picB4);
            this.panelSeats.Location = new System.Drawing.Point(40, 212);
            this.panelSeats.Name = "panelSeats";
            this.panelSeats.Size = new System.Drawing.Size(247, 217);
            this.panelSeats.TabIndex = 39;
            this.panelSeats.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSeats_Paint);
            // 
            // picB3
            // 
            this.picB3.BackColor = System.Drawing.Color.LightGray;
            this.picB3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picB3.Image = ((System.Drawing.Image)(resources.GetObject("picB3.Image")));
            this.picB3.Location = new System.Drawing.Point(104, 73);
            this.picB3.Margin = new System.Windows.Forms.Padding(2);
            this.picB3.Name = "picB3";
            this.picB3.Size = new System.Drawing.Size(31, 32);
            this.picB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB3.TabIndex = 24;
            this.picB3.TabStop = false;
            // 
            // picA1
            // 
            this.picA1.BackColor = System.Drawing.Color.LightGray;
            this.picA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picA1.Image = ((System.Drawing.Image)(resources.GetObject("picA1.Image")));
            this.picA1.Location = new System.Drawing.Point(18, 25);
            this.picA1.Margin = new System.Windows.Forms.Padding(2);
            this.picA1.Name = "picA1";
            this.picA1.Size = new System.Drawing.Size(31, 32);
            this.picA1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picA1.TabIndex = 17;
            this.picA1.TabStop = false;
            // 
            // picA2
            // 
            this.picA2.BackColor = System.Drawing.Color.LightGray;
            this.picA2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picA2.Image = ((System.Drawing.Image)(resources.GetObject("picA2.Image")));
            this.picA2.Location = new System.Drawing.Point(61, 25);
            this.picA2.Margin = new System.Windows.Forms.Padding(2);
            this.picA2.Name = "picA2";
            this.picA2.Size = new System.Drawing.Size(31, 32);
            this.picA2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picA2.TabIndex = 18;
            this.picA2.TabStop = false;
            // 
            // picA3
            // 
            this.picA3.BackColor = System.Drawing.Color.LightGray;
            this.picA3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picA3.Image = ((System.Drawing.Image)(resources.GetObject("picA3.Image")));
            this.picA3.Location = new System.Drawing.Point(104, 25);
            this.picA3.Margin = new System.Windows.Forms.Padding(2);
            this.picA3.Name = "picA3";
            this.picA3.Size = new System.Drawing.Size(31, 32);
            this.picA3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picA3.TabIndex = 19;
            this.picA3.TabStop = false;
            // 
            // picA4
            // 
            this.picA4.BackColor = System.Drawing.Color.LightGray;
            this.picA4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picA4.Image = ((System.Drawing.Image)(resources.GetObject("picA4.Image")));
            this.picA4.Location = new System.Drawing.Point(149, 25);
            this.picA4.Margin = new System.Windows.Forms.Padding(2);
            this.picA4.Name = "picA4";
            this.picA4.Size = new System.Drawing.Size(31, 32);
            this.picA4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picA4.TabIndex = 20;
            this.picA4.TabStop = false;
            // 
            // picA5
            // 
            this.picA5.BackColor = System.Drawing.Color.LightGray;
            this.picA5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picA5.Image = ((System.Drawing.Image)(resources.GetObject("picA5.Image")));
            this.picA5.Location = new System.Drawing.Point(192, 25);
            this.picA5.Margin = new System.Windows.Forms.Padding(2);
            this.picA5.Name = "picA5";
            this.picA5.Size = new System.Drawing.Size(31, 32);
            this.picA5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picA5.TabIndex = 21;
            this.picA5.TabStop = false;
            // 
            // picB1
            // 
            this.picB1.BackColor = System.Drawing.Color.LightGray;
            this.picB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picB1.Image = ((System.Drawing.Image)(resources.GetObject("picB1.Image")));
            this.picB1.Location = new System.Drawing.Point(18, 73);
            this.picB1.Margin = new System.Windows.Forms.Padding(2);
            this.picB1.Name = "picB1";
            this.picB1.Size = new System.Drawing.Size(31, 32);
            this.picB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB1.TabIndex = 22;
            this.picB1.TabStop = false;
            // 
            // picB2
            // 
            this.picB2.BackColor = System.Drawing.Color.LightGray;
            this.picB2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picB2.Image = ((System.Drawing.Image)(resources.GetObject("picB2.Image")));
            this.picB2.Location = new System.Drawing.Point(61, 73);
            this.picB2.Margin = new System.Windows.Forms.Padding(2);
            this.picB2.Name = "picB2";
            this.picB2.Size = new System.Drawing.Size(31, 32);
            this.picB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB2.TabIndex = 23;
            this.picB2.TabStop = false;
            // 
            // picB5
            // 
            this.picB5.BackColor = System.Drawing.Color.LightGray;
            this.picB5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picB5.Image = ((System.Drawing.Image)(resources.GetObject("picB5.Image")));
            this.picB5.Location = new System.Drawing.Point(192, 73);
            this.picB5.Margin = new System.Windows.Forms.Padding(2);
            this.picB5.Name = "picB5";
            this.picB5.Size = new System.Drawing.Size(31, 32);
            this.picB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB5.TabIndex = 26;
            this.picB5.TabStop = false;
            // 
            // picB4
            // 
            this.picB4.BackColor = System.Drawing.Color.LightGray;
            this.picB4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picB4.Image = ((System.Drawing.Image)(resources.GetObject("picB4.Image")));
            this.picB4.Location = new System.Drawing.Point(149, 73);
            this.picB4.Margin = new System.Windows.Forms.Padding(2);
            this.picB4.Name = "picB4";
            this.picB4.Size = new System.Drawing.Size(31, 32);
            this.picB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB4.TabIndex = 25;
            this.picB4.TabStop = false;
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.Transparent;
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.Location = new System.Drawing.Point(5, 41);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(35, 35);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 38;
            this.picImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "GEN AD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelected.BackColor = System.Drawing.Color.Transparent;
            this.lblSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.ForeColor = System.Drawing.Color.White;
            this.lblSelected.Location = new System.Drawing.Point(36, 446);
            this.lblSelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(126, 20);
            this.lblSelected.TabIndex = 37;
            this.lblSelected.Click += new System.EventHandler(this.lblSelected_Click);
            // 
            // picD5
            // 
            this.picD5.BackColor = System.Drawing.Color.LightGray;
            this.picD5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picD5.Image = ((System.Drawing.Image)(resources.GetObject("picD5.Image")));
            this.picD5.Location = new System.Drawing.Point(192, 168);
            this.picD5.Margin = new System.Windows.Forms.Padding(2);
            this.picD5.Name = "picD5";
            this.picD5.Size = new System.Drawing.Size(31, 32);
            this.picD5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picD5.TabIndex = 36;
            this.picD5.TabStop = false;
            // 
            // picD4
            // 
            this.picD4.BackColor = System.Drawing.Color.LightGray;
            this.picD4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picD4.Image = ((System.Drawing.Image)(resources.GetObject("picD4.Image")));
            this.picD4.Location = new System.Drawing.Point(149, 168);
            this.picD4.Margin = new System.Windows.Forms.Padding(2);
            this.picD4.Name = "picD4";
            this.picD4.Size = new System.Drawing.Size(31, 32);
            this.picD4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picD4.TabIndex = 35;
            this.picD4.TabStop = false;
            // 
            // picD3
            // 
            this.picD3.BackColor = System.Drawing.Color.LightGray;
            this.picD3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picD3.Image = ((System.Drawing.Image)(resources.GetObject("picD3.Image")));
            this.picD3.Location = new System.Drawing.Point(104, 168);
            this.picD3.Margin = new System.Windows.Forms.Padding(2);
            this.picD3.Name = "picD3";
            this.picD3.Size = new System.Drawing.Size(31, 32);
            this.picD3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picD3.TabIndex = 34;
            this.picD3.TabStop = false;
            // 
            // picD2
            // 
            this.picD2.BackColor = System.Drawing.Color.LightGray;
            this.picD2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picD2.Image = ((System.Drawing.Image)(resources.GetObject("picD2.Image")));
            this.picD2.Location = new System.Drawing.Point(61, 168);
            this.picD2.Margin = new System.Windows.Forms.Padding(2);
            this.picD2.Name = "picD2";
            this.picD2.Size = new System.Drawing.Size(31, 32);
            this.picD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picD2.TabIndex = 33;
            this.picD2.TabStop = false;
            // 
            // picD1
            // 
            this.picD1.BackColor = System.Drawing.Color.LightGray;
            this.picD1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picD1.Image = ((System.Drawing.Image)(resources.GetObject("picD1.Image")));
            this.picD1.Location = new System.Drawing.Point(18, 168);
            this.picD1.Margin = new System.Windows.Forms.Padding(2);
            this.picD1.Name = "picD1";
            this.picD1.Size = new System.Drawing.Size(31, 32);
            this.picD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picD1.TabIndex = 32;
            this.picD1.TabStop = false;
            // 
            // frmSelectGenAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 521);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.panelSeats);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelected);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSelectGenAd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.frmSelectGenAd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picC5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC1)).EndInit();
            this.panelSeats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picA3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picA4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picA5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.PictureBox picC5;
        private System.Windows.Forms.PictureBox picC4;
        private System.Windows.Forms.PictureBox picC3;
        private System.Windows.Forms.PictureBox picC2;
        private System.Windows.Forms.PictureBox picC1;
        private System.Windows.Forms.Panel panelSeats;
        private System.Windows.Forms.PictureBox picD5;
        private System.Windows.Forms.PictureBox picD4;
        private System.Windows.Forms.PictureBox picD3;
        private System.Windows.Forms.PictureBox picD2;
        private System.Windows.Forms.PictureBox picD1;
        private System.Windows.Forms.PictureBox picB3;
        private System.Windows.Forms.PictureBox picA1;
        private System.Windows.Forms.PictureBox picA2;
        private System.Windows.Forms.PictureBox picA3;
        private System.Windows.Forms.PictureBox picA4;
        private System.Windows.Forms.PictureBox picA5;
        private System.Windows.Forms.PictureBox picB1;
        private System.Windows.Forms.PictureBox picB2;
        private System.Windows.Forms.PictureBox picB5;
        private System.Windows.Forms.PictureBox picB4;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelected;
    }
}