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
    /// Interaction logic for RegistrationTaxist.xaml
    /// </summary>
    public partial class RegistrationTaxist : Window
    {
        Car car;
        TaxistPerson taxist;
        public RegistrationTaxist()
        {
            InitializeComponent();
            taxist = new TaxistPerson();
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

        private void ButtonRegistration_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxName.Text) ||
                    string.IsNullOrEmpty(textBoxSurname.Text) ||
                    string.IsNullOrEmpty(textBoxNickname.Text) ||
                    string.IsNullOrEmpty(textBoxPassword.Password) ||
                    string.IsNullOrEmpty(textBoxConfirmPass.Password) ||
                    string.IsNullOrEmpty(textBoxCarName.Text) ||
                    string.IsNullOrEmpty(textBoxCarModel.Text) ||
                    string.IsNullOrEmpty(textBoxCarNumber.Text))
                {
                    throw new Exception("Some field is empty!!!");
                }

                if (textBoxPassword.Password != textBoxConfirmPass.Password)
                {
                    throw new Exception("Password mismatch");
                }

                string filePath = $@"..\..\Files\Taxists\{textBoxNickname.Text}.txt";
                if (File.Exists(filePath))
                {
                    throw new Exception("Taxist with this nickname is already exist!!!");
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine(textBoxNickname.Text);
                        writer.WriteLine(textBoxPassword.Password);
                        writer.WriteLine(comboBoxCarsType.Text);
                    }
                }

                taxist.Name = textBoxName.Text;
                taxist.Surname = textBoxSurname.Text;
                taxist.birthDate = dateTimePicker1.DisplayDate;
                taxist.Nickname = textBoxNickname.Text;
                taxist.Password = textBoxPassword.Password;

                car.taxist = taxist;
                car.CarName = textBoxCarName.Text;
                car.CarModel = textBoxCarModel.Text;
                car.CarNumber = textBoxCarNumber.Text;

                if (comboBoxCarsType.Text == "Econom")
                {
                    WorkingWithXML.SerializeEconomCar(ref car, taxist.Nickname);
                }
                else if (comboBoxCarsType.Text == "Luxury")
                {
                    WorkingWithXML.SerializeLuxuryCar(ref car, taxist.Nickname);
                }
                else if (comboBoxCarsType.Text == "Truck")
                {
                    WorkingWithXML.SerializeTruck(ref car, taxist.Nickname);
                }
                comboBoxCarsType.IsEnabled = false;

             
                TaxistWorking taxistWorking = new TaxistWorking(car);
                this.Close();
                taxistWorking.ShowDialog();
            }
            catch (Exception ex)
            {
                WindowForException windowForException = new WindowForException(ex.Message);
                windowForException.Show();
            }
        }

        private void comboBoxCarsType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxCarsType.SelectedIndex==0)
            {
                car = new EconomCar();
                TaxistEconomCarDetails economCarDetails = new TaxistEconomCarDetails(car);
                economCarDetails.ShowDialog();
            }
            else if (comboBoxCarsType.SelectedIndex==1)
            {
                car = new LuxuryCar();
                TaxistLuxuryCarDetails luxuryCarDetails = new TaxistLuxuryCarDetails(car);
                luxuryCarDetails.ShowDialog();
            }
            else if (comboBoxCarsType.SelectedIndex == 2)
            {
                car = new Truck();
                TaxistTruckDetails truckDetails = new TaxistTruckDetails(car);
                truckDetails.ShowDialog();
            }
        }
    }
}
