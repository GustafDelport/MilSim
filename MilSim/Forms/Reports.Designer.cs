namespace MilSim
{
    partial class Reports
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataFilter = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchByRep = new System.Windows.Forms.Button();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.btnSearchByPlane = new System.Windows.Forms.Button();
            this.txtRep = new System.Windows.Forms.TextBox();
            this.txtPlane = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // picAdmin
            // 
            this.picAdmin.Image = global::MilSim.Properties.Resources.Admin_Panel1;
            this.picAdmin.Location = new System.Drawing.Point(634, 2);
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
            this.picExit.Image = global::MilSim.Properties.Resources.ReturnOne;
            this.picExit.Location = new System.Drawing.Point(666, 2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(26, 26);
            this.picExit.TabIndex = 13;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseEnter += new System.EventHandler(this.picExit_MouseEnter);
            this.picExit.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 233);
            this.dataGridView1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Search By Report ID";
            // 
            // dtpDataFilter
            // 
            this.dtpDataFilter.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.dtpDataFilter.Location = new System.Drawing.Point(200, 332);
            this.dtpDataFilter.Name = "dtpDataFilter";
            this.dtpDataFilter.Size = new System.Drawing.Size(303, 32);
            this.dtpDataFilter.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Filter By Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(552, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Search By Plane ID";
            // 
            // btnSearchByRep
            // 
            this.btnSearchByRep.BackColor = System.Drawing.Color.Green;
            this.btnSearchByRep.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchByRep.FlatAppearance.BorderSize = 0;
            this.btnSearchByRep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnSearchByRep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearchByRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByRep.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByRep.ForeColor = System.Drawing.Color.White;
            this.btnSearchByRep.Location = new System.Drawing.Point(12, 370);
            this.btnSearchByRep.Name = "btnSearchByRep";
            this.btnSearchByRep.Size = new System.Drawing.Size(139, 32);
            this.btnSearchByRep.TabIndex = 35;
            this.btnSearchByRep.Text = "Search";
            this.btnSearchByRep.UseVisualStyleBackColor = false;
            this.btnSearchByRep.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.BackColor = System.Drawing.Color.Green;
            this.btnSearchByDate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchByDate.FlatAppearance.BorderSize = 0;
            this.btnSearchByDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnSearchByDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearchByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByDate.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByDate.ForeColor = System.Drawing.Color.White;
            this.btnSearchByDate.Location = new System.Drawing.Point(200, 370);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(303, 32);
            this.btnSearchByDate.TabIndex = 36;
            this.btnSearchByDate.Text = "Search";
            this.btnSearchByDate.UseVisualStyleBackColor = false;
            this.btnSearchByDate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearchByPlane
            // 
            this.btnSearchByPlane.BackColor = System.Drawing.Color.Green;
            this.btnSearchByPlane.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchByPlane.FlatAppearance.BorderSize = 0;
            this.btnSearchByPlane.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnSearchByPlane.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearchByPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByPlane.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByPlane.ForeColor = System.Drawing.Color.White;
            this.btnSearchByPlane.Location = new System.Drawing.Point(556, 370);
            this.btnSearchByPlane.Name = "btnSearchByPlane";
            this.btnSearchByPlane.Size = new System.Drawing.Size(139, 32);
            this.btnSearchByPlane.TabIndex = 37;
            this.btnSearchByPlane.Text = "Search";
            this.btnSearchByPlane.UseVisualStyleBackColor = false;
            this.btnSearchByPlane.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtRep
            // 
            this.txtRep.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRep.Location = new System.Drawing.Point(12, 332);
            this.txtRep.Name = "txtRep";
            this.txtRep.Size = new System.Drawing.Size(139, 32);
            this.txtRep.TabIndex = 38;
            this.txtRep.Text = "Report ID";
            this.txtRep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRep_MouseClick);
            this.txtRep.MouseLeave += new System.EventHandler(this.txtRep_MouseLeave);
            // 
            // txtPlane
            // 
            this.txtPlane.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlane.Location = new System.Drawing.Point(556, 332);
            this.txtPlane.Name = "txtPlane";
            this.txtPlane.Size = new System.Drawing.Size(139, 32);
            this.txtPlane.TabIndex = 39;
            this.txtPlane.Text = "Plane ID";
            this.txtPlane.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPlane_MouseClick);
            this.txtPlane.MouseLeave += new System.EventHandler(this.txtPlane_MouseLeave);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.Green;
            this.btnShowAll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnShowAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(265, 273);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(139, 32);
            this.btnShowAll.TabIndex = 40;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(707, 410);
            this.ControlBox = false;
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.txtPlane);
            this.Controls.Add(this.txtRep);
            this.Controls.Add(this.btnSearchByPlane);
            this.Controls.Add(this.btnSearchByDate);
            this.Controls.Add(this.btnSearchByRep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.picAdmin);
            this.Controls.Add(this.picExit);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchByRep;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.Button btnSearchByPlane;
        private System.Windows.Forms.TextBox txtRep;
        private System.Windows.Forms.TextBox txtPlane;
        private System.Windows.Forms.Button btnShowAll;
    }
}