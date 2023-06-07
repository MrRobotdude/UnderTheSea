using Caliburn.Micro;
using System;

namespace UnderTheSea.ViewModels
{
    public class ResignLetterViewModel : Screen
    {
        private int employeeID;
        private RequestHandler requestHandler;
        private Employee employeeDA;
        public string Detail { get; set; }
        public DateTime SelectedDate { get; set; }
        public ResignLetterViewModel(int EmployeeID)
        {
            employeeID = EmployeeID;
            requestHandler = new RequestHandler();
            employeeDA = new Employee();
            SelectedDate = DateTime.Now;
        }
        public void sendBtn()
        {
            requestHandler.addRequest(employeeID,
                11, SelectedDate + "-" + Detail, employeeDA.GetEmployee(employeeID), "Resign Letter");
            TryClose();
        }

        public void CancelBtn()
        {
            TryClose();
        }
    }
}
