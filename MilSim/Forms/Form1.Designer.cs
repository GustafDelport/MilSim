namespace MilSim
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlSim = new System.Windows.Forms.Panel();
            this.lblSim = new System.Windows.Forms.Label();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.lblReports = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlSim.SuspendLayout();
            this.pnlReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 587);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlInfo);
            this.panel2.Controls.Add(this.pnlSim);
            this.panel2.Controls.Add(this.pnlReports);
            this.panel2.Location = new System.Drawing.Point(11, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 393);
            this.panel2.TabIndex = 64;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.Location = new System.Drawing.Point(3, 263);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(343, 124);
            this.pnlInfo.TabIndex = 67;
            this.pnlInfo.MouseEnter += new System.EventHandler(this.pnlInfo_MouseEnter);
            this.pnlInfo.MouseLeave += new System.EventHandler(this.pnlInfo_MouseLeave);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(104, 50);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(132, 27);
            this.lblInfo.TabIndex = 67;
            this.lblInfo.Text = "Information";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            this.lblInfo.MouseEnter += new System.EventHandler(this.lablInfo_MouseEnter);
            this.lblInfo.MouseLeave += new System.EventHandler(this.lblInfo_MouseLeave);
            // 
            // pnlSim
            // 
            this.pnlSim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSim.Controls.Add(this.lblSim);
            this.pnlSim.Location = new System.Drawing.Point(3, 133);
            this.pnlSim.Name = "pnlSim";
            this.pnlSim.Size = new System.Drawing.Size(343, 124);
            this.pnlSim.TabIndex = 66;
            this.pnlSim.MouseEnter += new System.EventHandler(this.pnlSim_MouseEnter);
            this.pnlSim.MouseLeave += new System.EventHandler(this.pnlSim_MouseLeave);
            // 
            // lblSim
            // 
            this.lblSim.AutoSize = true;
            this.lblSim.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSim.ForeColor = System.Drawing.Color.White;
            this.lblSim.Location = new System.Drawing.Point(104, 47);
            this.lblSim.Name = "lblSim";
            this.lblSim.Size = new System.Drawing.Size(125, 27);
            this.lblSim.TabIndex = 65;
            this.lblSim.Text = "Simulation";
            this.lblSim.Click += new System.EventHandler(this.lblSim_Click);
            this.lblSim.MouseEnter += new System.EventHandler(this.lblSim_MouseEnter);
            this.lblSim.MouseLeave += new System.EventHandler(this.lblSim_MouseLeave);
            // 
            // pnlReports
            // 
            this.pnlReports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReports.Controls.Add(this.lblReports);
            this.pnlReports.Location = new System.Drawing.Point(3, 3);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(343, 124);
            this.pnlReports.TabIndex = 65;
            this.pnlReports.MouseEnter += new System.EventHandler(this.pnlReports_MouseEnter);
            this.pnlReports.MouseLeave += new System.EventHandler(this.pnlReports_MouseLeave);
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.ForeColor = System.Drawing.Color.White;
            this.lblReports.Location = new System.Drawing.Point(116, 44);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(96, 27);
            this.lblReports.TabIndex = 66;
            this.lblReports.Text = "Reports";
            this.lblReports.Click += new System.EventHandler(this.lblReports_Click);
            this.lblReports.MouseEnter += new System.EventHandler(this.lblReports_MouseEnter);
            this.lblReports.MouseLeave += new System.EventHandler(this.lblReports_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 62;
            this.label1.Text = "MillSim V2.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MilSim.Properties.Resources.MainLogo;
            this.pictureBox1.Location = new System.Drawing.Point(120, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // picAdmin
            // 
            this.picAdmin.Image = global::MilSim.Properties.Resources.Admin_Panel1;
            this.picAdmin.Location = new System.Drawing.Point(327, 3);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(26, 26);
            this.picAdmin.TabIndex = 12;
            this.picAdmin.TabStop = false;
            this.picAdmin.Click += new System.EventHandler(this.picAdmin_Click);
            this.picAdmin.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.picAdmin.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(359, 3);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(26, 26);
            this.picExit.TabIndex = 10;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseEnter += new System.EventHandler(this.picExit_MouseEnter);
            this.picExit.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(395, 626);
            this.ControlBox = false;
            this.Controls.Add(this.picAdmin);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlSim.ResumeLayout(false);
            this.pnlSim.PerformLayout();
            this.pnlReports.ResumeLayout(false);
            this.pnlReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlSim;
        private System.Windows.Forms.Label lblSim;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblReports;
    }
}

