using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnderTheSea.ViewModels;

namespace UnderTheSea.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public List<Department> getAllDepartment()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Department>($"SELECT * FROM MsDepartment").ToList();
                return output;
            }
        }

        public List<Division> getDivision(int departmentID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Division>($"SELECT * FROM MsDivision WHERE DepartmentID='"+ departmentID +"'").ToList();
                return output;
            }
        }

        public Division getOneDivision(int divisionID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Division>($"SELECT * FROM MsDivision WHERE DivisionID='" + divisionID + "'").ToList();
                if (output.Count() == 0)
                {
                    return null;
                }
                return output.ElementAt(0);
            }
        }

        public Department getOneDepartment(int departmentID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Department>($"SELECT * FROM MsDepartment WHERE DepartmentID='" + departmentID + "'").ToList();
                return output.ElementAt(0);
            }
        }

        public List<Facility> getFacilityForDepartment(int DepartmentID)
        {
            List<Facility> output = new List<Facility>();
            Facility facilityDA = new Facility();
            if (DepartmentID == 2)
            {
                output = facilityDA.getFacilityBaseStatus("Need Maintenance");
            }

            return output;
        }

        //overloading SendRequest
        public void sendRequest(int sender, int receiver, string facilityName, int price, int type, string detail, string RequestType)
        {
            RequestHandler requestHandler = new RequestHandler();
            Facility facility = new Facility(facilityName, price, type);
            requestHandler.addRequest(sender, receiver, detail, facility, RequestType);
        }


        public void sendRequest(int sender, int receiver, Employee employee, string description, string requestType)
        {
            RequestHandler requestHandler = new RequestHandler();
            requestHandler.addRequest(sender, receiver, description, employee, requestType);
        }

        public void sendRequest(int sender, int receiver, int salary, Employee employee, string description, string RequestType)
        {
            RequestHandler requestHandler = new RequestHandler();
            employee.Salary = salary.ToString();
            requestHandler.addRequest(sender, receiver, description, employee, RequestType);
        }

        public void sendRequest(int sender, int receiver, int price, string description, string RequestType)
        {
            RequestHandler requestHandler = new RequestHandler();
            requestHandler.addRequest(sender, receiver, description, price, RequestType);
        }

        public List<Request> getRequest(int receiver)
        {
            Request requestDA = new Request();
            List<Request> output = requestDA.GetRequest(receiver);
            return output;
        }
    }



    public class Division
    {
        public int DivisionID { get; set; }
        public int DepartmentID { get; set; }
        public string DivisionName { get; set; }
    }
}
