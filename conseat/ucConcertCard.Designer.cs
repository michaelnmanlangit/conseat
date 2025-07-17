namespace conseat
{
    partial class ucConcertCard
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.picArtist = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picArtist)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArtistName
            // 
            this.lblArtistName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblArtistName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblArtistName.Location = new System.Drawing.Point(49, 109);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(35, 13);
            this.lblArtistName.TabIndex = 2;
            this.lblArtistName.Text = "label1";
            this.lblArtistName.Click += new System.EventHandler(this.lblArtistName_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(0, 128);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(133, 35);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 169);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // picArtist
            // 
            this.picArtist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picArtist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picArtist.Location = new System.Drawing.Point(0, 0);
            this.picArtist.Margin = new System.Windows.Forms.Padding(10);
            this.picArtist.Name = "picArtist";
            this.picArtist.Size = new System.Drawing.Size(133, 100);
            this.picArtist.TabIndex = 1;
            this.picArtist.TabStop = false;
            this.picArtist.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ucConcertCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblArtistName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.picArtist);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ucConcertCard";
            this.Size = new System.Drawing.Size(133, 209);
            this.Load += new System.EventHandler(this.ucConcertCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picArtist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox picArtist;
    }
}
