using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.Models
{
    public class Visitor
    {
        public int VisitorID { get; set; }
        public string Passport { get; set; }
        public string VisitorName { get; set; }

        public Visitor insertVisitor(string custName, string passport)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Visitor_Insert @custName,@passport", new { custName,passport });
                var output = connection.Query<Visitor>($"SELECT * FROM MsVisitor WHERE VisitorName='"+custName+"' AND Passport='"+passport+"'").ToList();
                return output.ElementAt(0);
            }
        }

        public Visitor getVisitor(string custName, string passport)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Visitor>($"SELECT * FROM MsVisitor WHERE VisitorName='"+custName+"' AND Passport='"+passport+"'").ToList();
                if (output.Count != 0)
                {
                    return output.ElementAt(0);
                }
                return null;
                
            }
        }
        
        public int insertVisitorData(string custName, string passport)
        {
            Visitor visitor = insertVisitor(custName, passport);
            return visitor.VisitorID;
        }

        public int getVisitorID(string custName, string passport)
        {
            Visitor visitor = getVisitor(custName, passport);
            if (visitor == null)
            {
                return 0;
            }
            return visitor.VisitorID;
        }
    }
}
