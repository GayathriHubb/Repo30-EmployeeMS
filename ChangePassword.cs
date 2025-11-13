using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMS
{
    public partial class FormChangePswrd : Form
    {
        public FormChangePswrd()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\EmployeeMS\Employees.mdf;Integrated Security = True";

        private void BtnChange_Click(object sender, EventArgs e)
        {
            string getun = EmployeesData.Username;

            if (TxtBxNewPswrd.Text == string.Empty || TxtBxCnfrmPswrd.Text == string.Empty)
            {
                MessageBox.Show("Please Fill The Fields", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else if (TxtBxNewPswrd.Text.Length < 8)
            {
                MessageBox.Show("Invalid Password.. Password Must be atleast 8 characters", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (TxtBxNewPswrd.Text != TxtBxCnfrmPswrd.Text)
            {
                MessageBox.Show("Passwords Does Not Match", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string upddata = "Update Users Set Password = @pswd, DatePswrdLastChange = @dtpswdchng Where Username = @un";

                        using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                        {
                            updcmd.Parameters.AddWithValue("@pswd", TxtBxNewPswrd.Text.Trim());
                            updcmd.Parameters.AddWithValue("@dtpswdchng", DateTime.Today);
                            updcmd.Parameters.AddWithValue("@un", getun);

                            updcmd.ExecuteNonQuery();

                            MessageBox.Show("Password Changed Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                            Form1Login login = new Form1Login();
                            login.Show();
                            Hide();
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "BtnChange - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormForgotPswrd frmfrgtpswrd = new FormForgotPswrd();
            frmfrgtpswrd.ShowDialog();
            Hide();
        }

        private void ChkBxPswrd_CheckedChanged(object sender, EventArgs e)
        {
            TxtBxNewPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
            TxtBxCnfrmPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
        }
    }
}
