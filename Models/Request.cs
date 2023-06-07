using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class Request
    {
        public int RequestID { get; set; }
        public int Sender { get; set; }
        public int Receiver { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTime SentTime { get; set; }

        public List<Request> GetRequest(int receiverID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConnString")))
            {
                var output = connection.Query<Request>($"SELECT * FROM MsRequest WHERE Receiver = {receiverID} OR Sender = {receiverID}").ToList();
                return output;
            }
        }

        public void AddRequest(Request request)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConnString")))
            {
                connection.Execute("dbo.Request_Insert @Sender,@Receiver, @Description", request);
            }
        }

        public void updateStatus(int id, string status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConnString")))
            {
                connection.Execute("dbo.Request_Update @id,@status", new { id, status });
            }
        }

        public List<Request> GetRequestBySender(int departmentID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConnString")))
            {
                var output = connection.Query<Request>($"SELECT * FROM MsRequest WHERE Sender = {departmentID}").ToList();
                return output;
            }
        }

        public List<Request> getRequestByDesc(string desc)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConnString")))
            {
                var output = connection.Query<Request>($"SELECT * FROM MsRequest WHERE CHARINDEX('" + desc + "',[Description])>0").ToList();
                return output;
            }
        }
    }

    class AddPurchaseRequest : Request
    {
        public AddPurchaseRequest(int price, string description)
        {
            this.Description = price + "-" + description;
        }
    }

    class AddFundRequest : Request
    {
        public AddFundRequest(int price, string description)
        {
            this.Description = price + "-" + description;
        }
    }

    class AddEmployeeRequest : Request
    {
        public AddEmployeeRequest(Employee employee, string description, string requestType)
        {
            this.Description = requestType + "-" + employee.UserName + "-" + employee.Salary + "-" + employee.DepartmentID + "-" + employee.DivisionID + "-" + employee.Password + "-" + description;
        }
    }

    class RaiseSalaryRequest : Request
    {
        public RaiseSalaryRequest(Employee employee, string description, string requestType)
        {
            this.Description = requestType + "-" + employee.EmployeeID + "-" + employee.Salary + "-" + description;
        }

    }

    class FireEmployeeRequest : Request
    {
        public FireEmployeeRequest(Employee employee, string description, string requestType)
        {
            this.Description = requestType + "-" + employee.EmployeeID + "-" + description;
        }
    }
    class AddFacilityRequest : Request
    {
        public AddFacilityRequest(Facility facility, string Description,string requestType)
        {
            this.Description = requestType + "-" + facility.FacilityID + "-" + facility.FacilityName + "-" + facility.Price + "-" + Description;
        }
    }
    class UpdateFacilityRequest : Request
    {
        public UpdateFacilityRequest(Facility facility, string requestType)
        {
            this.Description = requestType + "-" + facility.FacilityID + "-" + facility.FacilityName + "-" + facility.Price;
        }
    }
    class DeleteFacilityRequest : Request
    {
        public DeleteFacilityRequest(Facility facility, string requestType)
        {
            this.Description = requestType + "-" + facility.FacilityID;
        }
    }

    class LeavePermitRequest : Request
    {
        public LeavePermitRequest(Employee employee, string description, string requestType)
        {
            this.Description = requestType + "-" + employee.EmployeeID + "-" + description;
        }
    }
    class ResignRequest : Request
    {
        public ResignRequest(Employee employee, string description, string requestType)
        {
            this.Description = requestType + "-" + employee.EmployeeID + "-" + description;
        }
    }
    class RequestHandler
    {
        Request DA = new Request();
        public void addRequest(int sender, int receiver, string description, Object obj, string requestType)
        {
            Request newRequest = null;
            if (obj is Facility)
            {
                if (requestType.Equals("Add Ride") || requestType.Equals("Add Attraction"))
                {
                    newRequest = new Models.AddFacilityRequest(obj as Facility, description, requestType)
                    {
                        Sender = sender,
                        Receiver = receiver
                    };
                }

                else if (requestType.Equals("Update Facility"))
                {
                    newRequest = new UpdateFacilityRequest(obj as Facility, requestType)
                    {
                        Sender = sender,
                        Receiver = receiver
                    };
                }
                else if (requestType.Equals("Delete Facility"))
                {
                    newRequest = new DeleteFacilityRequest(obj as Facility, requestType)
                    {
                        Sender = sender,
                        Receiver = receiver
                    };
                }
            }
            else if (obj is int)
            {
                if (requestType.Equals("Purchase Request"))
                {
                    newRequest = new Models.AddPurchaseRequest((int)obj, description)
                    {
                        Sender = sender,
                        Receiver = receiver
                    };
                }
                else
                {
                    newRequest = new Models.AddFundRequest((int)obj, description)
                    {
                        Sender = sender,
                        Receiver = receiver
                    };
                }

            }
            else if (obj is Employee)
            {
                if (requestType.Equals("Recruitment"))
                {
                    newRequest = new AddEmployeeRequest(obj as Employee, description, requestType)
                    {
                        Sender = sender,
                        Receiver = receiver
                    };
                }
                else if (requestType.Equals("Raise Salary"))
                {
                    newRequest = new RaiseSalaryRequest(obj as Employee, description, requestType)
                    {
                        Sender = sender,
                        Receiver = receiver
                    };
                }
                else if (requestType.Equals("Fire Employee"))
                {
                    newRequest = new FireEmployeeRequest(obj as Employee, description, requestType)
                    {
                        Sender = sender,
                        Receiver = receiver
                    };
                }
                else if (requestType.Equals("Leave Permit"))
                {
                    newRequest = new LeavePermitRequest(obj as Employee, description, requestType)
                    {
                        Sender = sender,
                        Receiver = receiver
                    };
                }
                else if (requestType.Equals("Resign Letter"))
                {
                    newRequest = new ResignRequest(obj as Employee, description, requestType)
                    {
                        Sender = sender,
                        Receiver = receiver
                    };
                }

            }
            DA.AddRequest(newRequest);
        }

        internal List<Request> getResignRequest()
        {
            return DA.getRequestByDesc("Resign Letter");
        }

        public List<Request> getLeaveRequest()
        {
            return DA.getRequestByDesc("Leave Permit");
        }

        public void proceedRequest(int requestID)
        {
            DA.updateStatus(requestID, "Proceeded");
        }

        public void declineRequest(int requestID)
        {
            DA.updateStatus(requestID, "Declined");
        }

        public void acceptRequest(int requestID)
        {
            DA.updateStatus(requestID, "Confirmed");
        }
    }
}
