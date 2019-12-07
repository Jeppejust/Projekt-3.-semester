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
using Biograf_Booking_Client.Model;

namespace Biograf_Booking_Client.View
{
    /// <summary>
    /// Interaction logic for SeatBooking.xaml
    /// </summary>
    public partial class SeatBooking : Window
    {
        private List<Seat> Seats = new List<Seat>();
        private List<int> MarkedSeats = new List<int>();
        private Movie m = null;
        private Hall h = null;
        private ReservationCtrl ResCtrl = new ReservationCtrl();
        private seatCtrl seatCtrl = new seatCtrl();

        // Creating new seat booking by finding movie, hall and seats
        public SeatBooking(Movie m, Hall h)
        {
            this.m = m;
            this.h = h;
            
            
            InitializeComponent();
            UpdateSeats();
            
        }
        private void UpdateSeats()
        {
            List<Seat> s = new List<Seat>();
            s = FindSeatsByHallId();
            Seats = s;
            foreach (Seat tempS in s)
            {

                if (tempS.booked == true)
                {
                    tempS.Color = Convert.ToString(Colors.Red);
                }
                else
                {
                    tempS.Color = Convert.ToString(Colors.ForestGreen);
                }
            }
            listViewSeats.ItemsSource = s;
        }

        // Finding seats by ID
        private List<Seat> FindSeatsByHallId()
        {
            List<Seat> seats = new List<Seat>();
            seats = seatCtrl.FindSeatsByHallId(h.HallId);
            return seats;
        }

        // Mousedown event for choosing seats
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var xx = sender as TextBlock;
            SolidColorBrush b = xx.Background as SolidColorBrush;
            Color c = b.Color;
            if (c == Colors.Yellow)
            {
                xx.Background = new SolidColorBrush(Colors.ForestGreen);
                int id;
                id = Int32.Parse(xx.Text);
                MarkedSeats.Remove(id);
            }
            else if (c == Colors.ForestGreen)
            {
                xx.Background = new SolidColorBrush(Colors.Yellow);
                int id = Int32.Parse(xx.Text);
                MarkedSeats.Add(id);
            }
            else if (c == Colors.Red)
            {
                int id = Int32.Parse(xx.Text);
                MessageBox.Show("This seat is already booked. Please choose another.");
            }
        }

        // Button which creates a new reservation
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Reservation r = new Reservation();
            r.Seats = new List<Seat>();
            r.MovieId = m.MovieId;
            foreach (int Marked in MarkedSeats)
            {
                foreach (Seat s in Seats)
                {
                    if (s.SeatId == Marked)
                    {
                        r.Seats.Add(s);
                    }
                }
            }
            if (r.Seats == null)
            {
                MessageBox.Show("You have not clicked on any seats.");
            }
            else
            {
                r.Date = DateTime.Now;
                r.CustomerId = 1;
                Reserve(r);
            }
        }

        // Messagebox with result
        private void Reserve(Reservation r)
        {
            MessageBoxResult result = MessageBox.Show("Vil du fortsætte?", "POP UP", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    bool b = ResCtrl.InsertReservation(r);
                    if (b)
                    {
                        MessageBox.Show("Reservation gennemført");
                        UpdateSeats();
                    }
                    else
                    {
                        MessageBox.Show("Noget gik galt");
                    }
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Annulleret");
                    break;
            }
        }
    }
}
