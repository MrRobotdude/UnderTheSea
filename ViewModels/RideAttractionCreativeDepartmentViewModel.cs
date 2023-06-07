using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.ViewModels
{
   
    public class RideAttractionCreativeDepartmentViewModel:Conductor<object>
    {
        private int employeeID;
        private static RideAttractionCreativeDepartmentViewModel instance;

        public static RideAttractionCreativeDepartmentViewModel getInstance(int EmployeeID)
        {
            if (instance == null)
            {
                instance = new RideAttractionCreativeDepartmentViewModel(EmployeeID);
            }
            return instance;
        }

        public RideAttractionCreativeDepartmentViewModel(int EmployeeID)
        {
            
            employeeID = EmployeeID;
            ActivateItem(new AddRideViewModel());
            instance = this;
        }

        public void addRideBtn()
        {
            ActivateItem(new AddRideViewModel());
        }

        public void editFacilityBtn()
        {
            ActivateItem(new EditRideorAttractionViewModel());
        }
        
        public void requestBtn()
        {
            ActivateItem(new RADRequestViewModel());
        }

        public void addAttractionBtn()
        {
            ActivateItem(new AddAttractionViewModel());
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
