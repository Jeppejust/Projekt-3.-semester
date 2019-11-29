using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Biograf_Booking_Server.Database
{
    class SeatRepository : ISeatRepository<Seat>
    {
        IDbConnection Con = null;
        public List<Seat> FindSeatByHallId(string HallId)
        {
            string SqlGetSeatByHallId = "select * from tblSeat where HallId = @HallId";

            using (Con = new SqlConnection(DataBase.DbConnectionString))
            {
                return Con.Query<Seat>(SqlGetSeatByHallId, new { HallId }).ToList();
            }

        }
    }
}
