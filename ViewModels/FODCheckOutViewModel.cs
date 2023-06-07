using Caliburn.Micro;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class FODCheckOutViewModel:Screen
    {
        private RoomHandler roomHandler;
        private Visitor visitorDA;
        private Feedback feedDA;
        public string CustomerName { get; set; }
        public int RoomNumber { get; set; }
        public string Passport { get; set; }
        public string Feedback { get; set; }
        public FODCheckOutViewModel()
        {
            roomHandler = new RoomHandler();
            visitorDA = new Visitor();
        }
        public void btnCheckOut()
        {
            feedDA = new Feedback();
            int visitorID = visitorDA.getVisitorID(CustomerName, Passport);
            RoomTransaction transaction = roomHandler.getTransactionForCO(visitorID);
            feedDA.insertFeedback(transaction.RoomTransactionID, "Hotel", Feedback);
            if (transaction.Report!=null)
            {
                string[] additional = transaction.Report.Split('-');
                IWindowManager manager = new WindowManager();
                manager.ShowWindow(new FODAdditionalPriceViewModel(additional), null, null);
            }
            roomHandler.updateRoom(RoomNumber, "Checked Out", transaction.RoomTransactionID);

        }
    }
}
