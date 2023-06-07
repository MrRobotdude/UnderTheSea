using Caliburn.Micro;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class DRDCheckOutViewModel:Screen
    {
        public BindableCollection<Order> Order { get; set; }
        private OrderHandler orderHandler;
        Order orderDA;
        public DRDCheckOutViewModel()
        {
            orderHandler = new OrderHandler();
            orderDA = new Order();
            Order = new BindableCollection<Models.Order>(orderDA.getAllOrder());
            
        }
    }
}
