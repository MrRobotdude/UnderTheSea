using System;
using System.Windows;
using System.Windows.Controls;
using UnderTheSea.ViewModels;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for AttractionDepartmentView.xaml
    /// </summary>
    public partial class AttractionDepartmentView : UserControl
    {
        public AttractionDepartmentView()
        {
            InitializeComponent();
        }

        private void checkTicketBtn_Click(object sender, RoutedEventArgs e)
        {
            Ticket ticketDA = new Ticket();
            Ticket ticket = ticketDA.getTicket();
            if (ticket == null)
            {
                WarningLbl.Content = "Undefined QR Code";
            }
            else
            {
                if ((DateTime.Now - ticket.getDate(ticket.TicketID)).TotalDays > 1)
                {
                    WarningLbl.Content = "Its already Out of Date";
                }
                else
                {
                    WarningLbl.Content = "You are Allowed";
                    ticketDA.updateStatus(ticket.TicketID, "Scanned");
                }

            }
        }

        private void sellTicketBtn_Click(object sender, RoutedEventArgs e)
        {
            Ticket ticketDA = new Ticket();
            ticketDA.buyTicket();
        }
    }
}
