using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.ViewModels;

namespace UnderTheSea.Models
{
    class AddPurchaseRequest:Request
    {
        public AddPurchaseRequest(int price, string detail)
        {
            this.Description = "Purchase Request-" + price + "-" + detail;
        }
    }
}
