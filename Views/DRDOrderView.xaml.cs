using System.Windows;
using System.Windows.Controls;
using UnderTheSea.Models;
using static UnderTheSea.ViewModels.DRDOrderViewModel;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for DRDOrderView.xaml
    /// </summary>
    public partial class DRDOrderView : UserControl
    {
        private OrderHandler orderHandler;
        public DRDOrderView()
        {
            InitializeComponent();
            orderHandler = new OrderHandler();
        }

        private void doneBtn_Click(object sender, RoutedEventArgs e)
        {
            FoodOrderModel order = Order.SelectedItem as FoodOrderModel;
            if (order.Status.Equals("Cooked"))
            {
                orderHandler.serveOrder(order.MenuID,order.OrderID);
            }
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            FoodOrderModel order = Order.SelectedItem as FoodOrderModel;
            if (!order.Status.Equals("Cooked") && !order.Status.Equals("Served"))
            {
                orderHandler.cancelOrder(order.MenuID, order.OrderID);
            }
        }
    }
}
