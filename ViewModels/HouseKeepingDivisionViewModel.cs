
using Caliburn.Micro;
using System.Collections.Generic;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class HouseKeepingDivisionViewModel:Screen
    {
        private int employeeID;
        private RoomHandler roomHandler;
        public int RoomNumber { get; set; }
        public class RoomProperty
        {
            public string PropertyName { get; set; }
            public bool isBroken { get; set; }
        }
        public BindableCollection<RoomProperty> Property { get; set; }
        public HouseKeepingDivisionViewModel(int EmployeeID)
        {
            employeeID = EmployeeID;
            roomHandler = new RoomHandler();
            Property = new BindableCollection<RoomProperty>();
            string[] propertyName = {"Door","Bed","Furniture", "Bathroom Property","Electronic" };
            foreach(string v in propertyName)
            {
                Property.Add(new RoomProperty
                {
                    PropertyName = v,
                    isBroken = false
                });
            }
        }

        public void reportBtn()
        {
            List<string> report = new List<string>();
            foreach(RoomProperty property in Property)
            {
                if (property.isBroken)
                {
                    report.Add(property.PropertyName);
                }
            }
            roomHandler.addReport(RoomNumber, report);
        }
        public void BtnLeave()
        {
            IWindowManager manager = new WindowManager();
            manager.ShowWindow(new LeavePermitViewModel(employeeID), null, null);
        }
        public void BtnResign()
        {
            IWindowManager manager = new WindowManager();
            manager.ShowWindow(new ResignLetterViewModel(employeeID), null, null);
        }
        public void BtnSignOut()
        {
            IWindowManager manager = new WindowManager();
            manager.ShowWindow(new WorkReportViewModel(employeeID), null, null);
            ShellViewModel viewModel = ShellViewModel.getInstance();
            viewModel.ShowLoginView();
        }
    }
}
