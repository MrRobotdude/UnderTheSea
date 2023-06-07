using Caliburn.Micro;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class CreateScheduleViewModel:Screen
    {
        Facility facilityDA = new Facility();
        public BindableCollection<Facility> Ride { get; set; }

        public CreateScheduleViewModel()
        {
            Ride = new BindableCollection<Facility>();
            foreach(Facility ride in facilityDA.getFacilityBaseStatus("Operating"))
            {
                Ride.Add(ride);
            }
        }
    }
}
