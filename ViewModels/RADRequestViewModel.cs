using Caliburn.Micro;
using System;
using System.Linq;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class RADRequestViewModel : Screen
    {
        private Facility facilityDA;
        public class RADRequestModel
        {
            public int RequestID { get; set; }
            public string RequestType { get; set; }
            public Facility FacilityInfo { get; set; }
            public string Status { get; set; }
            
        }

        public BindableCollection<RADRequestModel> Request { get; set; }
        private Request requestDA = new Request();

        public RADRequestViewModel()
        {
            facilityDA = new Facility();
            Request = new BindableCollection<RADRequestModel>();
            foreach (Request request in requestDA.GetRequest(3))
            {
                string[] info = extractInformation(request.Description);
                Facility facility = createFacilityInformation(info);
                Request.Add(new RADRequestModel
                {
                    Status = request.Status,
                    RequestType = info[0],
                    FacilityInfo = facility,
                    RequestID = request.RequestID
                });
            }
        }
        private string[] extractInformation(string desc)
        {
            string[] output = desc.Split('-');
            return output;
        }
        private Facility createFacilityInformation(string[] info)
        {
            Facility output = new Facility();
            if (info[0].Equals("Add Ride")|| info[0].Equals("Add Attraction"))
            {
                output.FacilityType = 1;
                output.FacilityName = info[1];
                output.Price = Int32.Parse(info[2]);
                output.FacilityDetail = info[3];
            }
            else if(info[0].Equals("Delete Facility"))
            {
                output = facilityDA.getFacility(int.Parse(info[1])).ElementAt(0);
            }
            else if(info[0].Equals("Update Facility"))
            {
                output = facilityDA.getFacility(int.Parse(info[1])).ElementAt(0);
                output.FacilityName = info[2];
                output.Price = int.Parse(info[3]);
            }
            return output;
        }
    }

}

        

