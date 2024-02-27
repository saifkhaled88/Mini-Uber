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
    /// Interaction logic for Ride.xaml
    /// </summary>
    public partial class Ride : Window
    {
        DbProxy dataBase = DbProxy.GetDB();
        User user;
        Dictionary<string, int> Cities;
        string from ,to;
        RidePrice ride;
        PaymentType pay;
        public Ride(User u,string f,string t)
        {
            user = u;
            from = f;
             to = t;
            Cities = dataBase.GetCities();
            
            ride = new Basic(null, user, from, to);
            pay = new PaymentType();

            InitializeComponent();
            premium_border.MouseLeftButtonDown += Premium_border_MouseLeftButtonDown;

            comfort_price_lb.Content = $"EGP : {ride.CalculatePrice(Cities[from.ToLower()], Cities[to.ToLower()])*2}";
            basic_price_lb.Content = $"EGP : {ride.CalculatePrice(Cities[from.ToLower()], Cities[to.ToLower()])}";
            bike_price_lb.Content = $"EGP : {ride.CalculatePrice(Cities[from.ToLower()], Cities[to.ToLower()])*0.75}";

            confirm_btn.Click += Confirm_btn_Click;


        }

        private void Confirm_btn_Click(object sender, RoutedEventArgs e)
        {
            
            if(basic_border.BorderThickness==new Thickness(3, 3, 3, 3))
            {
                ride.price = ride.CalculatePrice(Cities[from.ToLower()], Cities[to.ToLower()]);
            if (cash_rb.IsChecked==true)
                {
                    pay.SetPaymentMethod(new Cash());
                   
                    var page = new Searching(user,ride);
                    page.Show();
                    this.Close();

                }
                else
                {
                    pay.SetPaymentMethod(new CreditCard());

                    if (user.Card.CardNumber == "-1")
                    {
                        var page = new CreditCardPage(user,ride);
                        page.Show();
                         this.Close();

                    }
                    else
                    {
                        var page = new Searching(user, ride);
                        page.Show();
                        this.Close();
                    }

                }

            }
            else if (premium_border.BorderThickness == new Thickness(3, 3, 3, 3))
            {
                ride = new Premium(null, user, from, to);
                ride.price = ride.CalculatePrice(Cities[from.ToLower()], Cities[to.ToLower()]);


                if (cash_rb.IsChecked == true)
                {
                    pay.SetPaymentMethod(new Cash());
                    
                    var page = new Searching(user, ride);
                    page.Show();
                    this.Close();

                }
                else
                {
                    pay.SetPaymentMethod(new CreditCard());
                    if (user.Card.CardNumber == "-1")
                    {
                        var page = new CreditCardPage(user,ride);
                        page.Show();
                        this.Close();

                    }
                    else
                    {
                        var page = new Searching(user, ride);
                        page.Show();
                        this.Close();
                    }

                }


            }
            else if(bike_border.BorderThickness == new Thickness(3, 3, 3, 3))
            {
                ride = new Bike(null, user, from, to);
                ride.price = ride.CalculatePrice(Cities[from.ToLower()], Cities[to.ToLower()]);


                if (cash_rb.IsChecked == true)
                {
                    pay.SetPaymentMethod(new Cash());
                    var page = new Searching(user, ride);
                    page.Show();
                    this.Close();
                }
                else
                {
                    pay.SetPaymentMethod(new CreditCard());
                    if (user.Card.CardNumber == "-1")
                    {
                        var page = new CreditCardPage(user,ride);
                        page.Show();
                        this.Close();

                    }
                    else
                    {
                        var page = new Searching(user, ride);
                        page.Show();
                        this.Close();
                    }

                }


            }
            else
            {
                MessageBox.Show("Please Select Your Ride Type");
            }
        }

        private void Premium_border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender==premium_border)
            {
               
                premium_border.BorderThickness = new Thickness(3, 3, 3, 3);
                basic_border.BorderThickness = new Thickness(1, 1, 1, 1);
                bike_border.BorderThickness = new Thickness(1, 1, 1, 1);
                basic_border.BorderBrush = Brushes.White;
                bike_border.BorderBrush = Brushes.White;
                premium_border.BorderBrush = Brushes.Black;
                 
            }
            else if (sender == basic_border)
            {
                premium_border.BorderThickness = new Thickness(1, 1, 1, 1);
                basic_border.BorderThickness = new Thickness(3,3,3,3);
                bike_border.BorderThickness = new Thickness(1, 1, 1, 1);
                basic_border.BorderBrush = Brushes.Black;
                bike_border.BorderBrush = Brushes.White;
                premium_border.BorderBrush = Brushes.White;
            }
            else if (sender == bike_border)
            {
                premium_border.BorderThickness = new Thickness(1, 1, 1, 1);
                basic_border.BorderThickness = new Thickness(1, 1, 1, 1);
                bike_border.BorderThickness = new Thickness(3,3,3,3);

                basic_border.BorderBrush = Brushes.White;
                bike_border.BorderBrush = Brushes.Black;
                premium_border.BorderBrush = Brushes.White;

            }

        }

        
    }
}
