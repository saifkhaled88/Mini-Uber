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
    /// Interaction logic for Searching.xaml
    /// </summary>
    public partial class Searching : Window
    {
        DbProxy database;
        User user;
        RidePrice ride;
        List<Driver> drivers;
        Driver driver;
        System.Windows.Threading.DispatcherTimer DispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        public Searching(User u , RidePrice r)
        {
            database = DbProxy.GetDB();
            user = u;
            ride = r;
            drivers = database.GetDrivers();
            
            InitializeComponent();
            DispatcherTimer.Tick += DispatcherTimer_Tick;
            DispatcherTimer.Interval = new TimeSpan(0, 0, 10);
            DispatcherTimer.Start();
            Random rand = new Random();
            driver = drivers[rand.Next(0, drivers.Count)];
            //driver.Vehicle = database.GetVehicle(driver);


        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            DispatcherTimer.Stop();
            ride.driver = driver;
            var page = new DriverDetailes(driver,user,ride);
            page.Show();
            this.Close();
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            myGif.Position = new TimeSpan(0, 0, 1);
            myGif.Play();
        }
    }

        
}
