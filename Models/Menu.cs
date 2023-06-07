using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.Models
{
    public class Menu
    {
        public int MenuID { get; set; }
        public string MenuName { get; set; }
        public int MenuPrice { get; set; }
        public string MenuStatus { get; set; }

        public List<Menu> getAllMenuForDRD()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Menu>($"SELECT * FROM MsMenu WHERE MenuStatus LIKE '%Available%'").ToList();
                return output;
            }
        }

        public void insertMenu(string MenuName, int MenuPrice)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Menu_Insert @MenuName, @MenuPrice", new { MenuName, MenuPrice });
            }
        }

        public void DeleteMenu(int menuID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Menu_Delete @menuID", new { menuID });
            }
        }

        public void UpdateMenu(Menu selectedMenu)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Menu_Update @MenuID, @MenuName, @MenuPrice, @MenuStatus", new { selectedMenu.MenuID, selectedMenu.MenuName, selectedMenu.MenuPrice, selectedMenu.MenuStatus });
            }
        }

        public List<Menu> getAllMenu()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Menu>($"SELECT * FROM MsMenu").ToList();
                return output;
            }
        }

        public Menu getMenu(int menuID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Menu>($"SELECT * FROM MsMenu WHERE MenuID='"+menuID+"'").ToList();
                return output.ElementAt(0);
            }
        }

        public List<Menu> getAllMenuForKD()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Menu>($"SELECT * FROM MsMenu").ToList();
                return output;
            }
        }

        public string getMenuName(int menuID)
        {
            return getMenu(menuID).MenuName;
        }
        public int getMenuPrice(int menuID)
        {
            return getMenu(menuID).MenuPrice;
        }
    }
}
