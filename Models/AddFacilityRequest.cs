using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.ViewModels;

namespace UnderTheSea.Models
{
    class AddFacilityRequest:Request
    {   
        public AddFacilityRequest(Facility facility, string detail, string requestType)
        {
            this.Description =requestType+ "-" + facility.FacilityName +"-"+ facility.Price+"-"+detail;
        }
    }
}
