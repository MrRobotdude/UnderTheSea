using System;
using System.Windows;
using System.Windows.Controls;
using UnderTheSea.Models;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for CreateSchedule.xaml
    /// </summary>
    public partial class CreateScheduleView : UserControl
    {
        private Schedule scheduleDA = new Schedule();
        public CreateScheduleView()
        {
            InitializeComponent();
        }

        private void createScheduleBtn_Click(object sender, RoutedEventArgs e)
        {
            Facility ride = (Facility)Ride.SelectedItem;
            DateTime date =(DateTime)Date.SelectedDate;
            scheduleDA.CreateSchedule(date, ride.FacilityID);
        }
    }
}
