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

        public bool InsertReservation(Reservation r)
        {
            string SqlInsertReservation = "insert into tblReservation (ResDate, ResTime, CustomerId, MovieId) values (@ResDate, @ResTime, @CustomerId, @MovieId)";
            
            Reservation CurrR = r;
            DateTime CurrDateTime = r.Date;
            string CurrTime = CurrDateTime.ToString("HH:mm:ss");
            string CurrDate = CurrDateTime.ToString("yyyy-MM-dd");

            using (con = new SqlConnection(DataBase.DbConnectionString))
            {
                con.Execute(SqlInsertReservation, new { ResDate = CurrDate, ResTime = CurrTime, CustomerId = 1, MovieId = r.MovieId });
                return true;
            }
        }
        public int FindMaxRes()
        {
            string SqlMaxReservation = "select MAX(ReservationId) from tblReservation";
            int resId;
            using (con = new SqlConnection(DataBase.DbConnectionString))
            {
                resId = con.Execute(SqlMaxReservation);
            }
            return resId;
        }
        public void DeleteTopRes()
        {
            string SqlDeleteTop = "DELETE TOP (1) from tblReservation";
            using (con = new SqlConnection(DataBase.DbConnectionString))
            {
                con.Execute(SqlDeleteTop);
            }
            
        }
    }
}
