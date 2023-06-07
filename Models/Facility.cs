using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.Models
{
    public class Facility
    {
        public Facility(string facilityName, int price, int type)
        {
            FacilityName = facilityName;
            this.Price = price;
            this.FacilityType = type;
        }

        public Facility()
        {

        }

        public int FacilityID { get; set; }
        public int FacilityType { get; set; }
        public string FacilityName { get; set; }
        public string Status { get; set; }
        public int Price { get; set; }
        public string FacilityDetail { get; set; }

        public List<Facility> getAllFacility()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Facility>($"SELECT * FROM MsFacility WHERE Status NOT LIKE '%Deleted%'").ToList();
                return output;
            }
        }

        public List<Facility> getFacility(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Facility>($"SELECT * FROM MsFacility WHERE FacilityName = '" + name + "'").ToList();
                return output;
            }
        }


        public List<Facility> getFacilityBaseStatus(string status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Facility>($"SELECT * FROM MsFacility WHERE Status = '" + status + "'").ToList();
                return output;
            }
        }

        public void updateFacility(int id, string FacilityName, int Price)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Facility_UpdateFacility @id, @FacilityName, @Price", new { id, FacilityName, Price });
            }
        }

        public void delete(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Facility_Delete @id", new { id });
            }
        }

        public List<Facility> getFacility(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                var output = connection.Query<Facility>($"SELECT * FROM MsFacility WHERE FacilityID = " + id + "").ToList();
                return output;
            }
        }

        public void insertFacility(string name, int type, int price, string detail)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Facility_Insert @name, @type, @price, @detail", new { name, type, price, detail });
            }
        }

        public void updateFacility(int id, string status, string detail)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Facility_Update @id, @status, @detail", new { id, status, detail });
            }
        }

        public int getFacilityID(string facilityName)
        {
            List<Facility> output = getFacility(facilityName);
            return output.ElementAt(0).FacilityID;
        }

        public int getFacilityPrice(string facilityName)
        {
            List<Facility> output = getFacility(facilityName);
            return output.ElementAt(0).Price;
        }

        public string getFacilityName(int id)
        {
            List<Facility> output = getFacility(id);
            return output.ElementAt(0).FacilityName;
        }

        public string getFacilityStatus(int id)
        {
            List<Facility> output = getFacility(id);
            return output.ElementAt(0).Status;
        }
    }
}
