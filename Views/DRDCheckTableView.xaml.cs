using System.Windows;
using System.Windows.Controls;
using UnderTheSea.Models;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for DRDCheckTableView.xaml
    /// </summary>
    public partial class DRDCheckTableView : UserControl
    {
        private OrderHandler orderHandler;
        public DRDCheckTableView()
        {
            InitializeComponent();
            orderHandler = new OrderHandler();
        }

        private void ReserveTable_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
