using System.Windows;
using System.Windows.Controls;
using UnderTheSea.Models;
using UnderTheSea.ViewModels;
using static UnderTheSea.ViewModels.RADRequestViewModel;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for RADRequestView.xaml
    /// </summary>
    public partial class RADRequestView : UserControl
    {
        public RADRequestView()
        {
            InitializeComponent();
        }

        private void proceedBtn_Click(object sender, RoutedEventArgs e)
        {
            RADRequestModel request = Request.SelectedItem as RADRequestModel;
            if (request.Status.Equals("Confirmed"))
            {
                RequestHandler requestHandler = new RequestHandler();
                requestHandler.proceedRequest(request.RequestID);
                Facility facilityDA = new Facility();
                int type = 0;
                if(request.RequestType.Equals("Add Ride")|| request.RequestType.Equals("Add Attraction"))
                {
                    if (request.RequestType.Equals("Add Ride"))
                    {
                        type = 1;
                    }
                    else if (request.RequestType.Equals("Add Attraction"))
                    {
                        type = 2;
                    }
                    facilityDA.insertFacility(request.FacilityInfo.FacilityName, type, request.FacilityInfo.Price, request.FacilityInfo.FacilityDetail);
                }
                else if(request.RequestType.Equals("Delete Facility"))
                {
                    facilityDA.delete(request.FacilityInfo.FacilityID);
                }
                else if(request.RequestType.Equals("Update Facility"))
                {
                    facilityDA.updateFacility(request.FacilityInfo.FacilityID, request.FacilityInfo.FacilityName, request.FacilityInfo.Price);
                }
                
            }
            else
            {
                err.Content = "Request is unconfirmed cannot proceed request";
            }
            
        }
    }
}
