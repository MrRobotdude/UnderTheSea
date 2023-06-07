using Caliburn.Micro;
using System.Linq;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class ManRequestViewModel:Screen
    {
        private Department departmentDA;
        private Facility facilityDA;
        private Employee employeeDA;
        public class RequestViewModel
        {
            public int RequestID { get; set; }
            public string RequestType { get; set; }
            public string Status { get; set; }
            public string Description { get; set; }
        }

        public BindableCollection<RequestViewModel> Request { get; set; }

        public ManRequestViewModel()
        {
            departmentDA = new Department();
            Request = new BindableCollection<RequestViewModel>();
            facilityDA = new Facility();
            employeeDA = new Employee();
            Request requestDA = new Request();
            foreach(Request request in requestDA.GetRequest(11))
            {
                string[] info = extractInformation(request.Description);
                Request.Add(new RequestViewModel
                {
                    RequestID = request.RequestID,
                    RequestType = info[0],
                    Status = request.Status,
                    Description = getDescription(info)
                });
            }
        }

        private string[] extractInformation(string desc)
        {
            string[] output = desc.Split('-');
            return output;
        }

        private string getDescription(string[] descs)
        {
            string desc = "";
            if(descs[0].Equals("Add Ride")|| descs[0].Equals("Add Attraction"))
            {
                desc += descs[1] + "\n" + descs[2]+"\n"+descs[3];
            }
            else if (descs[0].Equals("Recruitment"))
            {
                desc += descs[1] + "\n" + descs[2] + "\n" +departmentDA.getOneDepartment(int.Parse(descs[3])).DepartmentName+"\n"+descs[4]+ "\n" + descs[5] + "\n" +descs[6];
            }
            else if(descs[0].Equals("Raise Salary"))
            {
                Employee temp = employeeDA.GetEmployee(int.Parse(descs[1]));
                string divisionName = "";
                if (departmentDA.getDivision(temp.DivisionID).Count() != 0)
                {
                    divisionName = departmentDA.getDivision(temp.DivisionID).ElementAt(0).DivisionName;
                }

                desc += "" + temp.UserName + "\n" + descs[2] + "\n" + departmentDA.getOneDepartment(temp.DepartmentID).DepartmentName +
                    "\n" + divisionName + "\n" + descs[3];
            }
            else if(descs[0].Equals("Fire Employee"))
            {
                desc += descs[1] + "\n" + descs[2]+"\n"+employeeDA.GetEmployee(int.Parse(descs[1])).UserName;
            }
            else if(descs[0].Equals("Update Facility"))
            {
                desc += descs[1] + "\n" + descs[2] + "\n" + descs[3];
            }
            else if(descs[0].Equals("Delete Facility"))
            {
                desc += descs[1] + "\n" + facilityDA.getFacility(int.Parse(descs[1])).ElementAt(0).FacilityName + "\n" + facilityDA.getFacility(int.Parse(descs[1])).ElementAt(0).FacilityDetail;
            }
            return desc;
        }
    }
}
