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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\EmployeeMS\Employees.mdf;Integrated Security = True";

        private void FormDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeForm homeform = new HomeForm();
            homeform.Show();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DisplayTotalEmps();
                    DisplayActiveEmps();
                    DisplayInactiveEmps();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
        public void DisplayTotalEmps()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring)) 
            {
                try
                {
                    sqlcon.Open();
                    string seldata = "Select Count(Id) From Employees";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        object result = selcmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            LbTotEmpsCnt.Text = result.ToString();
                        }
                    }
                } 
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "DispTotEmps - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        public void DisplayActiveEmps()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    string seldata = "Select Count(Id) From Employees Where Status = @status";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@status", "Active");
                        object result = selcmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            LbActEmpsCnt.Text = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "DispActEmps - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        public void DisplayInactiveEmps() 
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    string seldata = "Select Count(Id) From Employees Where Status = @status";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@status", "Inactive");

                        object result = selcmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            LbInactEmpsCnt.Text = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "DispInactEmps - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}
