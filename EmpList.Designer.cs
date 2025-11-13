namespace EmployeeMS
{
    partial class FormEmpList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LbDashBoard = new System.Windows.Forms.Label();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.LbEL = new System.Windows.Forms.Label();
            this.DGVEmpsList = new System.Windows.Forms.DataGridView();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.TxtBxSalary = new System.Windows.Forms.TextBox();
            this.TxtbxPosition = new System.Windows.Forms.TextBox();
            this.TxtBxFullName = new System.Windows.Forms.TextBox();
            this.TxtBxEmpId = new System.Windows.Forms.TextBox();
            this.LbEmpId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpsList)).BeginInit();
            this.Pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbDashBoard
            // 
            this.LbDashBoard.AutoSize = true;
            this.LbDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbDashBoard.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDashBoard.ForeColor = System.Drawing.Color.Firebrick;
            this.LbDashBoard.Location = new System.Drawing.Point(490, 10);
            this.LbDashBoard.Name = "LbDashBoard";
            this.LbDashBoard.Size = new System.Drawing.Size(198, 28);
            this.LbDashBoard.TabIndex = 4;
            this.LbDashBoard.Text = "EMPLOYEES LIST";
            this.LbDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl1
            // 
            this.Pnl1.BackColor = System.Drawing.Color.SaddleBrown;
            this.Pnl1.Controls.Add(this.LbEL);
            this.Pnl1.Controls.Add(this.DGVEmpsList);
            this.Pnl1.Location = new System.Drawing.Point(14, 50);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(1150, 280);
            this.Pnl1.TabIndex = 7;
            // 
            // LbEL
            // 
            this.LbEL.AutoSize = true;
            this.LbEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbEL.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEL.ForeColor = System.Drawing.Color.Snow;
            this.LbEL.Location = new System.Drawing.Point(13, 12);
            this.LbEL.Name = "LbEL";
            this.LbEL.Size = new System.Drawing.Size(138, 25);
            this.LbEL.TabIndex = 0;
            this.LbEL.Text = "Employee\'s List";
            this.LbEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGVEmpsList
            // 
            this.DGVEmpsList.AllowUserToAddRows = false;
            this.DGVEmpsList.AllowUserToDeleteRows = false;
            this.DGVEmpsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVEmpsList.BackgroundColor = System.Drawing.Color.DimGray;
            this.DGVEmpsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVEmpsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVEmpsList.ColumnHeadersHeight = 34;
            this.DGVEmpsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVEmpsList.EnableHeadersVisualStyles = false;
            this.DGVEmpsList.Location = new System.Drawing.Point(5, 50);
            this.DGVEmpsList.Name = "DGVEmpsList";
            this.DGVEmpsList.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.DGVEmpsList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVEmpsList.RowTemplate.Height = 28;
            this.DGVEmpsList.Size = new System.Drawing.Size(1140, 220);
            this.DGVEmpsList.TabIndex = 8;
            this.DGVEmpsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEmpsList_CellClick);
            // 
            // Pnl2
            // 
            this.Pnl2.BackColor = System.Drawing.Color.SaddleBrown;
            this.Pnl2.Controls.Add(this.BtnClear);
            this.Pnl2.Controls.Add(this.BtnDelete);
            this.Pnl2.Controls.Add(this.BtnUpdate);
            this.Pnl2.Controls.Add(this.BtnInsert);
            this.Pnl2.Controls.Add(this.TxtBxSalary);
            this.Pnl2.Controls.Add(this.TxtbxPosition);
            this.Pnl2.Controls.Add(this.TxtBxFullName);
            this.Pnl2.Controls.Add(this.TxtBxEmpId);
            this.Pnl2.Controls.Add(this.LbEmpId);
            this.Pnl2.Controls.Add(this.label3);
            this.Pnl2.Controls.Add(this.label2);
            this.Pnl2.Controls.Add(this.label1);
            this.Pnl2.Location = new System.Drawing.Point(14, 340);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(1150, 290);
            this.Pnl2.TabIndex = 8;
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSize = true;
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnClear.Location = new System.Drawing.Point(901, 147);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(200, 45);
            this.BtnClear.TabIndex = 44;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = true;
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Enabled = false;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnDelete.Location = new System.Drawing.Point(656, 147);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(200, 45);
            this.BtnDelete.TabIndex = 42;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Visible = false;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.AutoSize = true;
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnUpdate.Location = new System.Drawing.Point(901, 77);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(200, 45);
            this.BtnUpdate.TabIndex = 41;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.AutoSize = true;
            this.BtnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsert.Enabled = false;
            this.BtnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsert.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsert.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnInsert.Location = new System.Drawing.Point(654, 77);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(200, 45);
            this.BtnInsert.TabIndex = 39;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Visible = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // TxtBxSalary
            // 
            this.TxtBxSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxSalary.Location = new System.Drawing.Point(162, 221);
            this.TxtBxSalary.Name = "TxtBxSalary";
            this.TxtBxSalary.Size = new System.Drawing.Size(300, 37);
            this.TxtBxSalary.TabIndex = 38;
            // 
            // TxtbxPosition
            // 
            this.TxtbxPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxPosition.Location = new System.Drawing.Point(162, 157);
            this.TxtbxPosition.Name = "TxtbxPosition";
            this.TxtbxPosition.Size = new System.Drawing.Size(300, 37);
            this.TxtbxPosition.TabIndex = 37;
            // 
            // TxtBxFullName
            // 
            this.TxtBxFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxFullName.Location = new System.Drawing.Point(162, 93);
            this.TxtBxFullName.Name = "TxtBxFullName";
            this.TxtBxFullName.Size = new System.Drawing.Size(400, 37);
            this.TxtBxFullName.TabIndex = 36;
            // 
            // TxtBxEmpId
            // 
            this.TxtBxEmpId.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxEmpId.Location = new System.Drawing.Point(162, 29);
            this.TxtBxEmpId.Name = "TxtBxEmpId";
            this.TxtBxEmpId.Size = new System.Drawing.Size(300, 37);
            this.TxtBxEmpId.TabIndex = 35;
            // 
            // LbEmpId
            // 
            this.LbEmpId.AutoSize = true;
            this.LbEmpId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbEmpId.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmpId.ForeColor = System.Drawing.Color.Snow;
            this.LbEmpId.Location = new System.Drawing.Point(32, 37);
            this.LbEmpId.Name = "LbEmpId";
            this.LbEmpId.Size = new System.Drawing.Size(124, 23);
            this.LbEmpId.TabIndex = 4;
            this.LbEmpId.Text = "Employee Id";
            this.LbEmpId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(32, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Full Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(32, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Position";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(32, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salary";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormEmpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.Pnl1);
            this.Controls.Add(this.LbDashBoard);
            this.MaximizeBox = false;
            this.Name = "FormEmpList";
            this.Text = "EmpList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmpList_FormClosing);
            this.Load += new System.EventHandler(this.FormEmpList_Load);
            this.Pnl1.ResumeLayout(false);
            this.Pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpsList)).EndInit();
            this.Pnl2.ResumeLayout(false);
            this.Pnl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbDashBoard;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Label LbEL;
        private System.Windows.Forms.DataGridView DGVEmpsList;
        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.Label LbEmpId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBxSalary;
        private System.Windows.Forms.TextBox TxtbxPosition;
        private System.Windows.Forms.TextBox TxtBxFullName;
        private System.Windows.Forms.TextBox TxtBxEmpId;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnInsert;
    }
}