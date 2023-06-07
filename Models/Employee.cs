using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.ViewModels;

namespace UnderTheSea
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int DepartmentID { get; set; }
        public int DivisionID { get; set; }
        public string Status { get; set; }
        public string Salary { get; set; }

        public Employee GetEmployee(string username)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Employee>($"select * from MsEmployee where UserName ='{username}'").ToList();
                return output[0];
            }
        }
        public Employee GetEmployee(int employeeID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Employee>($"select * from MsEmployee where EmployeeID ='{employeeID}'").ToList();
                return output[0];
            }
        }

        public List<Employee> GetAllEmployee()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                return connection.Query<Employee>($"SELECT * FROM MsEmployee").ToList();
            }
        }

        public void updateEmployee(int employeeID, string status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Employee_Update @employeeID, @status ", new { employeeID, status });
            }
        }

        public void insertEmployee(string username, string pass, int departmentID, int divisionID, string status, int salary)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                Employee employee = new Employee
                {
                    UserName = username,
                    Password = pass,
                    DepartmentID = departmentID,
                    DivisionID = divisionID,
                    Status = status,
                    Salary = salary.ToString()
                };
                List<Employee> employees = new List<Employee>();
                employees.Add(employee);
                connection.Execute("dbo.Employee_Insert @UserName,@Password, @DepartmentID, @DivisionID, @Status, @Salary", employees);
            }
        }

        public void updateSalary(int employeeID, string salary)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Employee_UpdateSalary @employeeID, @salary ", new { employeeID, salary });
            }
        }

        ShellViewModel instance = ShellViewModel.getInstance();
        public bool login(string username, string pass)
        {
            Employee employee = GetEmployee(username);
            if (employee != null)
            {
                if (pass.Equals(employee.Password))
                {
                    if (!employee.Status.Equals("Retired"))
                    {
                        instance.ShowEmployeeView(employee);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
