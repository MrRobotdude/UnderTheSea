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
                if (ticket.TicketDate.Date != DateTime.Today || ticket.Status != "Available")
                {
                    WarningLbl.Content = "This ticket is not valid for admission today.";
                }
                else
                {
                    WarningLbl.Content = "You are Allowed";
                    ticketDA.updateStatus(ticket.TicketID, "Scanned");
                    ((AttractionDepartmentViewModel)DataContext).RefreshTickets();
                }

            }
        }

        private void sellTicketBtn_Click(object sender, RoutedEventArgs e)
        {
            Ticket ticketDA = new Ticket();
            ticketDA.buyTicket();
            ((AttractionDepartmentViewModel)DataContext).RefreshTickets();
        }
    }
}
