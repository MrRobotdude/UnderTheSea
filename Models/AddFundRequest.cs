using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.ViewModels;

namespace UnderTheSea.Models
{
    public class AddFundRequest:Request
    {
        public AddFundRequest(int price, string detail)
        {
            this.Description = "Fund Request-" + price + "-" + detail;
        }
    }
}
