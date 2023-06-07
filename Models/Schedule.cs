using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.Models
{
    public class Schedule
    {
        public int ScheduleID { get; set; }
        public DateTime ScheduleDate { get; set; }
        public int FacilityID { get; set; }

        public List<Schedule> getAllSchedule()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Schedule>($"SELECT * FROM MsSchedule WHERE ScheduleStatus NOT LIKE 'Deleted'").ToList();
                return output;
            }
        }

        public void insertSchedule(DateTime date, int ride)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Schedule_Insert @date, @ride", new { date, ride });
            }
        }

        public void updateSchedule(int scheduleID, string status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Schedule_Update @scheduleID, @status", new { scheduleID, status });
            }
        }

        public void updateSchedule(int scheduleID, DateTime scheduleDate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Schedule_UpdateSchedule @scheduleID, @scheduleDate", new { scheduleID, scheduleDate });
            }
        }

        public void MaintainSchedule(int id)
        {
            updateSchedule(id, "Maintenance Done");
        }

        public void DeleteSchedule(int id)
        {
            updateSchedule(id, "Deleted");
        }

        public void CreateSchedule(DateTime date, int RideId)
        {
            insertSchedule(date, RideId);
        }
    }
}
