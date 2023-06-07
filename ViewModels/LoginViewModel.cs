using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.ViewModels
{
    public class LoginViewModel:Screen
    {
        public string UsernameTxt { get; set; }
        public string Password { get; set; }
        public string errorLbl { get; set; }
        public void loginBtn()
        {
            Employee employeeDA = new Employee();

            Employee employee = employeeDA.GetEmployee(UsernameTxt);
            if (!Password.Equals(employee.Password))
            {
                errorLbl = "wrong password";
            }
            else
            {
                ShellViewModel viewModel = ShellViewModel.getInstance();
                viewModel.ShowEmployeeView(employee);
            }
        }
    }
}
