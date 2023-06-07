using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using UnderTheSea.ViewModels;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for SMDFundView.xaml
    /// </summary>
    public partial class SMDFundView : UserControl
    {
        public SMDFundView()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, RoutedEventArgs e)
        {
            RequestHandler requestHandler = new RequestHandler();
            string description = new TextRange(detailBox.Document.ContentStart, detailBox.Document.ContentEnd).Text;
            requestHandler.addRequest(9, 7, description, int.Parse(amountBox.Text), "Fund Request");
        }
    }
}
