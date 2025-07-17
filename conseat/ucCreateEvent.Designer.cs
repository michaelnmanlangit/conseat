using System;

namespace conseat
{
    partial class ucCreateEvent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCreateEvent));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.cmbVenue = new System.Windows.Forms.ComboBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPriceVIP = new System.Windows.Forms.TextBox();
            this.txtPriceUpperBox = new System.Windows.Forms.TextBox();
            this.txtPriceGenAd = new System.Windows.Forms.TextBox();
            this.pbArtistImage = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtistImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(98, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Create New Concert Event";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Artist Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Venue:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = " Price per Section:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = " VIP:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = " Upper Box:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Gen Ad:";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(144, 175);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(100, 20);
            this.txtEventName.TabIndex = 10;
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(144, 207);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(100, 20);
            this.txtArtistName.TabIndex = 11;
            // 
            // cmbVenue
            // 
            this.cmbVenue.FormattingEnabled = true;
            this.cmbVenue.Location = new System.Drawing.Point(144, 233);
            this.cmbVenue.Name = "cmbVenue";
            this.cmbVenue.Size = new System.Drawing.Size(100, 21);
            this.cmbVenue.TabIndex = 12;
            this.cmbVenue.SelectedIndexChanged += new System.EventHandler(this.cmbVenue_SelectedIndexChanged);
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "hh:mm tt";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(144, 280);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(100, 20);
            this.dtpTime.TabIndex = 13;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(144, 257);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(100, 20);
            this.dtpDate.TabIndex = 14;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(169, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear Button";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(77, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save Button";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPriceVIP
            // 
            this.txtPriceVIP.Location = new System.Drawing.Point(144, 334);
            this.txtPriceVIP.Name = "txtPriceVIP";
            this.txtPriceVIP.Size = new System.Drawing.Size(100, 20);
            this.txtPriceVIP.TabIndex = 17;
            // 
            // txtPriceUpperBox
            // 
            this.txtPriceUpperBox.Location = new System.Drawing.Point(144, 356);
            this.txtPriceUpperBox.Name = "txtPriceUpperBox";
            this.txtPriceUpperBox.Size = new System.Drawing.Size(100, 20);
            this.txtPriceUpperBox.TabIndex = 18;
            // 
            // txtPriceGenAd
            // 
            this.txtPriceGenAd.Location = new System.Drawing.Point(144, 379);
            this.txtPriceGenAd.Name = "txtPriceGenAd";
            this.txtPriceGenAd.Size = new System.Drawing.Size(100, 20);
            this.txtPriceGenAd.TabIndex = 19;
            // 
            // pbArtistImage
            // 
            this.pbArtistImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbArtistImage.Location = new System.Drawing.Point(101, 50);
            this.pbArtistImage.Name = "pbArtistImage";
            this.pbArtistImage.Size = new System.Drawing.Size(122, 70);
            this.pbArtistImage.TabIndex = 20;
            this.pbArtistImage.TabStop = false;
            this.pbArtistImage.Click += new System.EventHandler(this.pbArtistImage_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(121, 126);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(75, 23);
            this.btnUploadImage.TabIndex = 21;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // ucCreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.pbArtistImage);
            this.Controls.Add(this.txtPriceGenAd);
            this.Controls.Add(this.txtPriceUpperBox);
            this.Controls.Add(this.txtPriceVIP);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.cmbVenue);
            this.Controls.Add(this.txtArtistName);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Name = "ucCreateEvent";
            this.Size = new System.Drawing.Size(334, 521);
            this.Load += new System.EventHandler(this.ucCreateEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArtistImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.ComboBox cmbVenue;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPriceVIP;
        private System.Windows.Forms.TextBox txtPriceUpperBox;
        private System.Windows.Forms.TextBox txtPriceGenAd;
        private System.Windows.Forms.PictureBox pbArtistImage;
        private System.Windows.Forms.Button btnUploadImage;

    }
}
