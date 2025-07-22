namespace conseat
{
    partial class frmPaymentMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentMethod));
            this.rbtnGcash = new System.Windows.Forms.RadioButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnPaymaya = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProceed = new System.Windows.Forms.Button();
            this.rbtnCreditCard = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnGcash
            // 
            this.rbtnGcash.AutoSize = true;
            this.rbtnGcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGcash.Location = new System.Drawing.Point(65, 268);
            this.rbtnGcash.Name = "rbtnGcash";
            this.rbtnGcash.Size = new System.Drawing.Size(77, 24);
            this.rbtnGcash.TabIndex = 18;
            this.rbtnGcash.TabStop = true;
            this.rbtnGcash.Text = "GCash";
            this.rbtnGcash.UseVisualStyleBackColor = true;
            this.rbtnGcash.CheckedChanged += new System.EventHandler(this.rbtnGcash_CheckedChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(165, 172);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 20);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "₱ 2,500";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "TOTAL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Choose your preferred payment method and click \'PROCEED\'";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Payment method";
            // 
            // rbtnPaymaya
            // 
            this.rbtnPaymaya.AutoSize = true;
            this.rbtnPaymaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPaymaya.Location = new System.Drawing.Point(25, 9);
            this.rbtnPaymaya.Name = "rbtnPaymaya";
            this.rbtnPaymaya.Size = new System.Drawing.Size(91, 24);
            this.rbtnPaymaya.TabIndex = 6;
            this.rbtnPaymaya.TabStop = true;
            this.rbtnPaymaya.Text = "PayMaya";
            this.rbtnPaymaya.UseVisualStyleBackColor = true;
            this.rbtnPaymaya.CheckedChanged += new System.EventHandler(this.rbtnPaymaya_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbtnPaymaya);
            this.panel2.Location = new System.Drawing.Point(37, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 41);
            this.panel2.TabIndex = 23;
            // 
            // btnProceed
            // 
            this.btnProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.Location = new System.Drawing.Point(101, 452);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(122, 36);
            this.btnProceed.TabIndex = 20;
            this.btnProceed.Text = "PROCEED";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // rbtnCreditCard
            // 
            this.rbtnCreditCard.AutoSize = true;
            this.rbtnCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCreditCard.Location = new System.Drawing.Point(62, 387);
            this.rbtnCreditCard.Name = "rbtnCreditCard";
            this.rbtnCreditCard.Size = new System.Drawing.Size(161, 24);
            this.rbtnCreditCard.TabIndex = 19;
            this.rbtnCreditCard.TabStop = true;
            this.rbtnCreditCard.Text = "Credit or debit card";
            this.rbtnCreditCard.UseVisualStyleBackColor = true;
            this.rbtnCreditCard.CheckedChanged += new System.EventHandler(this.rbtnCreditCard_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(37, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 41);
            this.panel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(37, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 41);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(37, 164);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 41);
            this.panel4.TabIndex = 24;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(35, 35);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 26;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 521);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.rbtnGcash);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.rbtnCreditCard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPaymentMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.frmPaymentMethod_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnGcash;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnPaymaya;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.RadioButton rbtnCreditCard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picLogo;
    }
}