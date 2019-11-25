using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace Biograf_Booking_Server.Database
{
    class HallRepository : IHallRepository<Hall>
    {
        private IDbConnection Con = null;
        public List<Hall> FindHalls(int MovieId)
        {
            string SqlGetHalls = "select * from tblHall where MovieId = @MovieId";

            using (Con = new SqlConnection(DataBase.DbConnectionString))
            {
                List<Hall> halls = new List<Hall>();
                halls = Con.Query<Hall>(SqlGetHalls, new { MovieId }).ToList();
                return halls;
            }
        }
    }
}
