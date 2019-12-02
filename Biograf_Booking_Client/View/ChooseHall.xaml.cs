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
        private List<Hall> halls = new List<Hall>();
        public ChooseHall(Movie m)
        {
            movie = m;
            halls = FindHalls(m.MovieId);
            InitializeComponent();
            ListViewHalls.ItemsSource = halls;

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
                MessageBox.Show("Didn't get a hall");
                hall = null;
            }
            return hall;
        }
        private List<Hall> FindHalls(int movieId)
        {
            HallCtrl hallCtrl = new HallCtrl();
            List<Hall> halls = new List<Hall>();
            halls = hallCtrl.FindHalls(movieId);
            return halls;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
