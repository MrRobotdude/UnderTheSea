using Caliburn.Micro;
using System.Linq;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class HRDRequestViewModel:Screen
    {
        public HRDRequest SelectedRequest { get; set; }
        public class HRDRequest
        {
            public string Description { get; set; }
            public string Type { get; set; }
            public string Status { get; set; }
            public int RequestID { get; set; }
            public string[] Information { get; set; }
        }
        
        public BindableCollection<HRDRequest> Request { get; set; }
        private Request requestDA;
        private Department departmentDA;
        private Employee employeeDA;
        public HRDRequestViewModel()
        {
            requestDA = new Request();
            departmentDA = new Department();
            employeeDA = new Employee();
            Request = new BindableCollection<HRDRequest>();
            foreach (Request request in requestDA.GetRequest(10))
            {
                string[] info = request.Description.Split('-');
                Request.Add(new HRDRequest
                {
                    RequestID = request.RequestID,
                    Type = info[0],
                    Status = request.Status,
                    Description = extractInformation(info),
                    Information= request.Description.Split('-')

                });
            }
        }
        public void proceedBtn()
        {
            if (SelectedRequest.Status.Equals("Confirmed"))
            {
                if(SelectedRequest.Type.Equals("Raise Salary"))
                {
                    employeeDA.updateSalary(int.Parse(SelectedRequest.Information[1]), SelectedRequest.Information[2]);
                }
                else if (SelectedRequest.Type.Equals("Recruitment"))
                {
                    employeeDA.insertEmployee(SelectedRequest.Information[1], SelectedRequest.Information[5], int.Parse(SelectedRequest.Information[3]), int.Parse(SelectedRequest.Information[4]), "Working", int.Parse(SelectedRequest.Information[2]));
                }
                else if (SelectedRequest.Type.Equals("Fire Employee"))
                {
                    employeeDA.updateEmployee(int.Parse(SelectedRequest.Information[1]),"Deleted");
                }
                requestDA.updateStatus(SelectedRequest.RequestID, "Proceeded");
            } 
        }
        private string extractInformation(string[] descs)
        {
            
            if (descs[0].Equals("Raise Salary"))
            {
                Employee temp = employeeDA.GetEmployee(int.Parse(descs[1]));
                string divisionName = "";
                if (departmentDA.getDivision(temp.DivisionID).Count() != 0)
                {
                    divisionName = departmentDA.getDivision(temp.DivisionID).ElementAt(0).DivisionName;
                }
                
                return "" + temp.UserName  + "\n" + descs[2]  + "\n" + departmentDA.getOneDepartment(temp.DepartmentID).DepartmentName +
                    "\n" + divisionName + "\n" + descs[3];
            }
            else if(descs[0].Equals("Fire Employee"))
            {
                Employee temp = employeeDA.GetEmployee(int.Parse(descs[1]));
                string divisionName="";
                if (departmentDA.getDivision(temp.DivisionID).Count() != 0)
                {
                    divisionName = departmentDA.getDivision(temp.DivisionID).ElementAt(0).DivisionName;
                }
                
                return "" + temp.UserName + "\n" + departmentDA.getOneDepartment(temp.DepartmentID).DepartmentName +
                    "\n" + divisionName + "\n" + descs[2];
            }
            else if (descs[0].Equals("Recruitment"))
            {
                string divisionName = "";
                if (departmentDA.getDivision(int.Parse(descs[4])).Count() != 0)
                {
                    divisionName = departmentDA.getDivision(int.Parse(descs[4])).ElementAt(0).DivisionName;
                }
                return "" + descs[1] + "\n" + descs[2] + "\n" + departmentDA.getOneDepartment(int.Parse(descs[3])).DepartmentName
                    + "\n" + divisionName + "\n" + descs[5] + "\n" + descs[6];
            }
            return "";
        }
    }
}
