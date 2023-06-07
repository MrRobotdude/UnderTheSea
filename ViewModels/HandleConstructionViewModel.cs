using Caliburn.Micro;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class HandleConstructionViewModel:Screen
    {
        private Facility facilityDA = new Facility();
        public BindableCollection<Facility> Facility { get; set; }
        public HandleConstructionViewModel()
        {
            Facility = new BindableCollection<Models.Facility>(facilityDA.getFacilityBaseStatus("Under Construction"));
            Facility.AddRange(facilityDA.getFacilityBaseStatus("Under Demolition"));
            Facility.AddRange(facilityDA.getFacilityBaseStatus("Under Renovation"));
            
        }
    }
}
