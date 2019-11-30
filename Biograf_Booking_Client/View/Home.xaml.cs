using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        MovieCtrl movieCtrl = new MovieCtrl();
        List<Movie> movies = new List<Movie>();
        public Home()
        {
            InitializeComponent();
            movies = movieCtrl.GetAllMovies();
            ShowMovies(movies);
        }
        public void ShowMovies(List<Movie> movies)
        {
            if (movies != null)
            {
                ListViewMovies.ItemsSource = movies;
            }
            else
            {
                MessageBox.Show("no movies were found");
            }
                
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var xx = sender as TextBlock;
            Movie m = FindMovie(xx.Text);
            ChooseHall ch = new ChooseHall(m);
            ch.Topmost = true;
            ch.Show();
        }
        private Movie FindMovie(string title)
        {
            Movie movie = null;
            foreach (Movie m in movies)
            {
                if (m.Title == title)
                {
                    movie = m;
                }
            }
            return movie;
        }
    }
}