using System;
using System.Windows;
using System.Windows.Controls;
using UnderTheSea.Models;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for SMDPurchaseView.xaml
    /// </summary>
    public partial class SMDPurchaseView : UserControl
    {
        public SMDPurchaseView()
        {
            InitializeComponent();
        }

        private void purchaseBtn_Click(object sender, RoutedEventArgs e)
        {
            Department departmentDA = new Department();
            Advertisement advertisement = Advertisement.SelectedItem as Advertisement;
            departmentDA.sendRequest(9, 6, Int32.Parse(priceTxtBox.Text), advertisement.AdvertisementDescription, "Purchase Request");
        }

        private void purchaseBtn_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
