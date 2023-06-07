using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.ViewModels
{
    public class FrontOfficeDivisionViewModel:Conductor<object>
    {
        private int employeeID;
        private static FrontOfficeDivisionViewModel instance;

        public static FrontOfficeDivisionViewModel getInstance(int EmployeeID)
        {
            if (instance == null)
            {
                instance = new FrontOfficeDivisionViewModel(EmployeeID);
            }
            return instance;
        }

        public FrontOfficeDivisionViewModel(int EmployeeID)
        {
            employeeID = EmployeeID;
            ActivateItem(new FODReserveViewModel());
            instance = this;
        }

        public void btnReserve()
        {
            ActivateItem(new FODReserveViewModel());
        }
        public void btnCheckIn()
        {
            ActivateItem(new FODCheckInViewModel());
        }
        public void btnCheckOut()
        {
            ActivateItem(new FODCheckOutViewModel());
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
