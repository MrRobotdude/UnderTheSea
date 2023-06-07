using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using UnderTheSea.Models;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for PurchaseView.xaml
    /// </summary>
    public partial class PurchaseView : UserControl
    {
        public PurchaseView()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, RoutedEventArgs e)
        {
            Department departmentDA = new Department();
            string description = new TextRange(detailBox.Document.ContentStart, detailBox.Document.ContentEnd).Text;
            departmentDA.sendRequest(4, 6, Int32.Parse(amountBox.Text), description, "Purchase Request");
        }
    }
}
