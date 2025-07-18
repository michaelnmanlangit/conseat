namespace conseat
{
    partial class ucCustomerConcertCard
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
            this.lblArtistName = new System.Windows.Forms.Label();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.picArtist = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picArtist)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArtistName
            // 
            this.lblArtistName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblArtistName.Location = new System.Drawing.Point(3, 103);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(148, 24);
            this.lblArtistName.TabIndex = 1;
            this.lblArtistName.Text = "lblArtistName";
            this.lblArtistName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblArtistName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBuyTicket.Location = new System.Drawing.Point(0, 130);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(151, 35);
            this.btnBuyTicket.TabIndex = 2;
            this.btnBuyTicket.Text = "Buy Ticket";
            this.btnBuyTicket.UseVisualStyleBackColor = true;
            this.btnBuyTicket.Click += new System.EventHandler(this.button1_Click);
            // 
            // picArtist
            // 
            this.picArtist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picArtist.Dock = System.Windows.Forms.DockStyle.Top;
            this.picArtist.Location = new System.Drawing.Point(0, 0);
            this.picArtist.Name = "picArtist";
            this.picArtist.Size = new System.Drawing.Size(151, 100);
            this.picArtist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArtist.TabIndex = 0;
            this.picArtist.TabStop = false;
            // 
            // ucCustomerConcertCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.lblArtistName);
            this.Controls.Add(this.picArtist);
            this.Name = "ucCustomerConcertCard";
            this.Size = new System.Drawing.Size(151, 165);
            ((System.ComponentModel.ISupportInitialize)(this.picArtist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picArtist;
        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.Button btnBuyTicket;
    }
}
