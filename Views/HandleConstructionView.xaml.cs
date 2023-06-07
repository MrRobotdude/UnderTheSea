using System.Windows;
using System.Windows.Controls;
using UnderTheSea.Models;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for HandleConstructionView.xaml
    /// </summary>
    public partial class HandleConstructionView : UserControl
    {
        private Facility facilityDA;
        public HandleConstructionView()
        {
            InitializeComponent();
            facilityDA = new Facility();
        }

        private void handleBtn_Click(object sender, RoutedEventArgs e)
        {
            Facility facility = Facility.SelectedItem as Facility;
            if(facility.Status.Equals("Under Construction")){
                facilityDA.updateFacility(facility.FacilityID, "Operating", detailTxtBox.Text);
            }
            else if(facility.Status.Equals("Under Demolition"))
            {
                facilityDA.updateFacility(facility.FacilityID, "Deleted", detailTxtBox.Text);
            }
            else if(facility.Status.Equals("Under Renovation"))
            {
                facilityDA.updateFacility(facility.FacilityID, "Operating", detailTxtBox.Text);
            }
        }
    }
}
