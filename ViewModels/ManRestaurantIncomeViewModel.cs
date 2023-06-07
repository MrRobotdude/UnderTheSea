using Caliburn.Micro;
using System;

namespace UnderTheSea.ViewModels
{
    public class ManRestaurantIncomeViewModel:Screen
    {
        private Ticket ticketDA;
        public class RestaurantIncome{
            public int TotalIncome { get; set; }
            public DateTime TransactionDate { get; set; }
        }
        public BindableCollection<RestaurantIncome> Income { get; set; }
        public ManRestaurantIncomeViewModel()
        {
            ticketDA = new Ticket();
            Income = new BindableCollection<RestaurantIncome>(ticketDA.getRestaurantIncome()); 
        }
    }
}
