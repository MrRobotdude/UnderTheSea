using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.ViewModels
{
    public class LeavePermitViewModel : Screen
    {
        int employeeID;
        public DateTime LeaveDate { get; set; }
        public string Reason { get; set; }
        Employee EmployeeDA { get; set; }
        RequestHandler requestHandler;

        public LeavePermitViewModel(int employeeID)
        {
            this.employeeID = employeeID;
            this.LeaveDate = DateTime.Now;
            this.Reason = Reason;
            EmployeeDA = new Employee();
            requestHandler = new RequestHandler(); 
        }

        public void SendBtn()
        {
            requestHandler.addRequest(EmployeeDA.GetEmployee(employeeID).DepartmentID, 8, "Leave Permit-" + LeaveDate + "-" + Reason, EmployeeDA.GetEmployee(employeeID), "Leave Permit");
            TryClose();
        }

        public void CancelBtn()
        {
            TryClose();
        }
        
    }
}
