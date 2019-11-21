using Biograf_Booking_Client.Controller;
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


namespace Biograf_Booking_Client.View
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        private EmployeeCtrl empCtrl = null;
        private Home home = new Home();
        
            public LogIn()
        {
            empCtrl = new EmployeeCtrl();
            InitializeComponent();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string Username = tbUsername.Text;
            string Password = tbPassword.Text;
            bool Login = false;
            Login = empCtrl.Login(Username, Password);
            if (Login==false)
            {
                MessageBox.Show("Your username or password was incorrect");
            }
            else
            {
                MessageBox.Show("You are now logged in!!!");
                home.Show();
                Close();
                
            }
        }
    }
}
