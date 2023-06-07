using Dapper;
using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using static UnderTheSea.ViewModels.ManHotelIncomeViewModel;
using static UnderTheSea.ViewModels.ManRestaurantIncomeViewModel;
using static UnderTheSea.ViewModels.ManTicketIncomeViewModel;

namespace UnderTheSea
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public DateTime TicketDate { get; set; }
        public string Status { get; set; }

        public List<Ticket> GetAllTicket()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Ticket>($"select * from MsTicket").ToList();
                return output;
            }
        }
        
        public void CancelTicket(int TicketID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Cancel_Ticket @TicketID", new { TicketID });
            }
        }

        public Ticket getTicket(int ticketID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Ticket>($"SELECT * FROM MsTicket WHERE ticketID = '" + ticketID + "'").ToList();
                return output[0];
            }
        }

        public Ticket InsertTicket()
        {
            Debug.Write("masuk");
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Ticket_Insert");
                return connection.Query<Ticket>($"SELECT TOP 1 * FROM MsTicket ORDER BY TicketID DESC").ToList().ElementAt(0);
            }
        }

        public void updateDate(int ticketID, DateTime newDate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Ticket_UpdateDate @ticketID, @newDate", new { ticketID, newDate });
            }
        }

        public void updateStatus(int ticketID, string Status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Ticket_UpdateStatus @ticketID, @Status", new { ticketID, Status });
            }
        }

        public DateTime getDate(int ticketID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Ticket>($"SELECT * FROM MsTicket WHERE ticketID=" + ticketID + "").ToList();
                return output.ElementAt(0).TicketDate;
            }
        }

        public List<TicketIncome> getTicketIncome()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<TicketIncome>($"SELECT [Ticket Date] = CONVERT(DATE, TicketDate), TotalIncome= (COUNT(TicketID) * 300000) FROM MsTicket GROUP BY CONVERT(DATE, TicketDate)").ToList();
                return output;
            }
        }

        public List<HotelIncome> getHotelIncome()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<HotelIncome>($"SELECT CheckIn,CheckOut,TotalIncome=RoomPrice*DATEDIFF(DAY,CheckIn,CheckOut) FROM TrRoomTransaction JOIN MsRoom ON MsRoom.RoomID = TrRoomTransaction.RoomNumber").ToList();
                return output;
            }
        }
        public List<RestaurantIncome> getRestaurantIncome()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<RestaurantIncome>($"SELECT TotalIncome=SUM(Quantity*MenuPrice), TicketDate FROM MsTicket th JOIN TrOrderHeader ord ON ord.TicketID = th.TicketID JOIN TrOrderDetail OrderDetail ON ord.OrderID = OrderDetail.OrderID JOIN MsMenu Menu ON Menu.MenuID = OrderDetail.MenuID WHERE ord.[Status] = 'Paid' GROUP BY TicketDate").ToList();
                return output;
            }
        }
        
        public void buyTicket()
        {
            int ticketId = InsertTicket().TicketID;
            generateQrCode(ticketId);
        }

        private void generateQrCode(int id)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                    encoder.QRCodeScale = 8;
                    Bitmap bmp = encoder.Encode(id.ToString());
                    //PictureBox.Image = bmp
                    bmp.Save(sfd.FileName, ImageFormat.Jpeg);
                }
            }
        }

        public string readQrCode()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                    string output;
                    try
                    {
                        output = decoder.Decode(new QRCodeBitmapImage(Image.FromFile(ofd.FileName) as Bitmap));
                    }
                    catch (Exception)
                    {
                        output = null;
                    }
                    if (output != null)
                    {
                        return output;
                    }
                    else return null;

                }
                return null;
            }
        }

        public Ticket getTicket()
        {
            string ticketID = readQrCode();
            if (ticketID == null)
            {
                return null;
            }
            return getTicket(int.Parse(ticketID));
        }
    }
}
