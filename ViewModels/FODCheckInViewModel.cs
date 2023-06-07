using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class FODCheckInViewModel:Screen
    {
        private RoomHandler roomHandler;
        private Visitor visitorDA;
        
        private string _warning;

        public string warning
        {
            get { return _warning; }
            set
            {
                _warning = value;
                NotifyOfPropertyChange(() => warning);
            }
        }

        public string CustName { get; set; }
        public string Passport { get; set; }
        public FODCheckInViewModel()
        {
            roomHandler = new RoomHandler();
            visitorDA = new Visitor();
        }
        public void btnCheckIn()
        {
            int visitorID = visitorDA.getVisitorID(CustName, Passport);
            RoomTransaction transaction=roomHandler.getTransaction(visitorID);
            if (transaction != null)
            {
                warning = "Welcome Check In Room Number " + transaction.RoomNumber;
            }
            else
            {
                warning = "Can't Check In";
            }
            if (transaction != null)
            {
                roomHandler.updateRoom(transaction.RoomNumber, "Checked In",transaction.RoomTransactionID);
            }
            
        }
    }
}
