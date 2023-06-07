using Caliburn.Micro;

namespace UnderTheSea.ViewModels
{
    public class PurchaseRequestViewModel:Screen
    {
        private Request requestDA;
        public class purchaseRequestModel
        {
            public int RequestID { get; set; }
            public string Sender { get; set; }
            public string Status { get; set; }
            public string Description { get; set; }
            public int Price { get; set; }
        }
        public BindableCollection<purchaseRequestModel> PurchaseRequest { get; set; }

        public PurchaseRequestViewModel()
        {
            requestDA = new Request();
            PurchaseRequest = new BindableCollection<purchaseRequestModel>();
            foreach(Request request in requestDA.GetRequest(6))
            {
                string[] info = request.Description.Split('-');
                PurchaseRequest.Add(new purchaseRequestModel
                {
                    Sender = getDepartmentName(request.Sender),
                    Status = request.Status,
                    RequestID = request.RequestID,
                    Price = int.Parse(info[1]),
                    Description = info[2],
                    
                });
            }

        }
        private string getDepartmentName(int id)
        {
            if (id == 2) return "Maintenance Department";
            else if (id == 3) return "Ride and Attraction Department";
            else if (id == 4) return "Construction Department";
            else if (id == 5) return "Restaurant Department";
            else return "";
        }
    }
}
