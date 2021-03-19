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

namespace Project_IS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        Project_ISEntities context = new Project_ISEntities();

        public Autorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registration window1 = new Registration();
            this.Hide();
            window1.Show();
        }

        private void login_text_GotFocus(object sender, RoutedEventArgs e)
        {
            if (login_text.Text == "Введите логин")
            {
                login_text.Text = "";
            }
        }

        private void login_text_LostFocus(object sender, RoutedEventArgs e)
        {
            if (login_text.Text == "")
            {
                login_text.Text = "Введите логин";
            }
        }

        private void join_Click(object sender, RoutedEventArgs e)
        {
            var userLogin = context.Users.ToList().
                Where(i => i.Login == login_text.Text && i.Password == password_text.Password).
                FirstOrDefault();

            if (userLogin != null)
            {
                Window2 window2 = new Window2();
                this.Hide();
                window2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Пользователя не существует");
            }
        }
    }
}
