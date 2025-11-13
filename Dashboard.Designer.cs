namespace EmployeeMS
{
    partial class FormDashboard
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
            this.LbDashBoard = new System.Windows.Forms.Label();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.PnlAE = new System.Windows.Forms.Panel();
            this.LbActEmpsCnt = new System.Windows.Forms.Label();
            this.LbActEmps = new System.Windows.Forms.Label();
            this.PicBx2 = new System.Windows.Forms.PictureBox();
            this.PnlIE = new System.Windows.Forms.Panel();
            this.LbInactEmpsCnt = new System.Windows.Forms.Label();
            this.LbInactEmps = new System.Windows.Forms.Label();
            this.PicBx3 = new System.Windows.Forms.PictureBox();
            this.PnlTE = new System.Windows.Forms.Panel();
            this.LbTotEmpsCnt = new System.Windows.Forms.Label();
            this.LbTotEmps = new System.Windows.Forms.Label();
            this.PicBx1 = new System.Windows.Forms.PictureBox();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.PicBxConfRoom = new System.Windows.Forms.PictureBox();
            this.Pnl1.SuspendLayout();
            this.PnlAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx2)).BeginInit();
            this.PnlIE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx3)).BeginInit();
            this.PnlTE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx1)).BeginInit();
            this.Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxConfRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // LbDashBoard
            // 
            this.LbDashBoard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbDashBoard.AutoSize = true;
            this.LbDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbDashBoard.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDashBoard.ForeColor = System.Drawing.Color.Firebrick;
            this.LbDashBoard.Location = new System.Drawing.Point(517, 15);
            this.LbDashBoard.Name = "LbDashBoard";
            this.LbDashBoard.Size = new System.Drawing.Size(154, 28);
            this.LbDashBoard.TabIndex = 3;
            this.LbDashBoard.Text = "DASHBOARD";
            this.LbDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl1
            // 
            this.Pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl1.BackColor = System.Drawing.Color.SaddleBrown;
            this.Pnl1.Controls.Add(this.PnlAE);
            this.Pnl1.Controls.Add(this.PnlIE);
            this.Pnl1.Controls.Add(this.PnlTE);
            this.Pnl1.ForeColor = System.Drawing.Color.MistyRose;
            this.Pnl1.Location = new System.Drawing.Point(10, 50);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(1150, 250);
            this.Pnl1.TabIndex = 4;
            // 
            // PnlAE
            // 
            this.PnlAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PnlAE.BackColor = System.Drawing.Color.BurlyWood;
            this.PnlAE.Controls.Add(this.LbActEmpsCnt);
            this.PnlAE.Controls.Add(this.LbActEmps);
            this.PnlAE.Controls.Add(this.PicBx2);
            this.PnlAE.Location = new System.Drawing.Point(399, 20);
            this.PnlAE.Name = "PnlAE";
            this.PnlAE.Size = new System.Drawing.Size(350, 210);
            this.PnlAE.TabIndex = 0;
            // 
            // LbActEmpsCnt
            // 
            this.LbActEmpsCnt.AutoSize = true;
            this.LbActEmpsCnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbActEmpsCnt.Font = new System.Drawing.Font("Lucida Fax", 14F, System.Drawing.FontStyle.Bold);
            this.LbActEmpsCnt.ForeColor = System.Drawing.Color.Navy;
            this.LbActEmpsCnt.Location = new System.Drawing.Point(20, 140);
            this.LbActEmpsCnt.Name = "LbActEmpsCnt";
            this.LbActEmpsCnt.Size = new System.Drawing.Size(33, 32);
            this.LbActEmpsCnt.TabIndex = 9;
            this.LbActEmpsCnt.Text = "0";
            this.LbActEmpsCnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbActEmps
            // 
            this.LbActEmps.AutoSize = true;
            this.LbActEmps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbActEmps.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbActEmps.ForeColor = System.Drawing.Color.Black;
            this.LbActEmps.Location = new System.Drawing.Point(140, 38);
            this.LbActEmps.Name = "LbActEmps";
            this.LbActEmps.Size = new System.Drawing.Size(129, 64);
            this.LbActEmps.TabIndex = 8;
            this.LbActEmps.Text = "Active \r\nEmployees";
            this.LbActEmps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBx2
            // 
            this.PicBx2.Image = global::EmployeeMS.Properties.Resources.Employee;
            this.PicBx2.Location = new System.Drawing.Point(20, 20);
            this.PicBx2.Name = "PicBx2";
            this.PicBx2.Size = new System.Drawing.Size(100, 100);
            this.PicBx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBx2.TabIndex = 7;
            this.PicBx2.TabStop = false;
            // 
            // PnlIE
            // 
            this.PnlIE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlIE.BackColor = System.Drawing.Color.BurlyWood;
            this.PnlIE.Controls.Add(this.LbInactEmpsCnt);
            this.PnlIE.Controls.Add(this.LbInactEmps);
            this.PnlIE.Controls.Add(this.PicBx3);
            this.PnlIE.Location = new System.Drawing.Point(778, 20);
            this.PnlIE.Name = "PnlIE";
            this.PnlIE.Size = new System.Drawing.Size(350, 210);
            this.PnlIE.TabIndex = 0;
            // 
            // LbInactEmpsCnt
            // 
            this.LbInactEmpsCnt.AutoSize = true;
            this.LbInactEmpsCnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbInactEmpsCnt.Font = new System.Drawing.Font("Lucida Fax", 14F, System.Drawing.FontStyle.Bold);
            this.LbInactEmpsCnt.ForeColor = System.Drawing.Color.Navy;
            this.LbInactEmpsCnt.Location = new System.Drawing.Point(20, 140);
            this.LbInactEmpsCnt.Name = "LbInactEmpsCnt";
            this.LbInactEmpsCnt.Size = new System.Drawing.Size(33, 32);
            this.LbInactEmpsCnt.TabIndex = 10;
            this.LbInactEmpsCnt.Text = "0";
            this.LbInactEmpsCnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbInactEmps
            // 
            this.LbInactEmps.AutoSize = true;
            this.LbInactEmps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbInactEmps.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInactEmps.ForeColor = System.Drawing.Color.Black;
            this.LbInactEmps.Location = new System.Drawing.Point(140, 38);
            this.LbInactEmps.Name = "LbInactEmps";
            this.LbInactEmps.Size = new System.Drawing.Size(129, 64);
            this.LbInactEmps.TabIndex = 8;
            this.LbInactEmps.Text = "Inactive \r\nEmployees";
            this.LbInactEmps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBx3
            // 
            this.PicBx3.Image = global::EmployeeMS.Properties.Resources.Employees2;
            this.PicBx3.Location = new System.Drawing.Point(20, 20);
            this.PicBx3.Name = "PicBx3";
            this.PicBx3.Size = new System.Drawing.Size(100, 100);
            this.PicBx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBx3.TabIndex = 7;
            this.PicBx3.TabStop = false;
            // 
            // PnlTE
            // 
            this.PnlTE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlTE.BackColor = System.Drawing.Color.BurlyWood;
            this.PnlTE.Controls.Add(this.LbTotEmpsCnt);
            this.PnlTE.Controls.Add(this.LbTotEmps);
            this.PnlTE.Controls.Add(this.PicBx1);
            this.PnlTE.Location = new System.Drawing.Point(20, 20);
            this.PnlTE.Name = "PnlTE";
            this.PnlTE.Size = new System.Drawing.Size(350, 210);
            this.PnlTE.TabIndex = 0;
            // 
            // LbTotEmpsCnt
            // 
            this.LbTotEmpsCnt.AutoSize = true;
            this.LbTotEmpsCnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbTotEmpsCnt.Font = new System.Drawing.Font("Lucida Fax", 14F, System.Drawing.FontStyle.Bold);
            this.LbTotEmpsCnt.ForeColor = System.Drawing.Color.Navy;
            this.LbTotEmpsCnt.Location = new System.Drawing.Point(20, 140);
            this.LbTotEmpsCnt.Name = "LbTotEmpsCnt";
            this.LbTotEmpsCnt.Size = new System.Drawing.Size(33, 32);
            this.LbTotEmpsCnt.TabIndex = 8;
            this.LbTotEmpsCnt.Text = "0";
            this.LbTotEmpsCnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbTotEmps
            // 
            this.LbTotEmps.AutoSize = true;
            this.LbTotEmps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbTotEmps.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotEmps.ForeColor = System.Drawing.Color.Black;
            this.LbTotEmps.Location = new System.Drawing.Point(140, 38);
            this.LbTotEmps.Name = "LbTotEmps";
            this.LbTotEmps.Size = new System.Drawing.Size(129, 64);
            this.LbTotEmps.TabIndex = 7;
            this.LbTotEmps.Text = "Total \r\nEmployees";
            this.LbTotEmps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBx1
            // 
            this.PicBx1.Image = global::EmployeeMS.Properties.Resources.Employees;
            this.PicBx1.Location = new System.Drawing.Point(20, 20);
            this.PicBx1.Name = "PicBx1";
            this.PicBx1.Size = new System.Drawing.Size(100, 100);
            this.PicBx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBx1.TabIndex = 6;
            this.PicBx1.TabStop = false;
            // 
            // Pnl2
            // 
            this.Pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl2.BackColor = System.Drawing.Color.SaddleBrown;
            this.Pnl2.Controls.Add(this.PicBxConfRoom);
            this.Pnl2.Location = new System.Drawing.Point(10, 310);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(1150, 320);
            this.Pnl2.TabIndex = 5;
            // 
            // PicBxConfRoom
            // 
            this.PicBxConfRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBxConfRoom.Image = global::EmployeeMS.Properties.Resources.ConferenceRoom;
            this.PicBxConfRoom.Location = new System.Drawing.Point(10, 10);
            this.PicBxConfRoom.Name = "PicBxConfRoom";
            this.PicBxConfRoom.Size = new System.Drawing.Size(1130, 300);
            this.PicBxConfRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicBxConfRoom.TabIndex = 9;
            this.PicBxConfRoom.TabStop = false;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.Pnl1);
            this.Controls.Add(this.LbDashBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDashboard";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Employee Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDashboard_FormClosing);
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.Pnl1.ResumeLayout(false);
            this.PnlAE.ResumeLayout(false);
            this.PnlAE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx2)).EndInit();
            this.PnlIE.ResumeLayout(false);
            this.PnlIE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx3)).EndInit();
            this.PnlTE.ResumeLayout(false);
            this.PnlTE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx1)).EndInit();
            this.Pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxConfRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbDashBoard;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Panel PnlAE;
        private System.Windows.Forms.Panel PnlIE;
        private System.Windows.Forms.Panel PnlTE;
        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.PictureBox PicBx2;
        private System.Windows.Forms.PictureBox PicBx3;
        private System.Windows.Forms.Label LbTotEmps;
        private System.Windows.Forms.PictureBox PicBx1;
        private System.Windows.Forms.Label LbActEmpsCnt;
        private System.Windows.Forms.Label LbActEmps;
        private System.Windows.Forms.Label LbInactEmps;
        private System.Windows.Forms.Label LbTotEmpsCnt;
        private System.Windows.Forms.Label LbInactEmpsCnt;
        private System.Windows.Forms.PictureBox PicBxConfRoom;
    }
}