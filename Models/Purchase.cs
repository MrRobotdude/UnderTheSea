using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.Models
{
    public class Purchase
    {
        public int RequestID { get; set; }
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public int ItemQuantity { get; set; }

        public void InsertPurchase(int requestID,string itemName,int itemPrice, int itemQuantity)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Purchase_Insert @requestID, @itemName, @itemPrice, @itemQuantity", new { requestID,itemName,itemPrice,itemQuantity });
            }
        }

    }
}
