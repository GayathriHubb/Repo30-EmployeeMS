using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMS
{
    internal class EmployeesDetails
    {
        public EmployeesDetails() { }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\EmployeeMS\Employees.mdf;Integrated Security = True";

        public int Id { get; set; } 
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }  
        public string PhnNum { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public string Status { get; set; }
        public string ImagePath { get; set; }
        public string DateInsert { get; set; }
        public string DateUpdate { get; set; }

        public List<EmployeesDetails> ListEmployeesDetails()
        {
            List<EmployeesDetails> empslist = new List<EmployeesDetails>();

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                sqlcon.Open();

                string seldata = "Select * From Employees Where DateDelete is NULL";

                using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                {
                    SqlDataReader sdr = selcmd.ExecuteReader();

                    while (sdr.Read()) 
                    {
                        EmployeesDetails emps = new EmployeesDetails();

                        emps.Id = (int)sdr["Id"];
                        emps.EmployeeId = (string)sdr["EmployeeId"];
                        emps.Name = (string)sdr["FullName"];
                        emps.Gender = (string)sdr["Gender"];
                        emps.PhnNum = (string)sdr["ContactNum"];
                        emps.Position = (string)sdr["Position"];
                        emps.Salary = (int)sdr["Salary"];
                        emps.ImagePath = (string)sdr["ImagePath"];
                        emps.Status = (string)sdr["Status"];    
                        emps.DateInsert = (Convert.ToDateTime(sdr["DateInsert"])).ToString("dd-MM-yyyy");
                        emps.DateUpdate = sdr["DateUpdate"].ToString();

                        if (sdr["DateUpdate"] != DBNull.Value) 
                        {
                            emps.DateUpdate = (Convert.ToDateTime(sdr["DateUpdate"])).ToString("dd-MM-yyyy");
                        }

                        empslist.Add(emps);
                    }
                }

                return empslist;
            }


        }
    }
}
