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


        public SeatBooking(Movie m, Hall h)
        {
            this.m = m;
            this.h = h;
            
            List<Seat> s = new List<Seat>();
            s = FindSeatsByHallId();
            Seats = s;
            MessageBox.Show("" + s.Count());
            foreach (Seat tempS in s)
            {
                
                if (tempS.ResId==null)
                {
                    tempS.Color = Convert.ToString(Colors.Red);
                }
                else
                {
                    tempS.Color = Convert.ToString(Colors.ForestGreen);
                }
            }
            InitializeComponent();
            listViewSeats.ItemsSource = s;
            
        }
        private List<Seat> FindSeatsByHallId()
        {
            List<Seat> seats = new List<Seat>();
            seats = seatCtrl.FindSeatsByHallId(h.HallId);
            return seats;
        }
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
                MessageBox.Show("" + id);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Reservation r = new Reservation();
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
            r.Date = DateTime.Now;
            r.CustomerId = 1;
            

            
        }
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
                    }
                    else
                    {
                        MessageBox.Show("Noget gik galt");
                    }
                    

                    Reserve(r);
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Annulleret");
                    break;

            }
        }

    }
}
