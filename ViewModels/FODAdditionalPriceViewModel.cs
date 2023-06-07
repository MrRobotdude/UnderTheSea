using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.ViewModels
{
    public class FODAdditionalPriceViewModel:Screen
    {
        public class Property
        {
            public string propertyName { get; set; }
            public int propertyPrice { get; set; }
        }
        public int TotalCharge { get; set; }
        public int AmountOfMoney { get; set; }
        public BindableCollection<Property> PropertyList { get; set; }
        public FODAdditionalPriceViewModel(string[] properties)
        {
            PropertyList = new BindableCollection<Property>();
            TotalCharge = 0;
            foreach(string v in properties)
            {
                PropertyList.Add(new Property
                {
                    propertyName = v,
                    propertyPrice = getPrice(v)
                });
                TotalCharge += getPrice(v);
            }
        }
        public void btnPay()
        {
            if (AmountOfMoney >= TotalCharge)
            {
                TryClose();
            }
        }

        public int getPrice(string propertyName)
        {
            if (propertyName.Equals("Door"))
            {
                return 500000;
            }
            else if (propertyName.Equals("Bed"))
            {
                return 1000000;
            }
            else if (propertyName.Equals("Furniture"))
            {
                return 1000000;
            }
            else if(propertyName.Equals("Bathroom Property"))
            {
                return 200000;
            }
            else if (propertyName.Equals("Electronic"))
            {
                return 2500000;
            }
            return 0;
        }
    }
}
