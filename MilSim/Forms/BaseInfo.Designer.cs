namespace MilSim
{
    partial class BaseInfo
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
            this.rtxBaseInfo = new System.Windows.Forms.RichTextBox();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.picReturn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxBaseInfo
            // 
            this.rtxBaseInfo.Location = new System.Drawing.Point(5, 35);
            this.rtxBaseInfo.Name = "rtxBaseInfo";
            this.rtxBaseInfo.ReadOnly = true;
            this.rtxBaseInfo.Size = new System.Drawing.Size(152, 210);
            this.rtxBaseInfo.TabIndex = 17;
            this.rtxBaseInfo.Text = "";
            // 
            // picAdmin
            // 
            this.picAdmin.Image = global::MilSim.Properties.Resources.Admin_Panel1;
            this.picAdmin.Location = new System.Drawing.Point(99, 3);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(26, 26);
            this.picAdmin.TabIndex = 16;
            this.picAdmin.TabStop = false;
            this.picAdmin.Click += new System.EventHandler(this.picAdmin_Click);
            this.picAdmin.MouseEnter += new System.EventHandler(this.picAdmin_MouseEnter);
            this.picAdmin.MouseLeave += new System.EventHandler(this.picAdmin_MouseLeave);
            // 
            // picReturn
            // 
            this.picReturn.Image = global::MilSim.Properties.Resources.ReturnTwo;
            this.picReturn.Location = new System.Drawing.Point(131, 3);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(26, 26);
            this.picReturn.TabIndex = 15;
            this.picReturn.TabStop = false;
            this.picReturn.Click += new System.EventHandler(this.picExit_Click);
            this.picReturn.MouseEnter += new System.EventHandler(this.picExit_MouseEnter);
            this.picReturn.MouseLeave += new System.EventHandler(this.picReturn_MouseLeave);
            // 
            // BaseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(162, 250);
            this.ControlBox = false;
            this.Controls.Add(this.rtxBaseInfo);
            this.Controls.Add(this.picAdmin);
            this.Controls.Add(this.picReturn);
            this.Name = "BaseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseInfo";
            this.Load += new System.EventHandler(this.BaseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.PictureBox picReturn;
        private System.Windows.Forms.RichTextBox rtxBaseInfo;
    }
}