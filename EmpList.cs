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
    public partial class FormEmpList : Form
    {
        public FormEmpList()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\EmployeeMS\Employees.mdf;Integrated Security = True";

        private void FormEmpList_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeForm homeform = new HomeForm();
            homeform.Show();
        }

        private void FormEmpList_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DisplayEmployees();
                    DisableFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load -Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            } 
            if (!IsValidSalary(TxtBxSalary.Text, out int salary))
            {
                MessageBox.Show("Please enter a valid non-negative integer for Salary.", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if(CheckEmptyFields())
            {
                MessageBox.Show("Please select an Employee to update.", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidSalary(TxtBxSalary.Text, out int salary))
            {
                MessageBox.Show("Please Enter a Valid non-negative Integer for Salary.", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string empid = TxtBxEmpId.Text.Trim();
                DialogResult dr = MessageBox.Show($"Are you Sure you want to Update the EmpId: {empid}?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();
                            string updata = "Update Employees Set Salary = @Salary, DateUpdate = @DateUpdate Where EmployeeId = @EmployeeId";

                            using (SqlCommand upcmd = new SqlCommand(updata, sqlcon))
                            {
                                upcmd.Parameters.AddWithValue("@Salary", salary);
                                upcmd.Parameters.AddWithValue("@DateUpdate", DateTime.Now);
                                upcmd.Parameters.AddWithValue("@EmployeeId", empid);
                                upcmd.ExecuteNonQuery();

                                EmployeesData.Salary = salary;
                            }
                            DisplayEmployees();
                            MessageBox.Show("Employee Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Update - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void DGVEmpsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.DGVEmpsList.Rows[e.RowIndex];

                    TxtBxEmpId.Text = row.Cells["EmployeeId"].Value.ToString();
                    TxtBxFullName.Text = row.Cells["Name"].Value.ToString();
                    TxtbxPosition.Text = row.Cells["Position"].Value.ToString();
                    TxtBxSalary.Text = row.Cells["Salary"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DGV Cell Click - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public void DisplayEmployees()
        {
            EmployeesList empslist = new EmployeesList();
            DGVEmpsList.DataSource = empslist.ListEmployees();
        }

        private void ClearFields()
        {
            TxtBxEmpId.Text = string.Empty;
            TxtBxFullName.Text = string.Empty;
            TxtbxPosition.Text = string.Empty;
            TxtBxSalary.Text = string.Empty;
        } 
        
        private bool CheckEmptyFields()
        {
            if (string.IsNullOrWhiteSpace(TxtBxEmpId.Text) ||
                string.IsNullOrWhiteSpace(TxtBxFullName.Text) ||
                string.IsNullOrWhiteSpace(TxtbxPosition.Text) ||
                string.IsNullOrWhiteSpace(TxtBxSalary.Text))
            {
                return true;
            }
            return false;
        }   

        private bool IsValidSalary(string salarytext, out int salary)
        {
            if (int.TryParse(salarytext, out salary))
            {
                if (salary >= 0)
                {
                    return true;
                }
            }
            return false;
        }
        private void DisableFields()
        {
            TxtBxEmpId.Enabled = false;
            TxtBxFullName.Enabled = false;
            TxtbxPosition.Enabled = false;
        }

        
    }
}
