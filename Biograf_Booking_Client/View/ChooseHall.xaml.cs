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
using Biograf_Booking_Client.Model;

namespace Biograf_Booking_Client.View
{
    /// <summary>
    /// Interaction logic for ChooseHall.xaml
    /// </summary>
    
    public partial class ChooseHall : Window
    {
        private Movie movie = null;
        private Hall hall = null;
        private List<Hall> halls = new List<Hall>();
        public ChooseHall(Movie m)
        {
            movie = m;
            halls = FindHalls(m.MovieId);
            InitializeComponent();
            ListViewHalls.ItemsSource = halls;
        }

        // Creating an returninstance of hall and compares id by foreach-looping
        private Hall GetHall(int i)
        {
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
                MessageBox.Show("Didn't get a hall");
                hall = null;
            }
            return hall;
        }

        // Finding halls for given movie
        private List<Hall> FindHalls(int movieId)
        {
            MovieCtrl movieCtrl = new MovieCtrl();
            List<Hall> halls = movieCtrl.FindHalls(movieId);
            return halls;
        }

        // Click event for choosing hall
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var xx = sender as Button;
            int HallText = Convert.ToInt32(xx.Content);
            hall = GetHall(HallText);
            if (hall != null)
            {
                SeatBooking sb = new SeatBooking(movie,hall);
                sb.Show();
                this.Close();
            }
        }
    }
}
