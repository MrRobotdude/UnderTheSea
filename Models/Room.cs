using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace UnderTheSea.Models
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public int RoomPrice { get; set; }
        public string RoomStatus { get; set; }

        public Room getRoom(int roomNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Room>($"SELECT * FROM MsRoom WHERE RoomID = " + roomNumber + "").ToList();
                return output.ElementAt(0);
            }
        }

        public void updateRoom(int roomNumber, string status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Room_Update @roomNumber, @status", new { roomNumber,status });
            }
        }
    }

    public class RoomTransaction
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public string Report { get; set; }

        public void updateReservation(int reserveID, string status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.RoomTransaction_Update @reserveID, @status", new { reserveID, status });
            }
        }

        public DateTime CheckOut { get; set; }

        public void updateReport(int roomNumber, string report)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.RoomTransaction_AddReport @report, @roomNumber", new { report, roomNumber });
            }
        }

        public int RoomTransactionID { get; set; }

        public RoomTransaction getTransaction(int visitorID, string status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<RoomTransaction>($"SELECT * FROM TrRoomTransaction WHERE VisitorID = " + visitorID + "AND [Status]='"+status+"'").ToList();
                if (output.Count == 0)
                {
                    return null;
                }
                return output.ElementAt(0);
            }
        }

        public int VisitorID { get; set; }

        public void insertTransaction(int visitorID, int room, DateTime checkIn, DateTime checkOut)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.RoomTransaction_Insert @visitorID, @room, @CheckIn, @CheckOut", new { visitorID, room, checkIn, checkOut });
            }
        }
    }
    public class RoomHandler
    {
        RoomTransaction roomTransactionDA = new RoomTransaction();
        Room roomDA = new Room();
        public void insertReservation(string custName, string passport, int room, DateTime checkIn, DateTime CheckOut)
        {
            Visitor visitorDA = new Visitor();
            int visitorID = visitorDA.insertVisitorData(custName, passport);
            roomTransactionDA.insertTransaction(visitorID, room, checkIn, CheckOut);
        }

        public int getRoomPrice(int roomNumber)
        {
            Room room = roomDA.getRoom(roomNumber);
            return room.RoomPrice;
        }


        public RoomTransaction getTransaction(int visitorID)
        {
            return roomTransactionDA.getTransaction(visitorID, "Reserved");
        }
        public RoomTransaction getTransactionForCO(int visitorID)
        {
            return roomTransactionDA.getTransaction(visitorID, "Checked In");
        }

        public void updateRoom(int roomNumber, string status, int reserveID)
        {
            roomDA.updateRoom(roomNumber, status);
            roomTransactionDA.updateReservation(reserveID, status);
        }

        public void addReport(int roomNumber, List<string> report)
        {
            string reports = "";
            foreach (string v in report)
            {
                reports += v;
                if (v != report[report.Count - 1])
                {
                    reports += "-";
                }

            }
            roomTransactionDA.updateReport(roomNumber, reports);
        }
    }
}
