using System;
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
            var products = GetProducts();
            if (products.Count > 0)
                ListViewProducts.ItemsSource = products;
        }

        private List<Product> GetProducts()
        {
            return new List<Product>()
      {
        new Product("Product 1", 205.46, "Resources/jokerplakatny.jpg"),
        new Product("Product 2", 102.50, "Resources/le-mans-plakat.jpg"),
        new Product("Product 3", 400.99, "Resources/filmen_addams_plakat.jpg"),
        new Product("Product 4", 350.26, "Resources/frost-2-plakat.jpg"),
        new Product("Product 5", 150.10, "Resources/toy_story_4_payoffplakat_dk.jpg"),
        new Product("Product 6", 100.02, "Resources/flugten_fra_oe_plakat.jpg"),
        new Product("Product 7", 295.25, "Resources/jagtsaeson_plakat.jpg"),
        new Product("Product 7", 295.25, "Resources/startrek.jpg"),
        new Product("Product 7", 295.25, "Resources/doctor_sleep_plakat.jpg"),
        new Product("Product 7", 295.25, "Resources/hustlers-plakat.jpg"),
        new Product("Product 7", 295.25, "Resources/midway-plakat.jpg"),
        new Product("Product 7", 295.25, "Resources/terminator-dark-fate-plakat.jpg"),
      };
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public string Image { get; set; }

        public Product(string name, double value, string image)
        {
            Name = name;
            Value = value;
            Image = image;
        }
    }
}