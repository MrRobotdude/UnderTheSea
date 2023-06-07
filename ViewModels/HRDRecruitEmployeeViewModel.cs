using Caliburn.Micro;
using System.Collections.Generic;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class HRDRecruitEmployeeViewModel:Screen
    {
        private Department departmentDA;
        public class DepartmentModel
        {
            public int DepartmentID { get; set; }
            public int DivisionID { get; set; }
            public string DepartmentName { get; set; }
        }

        public BindableCollection<DepartmentModel> Department { get; set; }
        public HRDRecruitEmployeeViewModel()
        {
            departmentDA = new Department();
            Department = new BindableCollection<DepartmentModel>();
            foreach(Department department in departmentDA.getAllDepartment())
            {
                List<Division> division = department.getDivision(department.DepartmentID);
                if ( division.Count != 0)
                {
                    foreach(Division div in division)
                    {
                        Department.Add(new DepartmentModel
                        {
                            DepartmentID = department.DepartmentID,
                            DivisionID = div.DivisionID,
                            DepartmentName = div.DivisionName
                        });
                    }
                    
                }
                else
                {
                    Department.Add(new DepartmentModel
                    {
                        DepartmentID = department.DepartmentID,
                        DepartmentName = department.DepartmentName
                    });
                }
                
            }
        }
    }
}
