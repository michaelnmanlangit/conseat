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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
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
            // 
            // pnlBackG
            // 
            this.pnlBackG.Controls.Add(this.lblPayment);
            this.pnlBackG.Location = new System.Drawing.Point(89, 22);
            this.pnlBackG.Name = "pnlBackG";
            this.pnlBackG.Size = new System.Drawing.Size(164, 85);
            this.pnlBackG.TabIndex = 28;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(192, 317);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(74, 217);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(169, 20);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(63, 40);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(35, 13);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "label1";
            this.lblPayment.Click += new System.EventHandler(this.label1_Click);
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
            this.pnlBackG.PerformLayout();
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