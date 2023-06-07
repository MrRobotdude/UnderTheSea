using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.Models
{
    public class Advertisement
    {
        public int AdvertisementID { get; set; }
        public string AdvertisementName { get; set; }
        public string AdvertisementDescription { get; set; }

        public List<Advertisement> getAllAdvertisement()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                return connection.Query<Advertisement>($"SELECT * FROM MsAdvertisement").ToList();
            }
        }

        public void insertAdvertisement(string name, string desc)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connString")))
            {
                connection.Execute("dbo.Advertisement_Insert @name,@desc", new { name, desc});
            }
        }
    }

   
}
