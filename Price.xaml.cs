using Design_Pattern;
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
    /// Interaction logic for Price.xaml
    /// </summary>
    public partial class Price : Window
    {
        RidePrice ride;
        public Price(RidePrice r)
        {
            ride = r;
            InitializeComponent();
            problem_btn.Click += Problem_btn_Click;
            continue_btn.Click += Continue_btn_Click;

            price_lb.Content =$"EGP  {ride.price}";
        }

        private void Continue_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Problem_btn_Click(object sender, RoutedEventArgs e)
        {
            var page = new Customer_care(ride.user,ride.driver);
            page.Show();
            this.Close();

        }
    }
}
