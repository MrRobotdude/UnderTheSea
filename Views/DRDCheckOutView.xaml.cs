using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UnderTheSea.Models;
using UnderTheSea.ViewModels;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for DRDCheckOutView.xaml
    /// </summary>
    public partial class DRDCheckOutView : UserControl
    {
        public DRDCheckOutView()
        {
            InitializeComponent();
        }

        private void receiptBtn_Click(object sender, RoutedEventArgs e)
        {
            Order order = Order.SelectedItem as Order;
            IWindowManager manager = new WindowManager();
            manager.ShowWindow(new DRDReceiptViewModel(order.OrderID), null, null);
            
        }
    }
}
