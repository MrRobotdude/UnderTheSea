using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class WorkReportViewModel : Screen
    {
        private int employeeID;
        WorkPerformance reportDA;
        public string Detail { get; set; }
        public WorkReportViewModel(int EmployeeID)
        {
            employeeID = EmployeeID;
            reportDA = new WorkPerformance();
            Detail = "";
        }
        public void SendBtn()
        {
            if (!Detail.Equals(""))
            {
                reportDA.insertWorkReport(employeeID, Detail);
            }
            TryClose();
        }

        public void CancelBtn()
        {
            TryClose();
        }
    }
}