﻿namespace conseat
{
    partial class frmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            this.label5 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2Form1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            this.picEyeOpen = new System.Windows.Forms.PictureBox();
            this.picEyeClosed = new System.Windows.Forms.PictureBox();
            this.picConfirmEyeOpen = new System.Windows.Forms.PictureBox();
            this.picConfirmEyeClosed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirmEyeOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirmEyeClosed)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 34);
            this.label5.TabIndex = 34;
            this.label5.Text = "Confirm\r\n Password";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(122, 414);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(98, 28);
            this.btnSignUp.TabIndex = 33;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(132, 344);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfirmPassword.MaxLength = 20;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(181, 20);
            this.txtConfirmPassword.TabIndex = 32;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(132, 300);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 20);
            this.txtPassword.TabIndex = 29;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(132, 252);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 20);
            this.txtEmail.TabIndex = 28;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(132, 205);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 20);
            this.txtLastName.TabIndex = 27;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(132, 160);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(180, 20);
            this.txtMiddleName.TabIndex = 26;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(132, 118);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 20);
            this.txtFirstName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Middle name";
            // 
            // label2Form1
            // 
            this.label2Form1.AutoSize = true;
            this.label2Form1.BackColor = System.Drawing.Color.Transparent;
            this.label2Form1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Form1.ForeColor = System.Drawing.Color.White;
            this.label2Form1.Location = new System.Drawing.Point(39, 205);
            this.label2Form1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2Form1.Name = "label2Form1";
            this.label2Form1.Size = new System.Drawing.Size(83, 17);
            this.label2Form1.TabIndex = 22;
            this.label2Form1.Text = "Last name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(87, 472);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Already have an Account?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // linkSignUp
            // 
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.BackColor = System.Drawing.Color.Transparent;
            this.linkSignUp.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkSignUp.Location = new System.Drawing.Point(220, 472);
            this.linkSignUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(36, 13);
            this.linkSignUp.TabIndex = 35;
            this.linkSignUp.TabStop = true;
            this.linkSignUp.Text = "Log in";
            this.linkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignUp_LinkClicked);
            // 
            // picEyeOpen
            // 
            this.picEyeOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEyeOpen.Image = global::conseat.Properties.Resources.eye_svgrepo_com;
            this.picEyeOpen.Location = new System.Drawing.Point(292, 301);
            this.picEyeOpen.Name = "picEyeOpen";
            this.picEyeOpen.Size = new System.Drawing.Size(18, 18);
            this.picEyeOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeOpen.TabIndex = 38;
            this.picEyeOpen.TabStop = false;
            this.picEyeOpen.Click += new System.EventHandler(this.picEyeOpen_Click_1);
            // 
            // picEyeClosed
            // 
            this.picEyeClosed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEyeClosed.Image = global::conseat.Properties.Resources.eye_closed_svgrepo_com;
            this.picEyeClosed.Location = new System.Drawing.Point(293, 301);
            this.picEyeClosed.Name = "picEyeClosed";
            this.picEyeClosed.Size = new System.Drawing.Size(18, 18);
            this.picEyeClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeClosed.TabIndex = 37;
            this.picEyeClosed.TabStop = false;
            this.picEyeClosed.Click += new System.EventHandler(this.picEyeClosed_Click);
            // 
            // picConfirmEyeOpen
            // 
            this.picConfirmEyeOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picConfirmEyeOpen.Image = global::conseat.Properties.Resources.eye_svgrepo_com;
            this.picConfirmEyeOpen.Location = new System.Drawing.Point(294, 345);
            this.picConfirmEyeOpen.Name = "picConfirmEyeOpen";
            this.picConfirmEyeOpen.Size = new System.Drawing.Size(18, 18);
            this.picConfirmEyeOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConfirmEyeOpen.TabIndex = 40;
            this.picConfirmEyeOpen.TabStop = false;
            this.picConfirmEyeOpen.Click += new System.EventHandler(this.picConfirmEyeOpen_Click);
            // 
            // picConfirmEyeClosed
            // 
            this.picConfirmEyeClosed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picConfirmEyeClosed.Image = global::conseat.Properties.Resources.eye_closed_svgrepo_com;
            this.picConfirmEyeClosed.Location = new System.Drawing.Point(295, 345);
            this.picConfirmEyeClosed.Name = "picConfirmEyeClosed";
            this.picConfirmEyeClosed.Size = new System.Drawing.Size(18, 18);
            this.picConfirmEyeClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConfirmEyeClosed.TabIndex = 39;
            this.picConfirmEyeClosed.TabStop = false;
            this.picConfirmEyeClosed.Click += new System.EventHandler(this.picConfirmEyeClosed_Click);
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 560);
            this.Controls.Add(this.picConfirmEyeOpen);
            this.Controls.Add(this.picConfirmEyeClosed);
            this.Controls.Add(this.picEyeOpen);
            this.Controls.Add(this.picEyeClosed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkSignUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2Form1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirmEyeOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirmEyeClosed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2Form1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkSignUp;
        private System.Windows.Forms.PictureBox picEyeOpen;
        private System.Windows.Forms.PictureBox picEyeClosed;
        private System.Windows.Forms.PictureBox picConfirmEyeOpen;
        private System.Windows.Forms.PictureBox picConfirmEyeClosed;
    }
}