using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class HRDWorkViewModel:Screen
    {
        WorkPerformance da;
        Employee employeeDA;
        public class workPreformanceView
        {
            public WorkPerformance perform { get; set; }
            public string EmployeeName { get; set; }
        }
        public BindableCollection<workPreformanceView> Report { get; set; }
        public HRDWorkViewModel()
        {
            da = new WorkPerformance();
            employeeDA = new Employee();
            Report = new BindableCollection<workPreformanceView>();
            foreach(WorkPerformance wp in da.getWorkPerformance())
            {
                Report.Add(new workPreformanceView
                {
                    perform = wp,
                    EmployeeName = employeeDA.GetEmployee(wp.EmployeeID).UserName
                });
            }
        }
    }
}
