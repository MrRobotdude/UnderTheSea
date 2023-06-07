using System.Windows;
using UnderTheSea.Models;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for DRDReceiptView.xaml
    /// </summary>
    public partial class DRDReceiptView : Window
    {
        private OrderHandler orderHandler;
        public DRDReceiptView()
        {
            InitializeComponent();
            orderHandler = new OrderHandler();
        }

        private void payBtn_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(money.Text) >= int.Parse(grandTotal.Text))
            {
                orderHandler.paidOrder(int.Parse(OrderID.Content.ToString()));
                this.Close();
            }
        }
    }
}
