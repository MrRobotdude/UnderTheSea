using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.ViewModels
{
    
    public class HumanResourceDepartmentViewModel:Conductor<object>
    {
        private int employeeID;
        private static HumanResourceDepartmentViewModel instance;

        public static HumanResourceDepartmentViewModel getInstance(int EmployeeID)
        {
            if (instance == null)
            {
                instance = new HumanResourceDepartmentViewModel(EmployeeID);
            }
            return instance;
        }

        public HumanResourceDepartmentViewModel(int EmployeeID)
        {
            employeeID = EmployeeID;
            ActivateItem(new HRDRaiseSalaryViewModel());
            instance = this;
        }

        public void raiseBtn()
        {
            ActivateItem(new HRDRaiseSalaryViewModel());
        }

        public void recruitBtn()
        {
            ActivateItem(new HRDRecruitEmployeeViewModel());
        }

        public void reqBtn()
        {
            ActivateItem(new HRDRequestViewModel());
        }

        public void fireBtn()
        {
            ActivateItem(new HRDFireViewModel());
        }
        public void leaveBtn()
        {
            ActivateItem(new HRDLeavePermitViewModel());  
        }
        public void fundBtn()
        {
            ActivateItem(new HRDFundViewModel());
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
        public void BtnWork()
        {
            ActivateItem(new HRDWorkViewModel());
        }
    }
}
