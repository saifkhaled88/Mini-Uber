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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mini_Uber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DbProxy database;
        User user;
        public MainWindow()
        {
            database = DbProxy.GetDB();
            InitializeComponent();
            
        }

        private void Login_btn_Click(object sender, RoutedEventArgs e)
        {
            user = database.GetUser(user_email_txt.Text);

            if (user != null)
            {
                MessageBox.Show($"Welcome {user.Fname}");
                var page = new Location(user);
                page.Show();
                this.Close();


            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void signup_lb_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var page = new SignUp();
            page.Show();
            this.Close();
        }

        private void signup_btn_Click(object sender, RoutedEventArgs e)
        {
            var page = new SignUp();
            page.Show();
            this.Close();
        }
    }
}
