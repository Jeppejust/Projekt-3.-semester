using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using Biograf_Booking_Server.Model;

namespace Biograf_Booking_Server.Database
{
    class ReservationRepository : IReservationRepository<Reservation>
    {
        private IDbConnection con = null;

        public List<Reservation> FindAllReservations()
        {
            string SqlGetAllReservatins = "select * from tblReservations";
            using (con = new SqlConnection(DataBase.DbConnectionString))
            {
                return con.Query<Reservation>(SqlGetAllReservatins).ToList();
            }
        }

        public Reservation FindReservationById(int Id)
        {
            string SqlGetReservationById = "select * from tblReservation where Id = @Id";
            using (con = new SqlConnection(DataBase.DbConnectionString))
            {
                return con.Query<Reservation>(SqlGetReservationById).FirstOrDefault();
            }
        }

        public void InsertReservation(Reservation r)
        {
            string SqlInsertReservation = "insert into tblReservation (ResDate, ResTime, CustomerId, MovieId) values (@ResDate, @ResTime, @CustomerId, @MovieId)";

            using (con = new SqlConnection(DataBase.DbConnectionString))
            {
                con.Execute(SqlInsertReservation, new { ResDate = r.Date, ResTime = r.Time, CustomerId= r.CustomerId, MovieId = r.MovieId });
            }
        }
    }
}
