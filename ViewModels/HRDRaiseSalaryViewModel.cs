using Caliburn.Micro;

namespace UnderTheSea.ViewModels
{
    public class HRDRaiseSalaryViewModel:Screen
    {
        private Employee employeeDA = new Employee();
        public BindableCollection<Employee> Employee { get; set; }

        public HRDRaiseSalaryViewModel()
        {
            Employee = new BindableCollection<Employee>(employeeDA.GetAllEmployee());
        }
        
    }
}
