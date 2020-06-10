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
using System.Windows.Shapes;

namespace TaxiServiceWPF
{
    /// <summary>
    /// Interaction logic for RegistrationUser.xaml
    /// </summary>
    public partial class RegistrationUser : Window
    {
        public RegistrationUser()
        {
            InitializeComponent();
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

        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxName.Text) ||
                    string.IsNullOrEmpty(textBoxSurname.Text) ||
                    string.IsNullOrEmpty(textBoxNickname.Text) ||
                    string.IsNullOrEmpty(textBoxPassword.Password) ||
                    string.IsNullOrEmpty(textBoxConfirmPass.Password))
                {
                    throw new Exception("Some field is empty!!!");
                }

                if (textBoxPassword.Password != textBoxConfirmPass.Password)
                {
                    throw new Exception("Password mismatch");
                }

                string filePath = $@"..\..\Files\Users\{textBoxNickname.Text}.txt";
                if (File.Exists(filePath))
                {
                    throw new Exception("User already exist!!!");
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine(textBoxNickname.Text);
                        writer.WriteLine(textBoxPassword.Password);
                    }
                    MessageBox.Show("Successful registration");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                WindowForException windowForException = new WindowForException(ex.Message);
                windowForException.Show();
            }
        }
    }
}
