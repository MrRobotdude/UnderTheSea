using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.ViewModels
{
    public class MaintenanceDepartmentViewModel:Conductor<object>
    {
        private static MaintenanceDepartmentViewModel instance;
        private int employeeID;
        public static MaintenanceDepartmentViewModel getInstance(int EmployeeID)
        {
            if (instance == null)
            {
                instance = new MaintenanceDepartmentViewModel(EmployeeID);
            }
            return instance;
        }

        public MaintenanceDepartmentViewModel(int EmployeeID)
        {
            employeeID = EmployeeID;
            ActivateItem(new MDEditScheduleViewModel());
            instance = this;
        }

        public void maintainBtn()
        {
            ActivateItem(new MDEditScheduleViewModel());
        }

        public void emergencyBtn()
        {
            ActivateItem(new CreateScheduleViewModel());
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
