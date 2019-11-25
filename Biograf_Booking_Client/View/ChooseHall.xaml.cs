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

        public ChooseHall(Movie m)
        {
            List<Hall> halls = new List<Hall>();
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
    }
}
