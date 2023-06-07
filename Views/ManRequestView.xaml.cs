using System.Windows;
using System.Windows.Controls;
using UnderTheSea.ViewModels;
using static UnderTheSea.ViewModels.ManRequestViewModel;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for ManRequestView.xaml
    /// </summary>
    public partial class ManRequestView : UserControl
    {
        private RequestHandler requestHandler;
        public ManRequestView()
        {
            InitializeComponent();
            requestHandler = new RequestHandler();
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            RequestViewModel request = Request.SelectedItem as RequestViewModel;
            requestHandler.acceptRequest(request.RequestID);

        }

        private void declineBtn_Click(object sender, RoutedEventArgs e)
        {
            RequestViewModel request = Request.SelectedItem as RequestViewModel;
            requestHandler.declineRequest(request.RequestID);
        }
    }
}
