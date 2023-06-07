using System.Windows;
using System.Windows.Controls;
using UnderTheSea.Models;
using static UnderTheSea.ViewModels.KDOrderViewModel;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for KDOrderView.xaml
    /// </summary>
    public partial class KDOrderView : UserControl
    {
        private OrderHandler orderHandler;
        public KDOrderView()
        {
            InitializeComponent();
            orderHandler = new OrderHandler();
        }

        private void cookBtn_Click(object sender, RoutedEventArgs e)
        {
            menuOrder order = Order.SelectedItem as menuOrder;
            orderHandler.updateOrder(order.Order.OrderID, order.Order.MenuID, "Cooked");
        }
    }
}
