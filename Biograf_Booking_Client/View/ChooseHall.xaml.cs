using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Biograf_Booking_Client;
using Biograf_Booking_Client.Controller;
using Biograf_Booking_Client.PersonService;

namespace Biograf_Booking_Client.View
{
    /// <summary>
    /// Interaction logic for ChooseHall.xaml
    /// </summary>
    public partial class ChooseHall : Window
    {
        private PersonService.Movie m;
        private Movie movie;
        private List<Hall> halls = new List<Hall>();
        public ChooseHall(Movie m)
        {
            movie = m;

            halls = FindHalls(m.MovieId);
            InitializeComponent();
            ListViewHalls.ItemsSource = halls;

        }
        private List<Hall> FindHalls(int movieId)
        {
            MovieCtrl movieCtrl = new MovieCtrl();
            List<Hall> halls = movieCtrl.FindHalls(movieId);
            return halls;
        }
        private Hall FindHall(string t)
        {
            int i = Convert.ToInt32(t);
            Hall hall = new Hall();
            try
            {
                foreach (Hall h in halls)
                {
                    if (h.HallId == i)
                    {
                        hall = h;
                    }
                }
            }
            catch (Exception)
            {
                hall = null;
            }
            return hall;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var xx = sender as Button;
            string t = xx.Content.ToString();
            Hall h = FindHall(t);
            if (h!=null)
            {
                SeatBooking sb = new SeatBooking(movie, h);
                sb.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
