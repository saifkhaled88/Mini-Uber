using Design_Pattern;
using MiniUber;
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

namespace Mini_Uber
{
    /// <summary>
    /// Interaction logic for DriverDetailes.xaml
    /// </summary>
    public partial class DriverDetailes : Window
    {
        Driver driver;
        User user;
        RidePrice ride;
        public DriverDetailes(Driver d,User u, RidePrice r)
        {
            InitializeComponent();
            checkout_btn.Click += Checkout_btn_Click;
            driver = d;
            user = u;
            ride = r;

            driver_name_lb.Content = driver.Fname + " " + driver.Lname;
            //car_type_lb.Content = driver.Vehicle.Model;
            plate_number_lb.Content = driver.Vehicle.PlateNumber;

        }

        private void Checkout_btn_Click(object sender, RoutedEventArgs e)
        {
            var page = new Price(ride);
            page.Show();
            this.Close();

        }
    }
}
