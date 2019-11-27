
using Seat = Biograf_Booking_Client.Model.Seat;
using Biograf_Booking_Client.PersonService;
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
using Biograf_Booking_Client.Controller;

namespace Biograf_Booking_Client.View
{
    /// <summary>
    /// Interaction logic for SeatBooking.xaml
    /// </summary>
    public partial class SeatBooking : Window
    {
        public ObservableCollection<int> Seats { get; private set; }
        private List<int> MarkedSeats = new List<int>();
        private Movie m = null;
        private Hall h = null;
        private ReservationCtrl ResCtrl = new ReservationCtrl();
        

        public SeatBooking(Movie m, Hall h)
        {
            this.m = m; 
            h = this.h;
            Seats = new ObservableCollection<int>();
            for (int i = 1; i <= 84; i++)
                Seats.Add(i);

            InitializeComponent();
        }



        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var xx = sender as TextBlock;
            var yy = xx.Text;
            SolidColorBrush b = xx.Background as SolidColorBrush;
            Color x = b.Color;
            if (x == Colors.Yellow)
            {
                xx.Background = new SolidColorBrush(Colors.ForestGreen);
                int id;
                id = Int32.Parse(xx.Text);
                MarkedSeats.Remove(id);
            }
            else
            {
                xx.Background = new SolidColorBrush(Colors.Yellow);
                int id;
                id = Int32.Parse(xx.Text);
                MarkedSeats.Add(id);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Reservation r = new Reservation();
            r.MovieId = m.MovieId;
            r.Seats = MarkedSeats;
            r.Date = DateTime.Now;
            r.CustomerId = 1;
            ResCtrl.InsertReservation(r);
            Close();
        }
    }
}
