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
using System.IO;
using MethodsFW;

namespace EmployeeMS
{
    public partial class FormEmpData : Form
    {
        public FormEmpData()
        {
            InitializeComponent();
        }

        string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\EmployeeMS\Employees.mdf;Integrated Security = True";
        string path;
        private void FormEmpData_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeForm homeform = new HomeForm();
            homeform.Show();
        }

        private void FormEmpData_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DisplayEmployees();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load -Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        public void DisplayEmployees()
        {
            EmployeesDetails empslist = new EmployeesDetails();
            DGVEmpData.DataSource = empslist.ListEmployeesDetails();

            if (MaximizeBox == true)
            {
                DGVEmpData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                DGVEmpData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            }
        }

        private void BtnPhoto_Click(object sender, EventArgs e)
        {
            Ofd.Title = "Select Employee Photo";
            Ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";

            string imgpath = string.Empty;
            try
            {
                if (Ofd.ShowDialog() == DialogResult.OK)
                {
                    imgpath = Ofd.FileName;
                    PicBxPhoto.ImageLocation = Ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PicBx - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Please fill in all fields and select a photo.", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!Solutions.PhnNumInd(TxtBxPhnNum.Text))
            {
                MessageBox.Show("Invalid Input.. Please Enter a Valid Indian Phone Number.", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidSalary(TxtBxSalary.Text, out int salary))
            {
                MessageBox.Show("Please Enter a Valid non-negative Integer for Salary.", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string empid = TxtBxEmpId.Text.Trim().ToUpper();

                string basedirectory = AppDomain.CurrentDomain.BaseDirectory;   
                string relativepath = Path.Combine("EmpDirectory", $"{empid}.jpg");
                path = Path.Combine(basedirectory, relativepath);

                string directorypath = Path.GetDirectoryName(path);
                if (!Directory.Exists(directorypath))
                {
                    Directory.CreateDirectory(directorypath);
                }
                if (!string.IsNullOrEmpty(PicBxPhoto.ImageLocation))
                {
                    File.Copy(PicBxPhoto.ImageLocation, path, true);
                }   


                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    sqlcon.Open();

                    string chkempid = "Select Count(*) From Employees Where EmployeeId = @empid AND DateDelete IS NULL";

                    using (SqlCommand chkcmd = new SqlCommand(chkempid, sqlcon))
                    {
                        chkcmd.Parameters.AddWithValue("@empid", TxtBxEmpId.Text.Trim());
                        int count = (int)chkcmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Employee Id already exists. Please use a different Employee ID.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        string insertdata = "Insert into Employees (EmployeeId, FullName, Gender, ContactNum, Position, Salary, ImagePath, Status, DateInsert) " +
                                            "Values (@empid, @fname, @gender, @contactnum, @position, @salary, @imagepath, @status, @dateinsert)";

                        using (SqlCommand insertcmd = new SqlCommand(insertdata, sqlcon))
                        {
                            insertcmd.Parameters.AddWithValue("@empid", empid);
                            insertcmd.Parameters.AddWithValue("@fname", TxtBxFullName.Text.Trim());
                            insertcmd.Parameters.AddWithValue("@gender", CmbBxGender.Text.Trim());
                            insertcmd.Parameters.AddWithValue("@contactnum", TxtBxPhnNum.Text.Trim());
                            insertcmd.Parameters.AddWithValue("@position", CmbBxPosition.Text.Trim());
                            insertcmd.Parameters.AddWithValue("@salary", salary);
                            insertcmd.Parameters.AddWithValue("@imagepath", path ?? string.Empty);
                            insertcmd.Parameters.AddWithValue("@status", CmbBxStatus.Text.Trim());
                            insertcmd.Parameters.AddWithValue("@dateinsert", DateTime.Now);

                            insertcmd.ExecuteNonQuery();

                            DisplayEmployees();
                            MessageBox.Show("Employee Record Inserted successfully.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            ClearFields();
                        }
                    }
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Please fill in all Fields and Select a photo.", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!Solutions.PhnNumInd(TxtBxPhnNum.Text))
            {
                MessageBox.Show("Invalid Input.. Please Enter a Valid Indian Phone Number.", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidSalary(TxtBxSalary.Text, out int salary))
            {
                MessageBox.Show("Please Enter a Valid non-negative Integer for Salary.", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string empid = TxtBxEmpId.Text.Trim().ToUpper();
                DialogResult dr = MessageBox.Show($"Are You Sure You Want To Update Employee Id: {empid} ?", "Update Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    try
                    {
                        sqlcon.Open();

                        // Fetch existing image path from DB to avoid overwriting it when no new image is selected
                        string selectImageSql = "Select ImagePath From Employees Where EmployeeId = @empid AND DateDelete IS NULL";
                        string existingImagePath = string.Empty;
                        using (SqlCommand selCmd = new SqlCommand(selectImageSql, sqlcon))
                        {
                            selCmd.Parameters.AddWithValue("@empid", empid);
                            object result = selCmd.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                existingImagePath = result.ToString();
                            }
                        }

                        // Determine image path to save: use existing unless a new valid image was chosen
                        string imagePathToSave = existingImagePath;

                        if (!string.IsNullOrEmpty(PicBxPhoto.ImageLocation) && File.Exists(PicBxPhoto.ImageLocation))
                        {
                            try
                            {
                                string basedirectory = AppDomain.CurrentDomain.BaseDirectory;
                                string relativepath = Path.Combine("EmpDirectory", $"{empid}.jpg");
                                path = Path.Combine(basedirectory, relativepath);

                                string directorypath = Path.GetDirectoryName(path);
                                if (!Directory.Exists(directorypath))
                                {
                                    Directory.CreateDirectory(directorypath);
                                }

                                // Copy the chosen file into application directory (overwrite)
                                File.Copy(PicBxPhoto.ImageLocation, path, true);
                                imagePathToSave = path;

                                MessageBox.Show("Image Updated Successfully", "PicBx - Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "PicBx - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                // If image copy failed, keep existingImagePath to avoid writing an invalid path
                                imagePathToSave = existingImagePath;
                            }
                        }
                        // If no new image selected, imagePathToSave remains as existingImagePath (could be empty)

                        string updatedata = "Update Employees Set FullName = @fname, Gender = @gender, ContactNum = @contactnum, " +
                                                "Position = @position, Salary = @salary, ImagePath = @imagepath, Status = @status, DateUpdate = @dateupdate " +
                                                "Where EmployeeId = @empid AND DateDelete IS NULL";

                        using (SqlCommand updatecmd = new SqlCommand(updatedata, sqlcon))
                        {
                            updatecmd.Parameters.AddWithValue("@empid", empid);
                            updatecmd.Parameters.AddWithValue("@fname", TxtBxFullName.Text.Trim());
                            updatecmd.Parameters.AddWithValue("@gender", CmbBxGender.Text.Trim());
                            updatecmd.Parameters.AddWithValue("@contactnum", TxtBxPhnNum.Text.Trim());
                            updatecmd.Parameters.AddWithValue("@position", CmbBxPosition.Text.Trim());
                            updatecmd.Parameters.AddWithValue("@salary", salary);
                            updatecmd.Parameters.AddWithValue("@imagepath", imagePathToSave ?? string.Empty);
                            updatecmd.Parameters.AddWithValue("@status", CmbBxStatus.Text.Trim());
                            updatecmd.Parameters.AddWithValue("@dateupdate", DateTime.Now);

                            updatecmd.ExecuteNonQuery();
                            DisplayEmployees();
                            MessageBox.Show("Employee Record Updated Successfully.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            ClearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Update - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }

        }
        

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TxtBxEmpId.Text))
            {
                MessageBox.Show("Please Enter the Employee ID to Delete.", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string empid = TxtBxEmpId.Text.Trim().ToUpper();
                DialogResult dr = MessageBox.Show($"Are You Sure You Want To Delete Employee Id: {empid} ?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                { 
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();
                            string deletedata = "Update Employees Set DateDelete = @datedelete Where EmployeeId = @empid AND DateDelete IS NULL";
                            using (SqlCommand deletecmd = new SqlCommand(deletedata, sqlcon))
                            {
                                deletecmd.Parameters.AddWithValue("@empid", empid);
                                deletecmd.Parameters.AddWithValue("@datedelete", DateTime.Now);
                                deletecmd.ExecuteNonQuery();

                                DisplayEmployees();
                                MessageBox.Show("Employee Record Deleted Successfully.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Delete - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void DGVEmpData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = DGVEmpData.Rows[e.RowIndex];

                    TxtBxEmpId.Text = row.Cells["EmployeeId"].Value.ToString();
                    TxtBxFullName.Text = row.Cells["Name"].Value.ToString();
                    TxtBxPhnNum.Text = row.Cells["PhnNum"].Value.ToString();
                    CmbBxGender.Text = row.Cells["Gender"].Value.ToString();
                    CmbBxPosition.Text = row.Cells["Position"].Value.ToString();
                    CmbBxStatus.Text = row.Cells["Status"].Value.ToString();
                    TxtBxSalary.Text = row.Cells["Salary"].Value.ToString();

                    string imgpath = row.Cells["ImagePath"].Value.ToString();

                    if (File.Exists(imgpath))
                    {
                        PicBxPhoto.ImageLocation = imgpath;
                    }
                    else { PicBxPhoto.Image = null; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DGV - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            TxtBxEmpId.Clear();
            TxtBxFullName.Clear();
            TxtBxPhnNum.Clear();
            TxtBxSalary.Clear();
            CmbBxGender.SelectedIndex = -1;
            CmbBxPosition.SelectedIndex = -1;
            CmbBxStatus.SelectedIndex = -1;
            PicBxPhoto.Image = null;
        }

        private bool CheckEmptyFields()
        {
            if (string.IsNullOrWhiteSpace(TxtBxEmpId.Text) ||
            string.IsNullOrWhiteSpace(TxtBxFullName.Text) ||
            string.IsNullOrWhiteSpace(TxtBxPhnNum.Text) ||
            CmbBxGender.SelectedIndex == -1 ||  CmbBxPosition.SelectedIndex == -1 || CmbBxStatus.SelectedIndex == -1 || PicBxPhoto.Image == null)
            {
                return true;
            }
            return false ;
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

        // UNDONE: PicBxError in Update when no image selected -> Fixed: update preserves existing ImagePath when no new image is selected and only copies when a new image is chosen.
    }
}
