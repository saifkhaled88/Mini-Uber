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
    /// Interaction logic for Location.xaml
    /// </summary>
    public partial class Location : Window
    {
        DbProxy database;
        User user;
        Dictionary<string, int> Cities;
        public Location(User u)
        {
            user = u;
            database = DbProxy.GetDB();

            InitializeComponent();
            from_txt.TextChanged += From_txt_TextChanged;
            from_sugg_txt.SelectionChanged += From_sugg_txt_SelectionChanged;
            to_txt.TextChanged += To_txt_TextChanged;
            to_sugg_txt.SelectionChanged += To_sugg_txt_SelectionChanged;
            confirm_btn.Click += Confirm_btn_Click;
            Cities = database.GetCities();
           
        }

        private void Confirm_btn_Click(object sender, RoutedEventArgs e)
        {
            var page = new Ride(user,from_txt.Text,to_txt.Text);
            page.Show();
            this.Close();
            
        }

        private void To_sugg_txt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (to_sugg_txt.ItemsSource != null)
            {
                to_sugg_txt.Visibility = Visibility.Collapsed;
                to_txt.TextChanged -= new TextChangedEventHandler(To_txt_TextChanged);
                if (to_sugg_txt.SelectedIndex != -1)
                {
                    to_txt.Text = to_sugg_txt.SelectedItem.ToString();
                }
                to_txt.TextChanged += new TextChangedEventHandler(To_txt_TextChanged);

            }
        }

        private void To_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string typedstring = to_txt.Text;
            List<string> autolist = new List<string>();
            autolist.Clear();

            foreach (string item in Cities.Keys)
            {
                if (!string.IsNullOrEmpty(to_txt.Text))
                {
                    if (item.ToLower().StartsWith(typedstring.ToLower()) && item.ToLower()!=from_txt.Text.ToLower())
                    {
                        autolist.Add(item);
                    }
                }
            }

            if (autolist.Count > 0)
            {
                to_sugg_txt.ItemsSource = autolist;
                to_sugg_txt.Visibility = Visibility.Visible;
            }
            else if (from_txt.Text.Equals(""))
            {
                to_sugg_txt.ItemsSource = null;
                to_sugg_txt.Visibility = Visibility.Collapsed;
            }
            else
            {
                to_sugg_txt.ItemsSource = null;
                to_sugg_txt.Visibility = Visibility.Collapsed;
            }

        }

        private void From_sugg_txt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (from_sugg_txt.ItemsSource != null)
            {
                from_sugg_txt.Visibility = Visibility.Collapsed;
                from_txt.TextChanged -= new TextChangedEventHandler(From_txt_TextChanged);
                if (from_sugg_txt.SelectedIndex != -1)
                {
                    from_txt.Text = from_sugg_txt.SelectedItem.ToString();
                }
                from_txt.TextChanged += new TextChangedEventHandler(From_txt_TextChanged);

            }
        }

        private void From_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string typedstring = from_txt.Text;
            List<string> autolist = new List<string>();
            autolist.Clear();

            foreach(string item in Cities.Keys)
            {
                if (!string.IsNullOrEmpty(from_txt.Text))
                {
                    if (item.ToLower().StartsWith(typedstring.ToLower()))
                    {
                        autolist.Add(item);
                    }
                }
            }

            if (autolist.Count > 0)
            {
                from_sugg_txt.ItemsSource = autolist;
                from_sugg_txt.Visibility = Visibility.Visible;
            }
            else if (from_txt.Text.Equals(""))
            {
                from_sugg_txt.ItemsSource = null;
                from_sugg_txt.Visibility = Visibility.Collapsed;
            }
            else
            {
                from_sugg_txt.ItemsSource = null;
                from_sugg_txt.Visibility = Visibility.Collapsed;
            }


        }
    }
}
