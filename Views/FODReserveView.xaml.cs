using Caliburn.Micro;
using System;
using System.Windows;
using System.Windows.Controls;
using UnderTheSea.Models;
using UnderTheSea.ViewModels;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for FODReserveView.xaml
    /// </summary>
    public partial class FODReserveView : UserControl
    {
        private RoomHandler roomHandler;
        public FODReserveView()
        {
            InitializeComponent();
            roomHandler = new RoomHandler();
        }

        private void reserveBtn_Click(object sender, RoutedEventArgs e)
        {
            IWindowManager manager = new WindowManager();
            manager.ShowWindow(new FODPaymentViewModel(customerName.Text, passport.Text, int.Parse(roomNumber.Text), (DateTime)CheckInDate.SelectedDate, (DateTime)CheckOutDate.SelectedDate), null, null);
        }
    }
}
