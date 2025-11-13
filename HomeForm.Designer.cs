namespace EmployeeMS
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnEmpList = new System.Windows.Forms.Button();
            this.BtnEmpData = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LbHeading = new System.Windows.Forms.Label();
            this.LbWelcome = new System.Windows.Forms.Label();
            this.LbUser = new System.Windows.Forms.Label();
            this.PicBxLogout = new System.Windows.Forms.PictureBox();
            this.PicBxEmpDetails = new System.Windows.Forms.PictureBox();
            this.PicBxEmplList = new System.Windows.Forms.PictureBox();
            this.PicBxDashBoard = new System.Windows.Forms.PictureBox();
            this.PicBxHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxEmpDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxEmplList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxDashBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.AutoSize = true;
            this.BtnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.Snow;
            this.BtnDashboard.Location = new System.Drawing.Point(100, 550);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(150, 62);
            this.BtnDashboard.TabIndex = 6;
            this.BtnDashboard.Text = "DASHBOARD";
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // BtnEmpList
            // 
            this.BtnEmpList.AutoSize = true;
            this.BtnEmpList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnEmpList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmpList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEmpList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpList.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpList.ForeColor = System.Drawing.Color.Snow;
            this.BtnEmpList.Location = new System.Drawing.Point(341, 550);
            this.BtnEmpList.Name = "BtnEmpList";
            this.BtnEmpList.Size = new System.Drawing.Size(197, 62);
            this.BtnEmpList.TabIndex = 7;
            this.BtnEmpList.Text = "EMPLOYEES LIST";
            this.BtnEmpList.UseVisualStyleBackColor = false;
            this.BtnEmpList.Visible = false;
            this.BtnEmpList.Click += new System.EventHandler(this.BtnEmpList_Click);
            // 
            // BtnEmpData
            // 
            this.BtnEmpData.AutoSize = true;
            this.BtnEmpData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnEmpData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmpData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEmpData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpData.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpData.ForeColor = System.Drawing.Color.Snow;
            this.BtnEmpData.Location = new System.Drawing.Point(600, 550);
            this.BtnEmpData.Name = "BtnEmpData";
            this.BtnEmpData.Size = new System.Drawing.Size(212, 62);
            this.BtnEmpData.TabIndex = 8;
            this.BtnEmpData.Text = "EMPLOYEES DATA";
            this.BtnEmpData.UseVisualStyleBackColor = false;
            this.BtnEmpData.Click += new System.EventHandler(this.BtnEmpData_Click);
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbHeading.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.Lavender;
            this.LbHeading.Location = new System.Drawing.Point(192, 27);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(495, 34);
            this.LbHeading.TabIndex = 9;
            this.LbHeading.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbWelcome
            // 
            this.LbWelcome.AutoSize = true;
            this.LbWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbWelcome.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWelcome.ForeColor = System.Drawing.Color.Indigo;
            this.LbWelcome.Location = new System.Drawing.Point(321, 250);
            this.LbWelcome.Name = "LbWelcome";
            this.LbWelcome.Size = new System.Drawing.Size(134, 29);
            this.LbWelcome.TabIndex = 10;
            this.LbWelcome.Text = "Welcome, ";
            this.LbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbUser
            // 
            this.LbUser.AutoSize = true;
            this.LbUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbUser.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUser.ForeColor = System.Drawing.Color.Indigo;
            this.LbUser.Location = new System.Drawing.Point(454, 250);
            this.LbUser.Name = "LbUser";
            this.LbUser.Size = new System.Drawing.Size(29, 29);
            this.LbUser.TabIndex = 11;
            this.LbUser.Text = " -";
            this.LbUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBxLogout
            // 
            this.PicBxLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBxLogout.Image = global::EmployeeMS.Properties.Resources.LogoutSkeuomorphism;
            this.PicBxLogout.Location = new System.Drawing.Point(765, 90);
            this.PicBxLogout.Name = "PicBxLogout";
            this.PicBxLogout.Size = new System.Drawing.Size(80, 80);
            this.PicBxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxLogout.TabIndex = 4;
            this.PicBxLogout.TabStop = false;
            this.PicBxLogout.Click += new System.EventHandler(this.PicBxLogout_Click);
            this.PicBxLogout.MouseHover += new System.EventHandler(this.PicBxLogout_MouseHover);
            // 
            // PicBxEmpDetails
            // 
            this.PicBxEmpDetails.Image = global::EmployeeMS.Properties.Resources.Directory;
            this.PicBxEmpDetails.Location = new System.Drawing.Point(631, 390);
            this.PicBxEmpDetails.Name = "PicBxEmpDetails";
            this.PicBxEmpDetails.Size = new System.Drawing.Size(150, 150);
            this.PicBxEmpDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxEmpDetails.TabIndex = 3;
            this.PicBxEmpDetails.TabStop = false;
            // 
            // PicBxEmplList
            // 
            this.PicBxEmplList.Image = global::EmployeeMS.Properties.Resources.Employees;
            this.PicBxEmplList.Location = new System.Drawing.Point(364, 390);
            this.PicBxEmplList.Name = "PicBxEmplList";
            this.PicBxEmplList.Size = new System.Drawing.Size(150, 150);
            this.PicBxEmplList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxEmplList.TabIndex = 2;
            this.PicBxEmplList.TabStop = false;
            this.PicBxEmplList.Visible = false;
            // 
            // PicBxDashBoard
            // 
            this.PicBxDashBoard.Image = global::EmployeeMS.Properties.Resources.Dashboard;
            this.PicBxDashBoard.Location = new System.Drawing.Point(102, 390);
            this.PicBxDashBoard.Name = "PicBxDashBoard";
            this.PicBxDashBoard.Size = new System.Drawing.Size(150, 150);
            this.PicBxDashBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxDashBoard.TabIndex = 1;
            this.PicBxDashBoard.TabStop = false;
            // 
            // PicBxHome
            // 
            this.PicBxHome.Image = global::EmployeeMS.Properties.Resources.HomeFlatIcon2;
            this.PicBxHome.Location = new System.Drawing.Point(364, 90);
            this.PicBxHome.Name = "PicBxHome";
            this.PicBxHome.Size = new System.Drawing.Size(150, 150);
            this.PicBxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxHome.TabIndex = 0;
            this.PicBxHome.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.LbUser);
            this.Controls.Add(this.LbWelcome);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.BtnEmpData);
            this.Controls.Add(this.BtnEmpList);
            this.Controls.Add(this.BtnDashboard);
            this.Controls.Add(this.PicBxLogout);
            this.Controls.Add(this.PicBxEmpDetails);
            this.Controls.Add(this.PicBxEmplList);
            this.Controls.Add(this.PicBxDashBoard);
            this.Controls.Add(this.PicBxHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxEmpDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxEmplList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxDashBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBxHome;
        private System.Windows.Forms.PictureBox PicBxDashBoard;
        private System.Windows.Forms.PictureBox PicBxEmplList;
        private System.Windows.Forms.PictureBox PicBxEmpDetails;
        private System.Windows.Forms.PictureBox PicBxLogout;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnEmpList;
        private System.Windows.Forms.Button BtnEmpData;
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Label LbWelcome;
        private System.Windows.Forms.Label LbUser;
    }
}