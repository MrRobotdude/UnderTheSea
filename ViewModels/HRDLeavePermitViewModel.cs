using Caliburn.Micro;

namespace UnderTheSea.ViewModels
{
    public class HRDLeavePermitViewModel:Screen
    {
        private RequestHandler requestHandler;
        private Employee employeeDA;
        public LeaveModel SelectedRequest { get; set; }
        public class LeaveModel
        {
            public Request request { get; set; }
            public string  employeeName { get; set; }
        }
        public BindableCollection<LeaveModel> LeaveRequest { get; set; }
        public HRDLeavePermitViewModel()
        {
            requestHandler = new RequestHandler();
            employeeDA = new Employee();
            LeaveRequest = new BindableCollection<LeaveModel>();
            foreach(Request req in requestHandler.getLeaveRequest())
            {
                LeaveRequest.Add(new LeaveModel
                {
                    request = req,
                    employeeName = employeeDA.GetEmployee(req.Sender).UserName
                });
            }
            
        }
        public void BtnConfirm()
        {
            requestHandler.acceptRequest(SelectedRequest.request.RequestID);
            employeeDA.updateEmployee(SelectedRequest.request.Sender, "Leaving");
        }
        public void BtnDecline()
        {
            requestHandler.declineRequest(SelectedRequest.request.RequestID);
        }
    }
}
