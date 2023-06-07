using Caliburn.Micro;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class EditRideorAttractionViewModel:Screen
    {
        private Facility myVar;

        public Facility SelectedFacility
        {
            get { return myVar; }
            set { myVar = value;
                NotifyOfPropertyChange(() => SelectedFacility);

            }
        }

        //public Facility SelectedFacility { get; set; }
        public BindableCollection<Facility> Facility { get; set; }
        private Facility facilityDA = new Facility();

        public EditRideorAttractionViewModel()
        {
            Facility = new BindableCollection<Models.Facility>(facilityDA.getAllFacility());
        }
        public void FacUpdate()
        {
            RequestHandler requestHandler = new RequestHandler();
            requestHandler.addRequest(3, 11,"", SelectedFacility , "Update Facility");
        }
        public void FacDelete()
        {
            RequestHandler requestHandler = new RequestHandler();
            requestHandler.addRequest(3, 11, "", SelectedFacility, "Delete Facility");
        }

    }
}
