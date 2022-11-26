using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4_Employee_Table
{
    internal class DBConnection: EmployeeLists
    {
        string connetionString = "";
        SqlCommand cmd;
        SqlConnection SqlCon;
        string query = "";
        public void Method1()
        {
        EmployeeLists employeeListobj = new EmployeeLists();
            var employeeLists = employeeListobj.Method();
        SqlConnection connectionstring = new SqlConnection("Server=LAPTOP-0ELAKBQI\\SQLEXPRESS;Database=Mounika;Trusted_Connection=true;");
        string query = "Insert Into Employe (EmpName, EmpAge,EmpGender,DeptID) " +
                               "VALUES (@N, @A,@GN,@ID) ";
        foreach (var emp in employeeLists)
        {
               
            // add parameters and their values
            cmd = new SqlCommand(query, connectionstring);
            cmd.Parameters.Add("@N", System.Data.SqlDbType.NVarChar, 100).Value = emp.EmpName;
                cmd.Parameters.Add("@A",System.Data.SqlDbType.NVarChar, 100).Value = emp.EmpAge;
            cmd.Parameters.Add("@GN", System.Data.SqlDbType.NVarChar, 100).Value = emp.EmpGender;
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.NVarChar, 100).Value = emp.DeptID;

                connectionstring.Open(); 
                cmd.ExecuteNonQuery();
                connectionstring.Close();

        }

    }
    }
}
