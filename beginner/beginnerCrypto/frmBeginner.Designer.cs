namespace beginnerCrypto
{
    partial class Beginner
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lbDES = new System.Windows.Forms.Label();
            this.lbAES = new System.Windows.Forms.Label();
            this.lbRSA = new System.Windows.Forms.Label();
            this.lbHill = new System.Windows.Forms.Label();
            this.lbVigenere = new System.Windows.Forms.Label();
            this.lbAffine = new System.Windows.Forms.Label();
            this.lbThayThe = new System.Windows.Forms.Label();
            this.lbDichVong = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lbDES);
            this.pnlMain.Controls.Add(this.lbAES);
            this.pnlMain.Controls.Add(this.lbRSA);
            this.pnlMain.Controls.Add(this.lbHill);
            this.pnlMain.Controls.Add(this.lbVigenere);
            this.pnlMain.Controls.Add(this.lbAffine);
            this.pnlMain.Controls.Add(this.lbThayThe);
            this.pnlMain.Controls.Add(this.lbDichVong);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(203, 292);
            this.pnlMain.TabIndex = 0;
            // 
            // lbDES
            // 
            this.lbDES.BackColor = System.Drawing.Color.Blue;
            this.lbDES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDES.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDES.Location = new System.Drawing.Point(102, 219);
            this.lbDES.Name = "lbDES";
            this.lbDES.Size = new System.Drawing.Size(95, 64);
            this.lbDES.TabIndex = 23;
            this.lbDES.Text = "Mã hóa DES";
            this.lbDES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDES.Visible = false;
            this.lbDES.Click += new System.EventHandler(this.lbDES_Click);
            // 
            // lbAES
            // 
            this.lbAES.BackColor = System.Drawing.Color.Blue;
            this.lbAES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAES.ForeColor = System.Drawing.SystemColors.Control;
            this.lbAES.Location = new System.Drawing.Point(7, 219);
            this.lbAES.Name = "lbAES";
            this.lbAES.Size = new System.Drawing.Size(89, 64);
            this.lbAES.TabIndex = 22;
            this.lbAES.Text = "Mã hóa AES";
            this.lbAES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAES.Visible = false;
            this.lbAES.Click += new System.EventHandler(this.lbAES_Click);
            // 
            // lbRSA
            // 
            this.lbRSA.BackColor = System.Drawing.Color.Blue;
            this.lbRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRSA.ForeColor = System.Drawing.SystemColors.Control;
            this.lbRSA.Location = new System.Drawing.Point(102, 148);
            this.lbRSA.Name = "lbRSA";
            this.lbRSA.Size = new System.Drawing.Size(95, 64);
            this.lbRSA.TabIndex = 21;
            this.lbRSA.Text = "Mã hóa RSA";
            this.lbRSA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbRSA.Visible = false;
            this.lbRSA.Click += new System.EventHandler(this.lbRSA_Click);
            // 
            // lbHill
            // 
            this.lbHill.BackColor = System.Drawing.Color.Blue;
            this.lbHill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHill.ForeColor = System.Drawing.SystemColors.Control;
            this.lbHill.Location = new System.Drawing.Point(7, 148);
            this.lbHill.Name = "lbHill";
            this.lbHill.Size = new System.Drawing.Size(89, 64);
            this.lbHill.TabIndex = 20;
            this.lbHill.Text = "Mã hóa Hill";
            this.lbHill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHill.Visible = false;
            this.lbHill.Click += new System.EventHandler(this.lbHill_Click);
            // 
            // lbVigenere
            // 
            this.lbVigenere.BackColor = System.Drawing.Color.Blue;
            this.lbVigenere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbVigenere.ForeColor = System.Drawing.SystemColors.Control;
            this.lbVigenere.Location = new System.Drawing.Point(102, 78);
            this.lbVigenere.Name = "lbVigenere";
            this.lbVigenere.Size = new System.Drawing.Size(95, 64);
            this.lbVigenere.TabIndex = 19;
            this.lbVigenere.Text = "Mã hóa Vigenere";
            this.lbVigenere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbVigenere.Visible = false;
            this.lbVigenere.Click += new System.EventHandler(this.lbVigenere_Click);
            // 
            // lbAffine
            // 
            this.lbAffine.BackColor = System.Drawing.Color.Blue;
            this.lbAffine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAffine.ForeColor = System.Drawing.SystemColors.Control;
            this.lbAffine.Location = new System.Drawing.Point(7, 78);
            this.lbAffine.Name = "lbAffine";
            this.lbAffine.Size = new System.Drawing.Size(89, 64);
            this.lbAffine.TabIndex = 18;
            this.lbAffine.Text = "Mã hóa affine";
            this.lbAffine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAffine.Visible = false;
            this.lbAffine.Click += new System.EventHandler(this.lbAffine_Click);
            // 
            // lbThayThe
            // 
            this.lbThayThe.BackColor = System.Drawing.Color.Blue;
            this.lbThayThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThayThe.ForeColor = System.Drawing.SystemColors.Control;
            this.lbThayThe.Location = new System.Drawing.Point(102, 8);
            this.lbThayThe.Name = "lbThayThe";
            this.lbThayThe.Size = new System.Drawing.Size(95, 64);
            this.lbThayThe.TabIndex = 17;
            this.lbThayThe.Text = "Mã hóa thay thế";
            this.lbThayThe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbThayThe.Visible = false;
            this.lbThayThe.Click += new System.EventHandler(this.lbThayThe_Click);
            // 
            // lbDichVong
            // 
            this.lbDichVong.BackColor = System.Drawing.Color.Blue;
            this.lbDichVong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDichVong.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDichVong.Location = new System.Drawing.Point(7, 8);
            this.lbDichVong.Name = "lbDichVong";
            this.lbDichVong.Size = new System.Drawing.Size(89, 64);
            this.lbDichVong.TabIndex = 16;
            this.lbDichVong.Text = "Mã hóa dịch vòng";
            this.lbDichVong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDichVong.Visible = false;
            this.lbDichVong.Click += new System.EventHandler(this.lbDichVong_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHome,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(203, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHome
            // 
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(52, 20);
            this.mnuHome.Text = "Home";
            this.mnuHome.Click += new System.EventHandler(this.mnuHome_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(42, 20);
            this.mnuHelp.Text = "help";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // Beginner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 316);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Beginner";
            this.Text = "Cơ sở mật mã";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Beginner_FormClosing);
            this.Load += new System.EventHandler(this.frmBeginner_Load);
            this.pnlMain.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.Label lbAffine;
        private System.Windows.Forms.Label lbThayThe;
        private System.Windows.Forms.Label lbDichVong;
        private System.Windows.Forms.Label lbDES;
        private System.Windows.Forms.Label lbAES;
        private System.Windows.Forms.Label lbRSA;
        private System.Windows.Forms.Label lbHill;
        private System.Windows.Forms.Label lbVigenere;
    }
}

