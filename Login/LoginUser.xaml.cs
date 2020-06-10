using System;
using System.Collections.Generic;
using System.IO;
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

namespace TaxiServiceWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginUser : Window
    {
        public LoginUser()
        {
            InitializeComponent();

        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ButtonInstagram_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/shark.taxi.ukraine");
        }

        private void buttonInstagram_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/shark.taxi/?hl=ru");
        }

        private void buttonGooglePlus_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://shark-taxi.ua/ua");
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        private void buttonClose_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);

        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxNickname.Text) || string.IsNullOrEmpty(textBoxPassword.Password))
                {
                    throw new Exception("Some field is empty!!!");
                }

                string filePath = $@"..\..\Files\Users\{textBoxNickname.Text}.txt";
                if (!File.Exists(filePath))
                {
                    throw new Exception($"User with nickname: {textBoxNickname.Text}\nDoes not exist!!!");
                }
                else
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string nickname = reader.ReadLine();
                        string password = reader.ReadLine();
                        if (textBoxNickname.Text == nickname && textBoxPassword.Password == password)
                        {
                            WindowForException windowForException = new WindowForException("Successful login");
                            windowForException.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            throw new Exception("Incorrect password\nEnter again!");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                WindowForException windowForException = new WindowForException(ex.Message);
                windowForException.Show();
            }
        }
    }
}
