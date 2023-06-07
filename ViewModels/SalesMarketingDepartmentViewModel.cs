using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.ViewModels
{
    public class SalesMarketingDepartmentViewModel:Conductor<object>
    {
        private int employeeID;
        private static SalesMarketingDepartmentViewModel instance;

        public static SalesMarketingDepartmentViewModel getInstance(int EmployeeID)
        {
            if (instance == null)
            {
                instance = new SalesMarketingDepartmentViewModel(EmployeeID);
            }
            return instance;
        }

        public SalesMarketingDepartmentViewModel(int EmployeeID)
        {
            employeeID = EmployeeID;
            ActivateItem(new SMDPurchaseViewModel());
            instance = this;
        }

        public void purchaseBtn()
        {
            ActivateItem(new SMDPurchaseViewModel());
        }
        public void makeBtn()
        {
            ActivateItem(new MakeAdvertisementViewModel());
        }

        public void fundBtn()
        {
            ActivateItem(new SMDFundViewModel());
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
