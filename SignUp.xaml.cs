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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        DbProxy database;
        public SignUp()
        {
             database = DbProxy.GetDB();
            
            InitializeComponent();
            signup_btn.Click += Signup_btn_Click;
        }

        private void Signup_btn_Click(object sender, RoutedEventArgs e)
        {
            Person user = new User(Fname_txt.Text,Lname_txt.Text,phone_txt.Text,user_name_txt.Text,password_txt.Password);

            SetValidation validate = new SetValidation();
            validate.sendValidation((User)user);

            switch (IValidation.counter)
            {

                case 0:
                    MessageBox.Show("Invalid First Name");
                    IValidation.counter = 0;
                    break;
                case 1:
                    MessageBox.Show("Invalid Last Name");
                    IValidation.counter = 0;
                    break;
                case 2:
                    MessageBox.Show("Username Already Exist");
                    IValidation.counter = 0;

                    break;
                case 3:
                    MessageBox.Show("Invalid Phone Number");
                    IValidation.counter = 0;

                    break;
                case 4:
                    database.InsertUser((User)user);
                    MessageBox.Show("Account Successfully Created");
                    IValidation.counter = 0;
                    var page = new MainWindow();
                    page.Show();
                    this.Close();

                    break;
                   


            }
        }

        private void alreadyhaveaccount_lb_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var page = new MainWindow();
            page.Show();
            this.Close();
        }
    }
}
