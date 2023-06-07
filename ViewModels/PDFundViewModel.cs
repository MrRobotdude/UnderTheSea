using Caliburn.Micro;

namespace UnderTheSea.ViewModels
{
    public class PDFundViewModel:Screen
    {
        private Request requestDA;
        public RequestMod SelectedRequest { get; set; }
        public class RequestMod
        {
            public Request Request { get; set; }
            public int Amount { get; set; }
            public string Description { get; set; }

        }
        public BindableCollection<RequestMod> FundRequests { get; set; }

        public PDFundViewModel()
        {
            requestDA = new Request();
            FundRequests = new BindableCollection<RequestMod>();
            foreach(Request req in requestDA.GetRequestBySender(6))
            {
                string[] info = req.Description.Split('-');
                FundRequests.Add(new RequestMod
                {
                    Request = req,
                    Amount = int.Parse(info[1]),
                    Description= info[2]
                });
            }
            
        }
        public void BtnProceed()
        {
            if (SelectedRequest.Request.Status.Equals("Confirmed"))
            {
                requestDA.updateStatus(SelectedRequest.Request.RequestID, "Proceeded");
                IWindowManager manager = new WindowManager();
                manager.ShowWindow(new PDReportPurchaseViewModel(SelectedRequest.Request.RequestID), null, null);
            }
        }
    }
}
