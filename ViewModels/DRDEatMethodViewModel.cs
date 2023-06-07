using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.ViewModels
{
    public class DRDEatMethodViewModel:Screen
    {
        private int employeeID;
        public void takeAwayBtn()
        {
            DiningRoomDivisionViewModel.getInstance(employeeID).showMenu();
            TryClose();
        }
        public void DineInBtn()
        {
            DiningRoomDivisionViewModel.getInstance(employeeID).showCheckTable();
            TryClose();
        }
        public DRDEatMethodViewModel(int EmployeeID)
        {
            employeeID = EmployeeID;
        }
    }
}
