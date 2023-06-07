using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.Models
{
    public class WorkPerformance
    {
        public int EmployeeID { get; set; }
        public DateTime WorkDate { get; set; }
        public string WorkReport { get; set; }

        public List<WorkPerformance> getWorkPerformance()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<WorkPerformance>($"SELECT * FROM MsWorkPerformance").ToList();
                return output;
            }
        }

        public void insertWorkReport(int employeeId, string workReport)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.WorkPerformance_Insert @employeeID, @workReport", new { employeeId, workReport });
            }
        }
    }
}