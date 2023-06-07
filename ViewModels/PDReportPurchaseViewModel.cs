using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class PDReportPurchaseViewModel:Screen
    {
        private int requestID;
        public string ItemName { get; set; }
        public string ItemPrice { get; set; }
        public string ItemQuantity { get; set; }

        public PDReportPurchaseViewModel(int requestId)
        {
            requestID = requestId;
        }
        public void btnReport()
        {
            string[] itemNames = ItemName.Split('\n');
            string[] itemPrice = ItemPrice.Split('\n');
            string[] itemQuantity = ItemQuantity.Split('\n');
            Purchase da = new Purchase();
            for (int i = 0; i < itemNames.Count();i++)
            {
                da.InsertPurchase(requestID, itemNames[i], int.Parse(itemPrice[i]), int.Parse(itemQuantity[i]));
            }
                
           
            
        }
    }
}