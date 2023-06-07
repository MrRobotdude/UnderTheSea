using Caliburn.Micro;
using System;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class FODPaymentViewModel:Screen
    {
        private RoomHandler roomHandler;
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Total { get; set; }
        public int MoneyTxt { get; set; }
        
        public string CustomerName { get; set; }
        public string Passport { get; set; }

        public void payBtn()
        {
            if (MoneyTxt >= Total)
            {
                roomHandler.insertReservation(CustomerName, Passport, RoomNumber,CheckIn, CheckOut);
            }
        }

        public FODPaymentViewModel(string custName, string passport, int roomNumber, DateTime CheckInDate, DateTime CheckOutDate)
        {
            roomHandler = new RoomHandler();
            RoomNumber = roomNumber;
            CheckIn = CheckInDate;
            CheckOut = CheckOutDate;
            Total = ((TimeSpan)(CheckOutDate - CheckInDate)).Days * roomHandler.getRoomPrice(roomNumber);
            CustomerName = custName;
            Passport = passport;
        }
    }
}
