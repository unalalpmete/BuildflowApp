namespace DATABASE_PROJECT
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxAssignee = new System.Windows.Forms.PictureBox();
            this.pictureBoxContractor = new System.Windows.Forms.PictureBox();
            this.pictureBoxSupervısor = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAssignee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSupervısor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAssignee
            // 
            this.pictureBoxAssignee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAssignee.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAssignee.Image")));
            this.pictureBoxAssignee.Location = new System.Drawing.Point(748, 151);
            this.pictureBoxAssignee.Name = "pictureBoxAssignee";
            this.pictureBoxAssignee.Size = new System.Drawing.Size(291, 359);
            this.pictureBoxAssignee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAssignee.TabIndex = 0;
            this.pictureBoxAssignee.TabStop = false;
            this.pictureBoxAssignee.Click += new System.EventHandler(this.pictureBoxAssignee_Click);
            // 
            // pictureBoxContractor
            // 
            this.pictureBoxContractor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxContractor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxContractor.Image")));
            this.pictureBoxContractor.Location = new System.Drawing.Point(100, 151);
            this.pictureBoxContractor.Name = "pictureBoxContractor";
            this.pictureBoxContractor.Size = new System.Drawing.Size(291, 359);
            this.pictureBoxContractor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxContractor.TabIndex = 1;
            this.pictureBoxContractor.TabStop = false;
            this.pictureBoxContractor.Click += new System.EventHandler(this.pictureBoxContractor_Click);
            // 
            // pictureBoxSupervısor
            // 
            this.pictureBoxSupervısor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSupervısor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSupervısor.Image")));
            this.pictureBoxSupervısor.Location = new System.Drawing.Point(434, 151);
            this.pictureBoxSupervısor.Name = "pictureBoxSupervısor";
            this.pictureBoxSupervısor.Size = new System.Drawing.Size(291, 359);
            this.pictureBoxSupervısor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSupervısor.TabIndex = 2;
            this.pictureBoxSupervısor.TabStop = false;
            this.pictureBoxSupervısor.Click += new System.EventHandler(this.pictureBoxSupervısor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(476, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "BUILDFLOW";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1157, 657);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxSupervısor);
            this.Controls.Add(this.pictureBoxContractor);
            this.Controls.Add(this.pictureBoxAssignee);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAssignee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContractor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSupervısor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAssignee;
        private System.Windows.Forms.PictureBox pictureBoxContractor;
        private System.Windows.Forms.PictureBox pictureBoxSupervısor;
        private System.Windows.Forms.Label label4;
    }
}

