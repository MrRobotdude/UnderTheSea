using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using UnderTheSea.Models;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for FundView.xaml
    /// </summary>
    public partial class FundView : UserControl
    {
        public FundView()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, RoutedEventArgs e)
        {
            Department departmentDA = new Department();
            string description = new TextRange(detailBox.Document.ContentStart, detailBox.Document.ContentEnd).Text;
            departmentDA.sendRequest(4, 7, Int32.Parse( amountBox.Text), description, "Fund Request");
        }
    }
}
