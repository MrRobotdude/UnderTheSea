using System.Windows;
using System.Windows.Controls;
using UnderTheSea.ViewModels;
using static UnderTheSea.ViewModels.AccountingFinanceDepartmentViewModel;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for AccountingFinanceDepartmentView.xaml
    /// </summary>
    public partial class AccountingFinanceDepartmentView : UserControl
    {
        private RequestHandler requestHandler = new RequestHandler();
        public AccountingFinanceDepartmentView()
        {
            InitializeComponent();
            requestHandler = new RequestHandler();
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            FundModel fund = FundRequest.SelectedItem as FundModel;
            requestHandler.acceptRequest(fund.RequestID);
        }

        private void rejectBtn_Click(object sender, RoutedEventArgs e)
        {
            FundModel fund = FundRequest.SelectedItem as FundModel;
            requestHandler.declineRequest(fund.RequestID);
        }
    }
}
