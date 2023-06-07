using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.Models
{
    public class Feedback
    {
        public int TransactionID { get; set; }
        public string TransactionType { get; set; }
        public string FeedbackText { get; set; }

        public void insertFeedback(int TransactionID, string TransactionType, string FeedbackText)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Feedback_Insert @TransactionID, @TransactionType, @FeedbackText", new { TransactionID, TransactionType, FeedbackText });
            }
        }
    }
}
