using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public void showAttraction(int employeeID)
        {
            ActivateItem(new AttractionDepartmentViewModel(employeeID));
        }

        public void ShowLoginView()
        {
            ActivateItem(new LoginViewModel());
        }

        private static ShellViewModel instance;

        public static ShellViewModel getInstance()
        {
            if (instance == null)
            {
                instance = new ShellViewModel();
            }
            return instance;
        }

        internal void ShowEmployeeView(Employee employee)
        {
            int id = employee.EmployeeID;
            
            int department = employee.DepartmentID;
            
            switch (department)
            {
                case 1:
                        ActivateItem(new RideAttractionCreativeDepartmentViewModel(id));
                        break;
                case 2:
                    ActivateItem(new MaintenanceDepartmentViewModel(id));
                        break;
                case 3:
                    ActivateItem(new AttractionDepartmentViewModel(id));
                        break;
                case 4:
                    ActivateItem(new ConstructionDepartmentViewModel(id));
                    break;
                case 5:
                    ActivateItem(new PurchasingDepartmentViewModel(id));
                        break;
                case 6:
                    ActivateItem(new AccountingFinanceDepartmentViewModel(id));
                        break;
                case 7:
                    ActivateItem(new SalesMarketingDepartmentViewModel(id));
                        break;
                case 8:
                    ActivateItem(new ManagerViewModel());
                        break;
                case 9:
                    ActivateItem(new HumanResourceDepartmentViewModel(id));
                        break;
                case 10:
                        if (employee.DivisionID == 1) ActivateItem(new DiningRoomDivisionViewModel(id));
                        else ActivateItem(new KitchenDivisionViewModel(id));
                        break;
                case 11:
                        if (employee.DivisionID == 3) ActivateItem(new FrontOfficeDivisionViewModel(id));
                        else ActivateItem(new HouseKeepingDivisionViewModel(id));
                        break;
            }
        }

        public ShellViewModel()
        {
            ActivateItem(new LoginViewModel());
            instance = this;
        }
    }
}
