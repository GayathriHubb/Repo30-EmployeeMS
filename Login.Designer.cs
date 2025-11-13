namespace EmployeeMS
{
    partial class Form1Login
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
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.LbFrgtPswrd = new System.Windows.Forms.Label();
            this.LbLogin = new System.Windows.Forms.Label();
            this.PicBxUser = new System.Windows.Forms.PictureBox();
            this.ChkBxPswrd = new System.Windows.Forms.CheckBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LbNoAcc = new System.Windows.Forms.Label();
            this.LbPassword = new System.Windows.Forms.Label();
            this.LbUsername = new System.Windows.Forms.Label();
            this.TxtBxUsername = new System.Windows.Forms.TextBox();
            this.TxtBxPswrd = new System.Windows.Forms.TextBox();
            this.LbHeading = new System.Windows.Forms.Label();
            this.Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl1
            // 
            this.Pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Pnl1.Controls.Add(this.LbFrgtPswrd);
            this.Pnl1.Controls.Add(this.LbLogin);
            this.Pnl1.Controls.Add(this.PicBxUser);
            this.Pnl1.Controls.Add(this.ChkBxPswrd);
            this.Pnl1.Controls.Add(this.BtnRegister);
            this.Pnl1.Controls.Add(this.BtnClear);
            this.Pnl1.Controls.Add(this.BtnLogin);
            this.Pnl1.Controls.Add(this.LbNoAcc);
            this.Pnl1.Controls.Add(this.LbPassword);
            this.Pnl1.Controls.Add(this.LbUsername);
            this.Pnl1.Controls.Add(this.TxtBxUsername);
            this.Pnl1.Controls.Add(this.TxtBxPswrd);
            this.Pnl1.Location = new System.Drawing.Point(29, 80);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(820, 550);
            this.Pnl1.TabIndex = 1;
            // 
            // LbFrgtPswrd
            // 
            this.LbFrgtPswrd.AutoSize = true;
            this.LbFrgtPswrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LbFrgtPswrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LbFrgtPswrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbFrgtPswrd.Font = new System.Drawing.Font("Cambria", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LbFrgtPswrd.ForeColor = System.Drawing.Color.Navy;
            this.LbFrgtPswrd.Location = new System.Drawing.Point(505, 172);
            this.LbFrgtPswrd.Name = "LbFrgtPswrd";
            this.LbFrgtPswrd.Size = new System.Drawing.Size(174, 23);
            this.LbFrgtPswrd.TabIndex = 7;
            this.LbFrgtPswrd.Text = "Forgot Password ?";
            this.LbFrgtPswrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbFrgtPswrd.Click += new System.EventHandler(this.LbFrgtPswrd_Click);
            // 
            // LbLogin
            // 
            this.LbLogin.AutoSize = true;
            this.LbLogin.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLogin.ForeColor = System.Drawing.Color.DarkRed;
            this.LbLogin.Location = new System.Drawing.Point(27, 105);
            this.LbLogin.Name = "LbLogin";
            this.LbLogin.Size = new System.Drawing.Size(96, 33);
            this.LbLogin.TabIndex = 10;
            this.LbLogin.Text = "LOGIN";
            this.LbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PicBxUser
            // 
            this.PicBxUser.Image = global::EmployeeMS.Properties.Resources.User;
            this.PicBxUser.Location = new System.Drawing.Point(35, 20);
            this.PicBxUser.Name = "PicBxUser";
            this.PicBxUser.Size = new System.Drawing.Size(80, 80);
            this.PicBxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxUser.TabIndex = 9;
            this.PicBxUser.TabStop = false;
            // 
            // ChkBxPswrd
            // 
            this.ChkBxPswrd.AutoSize = true;
            this.ChkBxPswrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ChkBxPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxPswrd.Location = new System.Drawing.Point(487, 135);
            this.ChkBxPswrd.Name = "ChkBxPswrd";
            this.ChkBxPswrd.Size = new System.Drawing.Size(192, 34);
            this.ChkBxPswrd.TabIndex = 6;
            this.ChkBxPswrd.Text = "Show Password";
            this.ChkBxPswrd.UseVisualStyleBackColor = false;
            this.ChkBxPswrd.CheckedChanged += new System.EventHandler(this.ChkBxPswrd_CheckedChanged);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRegister.AutoSize = true;
            this.BtnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegister.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnRegister.Location = new System.Drawing.Point(308, 420);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(300, 50);
            this.BtnRegister.TabIndex = 3;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSize = true;
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnClear.Location = new System.Drawing.Point(485, 257);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(200, 45);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.AutoSize = true;
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnLogin.Location = new System.Drawing.Point(254, 257);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(200, 45);
            this.BtnLogin.TabIndex = 1;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LbNoAcc
            // 
            this.LbNoAcc.AutoSize = true;
            this.LbNoAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(5)))));
            this.LbNoAcc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNoAcc.Location = new System.Drawing.Point(358, 375);
            this.LbNoAcc.Name = "LbNoAcc";
            this.LbNoAcc.Size = new System.Drawing.Size(201, 32);
            this.LbNoAcc.TabIndex = 4;
            this.LbNoAcc.Text = "No Account Yet ?";
            this.LbNoAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LbPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassword.Location = new System.Drawing.Point(239, 89);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(118, 28);
            this.LbPassword.TabIndex = 3;
            this.LbPassword.Text = "Password";
            this.LbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LbUsername.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsername.Location = new System.Drawing.Point(238, 35);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(124, 28);
            this.LbUsername.TabIndex = 2;
            this.LbUsername.Text = "Username";
            this.LbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxUsername
            // 
            this.TxtBxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUsername.Location = new System.Drawing.Point(379, 31);
            this.TxtBxUsername.Name = "TxtBxUsername";
            this.TxtBxUsername.Size = new System.Drawing.Size(300, 37);
            this.TxtBxUsername.TabIndex = 4;
            // 
            // TxtBxPswrd
            // 
            this.TxtBxPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPswrd.Location = new System.Drawing.Point(379, 85);
            this.TxtBxPswrd.Name = "TxtBxPswrd";
            this.TxtBxPswrd.Size = new System.Drawing.Size(300, 37);
            this.TxtBxPswrd.TabIndex = 5;
            this.TxtBxPswrd.UseSystemPasswordChar = true;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.DimGray;
            this.LbHeading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbHeading.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.Gold;
            this.LbHeading.Location = new System.Drawing.Point(211, 10);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(457, 33);
            this.LbHeading.TabIndex = 4;
            this.LbHeading.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = global::EmployeeMS.Properties.Resources.ConferenceRoom;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.Pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1Login";
            this.Text = "Login";
            this.Pnl1.ResumeLayout(false);
            this.Pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Label LbFrgtPswrd;
        private System.Windows.Forms.Label LbLogin;
        private System.Windows.Forms.PictureBox PicBxUser;
        private System.Windows.Forms.CheckBox ChkBxPswrd;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LbNoAcc;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.TextBox TxtBxUsername;
        private System.Windows.Forms.TextBox TxtBxPswrd;
        private System.Windows.Forms.Label LbHeading;
    }
}

