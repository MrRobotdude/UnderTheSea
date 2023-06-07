using Caliburn.Micro;
using System;

namespace UnderTheSea.ViewModels
{

    public class ManHotelIncomeViewModel:Screen
    {
        private Ticket ticketDA;
        public class HotelIncome
        {
            public DateTime CheckIn { get; set; }
            public DateTime CheckOut { get; set; }
            public int TotalIncome { get; set; }
        }
        
        public BindableCollection<HotelIncome> Income { get; set; }
        public ManHotelIncomeViewModel()
        {
            ticketDA = new Ticket();
            Income = new BindableCollection<HotelIncome>(ticketDA.getHotelIncome());
        }
    }
}
