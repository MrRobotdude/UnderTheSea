using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class AttractionDepartmentViewModel:Screen
    {
        public BindableCollection<TicketModel> Tickets { get; set; }
        Ticket TicketDA;
        public DateTime SelectDate { get; set; }

        private TicketModel myVar;
        public TicketModel selectedTicket
        {
            get { return myVar; }
            set {
                myVar = value;
                NotifyOfPropertyChange(() => selectedTicket);
            }
        }

        public class TicketModel
        {
            public int TicketID { get; set; }
            public DateTime TicketDate { get; set; }
            public string Status { get; set; }
        }

        public string IDInput { get; set; }
        int employeeID;

        public AttractionDepartmentViewModel(int employeeID)
        {
            TicketDA = new Ticket();
            Tickets = new BindableCollection<TicketModel>();
            this.employeeID = employeeID;
            SelectDate = DateTime.Now;
            foreach(Ticket ticket in TicketDA.GetAllTicket())
            {
                Tickets.Add(new TicketModel {
                    TicketID = ticket.TicketID,
                    TicketDate = ticket.TicketDate,
                    Status = ticket.Status
                });
            }
        }

        public void CancelTicket()
        {
            TicketDA.CancelTicket(int.Parse(IDInput));
        }

        public void UpdateTicket()
        {
            TicketDA.updateDate(int.Parse(IDInput), SelectDate);
        }

        public void LeavePermit()
        {
            IWindowManager manager = new WindowManager();
            manager.ShowWindow(new LeavePermitViewModel(employeeID), null, null);

        }

        public void Resign()
        {
            IWindowManager manager = new WindowManager();
            manager.ShowWindow(new ResignLetterViewModel(employeeID), null, null);
        }

        public void WorkReport()
        {
            IWindowManager manager = new WindowManager();
            manager.ShowWindow(new WorkReportViewModel(employeeID), null, null);
            ShellViewModel viewModel = ShellViewModel.getInstance();
        }

        public void BtnSignOut()
        {
            ShellViewModel viewModel = ShellViewModel.getInstance();
            viewModel.ShowLoginView();
        }
    }
}
