using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using UnderTheSea.ViewModels;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for HRDFireView.xaml
    /// </summary>
    public partial class HRDFireView : UserControl
    {
        public HRDFireView()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = Employee.SelectedItem as Employee;
            string description = new TextRange(detailTextBox.Document.ContentStart, detailTextBox.Document.ContentEnd).Text;
            RequestHandler requestHandler = new RequestHandler();
            requestHandler.addRequest(10, 11, description, employee, "Fire Employee");
        }
    }
}
