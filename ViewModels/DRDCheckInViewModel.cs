using Caliburn.Micro;

namespace UnderTheSea.ViewModels
{
    public class DRDCheckInViewModel:Screen
    {
        private int employeeID;
        public DRDCheckInViewModel(int EmployeeID)
        {
            employeeID = EmployeeID;
        }
        public string WarningLbl { get; set; }
        public void checkInBtn()
        {
            Ticket ticketDA = new Ticket();
            Ticket ticket = ticketDA.getTicket();
            if (ticket == null)
            {
                WarningLbl = "Undefined QR Code";
            }
            else
            {
                DiningRoomDivisionViewModel.getInstance(employeeID).HeaderID = ticket.TicketID;

                IWindowManager manager = new WindowManager();
                manager.ShowWindow(new DRDEatMethodViewModel(employeeID), null, null);
            }
        }
    }
}
