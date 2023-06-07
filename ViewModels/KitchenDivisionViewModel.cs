using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.ViewModels
{
    public class KitchenDivisionViewModel:Conductor<object>
    {
        private int employeeID;
        private static KitchenDivisionViewModel instance;

        public static KitchenDivisionViewModel getInstance(int EmployeeID)
        {
            if (instance == null)
            {
                instance = new KitchenDivisionViewModel(EmployeeID);
            }
            return instance;
        }

        public KitchenDivisionViewModel(int EmployeeID)
        {
            employeeID = EmployeeID;
            ActivateItem(new KDOrderViewModel());
            instance = this;
        }

        public void orderBtn()
        {
            ActivateItem(new KDOrderViewModel());
        }

        public void purchaseBtn()
        {
            ActivateItem(new KDPurchaseViewModel());
        }
        public void menuBtn()
        {
            ActivateItem(new KDMenuViewModel());
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
