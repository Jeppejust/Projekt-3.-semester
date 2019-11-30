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
        public List<Seat> FindSeatsByHallId(int HallId)
        {
            string SqlGetSeatByHallId = "select * from tblSeat where HallId = @HallId";

            using (Con = new SqlConnection(DataBase.DbConnectionString))
            {
                return Con.Query<Seat>(SqlGetSeatByHallId, new { HallId }).ToList();
            }

        }
        public List<Seat> FindSeatsBySeatId(List<Seat> s)
        {
            string SqlGetSeatBySeatId = "select * from tblSeat where SeatId = @SeatId";
            List<Seat> seats = new List<Seat>();
            using (Con = new SqlConnection(DataBase.DbConnectionString))
            {
                foreach (Seat tempS in s)
                {
                    Seat seat = new Seat();
                    seat = Con.Query<Seat>(SqlGetSeatBySeatId, new { tempS.SeatId}).FirstOrDefault();
                    seats.Add(seat);
                }                
                return seats;
            }

        }
    }
}
