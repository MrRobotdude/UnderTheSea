using System.Windows;
using System.Windows.Controls;
using UnderTheSea.ViewModels;
using static UnderTheSea.ViewModels.PurchaseRequestViewModel;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for PurchaseRequestView.xaml
    /// </summary>
    public partial class PurchaseRequestView : UserControl
    {
        private RequestHandler requestHandler;
        public PurchaseRequestView()
        {
            InitializeComponent();
            requestHandler = new RequestHandler();
        }

        private void reqFundBtn_Click(object sender, RoutedEventArgs e)
        {
            purchaseRequestModel purchase = PurchaseRequest.SelectedItem as purchaseRequestModel;
            requestHandler.acceptRequest(purchase.RequestID);
            requestHandler.addRequest(6, 7, purchase.Description, purchase.Price, "Fund Request");
        }
    }
}
