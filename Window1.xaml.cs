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

namespace Project_IS
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Registration : Window
    {
        Project_ISEntities context = new Project_ISEntities();

        public Registration()
        {
            InitializeComponent();
        }

        private void register_login_GotFocus(object sender, RoutedEventArgs e)
        {
            if (register_login.Text == "Введите логин")
            {
                register_login.Text = "";
            }
        }

        private void register_login_LostFocus(object sender, RoutedEventArgs e)
        {
            if (register_login.Text == "")
            {
                register_login.Text = "Введите логин";
            }
        }

        private void register_password_GotFocus(object sender, RoutedEventArgs e)
        {
            if (register_password.Text == "Введите пароль")
            {
                register_password.Text = "";
            }
        }

        private void register_password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (register_password.Text == "")
            {
                register_password.Text = "Введите пароль";
            }
        }

        private void register_name_GotFocus(object sender, RoutedEventArgs e)
        {
            if (register_name.Text == "Введите имя")
            {
                register_name.Text = "";
            }
        }

        private void register_name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (register_name.Text == "")
            {
                register_name.Text = "Введите имя";
            }
        }

        private void register_surname_GotFocus(object sender, RoutedEventArgs e)
        {
            if (register_surname.Text == "Введите фамилию")
            {
                register_surname.Text = "";
            }
        }

        private void register_surname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (register_surname.Text == "")
            {
                register_surname.Text = "Введите фамилию";
            }
        }

        private void register_fname_GotFocus(object sender, RoutedEventArgs e)
        {
            if (register_fname.Text == "Введите отчество")
            {
                register_fname.Text = "";
            }
        }

        private void register_fname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (register_fname.Text == "")
            {
                register_fname.Text = "Введите отчество";
            }
        }

        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            Autorization mainWindow = new Autorization();
            this.Hide();
            mainWindow.Show();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            Users users = new Users();
            users.Login = register_login.Text;
            users.Password = register_password.Text;
            users.First_Name = register_name.Text;
            users.Sur_Name = register_surname.Text;
            users.Father_Name = register_fname.Text;

            context.Users.Add(users);
            context.SaveChanges();

            Autorization window1 = new Autorization();
            this.Hide();
            window1.Show();
        }
    }
}
