﻿using System;
using System.Collections.Generic;
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
using Biograf_Booking_Client.PersonService;

namespace Biograf_Booking_Client.View
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            MovieCtrl movieCtrl = new MovieCtrl();
            var movies = movieCtrl.GetMovies();;
            ShowMovies(movies);
        }
        public void ShowMovies(List<Movie> movies)
        {
            if (movies != null)
                ListViewMovies.ItemsSource = movies;
        } // Resources/jokerplakatny.jpg
    }
}