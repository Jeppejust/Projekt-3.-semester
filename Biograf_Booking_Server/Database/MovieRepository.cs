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
    class MovieRepository : IMovieRepository<Movie>
    {
        private IDbConnection con = null;
        
        public List<Movie> GetMovies()
        {
            string sqlGetAllMovies = "select * from tblMovie";
            using (con = new SqlConnection(DataBase.DbConnectionString))
            {
                List<Movie> Movies = new List<Movie>();
                con.Open();

                Movies = con.Query<Movie>(sqlGetAllMovies).ToList();
                return Movies;
            }
        }
        public Movie GetMovie(int id)
        {
            string sqlGetMovie = "select * from tblMovie where MovieId = @id";
            using (con = new SqlConnection(DataBase.DbConnectionString))
            {
                Movie movie = new Movie();
                con.Open();

                try
                {
                    movie = con.Query<Movie>(sqlGetMovie, new { id }).FirstOrDefault();
                }
                catch (Exception)
                {
                    movie = null;
                }
                con.Close();
                con.Dispose();
                return movie;
            }
        }
    }
}
