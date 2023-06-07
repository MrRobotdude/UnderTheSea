using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using UnderTheSea.Models;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for KDPurchaseView.xaml
    /// </summary>
    public partial class KDPurchaseView : UserControl
    {
        public KDPurchaseView()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, RoutedEventArgs e)
        {
            Department departmentDA = new Department();
            string description = new TextRange(detailBox.Document.ContentStart, detailBox.Document.ContentEnd).Text;
            departmentDA.sendRequest(5, 6, Int32.Parse(amountBox.Text), description, "Purchase Request");
        }
    }
}
