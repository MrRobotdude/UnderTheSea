using Caliburn.Micro;
using System.Collections.Generic;
using UnderTheSea.Models;


namespace UnderTheSea.ViewModels
{
    public class DRDMenuViewModel:Screen
    {
        private int employeeID;
        private DiningRoomDivisionViewModel viewModel;
        private OrderHandler orderHandler;
        public int TableNumber { get; set; }
        public class MenuModel
        {
            public int MenuID { get; set; }
            public string MenuName { get; set; }
            public int MenuPrice { get; set; }
            public int Quantity { get; set; }
        }
        private Menu menuDA;
        public BindableCollection<MenuModel> Menu { get; set; }
        public DRDMenuViewModel(int tableNumber, int EmployeeID)
        {
            employeeID = EmployeeID;
            orderHandler = new OrderHandler();
            TableNumber = tableNumber;
            Menu = new BindableCollection<MenuModel>();
            menuDA = new Menu();
            viewModel = DiningRoomDivisionViewModel.getInstance(employeeID);
            foreach(Menu menu in menuDA.getAllMenuForDRD())
            {
                Menu.Add(new MenuModel
                {
                    MenuID = menu.MenuID,
                    MenuName = menu.MenuName,
                    MenuPrice = menu.MenuPrice,
                    Quantity = 0
                });
            }
        }

        public void OrderBtn()
        {
            List<MenuModel> menus = new List<MenuModel>();
            Order order = null;
            foreach(MenuModel menu in Menu)
            {
                if (menu.Quantity!=0)
                {
                   if(order == null)
                    {
                        order = new Order
                        {
                            TableNumber = this.TableNumber,
                            HeaderID = viewModel.HeaderID
                        };
                        menus.Add(menu);

                    }
                   else
                    {
                        menus.Add(menu);
                    } 
                }
            }
            if (order != null)
            {
                orderHandler.addOrder(order, menus);
            }
            
        }

    }
}
