using Caliburn.Micro;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class SMDPurchaseViewModel:Screen
    {
        private Advertisement advertisementDA = new Advertisement();
        public BindableCollection<Advertisement> Advertisement { get; set; }
        public SMDPurchaseViewModel()
        {
            Advertisement = new BindableCollection<Models.Advertisement>();
            foreach(Advertisement advertisement in advertisementDA.getAllAdvertisement())
            {
                Advertisement.Add(advertisement);
            }
        }
    }
}
