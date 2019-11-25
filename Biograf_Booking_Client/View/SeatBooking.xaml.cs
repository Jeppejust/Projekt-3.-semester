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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookingSeats
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<int> Seats { get; private set; }
        private List<int> MarkedSeats = new List<int>();

        public MainWindow()
        {
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
            if (x == Colors.Yellow){
                xx.Background = new SolidColorBrush(Colors.ForestGreen);
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
            foreach (int i in MarkedSeats)
            {

            }


        }
    }
    public class Seat
    {
        public string seatId { get; set; }
        public int MyProperty { get; set; }
    }
}



