using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class MainViewModel: Conductor<object>
    {
        private static MainViewModel instance;

        public static MainViewModel getInstance()
        {
            if (instance == null)
            {
                instance = new MainViewModel();
            }
            return instance;
        }

        public MainViewModel()
        {
            ActivateItem(new WelcomeViewModel());
            instance = this;
        }

        public void ShowTicketView()
        {
            ActivateItem(new TicketTransactionViewModel());
        }

        public void ShowLoginView()
        {
            ActivateItem(new LoginViewModel());
        }

        public void ShowEmployeeView(Employee employee)
        {
            if (employee.DepartmentID == 1 )
            {
                ActivateItem(new AttractionDepartmentViewModel(employee.EmployeeID));
            }
            else if(employee.DepartmentID == 2)
            {
                ActivateItem(new MaintenanceDepartmentViewModel(employee.EmployeeID));
            }
            else if(employee.DepartmentID == 3)
            {
                ActivateItem(new RideAttractionCreativeDepartmentViewModel(employee.EmployeeID));
            }
            else if(employee.DepartmentID == 4)
            {
                ActivateItem(new ConstructionDepartmentViewModel(employee.EmployeeID));
            }
            else if(employee.DepartmentID == 5)
            {
                if(employee.DivisionID == 1)
                {
                    ActivateItem(new DiningRoomDivisionViewModel(employee.EmployeeID));
                }
                else if(employee.DivisionID == 2){
                    ActivateItem(new KitchenDivisionViewModel(employee.EmployeeID));
                }
            }
            else if(employee.DepartmentID == 6)
            {
                ActivateItem(new PurchasingDepartmentViewModel(employee.EmployeeID));
            }
            else if(employee.DepartmentID == 7)
            {
                ActivateItem(new AccountingFinanceDepartmentViewModel(employee.EmployeeID));
            }
            else if(employee.DepartmentID == 8)
            {
                if(employee.DivisionID == 3)
                {
                    ActivateItem(new FrontOfficeDivisionViewModel(employee.EmployeeID));
                }
                else if(employee.DivisionID == 4)
                {
                    ActivateItem(new HouseKeepingDivisionViewModel(employee.EmployeeID));
                }
            }
            else if(employee.DepartmentID == 9)
            {
                ActivateItem(new SalesMarketingDepartmentViewModel(employee.EmployeeID));
            }
            else if(employee.DepartmentID == 10)
            {
                ActivateItem(new HumanResourceDepartmentViewModel(employee.EmployeeID));
            }
            else if(employee.DepartmentID == 11)
            {
                ActivateItem(new ManagerViewModel());
            }

        }

        public void showAddRideForm()
        {
            ActivateItem(new AddRideViewModel());
        }
    }
}
