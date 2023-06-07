using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using UnderTheSea.Models;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for AddRideView.xaml
    /// </summary>
    public partial class AddRideView : UserControl
    {
        public AddRideView()
        {
            InitializeComponent();
        }

        private void addRideBtn_Click(object sender, RoutedEventArgs e)
        {
            Department departmentDA = new Department();
            string description = new TextRange(detailTextBox.Document.ContentStart, detailTextBox.Document.ContentEnd).Text;
            departmentDA.sendRequest(3, 11, nameTextBox.Text,Int32.Parse(priceTextBox.Text),1,description, "Add Ride"); 

        }
    }
}
