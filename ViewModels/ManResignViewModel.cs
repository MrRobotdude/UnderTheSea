using Caliburn.Micro;

namespace UnderTheSea.ViewModels
{
    public class ManResignViewModel:Screen
    {
        private RequestHandler requestHandler;
        private Employee employeeDA;
        public LeaveModel SelectedRequest { get; set; }
        public class LeaveModel
        {
            public Request request { get; set; }
            public string employeeName { get; set; }
        }
        public BindableCollection<LeaveModel> ResignLetters { get; set; }
        public ManResignViewModel()
        {
            requestHandler = new RequestHandler();
            employeeDA = new Employee();
            ResignLetters = new BindableCollection<LeaveModel>();
            foreach (Request req in requestHandler.getResignRequest())
            {
                ResignLetters.Add(new LeaveModel
                {
                    request = req,
                    employeeName = employeeDA.GetEmployee(req.Sender).UserName
                });
            }

        }
        public void BtnConfirm()
        {
            requestHandler.acceptRequest(SelectedRequest.request.RequestID);
            employeeDA.updateEmployee(SelectedRequest.request.Sender, "Deleted");
        }
        public void BtnDecline()
        {
            requestHandler.declineRequest(SelectedRequest.request.RequestID);
        }
    }
}
