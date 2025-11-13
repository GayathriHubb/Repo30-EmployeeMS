namespace EmployeeMS
{
    partial class FormEmpData
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
            this.LbEmpData = new System.Windows.Forms.Label();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.LbED = new System.Windows.Forms.Label();
            this.DGVEmpData = new System.Windows.Forms.DataGridView();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.TxtBxSalary = new System.Windows.Forms.TextBox();
            this.LbSalary = new System.Windows.Forms.Label();
            this.BtnPhoto = new System.Windows.Forms.Button();
            this.PnlPhoto = new System.Windows.Forms.Panel();
            this.PicBxPhoto = new System.Windows.Forms.PictureBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.CmbBxStatus = new System.Windows.Forms.ComboBox();
            this.CmbBxPosition = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbBxGender = new System.Windows.Forms.ComboBox();
            this.TxtBxPhnNum = new System.Windows.Forms.TextBox();
            this.TxtBxFullName = new System.Windows.Forms.TextBox();
            this.TxtBxEmpId = new System.Windows.Forms.TextBox();
            this.LbEmpId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ofd = new System.Windows.Forms.OpenFileDialog();
            this.Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpData)).BeginInit();
            this.Pnl2.SuspendLayout();
            this.PnlPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // LbEmpData
            // 
            this.LbEmpData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbEmpData.AutoSize = true;
            this.LbEmpData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbEmpData.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmpData.ForeColor = System.Drawing.Color.Firebrick;
            this.LbEmpData.Location = new System.Drawing.Point(492, 10);
            this.LbEmpData.Name = "LbEmpData";
            this.LbEmpData.Size = new System.Drawing.Size(208, 28);
            this.LbEmpData.TabIndex = 5;
            this.LbEmpData.Text = "EMPLOYEES DATA";
            this.LbEmpData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl1
            // 
            this.Pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl1.BackColor = System.Drawing.Color.SaddleBrown;
            this.Pnl1.Controls.Add(this.LbED);
            this.Pnl1.Controls.Add(this.DGVEmpData);
            this.Pnl1.Location = new System.Drawing.Point(12, 50);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(1150, 280);
            this.Pnl1.TabIndex = 6;
            // 
            // LbED
            // 
            this.LbED.AutoSize = true;
            this.LbED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbED.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbED.ForeColor = System.Drawing.Color.Snow;
            this.LbED.Location = new System.Drawing.Point(13, 12);
            this.LbED.Name = "LbED";
            this.LbED.Size = new System.Drawing.Size(147, 25);
            this.LbED.TabIndex = 0;
            this.LbED.Text = "Employee\'s Data";
            this.LbED.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGVEmpData
            // 
            this.DGVEmpData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVEmpData.BackgroundColor = System.Drawing.Color.DimGray;
            this.DGVEmpData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVEmpData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVEmpData.ColumnHeadersHeight = 34;
            this.DGVEmpData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVEmpData.EnableHeadersVisualStyles = false;
            this.DGVEmpData.Location = new System.Drawing.Point(5, 50);
            this.DGVEmpData.Name = "DGVEmpData";
            this.DGVEmpData.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.DGVEmpData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVEmpData.RowTemplate.Height = 28;
            this.DGVEmpData.Size = new System.Drawing.Size(1140, 220);
            this.DGVEmpData.TabIndex = 8;
            this.DGVEmpData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEmpData_CellClick);
            // 
            // Pnl2
            // 
            this.Pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl2.BackColor = System.Drawing.Color.SaddleBrown;
            this.Pnl2.Controls.Add(this.TxtBxSalary);
            this.Pnl2.Controls.Add(this.LbSalary);
            this.Pnl2.Controls.Add(this.BtnPhoto);
            this.Pnl2.Controls.Add(this.PnlPhoto);
            this.Pnl2.Controls.Add(this.BtnClear);
            this.Pnl2.Controls.Add(this.BtnDelete);
            this.Pnl2.Controls.Add(this.BtnUpdate);
            this.Pnl2.Controls.Add(this.BtnInsert);
            this.Pnl2.Controls.Add(this.CmbBxStatus);
            this.Pnl2.Controls.Add(this.CmbBxPosition);
            this.Pnl2.Controls.Add(this.label4);
            this.Pnl2.Controls.Add(this.label5);
            this.Pnl2.Controls.Add(this.CmbBxGender);
            this.Pnl2.Controls.Add(this.TxtBxPhnNum);
            this.Pnl2.Controls.Add(this.TxtBxFullName);
            this.Pnl2.Controls.Add(this.TxtBxEmpId);
            this.Pnl2.Controls.Add(this.LbEmpId);
            this.Pnl2.Controls.Add(this.label3);
            this.Pnl2.Controls.Add(this.label2);
            this.Pnl2.Controls.Add(this.label1);
            this.Pnl2.Location = new System.Drawing.Point(12, 340);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(1150, 290);
            this.Pnl2.TabIndex = 7;
            // 
            // TxtBxSalary
            // 
            this.TxtBxSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtBxSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxSalary.Location = new System.Drawing.Point(154, 193);
            this.TxtBxSalary.Name = "TxtBxSalary";
            this.TxtBxSalary.Size = new System.Drawing.Size(300, 37);
            this.TxtBxSalary.TabIndex = 59;
            // 
            // LbSalary
            // 
            this.LbSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbSalary.AutoSize = true;
            this.LbSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbSalary.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSalary.ForeColor = System.Drawing.Color.Snow;
            this.LbSalary.Location = new System.Drawing.Point(24, 200);
            this.LbSalary.Name = "LbSalary";
            this.LbSalary.Size = new System.Drawing.Size(68, 23);
            this.LbSalary.TabIndex = 58;
            this.LbSalary.Text = "Salary";
            this.LbSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnPhoto
            // 
            this.BtnPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPhoto.AutoSize = true;
            this.BtnPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.BtnPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPhoto.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPhoto.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnPhoto.Location = new System.Drawing.Point(935, 190);
            this.BtnPhoto.Name = "BtnPhoto";
            this.BtnPhoto.Size = new System.Drawing.Size(196, 45);
            this.BtnPhoto.TabIndex = 57;
            this.BtnPhoto.Text = "Employee Photo";
            this.BtnPhoto.UseVisualStyleBackColor = false;
            this.BtnPhoto.Click += new System.EventHandler(this.BtnPhoto_Click);
            // 
            // PnlPhoto
            // 
            this.PnlPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlPhoto.Controls.Add(this.PicBxPhoto);
            this.PnlPhoto.Location = new System.Drawing.Point(958, 32);
            this.PnlPhoto.Name = "PnlPhoto";
            this.PnlPhoto.Size = new System.Drawing.Size(150, 150);
            this.PnlPhoto.TabIndex = 56;
            // 
            // PicBxPhoto
            // 
            this.PicBxPhoto.BackColor = System.Drawing.Color.DimGray;
            this.PicBxPhoto.Location = new System.Drawing.Point(0, 0);
            this.PicBxPhoto.Name = "PicBxPhoto";
            this.PicBxPhoto.Size = new System.Drawing.Size(150, 150);
            this.PicBxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxPhoto.TabIndex = 0;
            this.PicBxPhoto.TabStop = false;
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnClear.AutoSize = true;
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnClear.Location = new System.Drawing.Point(566, 246);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(120, 38);
            this.BtnClear.TabIndex = 55;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelete.AutoSize = true;
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnDelete.Location = new System.Drawing.Point(389, 246);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(120, 38);
            this.BtnDelete.TabIndex = 54;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnUpdate.AutoSize = true;
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnUpdate.Location = new System.Drawing.Point(212, 246);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(120, 38);
            this.BtnUpdate.TabIndex = 53;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnInsert.AutoSize = true;
            this.BtnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsert.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsert.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnInsert.Location = new System.Drawing.Point(35, 246);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(120, 38);
            this.BtnInsert.TabIndex = 52;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // CmbBxStatus
            // 
            this.CmbBxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbBxStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxStatus.FormattingEnabled = true;
            this.CmbBxStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.CmbBxStatus.Location = new System.Drawing.Point(666, 147);
            this.CmbBxStatus.Name = "CmbBxStatus";
            this.CmbBxStatus.Size = new System.Drawing.Size(200, 33);
            this.CmbBxStatus.TabIndex = 51;
            // 
            // CmbBxPosition
            // 
            this.CmbBxPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbBxPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxPosition.FormattingEnabled = true;
            this.CmbBxPosition.Items.AddRange(new object[] {
            "Business Management",
            "FronEnd Developer",
            "BackEnd Developer",
            "Full Stack Developer",
            "Data Administrator",
            "Content Writer",
            "UX/UI Design"});
            this.CmbBxPosition.Location = new System.Drawing.Point(666, 87);
            this.CmbBxPosition.Name = "CmbBxPosition";
            this.CmbBxPosition.Size = new System.Drawing.Size(260, 33);
            this.CmbBxPosition.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(576, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 49;
            this.label4.Text = "Position";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(576, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "Status";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbBxGender
            // 
            this.CmbBxGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbBxGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxGender.FormattingEnabled = true;
            this.CmbBxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.CmbBxGender.Location = new System.Drawing.Point(665, 25);
            this.CmbBxGender.Name = "CmbBxGender";
            this.CmbBxGender.Size = new System.Drawing.Size(200, 33);
            this.CmbBxGender.TabIndex = 47;
            // 
            // TxtBxPhnNum
            // 
            this.TxtBxPhnNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtBxPhnNum.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPhnNum.Location = new System.Drawing.Point(154, 138);
            this.TxtBxPhnNum.Name = "TxtBxPhnNum";
            this.TxtBxPhnNum.Size = new System.Drawing.Size(300, 37);
            this.TxtBxPhnNum.TabIndex = 46;
            // 
            // TxtBxFullName
            // 
            this.TxtBxFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtBxFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxFullName.Location = new System.Drawing.Point(154, 83);
            this.TxtBxFullName.Name = "TxtBxFullName";
            this.TxtBxFullName.Size = new System.Drawing.Size(400, 37);
            this.TxtBxFullName.TabIndex = 44;
            // 
            // TxtBxEmpId
            // 
            this.TxtBxEmpId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtBxEmpId.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxEmpId.Location = new System.Drawing.Point(154, 28);
            this.TxtBxEmpId.Name = "TxtBxEmpId";
            this.TxtBxEmpId.Size = new System.Drawing.Size(300, 37);
            this.TxtBxEmpId.TabIndex = 43;
            // 
            // LbEmpId
            // 
            this.LbEmpId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbEmpId.AutoSize = true;
            this.LbEmpId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbEmpId.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmpId.ForeColor = System.Drawing.Color.Snow;
            this.LbEmpId.Location = new System.Drawing.Point(24, 35);
            this.LbEmpId.Name = "LbEmpId";
            this.LbEmpId.Size = new System.Drawing.Size(124, 23);
            this.LbEmpId.TabIndex = 42;
            this.LbEmpId.Text = "Employee Id";
            this.LbEmpId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Full Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(576, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Gender";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(24, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Phone No.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ofd
            // 
            this.Ofd.FileName = "Image File";
            // 
            // FormEmpData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.Pnl1);
            this.Controls.Add(this.LbEmpData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEmpData";
            this.Text = "Employee Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmpData_FormClosing);
            this.Load += new System.EventHandler(this.FormEmpData_Load);
            this.Pnl1.ResumeLayout(false);
            this.Pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpData)).EndInit();
            this.Pnl2.ResumeLayout(false);
            this.Pnl2.PerformLayout();
            this.PnlPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbEmpData;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.DataGridView DGVEmpData;
        private System.Windows.Forms.Label LbED;
        private System.Windows.Forms.TextBox TxtBxPhnNum;
        private System.Windows.Forms.TextBox TxtBxFullName;
        private System.Windows.Forms.TextBox TxtBxEmpId;
        private System.Windows.Forms.Label LbEmpId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbBxGender;
        private System.Windows.Forms.ComboBox CmbBxStatus;
        private System.Windows.Forms.ComboBox CmbBxPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnPhoto;
        private System.Windows.Forms.Panel PnlPhoto;
        private System.Windows.Forms.PictureBox PicBxPhoto;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.OpenFileDialog Ofd;
        private System.Windows.Forms.TextBox TxtBxSalary;
        private System.Windows.Forms.Label LbSalary;
    }
}