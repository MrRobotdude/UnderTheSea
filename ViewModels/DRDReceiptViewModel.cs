using Caliburn.Micro;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class DRDReceiptViewModel:Screen
    {
        private OrderHandler orderHandler;
        OrderDetail orderDetailDA;
        private Menu menuDA;
        public int grandTotal { get; set; }
        public class ReceiptModel
        {
            public string MenuName { get; set; }
            public int MenuPrice { get; set; }
            public int Quantity { get; set; }
            public int TotalPrice { get; set; }
        }
        public BindableCollection<ReceiptModel> Receipt { get; set; }

        public int OrderID { get; set; }
        public DRDReceiptViewModel(int orderID)
        {
            OrderID = orderID;
            orderHandler = new OrderHandler();
            orderDetailDA = new OrderDetail();
            menuDA = new Menu();
            Receipt = new BindableCollection<ReceiptModel>();
            grandTotal = 0;
            foreach (OrderDetail order in orderDetailDA.getOrderDetail(OrderID))
            {
                ReceiptModel receipt = new ReceiptModel
                {
                    MenuName = menuDA.getMenuName(order.MenuID),
                    MenuPrice = menuDA.getMenuPrice(order.MenuID),
                    Quantity = order.Quantity,
                    TotalPrice = menuDA.getMenuPrice(order.MenuID) * order.Quantity
                };
                Receipt.Add(receipt);
                grandTotal += receipt.TotalPrice;
            }
        }
    }
}
