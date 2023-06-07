using Caliburn.Micro;

namespace UnderTheSea.ViewModels
{
    public class AccountingFinanceDepartmentViewModel:Screen
    {
        private int employeeID;
        public class FundModel
        {
            public int RequestID { get; set; }
            public string Sender { get; set; }
            public int Price { get; set; }
            public string Status { get; set; }
            public string Description { get; set; }
        }

        public BindableCollection<FundModel> FundRequest { get; set; }
        private RequestHandler requestHandler;
        private Request requestDA;
        public AccountingFinanceDepartmentViewModel(int EmployeeID)
        {
            employeeID = EmployeeID;
            FundRequest = new BindableCollection<FundModel>();
            requestHandler = new RequestHandler();
            requestDA = new Request();

            foreach(Request request in requestDA.GetRequest(7))
            {
                string[] info=request.Description.Split('-');
                FundRequest.Add(new FundModel
                {
                    RequestID = request.RequestID,
                    Status = request.Status,
                    Sender = getDepartmentName(request.Sender),
                    Price = int.Parse(info[1]),
                    Description = info[2]
                });
            }

        }
        private string getDepartmentName(int id)
        {
            if (id == 2) return "Maintenance Department";
            else if (id == 3) return "Ride and Attraction Department";
            else if (id == 4) return "Construction Department";
            else if (id == 5) return "Restaurant Department";
            else if (id == 6) return "Purchasing Department";
            else if (id == 9) return "Sales and Marketing Department";
            else return "";
        }
        public void BtnLeave()
        {
            IWindowManager manager = new WindowManager();
            manager.ShowWindow(new LeavePermitViewModel(employeeID), null, null);
        }
        public void BtnResign()
        {
            IWindowManager manager = new WindowManager();
            manager.ShowWindow(new ResignLetterViewModel(employeeID), null, null);
        }
        public void BtnSignOut()
        {
            IWindowManager manager = new WindowManager();
            manager.ShowWindow(new WorkReportViewModel(employeeID), null, null);
            ShellViewModel viewModel = ShellViewModel.getInstance();
            viewModel.ShowLoginView();
        }
    }
}
