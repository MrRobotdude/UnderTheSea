using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.ViewModels;

namespace UnderTheSea.Models
{
    public class Order
    {
        public int HeaderID { get; set; }
        public int OrderID { get; set; }
        public int TableNumber { get; set; }
        public string Status { get; set; }

        public Order insertOrder(Order order)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Order_Insert @HeaderID, @TableNumber", order);
                var output = connection.Query<Order>($"SELECT * FROM TrOrderHeader WHERE TicketID = "+ order.HeaderID +" AND OrderID = (SELECT MAX(OrderID) FROM TrOrderHeader WHERE TicketID ="+order.HeaderID+")").ToList();
                return output.ElementAt(0);
            }
        }

        public Order getOrder(int OrderID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Order>($"SELECT * FROM TrOrderHeader WHERE OrderID="+OrderID+"").ToList();
                return output.ElementAt(0);
            }
        }

        public List<Order> getAllOrder()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Order>($"SELECT * FROM TrOrderHeader WHERE Status = 'Not Paid'").ToList();
                return output;
            }
        }

        public void updateOrder(int OrderID,string Status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Order_Update @OrderID, @Status", new { OrderID, Status});    
            }
        }

        public int getTableNumber(int orderID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Order>($"SELECT * FROM TrOrderHeader WHERE OrderID='"+orderID+"'").ToList();
                return output.ElementAt(0).TableNumber;
            }
        }
        
    }

    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int MenuID { get; set; }
        public int Quantity { get; set; }
        public string OrderStatus { get; set; }

        public void insertOrderDetail(int orderID, int menuID, int quantity)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.OrderDetail_Insert @orderID, @menuID, @quantity", new {orderID, menuID, quantity });
            }
        }

        internal List<OrderDetail> getOrderDetail(int orderID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<OrderDetail>($"SELECT * FROM TrOrderDetail WHERE OrderID='"+orderID+"'").ToList();
                return output;
            }
        }

        public List<OrderDetail> getAllOrder()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<OrderDetail>($"SELECT * FROM TrOrderDetail WHERE OrderStatus NOT LIKE 'Served'").ToList();
                return output;
            }
        }

        public void updateStatus(int MenuID, int OrderID, string Status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.OrderDetail_Update @MenuID, @OrderID, @Status", new { MenuID,OrderID,Status });
            }
        }
    }
    public class Table
    {
        public int TableNumber { get; set; }
        public string Status { get; set; }

        public List<Table> getAllTable()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Table>($"SELECT * FROM MsTable").ToList();
                return output;
            }
        }

        internal void updateTable(int number, string status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Table_Update @number, @status", new {number,status});
            }
        }

        public Table getTable(int number)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Table>($"SELECT * FROM MsTable WHERE TableNumber = '"+number+"'").ToList();
                return output.ElementAt(0);
            }
        }
    }

    public class OrderHandler
    {
        private Order OrderDA;
        private OrderDetail OrderDetailDA;
        private Table TableDA;
        public OrderHandler()
        {
            OrderDA = new Order();
            OrderDetailDA = new OrderDetail();
            TableDA = new Table();
        }

        public void reserveTable(int number)
        {
            TableDA.updateTable(number, "Reserved");
        }

        public void addOrder(Order order, List<DRDMenuViewModel.MenuModel> menus)
        {
            Order getOrderID = OrderDA.insertOrder(order);
            foreach (DRDMenuViewModel.MenuModel menu in menus)
            {
                OrderDetailDA.insertOrderDetail(getOrderID.OrderID, menu.MenuID, menu.Quantity);
            }
        }

        public void updateOrder(int orderID, int menuID, string status)
        {
            OrderDetailDA.updateStatus(menuID, orderID, status);
        }

        public void serveOrder(int menuID, int orderID)
        {
            OrderDetailDA.updateStatus(menuID, orderID, "Served");
        }

        public void cancelOrder(int menuID, int orderID)
        {
            OrderDetailDA.updateStatus(menuID, orderID, "Canceled");
        }
        
        public void paidOrder(int orderID)
        {
            OrderDA.updateOrder(orderID, "Paid");
            TableDA.updateTable(OrderDA.getTableNumber(orderID), "Not Reserved");
        }
    }
}
