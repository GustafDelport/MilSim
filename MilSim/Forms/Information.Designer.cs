namespace MilSim
{
    partial class Information
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
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // picAdmin
            // 
            this.picAdmin.Image = global::MilSim.Properties.Resources.Admin_Panel1;
            this.picAdmin.Location = new System.Drawing.Point(220, 2);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(26, 26);
            this.picAdmin.TabIndex = 14;
            this.picAdmin.TabStop = false;
            this.picAdmin.Click += new System.EventHandler(this.picAdmin_Click);
            this.picAdmin.MouseEnter += new System.EventHandler(this.picAdmin_MouseEnter_1);
            this.picAdmin.MouseLeave += new System.EventHandler(this.picAdmin_MouseLeave_1);
            // 
            // picExit
            // 
            this.picExit.Image = global::MilSim.Properties.Resources.ReturnTwo;
            this.picExit.Location = new System.Drawing.Point(252, 2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(26, 26);
            this.picExit.TabIndex = 13;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseEnter += new System.EventHandler(this.picExit_MouseEnter_1);
            this.picExit.MouseLeave += new System.EventHandler(this.picExit_MouseLeave_1);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(7, 34);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(271, 407);
            this.rtbInfo.TabIndex = 15;
            this.rtbInfo.Text = "";
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(287, 450);
            this.ControlBox = false;
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.picAdmin);
            this.Controls.Add(this.picExit);
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.RichTextBox rtbInfo;
    }
}