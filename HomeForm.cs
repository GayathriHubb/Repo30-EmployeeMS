using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMS
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure you Want to Close ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            Application.ExitThread();
        }

        private void PicBxLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure you want to Logout ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Form1Login login = new Form1Login();
                login.Show();
            }
        }
        private void HomeForm_Load(object sender, EventArgs e)
        {
            string un = EmployeesData.Username;
            LbUser.Text = $"{un.Substring(0, 1).ToUpper()}{un.Substring(1)} !";
        }


        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            Hide();
        }

        private void BtnEmpList_Click(object sender, EventArgs e)
        {
            FormEmpList empList = new FormEmpList();
            empList.Show();
            Hide();
        }

        private void BtnEmpData_Click(object sender, EventArgs e)
        {
            FormEmpData empdata = new FormEmpData();
            empdata.Show();
            Hide();
        }

        private void PicBxLogout_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.SetToolTip(PicBxLogout, "Logout");
        }

        
    }
}
