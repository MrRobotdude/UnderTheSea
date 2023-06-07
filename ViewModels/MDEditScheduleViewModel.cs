using Caliburn.Micro;
using System;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class MDEditScheduleViewModel:Screen
    {
        private ScheduleViewModel myVar;

        public ScheduleViewModel SelectedSchedule
        {
            get { return myVar; }
            set
            {
                myVar = value;
                NotifyOfPropertyChange(() => SelectedSchedule);
            }
        }
        public class ScheduleViewModel
        {
            public int ScheduleID { get; set; }
            public DateTime ScheduleDate { get; set; }
            public String RideName { get; set; }
            public String RideStatus { get; set; }
        }

        private Facility facilityDA = new Facility();
        public BindableCollection<ScheduleViewModel> Schedule { get; set; }
        Schedule scheduleDa;
        public MDEditScheduleViewModel()
        {
            scheduleDa = new Schedule();
            Schedule = new BindableCollection<ScheduleViewModel>();
            foreach (Schedule schedule in scheduleDa.getAllSchedule())
            {
                Schedule.Add(new ScheduleViewModel
                {
                    ScheduleID = schedule.ScheduleID,
                    ScheduleDate = schedule.ScheduleDate,
                    RideName = facilityDA.getFacilityName(schedule.FacilityID),
                    RideStatus = facilityDA.getFacilityStatus(schedule.FacilityID)
                });
            }

        }

        public void btnUpdate()
        {
            scheduleDa.updateSchedule(SelectedSchedule.ScheduleID, SelectedSchedule.ScheduleDate);
        }
        public void btnDelete()
        {
            scheduleDa.updateSchedule(SelectedSchedule.ScheduleID, "Deleted");
        }
    }
}
