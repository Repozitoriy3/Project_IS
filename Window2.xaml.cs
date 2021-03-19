using System;
using System.IO;
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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>

    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void t_1_Click(object sender, RoutedEventArgs e)
        {
            StreamReader reader = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\Lection1.txt");
            string result1 = reader.ReadToEnd();
            lesson.Text = result1;
            test_button.Visibility = Visibility.Visible;
            test_button.Content = "Пройти тест(1)";
        }

        private void t_2_Click(object sender, RoutedEventArgs e)
        {
            test_button.Visibility = Visibility.Visible;
            StreamReader reader = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\Lection2.txt");
            string result2 = reader.ReadToEnd();
            lesson.Text = result2;
            test_button.Visibility = Visibility.Visible;
            test_button.Content = "Пройти тест(2)";
        }

        private void t_3_Click(object sender, RoutedEventArgs e)
        {
            test_button.Visibility = Visibility.Visible;
            StreamReader reader = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\Lection3.txt");
            string result3 = reader.ReadToEnd();
            lesson.Text = result3;
            test_button.Visibility = Visibility.Visible;
            test_button.Content = "Пройти тест(3)";
        }

        private void t_4_Click(object sender, RoutedEventArgs e)
        {
            test_button.Visibility = Visibility.Visible;
            StreamReader reader = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\Lection4.txt");
            string result4 = reader.ReadToEnd();
            lesson.Text = result4;
            test_button.Visibility = Visibility.Visible;
            test_button.Content = "Пройти тест(4)";
        }

        private void t_5_Click(object sender, RoutedEventArgs e)
        {
            test_button.Visibility = Visibility.Visible;
            StreamReader reader = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\Lection5.txt");
            string result5 = reader.ReadToEnd();
            lesson.Text = result5;
            test_button.Visibility = Visibility.Visible;
            test_button.Content = "Пройти тест(5)";
        }

        private void t_6_Click(object sender, RoutedEventArgs e)
        {
            test_button.Visibility = Visibility.Visible;
            StreamReader reader = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\Lection6.txt");
            string result6 = reader.ReadToEnd();
            lesson.Text = result6;
            test_button.Visibility = Visibility.Visible;
            test_button.Content = "Пройти тест(6)";

        }

        private void t_7_Click(object sender, RoutedEventArgs e)
        {
            test_button.Visibility = Visibility.Visible;
            StreamReader reader = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\Lection7.txt");
            string result7 = reader.ReadToEnd();
            lesson.Text = result7;
            test_button.Visibility = Visibility.Visible;
            test_button.Content = "Пройти тест(7)";
        }

        private void t_8_Click(object sender, RoutedEventArgs e)
        {
            test_button.Visibility = Visibility.Visible;
            StreamReader reader = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\Lection8.txt");
            string result8 = reader.ReadToEnd();
            lesson.Text = result8;
            test_button.Visibility = Visibility.Visible;
            test_button.Content = "Пройти тест(8)";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader reader = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\Start.txt");
            string result = reader.ReadToEnd();
            lesson.Text = result;
        }
    }
}
