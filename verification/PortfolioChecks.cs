using System;
using System.Data.SqlClient;
using UnderTheSea;

public static class PortfolioChecks
{
    [STAThread]
    public static int Main()
    {
        Environment.SetEnvironmentVariable("UNDER_THE_SEA_DEMO", "1");
        var employees = new Employee();
        if (employees.GetEmployee("missing-user") != null) throw new Exception("Unknown user must return null.");
        if (employees.GetEmployee("' OR 1=1 --") != null) throw new Exception("Login lookup must treat input as data.");
        var account = employees.GetEmployee("demo-attraction");
        if (account == null || account.DepartmentID != 3) throw new Exception("Demo account is unavailable.");
        var tickets = new Ticket();
        if (tickets.getTicket(-1) != null) throw new Exception("Unknown ticket must return null.");
        using (var connection = new SqlConnection(Helper.CnnVal("connString")))
        {
            connection.Open();
            // Roll back verification changes so the demo remains untouched.
            using (var transaction = connection.BeginTransaction())
            {
                var command = new SqlCommand("EXEC dbo.Ticket_Insert; SELECT MAX(TicketID) FROM dbo.MsTicket;", connection, transaction);
                int id = Convert.ToInt32(command.ExecuteScalar());
                command = new SqlCommand("EXEC dbo.Cancel_Ticket @id; SELECT Status FROM dbo.MsTicket WHERE TicketID=@id;", connection, transaction);
                command.Parameters.AddWithValue("@id", id);
                if ((string)command.ExecuteScalar() != "Cancelled") throw new Exception("Ticket cancellation failed.");
                transaction.Rollback();
            }
        }
        Console.WriteLine("PASS: unknown users, parameterized lookup, demo account, missing tickets, and cancellation rollback.");
        return 0;
    }
}
