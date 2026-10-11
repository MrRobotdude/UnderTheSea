using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea
{
    public static class Helper
    {
        public static bool IsPortfolioDemo
        {
            get { return Environment.GetEnvironmentVariable("UNDER_THE_SEA_DEMO") == "1"; }
        }

        public static string CnnVal(string name)
        {
            if (name == "connString" && IsPortfolioDemo)
                return @"Server=(localdb)\MSSQLLocalDB;Database=UnderTheSeaPortfolioDemo;Trusted_Connection=True;";
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
