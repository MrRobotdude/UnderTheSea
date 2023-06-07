using Caliburn.Micro;
using System;

namespace UnderTheSea.ViewModels
{
    public class ManTicketIncomeViewModel:Screen
    {
        private Ticket ticketDA;
        public class TicketIncome
        {
            public DateTime TransactionDate { get; set; }
            public int TotalIncome { get; set; }
        }
        public BindableCollection<TicketIncome> Income { get; set; }
        public ManTicketIncomeViewModel()
        {
            ticketDA = new Ticket();
            Income = new BindableCollection<TicketIncome>(ticketDA.getTicketIncome());
       
        }
    }
}
