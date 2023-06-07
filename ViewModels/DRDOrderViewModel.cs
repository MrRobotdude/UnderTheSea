using Caliburn.Micro;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class DRDOrderViewModel:Screen
    {
        public class FoodOrderModel
        {
            public int TableNumber { get; set; }
            public string Menu { get; set; }
            public int Quantity { get; set; }
            public string Status { get; set; }
            public int MenuID { get; set; }
            public int OrderID { get; set; }
        }

        public BindableCollection<FoodOrderModel> Order { get; set; }
        private Order orderDA;
        private OrderDetail orderDetailDA;
        private Menu menuHandler;
        public DRDOrderViewModel()
        {
            Order = new BindableCollection<FoodOrderModel>();
            orderDA = new Order();
            orderDetailDA = new OrderDetail();
            menuHandler = new Menu();
            foreach(OrderDetail order in orderDetailDA.getAllOrder())
            {
                Order.Add(new FoodOrderModel
                {
                    Quantity = order.Quantity,
                    Status = order.OrderStatus,
                    TableNumber = orderDA.getTableNumber(order.OrderID),
                    Menu = menuHandler.getMenuName(order.MenuID),
                    OrderID = order.OrderID,
                    MenuID = order.MenuID
                });
            }
        }
    }
}
