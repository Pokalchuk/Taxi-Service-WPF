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
using System.Xml.Serialization;
using TaxiService;

namespace TaxiServiceWPF
{
    /// <summary>
    /// Interaction logic for LoginTaxist.xaml
    /// </summary>
    public partial class LoginTaxist : Window
    {
        Car car;
        public LoginTaxist()
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

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            string typeCar = "";
            string nickname = "";
            try
            {
                if (string.IsNullOrEmpty(textBoxNickname.Text) || string.IsNullOrEmpty(textBoxPassword.Password))
                {
                    throw new Exception("Some field is empty!!!");
                }

                string filePath = $@"..\..\Files\Taxists\{textBoxNickname.Text}.txt";
                if (!File.Exists(filePath))
                {
                    throw new Exception($"User with nickname: {textBoxNickname.Text}\nDoes not exist!!!");
                }
                else
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        nickname = reader.ReadLine();
                        string password = reader.ReadLine();
                        typeCar = reader.ReadLine();
                        if (textBoxNickname.Text == nickname && textBoxPassword.Password == password)
                        {
                            WindowForException windowForException = new WindowForException("Successful login");
                            windowForException.ShowDialog();
                            this.Hide();
                        }
                        else
                        {
                            throw new Exception("Incorrect password\nEnter again!");
                        }
                    }
                }

                if (typeCar == "Econom")
                {
                    WorkingWithXML.DeserializeEconomCar(ref car, nickname);
                }
                else if (typeCar == "Luxury")
                {
                    WorkingWithXML.DeserializeLuxuryCar(ref car, nickname);
                }
                else if (typeCar == "Truck")
                {
                    WorkingWithXML.DeserializeTruck(ref car, nickname);
                }
                TaxistWorking taxistWorking = new TaxistWorking(car);
                taxistWorking.ShowDialog();
            }
            catch (Exception ex)
            {
                WindowForException windowForException = new WindowForException(ex.Message);
                windowForException.Show();
            }
        }
    }
}
