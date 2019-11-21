using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Database
{
    class DataBase
    {
        public static string DbConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["ConnectDatabaseString"].ToString(); }
        }
    }
}
