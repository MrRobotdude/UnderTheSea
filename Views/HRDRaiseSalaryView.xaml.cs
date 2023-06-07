using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using UnderTheSea.Models;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for HRDRaiseSalaryView.xaml
    /// </summary>
    public partial class HRDRaiseSalaryView : UserControl
    {
        public HRDRaiseSalaryView()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = Employee.SelectedItem as Employee;
            Department departmentDA = new Department();
            string description = new TextRange(detailTextBox.Document.ContentStart, detailTextBox.Document.ContentEnd).Text;
            departmentDA.sendRequest(10, 11, int.Parse(salaryTxtBox.Text),employee, description, "Raise Salary"); 
        }
    }
}
