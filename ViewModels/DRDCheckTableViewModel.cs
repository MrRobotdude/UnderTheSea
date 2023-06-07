using Caliburn.Micro;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class DRDCheckTableViewModel:Screen
    {
        private int employeeID;
        OrderHandler orderHandler;
        private Table TableDA;
        public int numberTxt { get; set; }
        public BindableCollection<Table> Table { get; set; }
        
        public DRDCheckTableViewModel(int EmployeeID)
        {
            employeeID = EmployeeID;
            TableDA = new Table();
            Table = new BindableCollection<Table>(TableDA.getAllTable());
            orderHandler = new OrderHandler();
        }
        public void ReserveTable()
        {
            orderHandler.reserveTable(numberTxt);
            DiningRoomDivisionViewModel.getInstance(employeeID).showMenu(numberTxt);
        }


    }
}
