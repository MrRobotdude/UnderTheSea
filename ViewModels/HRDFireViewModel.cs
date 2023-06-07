using Caliburn.Micro;

namespace UnderTheSea.ViewModels
{
    public class HRDFireViewModel:Screen
    {
        Employee employeeDA;
        public BindableCollection<Employee> Employee { get; set; }
        public HRDFireViewModel()
        {
            employeeDA = new Employee();
            Employee = new BindableCollection<Employee>(employeeDA.GetAllEmployee());
        }
    }
}
