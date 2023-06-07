using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.ViewModels
{
    public class ManIncomeViewModel:Conductor<object>
    {
        public void btnTicket()
        {
            ActivateItem(new ManTicketIncomeViewModel());
        }

        public void btnRestaurant()
        {
            ActivateItem(new ManRestaurantIncomeViewModel());
        }
        public void btnHotel()
        {
            ActivateItem(new ManHotelIncomeViewModel());
        }
    }
}
