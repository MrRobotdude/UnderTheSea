using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.ViewModels
{
    public class PurchasingDepartmentViewModel:Conductor<object>
    {
        private int employeeID;
        private static PurchasingDepartmentViewModel instance;

        public static PurchasingDepartmentViewModel getInstance(int EmployeeID)
        {
            if (instance == null)
            {
                instance = new PurchasingDepartmentViewModel(EmployeeID);
            }
            return instance;
        }

        public PurchasingDepartmentViewModel(int EmployeeID)
        {
            employeeID = EmployeeID;
            ActivateItem(new PurchaseRequestViewModel());
            instance = this;
        }

        public void purchaseBtn()
        {
            ActivateItem(new PurchaseRequestViewModel());
        }
        
        public void CheckBtn()
        {
            ActivateItem(new PDFundViewModel());
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
