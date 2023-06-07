using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.ViewModels
{
    public class ConstructionDepartmentViewModel:Conductor<object>
    {
        private int employeeID;
        private static ConstructionDepartmentViewModel instance;

        public static ConstructionDepartmentViewModel getInstance(int employeeID)
        {
            if (instance == null)
            {
                instance = new ConstructionDepartmentViewModel(employeeID);
            }
            return instance;
        }

        public ConstructionDepartmentViewModel(int EmployeeID)
        {
            employeeID = EmployeeID;
            ActivateItem(new HandleConstructionViewModel());
            instance = this;
        }

        public void constructionBtn()
        {
            ActivateItem(new HandleConstructionViewModel()); 
        }
        public void purchaseBtn()
        {
            ActivateItem(new PurchaseViewModel());
        }
        public void fundBtn()
        {
            ActivateItem(new FundViewModel());
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
