using Caliburn.Micro;
using System;
using System.Data.SqlClient;

namespace UnderTheSea.ViewModels
{
    public class LoginViewModel : Screen
    {
        public string UsernameTxt { get; set; }
        public string Password { get; set; }
        public string errorLbl { get; set; }

        public void LoginBtn()
        {
            errorLbl = "";
            if (string.IsNullOrWhiteSpace(UsernameTxt) || string.IsNullOrEmpty(Password))
            {
                errorLbl = "Enter your username and password.";
            }
            else
            {
                try
                {
                    Employee employee = new Employee().GetEmployee(UsernameTxt.Trim());
                    if (employee == null || !string.Equals(Password, employee.Password, StringComparison.Ordinal)
                        || string.Equals(employee.Status, "Retired", StringComparison.OrdinalIgnoreCase))
                    {
                        errorLbl = "Unable to sign in with these credentials.";
                    }
                    else
                    {
                        Password = null;
                        ShellViewModel.getInstance().ShowEmployeeView(employee);
                    }
                }
                catch (SqlException)
                {
                    errorLbl = "The training database is unavailable. Check the local database configuration.";
                }
            }
            NotifyOfPropertyChange(() => errorLbl);
        }
    }
}
