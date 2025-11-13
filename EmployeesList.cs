using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMS
{
    internal class EmployeesList
    {
        public EmployeesList() { }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\EmployeeMS\Employees.mdf;Integrated Security = True";

        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

        public List<EmployeesList> ListEmployees()
        {
            List<EmployeesList> empslist = new List<EmployeesList>();

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                sqlcon.Open();
                string seldata = "Select * From Employees Where DateDelete is NULL";

                using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                {
                    SqlDataReader sdr = selcmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        EmployeesList emps = new EmployeesList();

                        emps.Id = (int)sdr["Id"];
                        emps.EmployeeId = (string)sdr["EmployeeId"];
                        emps.Name = (string)sdr["FullName"];
                        emps.Position = (string)sdr["Position"];
                        emps.Salary = (int)sdr["Salary"];

                        empslist.Add(emps);
                    }
                }
            }

            return empslist;
        }
    }
}
