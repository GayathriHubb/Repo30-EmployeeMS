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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\EmployeeMS\Employees.mdf;Integrated Security = True";

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (TxtBxUsername.Text == string.Empty || TxtBxPswrd.Text == string.Empty || TxtBxCnfrmPswrd.Text == string.Empty || CmbBxSecQsns.SelectedIndex == -1 || TxtBxSecAns.Text == string.Empty)
            {
                MessageBox.Show("All Fields Are Required To Be Filled", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string checkun = "Select Count(*) From Users Where Username = @un";

                        using (SqlCommand uncmd = new SqlCommand(checkun, sqlcon))
                        {
                            uncmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                            int rowcount = 0;
                            object result = uncmd.ExecuteScalar();
                            if (result != DBNull.Value)
                            {
                                rowcount = Convert.ToInt32(result);
                            }

                            if (rowcount > 0)
                            {
                                string tempun = $"{TxtBxUsername.Text.Substring(0, 1).ToUpper()}{TxtBxUsername.Text.Substring(1)}";
                                MessageBox.Show($"Username: {tempun} is Existing Already", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            }
                            else if (TxtBxPswrd.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid Password.. Password Must be 8 characters or up", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                            else if (TxtBxPswrd.Text != TxtBxCnfrmPswrd.Text)
                            {
                                MessageBox.Show("Passwords Does Not Match", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insdata = "Insert Into Users (Username, Password, Question, Answer, DateRegister) Values (@un, @pswd, @qsn, @ans, @dtcrtd)";

                                using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                                {
                                    inscmd.Parameters.AddWithValue("@un", TxtBxUsername.Text);
                                    inscmd.Parameters.AddWithValue("@pswd", TxtBxPswrd.Text.Trim());
                                    inscmd.Parameters.AddWithValue("@qsn", CmbBxSecQsns.Text.Trim());
                                    inscmd.Parameters.AddWithValue("@ans", TxtBxSecAns.Text.Trim());
                                    inscmd.Parameters.AddWithValue("@dtcrtd", DateTime.Today);

                                    inscmd.ExecuteNonQuery();

                                    MessageBox.Show("Registration Successfull", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                    Form1Login login = new Form1Login();
                                    login.Show();
                                    Hide();
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "BtnSignUp - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBxUsername.Text = string.Empty;
            TxtBxPswrd.Text = string.Empty;
            TxtBxCnfrmPswrd.Text= string.Empty;
        }

        private void BtnSignin_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            login.Show();
        }

        private void ChkBxPswrd_CheckedChanged(object sender, EventArgs e)
        {
            TxtBxPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
            TxtBxCnfrmPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
        }

        private void FormRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
