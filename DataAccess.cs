using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea
{
    public class DataAccess
    {
        public List<Ticket> GetAllTicket()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Ticket>($"select * from Ticket").ToList();
                return output;
            }
        }
    }
}
