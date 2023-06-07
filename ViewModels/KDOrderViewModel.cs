using Caliburn.Micro;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class KDOrderViewModel:Screen
    {
        private OrderDetail orderDetailDA;
        private Menu menuDA;
       public class menuOrder
        {
            public OrderDetail Order { get; set; }
            public string MenuName { get; set; }

        }
        public BindableCollection<menuOrder> Order { get; set; }

        public KDOrderViewModel()
        {
            menuDA = new Menu();
            orderDetailDA = new OrderDetail();
            Order = new BindableCollection<menuOrder>();
            foreach(OrderDetail order in orderDetailDA.getAllOrder())
            {
                Order.Add(new menuOrder
                {
                    Order = order,
                    MenuName = menuDA.getMenuName(order.MenuID)
                });
            }
        }
    }
}
