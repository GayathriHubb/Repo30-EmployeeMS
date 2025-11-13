namespace EmployeeMS
{
    partial class FormForgotPswrd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgotPswrd));
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.LbHeading = new System.Windows.Forms.Label();
            this.LbAns = new System.Windows.Forms.Label();
            this.LbQsn = new System.Windows.Forms.Label();
            this.LbUsername = new System.Windows.Forms.Label();
            this.TxtBxUsername = new System.Windows.Forms.TextBox();
            this.TxtBxSecAns = new System.Windows.Forms.TextBox();
            this.CmbBxSecQsns = new System.Windows.Forms.ComboBox();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.ForeColor = System.Drawing.Color.Linen;
            this.BtnConfirm.Location = new System.Drawing.Point(239, 427);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(300, 50);
            this.BtnConfirm.TabIndex = 31;
            this.BtnConfirm.Text = "CONFIRM";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.LbHeading.ForeColor = System.Drawing.Color.Brown;
            this.LbHeading.Location = new System.Drawing.Point(234, 22);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(311, 37);
            this.LbHeading.TabIndex = 30;
            this.LbHeading.Text = "FORGOT PASSWORD";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbAns
            // 
            this.LbAns.AutoSize = true;
            this.LbAns.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAns.Location = new System.Drawing.Point(36, 302);
            this.LbAns.Name = "LbAns";
            this.LbAns.Size = new System.Drawing.Size(95, 28);
            this.LbAns.TabIndex = 29;
            this.LbAns.Text = "Answer";
            this.LbAns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbQsn
            // 
            this.LbQsn.AutoSize = true;
            this.LbQsn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbQsn.Location = new System.Drawing.Point(36, 202);
            this.LbQsn.Name = "LbQsn";
            this.LbQsn.Size = new System.Drawing.Size(112, 28);
            this.LbQsn.TabIndex = 28;
            this.LbQsn.Text = "Question";
            this.LbQsn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsername.Location = new System.Drawing.Point(36, 102);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(124, 28);
            this.LbUsername.TabIndex = 27;
            this.LbUsername.Text = "Username";
            this.LbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxUsername
            // 
            this.TxtBxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUsername.Location = new System.Drawing.Point(36, 140);
            this.TxtBxUsername.Name = "TxtBxUsername";
            this.TxtBxUsername.Size = new System.Drawing.Size(300, 37);
            this.TxtBxUsername.TabIndex = 26;
            // 
            // TxtBxSecAns
            // 
            this.TxtBxSecAns.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxSecAns.Location = new System.Drawing.Point(36, 340);
            this.TxtBxSecAns.Name = "TxtBxSecAns";
            this.TxtBxSecAns.Size = new System.Drawing.Size(300, 34);
            this.TxtBxSecAns.TabIndex = 25;
            // 
            // CmbBxSecQsns
            // 
            this.CmbBxSecQsns.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxSecQsns.FormattingEnabled = true;
            this.CmbBxSecQsns.Items.AddRange(new object[] {
            "What is your favorite Color ?",
            "What is your favorite Place ?",
            "What is your Nickname ?",
            "What is your Alma Mater ?"});
            this.CmbBxSecQsns.Location = new System.Drawing.Point(36, 240);
            this.CmbBxSecQsns.Name = "CmbBxSecQsns";
            this.CmbBxSecQsns.Size = new System.Drawing.Size(400, 36);
            this.CmbBxSecQsns.TabIndex = 24;
            this.CmbBxSecQsns.Text = "Select Questions";
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "BackWhite.png");
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.Linen;
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBack.ImageIndex = 0;
            this.BtnBack.ImageList = this.ImageList1;
            this.BtnBack.Location = new System.Drawing.Point(239, 573);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(300, 50);
            this.BtnBack.TabIndex = 32;
            this.BtnBack.Text = "BACK";
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FormForgotPswrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(778, 644);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.LbAns);
            this.Controls.Add(this.LbQsn);
            this.Controls.Add(this.LbUsername);
            this.Controls.Add(this.TxtBxUsername);
            this.Controls.Add(this.TxtBxSecAns);
            this.Controls.Add(this.CmbBxSecQsns);
            this.MaximizeBox = false;
            this.Name = "FormForgotPswrd";
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Label LbAns;
        private System.Windows.Forms.Label LbQsn;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.TextBox TxtBxUsername;
        private System.Windows.Forms.TextBox TxtBxSecAns;
        private System.Windows.Forms.ComboBox CmbBxSecQsns;
        private System.Windows.Forms.ImageList ImageList1;
    }
}