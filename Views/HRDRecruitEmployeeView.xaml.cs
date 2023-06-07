using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

using UnderTheSea.ViewModels;
using static UnderTheSea.ViewModels.HRDRecruitEmployeeViewModel;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for HRDRecruitEmployee.xaml
    /// </summary>
    public partial class HRDRecruitEmployeeView : UserControl
    {
        public HRDRecruitEmployeeView()
        {
            InitializeComponent();
        }

        private void Hirebtn_Click(object sender, RoutedEventArgs e)
        {
            RequestHandler requestHandler = new RequestHandler();
            DepartmentModel department = Department.SelectedItem as DepartmentModel;
            Employee employee = new Employee{
                UserName = UserNameins.Text,
                Password = Passwordins.Text,
                Salary =Salaryins.Text,
                DepartmentID = department.DepartmentID,
                DivisionID = department.DivisionID

            };
            string desc = new TextRange(descTextBox.Document.ContentStart, descTextBox.Document.ContentEnd).Text;
            requestHandler.addRequest(10,11,desc, employee,"Recruitment");
        }
    }
}
