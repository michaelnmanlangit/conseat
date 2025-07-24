namespace conseat
{
    partial class frmSendPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendPayment));
            this.picBack = new System.Windows.Forms.PictureBox();
            this.pnlBackG = new System.Windows.Forms.Panel();
            this.lblPayment = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.pnlBackG.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBack
            // 
            this.picBack.BackColor = System.Drawing.Color.Transparent;
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(1, 0);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(35, 35);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBack.TabIndex = 27;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click_1);
            // 
            // pnlBackG
            // 
            this.pnlBackG.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackG.Controls.Add(this.lblPayment);
            this.pnlBackG.Location = new System.Drawing.Point(67, 63);
            this.pnlBackG.Name = "pnlBackG";
            this.pnlBackG.Size = new System.Drawing.Size(209, 85);
            this.pnlBackG.TabIndex = 28;
            this.pnlBackG.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBackG_Paint);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoEllipsis = true;
            this.lblPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPayment.Location = new System.Drawing.Point(0, 32);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(209, 26);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "label1";
            this.lblPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPayment.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(201, 296);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(67, 241);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(209, 22);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmSendPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 521);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.pnlBackG);
            this.Controls.Add(this.picBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSendPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSendPayment";
            this.Load += new System.EventHandler(this.frmGcash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.pnlBackG.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.Panel pnlBackG;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblPayment;
    }
}