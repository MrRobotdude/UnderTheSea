using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.ViewModels
{
    public class DiningRoomDivisionViewModel:Conductor<object>
    {
        private int employeeID;
        private static DiningRoomDivisionViewModel instance;
        public int HeaderID { get; set; }

        public static DiningRoomDivisionViewModel getInstance(int EmployeeID)
        {
            if (instance == null)
            {
                instance = new DiningRoomDivisionViewModel(EmployeeID);
            }
            return instance;
        }

        public DiningRoomDivisionViewModel(int EmployeeID)
        {
            employeeID = EmployeeID;
            ActivateItem(new DRDCheckInViewModel(employeeID));
            instance = this;
        }

        public void cekInBtn()
        {
            ActivateItem(new DRDCheckInViewModel(employeeID));
        }

        public void cekOutBtn()
        {
            ActivateItem(new DRDCheckOutViewModel());
        }

        public void showMenu()
        {
            ActivateItem(new DRDMenuViewModel(0,employeeID));
        }

        public void showCheckTable()
        {
            ActivateItem(new DRDCheckTableViewModel(employeeID));
        }
        public void showMenu(int tableNumber)
        {
            ActivateItem(new DRDMenuViewModel(tableNumber,employeeID));
        }
        public void orderBtn()
        {
            ActivateItem(new DRDOrderViewModel());
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
