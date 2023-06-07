using System.Windows;
using System.Windows.Controls;
using UnderTheSea.ViewModels;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for ManagerView.xaml
    /// </summary>
    public partial class ManagerView : UserControl
    {
        private ManagerViewModel viewModel;
        public ManagerView()
        {
            viewModel = ManagerViewModel.getInstance();
            
        }

        private void requestBtn_Click(object sender, RoutedEventArgs e)
        {
            viewModel.showRequestView();
        }
    }
}
