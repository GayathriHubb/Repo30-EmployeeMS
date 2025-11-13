namespace EmployeeMS
{
    partial class FormChangePswrd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePswrd));
            this.ChkBxPswrd = new System.Windows.Forms.CheckBox();
            this.BtnChange = new System.Windows.Forms.Button();
            this.LbCnfrmPswrd = new System.Windows.Forms.Label();
            this.TxtBxCnfrmPswrd = new System.Windows.Forms.TextBox();
            this.LbUsername = new System.Windows.Forms.Label();
            this.TxtBxNewPswrd = new System.Windows.Forms.TextBox();
            this.LbHeading = new System.Windows.Forms.Label();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChkBxPswrd
            // 
            this.ChkBxPswrd.AutoSize = true;
            this.ChkBxPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxPswrd.Location = new System.Drawing.Point(154, 290);
            this.ChkBxPswrd.Name = "ChkBxPswrd";
            this.ChkBxPswrd.Size = new System.Drawing.Size(179, 32);
            this.ChkBxPswrd.TabIndex = 37;
            this.ChkBxPswrd.Text = "Show Password";
            this.ChkBxPswrd.UseVisualStyleBackColor = true;
            this.ChkBxPswrd.CheckedChanged += new System.EventHandler(this.ChkBxPswrd_CheckedChanged);
            // 
            // BtnChange
            // 
            this.BtnChange.AutoSize = true;
            this.BtnChange.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChange.ForeColor = System.Drawing.Color.Linen;
            this.BtnChange.Location = new System.Drawing.Point(239, 382);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(300, 50);
            this.BtnChange.TabIndex = 1;
            this.BtnChange.Text = "CHANGE";
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // LbCnfrmPswrd
            // 
            this.LbCnfrmPswrd.AutoSize = true;
            this.LbCnfrmPswrd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCnfrmPswrd.Location = new System.Drawing.Point(45, 200);
            this.LbCnfrmPswrd.Name = "LbCnfrmPswrd";
            this.LbCnfrmPswrd.Size = new System.Drawing.Size(213, 28);
            this.LbCnfrmPswrd.TabIndex = 35;
            this.LbCnfrmPswrd.Text = "Confirm Password";
            this.LbCnfrmPswrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxCnfrmPswrd
            // 
            this.TxtBxCnfrmPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCnfrmPswrd.Location = new System.Drawing.Point(45, 238);
            this.TxtBxCnfrmPswrd.Name = "TxtBxCnfrmPswrd";
            this.TxtBxCnfrmPswrd.Size = new System.Drawing.Size(300, 37);
            this.TxtBxCnfrmPswrd.TabIndex = 4;
            this.TxtBxCnfrmPswrd.UseSystemPasswordChar = true;
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsername.Location = new System.Drawing.Point(45, 98);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(171, 28);
            this.LbUsername.TabIndex = 33;
            this.LbUsername.Text = "New Password";
            this.LbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxNewPswrd
            // 
            this.TxtBxNewPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxNewPswrd.Location = new System.Drawing.Point(45, 136);
            this.TxtBxNewPswrd.Name = "TxtBxNewPswrd";
            this.TxtBxNewPswrd.Size = new System.Drawing.Size(300, 37);
            this.TxtBxNewPswrd.TabIndex = 3;
            this.TxtBxNewPswrd.UseSystemPasswordChar = true;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.LbHeading.ForeColor = System.Drawing.Color.Brown;
            this.LbHeading.Location = new System.Drawing.Point(233, 22);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(313, 37);
            this.LbHeading.TabIndex = 31;
            this.LbHeading.Text = "CHANGE PASSWORD";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "BackWhite.png");
            // 
            // BtnBack
            // 
            this.BtnBack.AutoSize = true;
            this.BtnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.Linen;
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBack.ImageIndex = 0;
            this.BtnBack.ImageList = this.ImageList1;
            this.BtnBack.Location = new System.Drawing.Point(239, 572);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(300, 50);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "BACK";
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FormChangePswrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(778, 644);
            this.Controls.Add(this.ChkBxPswrd);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.LbCnfrmPswrd);
            this.Controls.Add(this.TxtBxCnfrmPswrd);
            this.Controls.Add(this.LbUsername);
            this.Controls.Add(this.TxtBxNewPswrd);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormChangePswrd";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkBxPswrd;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Label LbCnfrmPswrd;
        private System.Windows.Forms.TextBox TxtBxCnfrmPswrd;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.TextBox TxtBxNewPswrd;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.ImageList ImageList1;
    }
}