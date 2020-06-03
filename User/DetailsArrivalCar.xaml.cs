using Microsoft.Win32;
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
using TaxiService;

namespace TaxiServiceWPF
{
    /// <summary>
    /// Interaction logic for DetailsArrivalCar.xaml
    /// </summary>
    public partial class DetailsArrivalCar : Window
    {
        public Car car;
        public static int CheckPrice(Car car)
        {
            Random rand = new Random();
            if (car is EconomCar)
            {
                int price = 32;
                if (((EconomCar)car).IsChildSeat)
                {
                    price += 10;
                }
                if (((EconomCar)car).IsWheelChair)
                {
                    price += 10;
                }
                if (((EconomCar)car).NumberOfSeats >= 3)
                {
                    price += 5;
                }
                price += rand.Next(10);
                return price;
            }
            else if (car is LuxuryCar)
            {
                int price = 65;
                if (((LuxuryCar)car).IsAlcohol)
                {
                    price += 25;
                }
                if (((LuxuryCar)car).IsTv)
                {
                    price += 30;
                }
                price += rand.Next(25);
                return price;
            }
            else if (car is Truck)
            {
                int price = 45;
                price += (((Truck)car).MaxKilogramsOfCargo / 100);
                price += rand.Next(15);
                return price;
            }
            else { return 0; }
        }
        public DetailsArrivalCar(Car _car)
        {
            InitializeComponent();
            car = _car;
            labelCarNameChange.Content = car.CarName;
            labelCarModelChange.Content = car.CarModel;
            labelCarNumberChange.Content = car.CarNumber;
            labelTaxistNameChange.Content = car.taxist.Name;
            labelPriceCheck.Content = CheckPrice(car).ToString() + " UAH";
            Random rand = new Random();
            DateTime currentTime = DateTime.Now;
            DateTime FewMinutesLater = currentTime.AddMinutes(rand.Next(10));
            labelTime.Content = FewMinutesLater.ToString("HH:mm:ss tt");


            if(car is EconomCar)
            {
                LoadImage($"EconomCar");
                //string selectedFileName = @"pack://application:,,,/Images/EconomCar.jpg";
                //BitmapImage bitmap = new BitmapImage();
                //bitmap.BeginInit();
                //bitmap.UriSource = new Uri(selectedFileName);
                //bitmap.EndInit();
                //imageCarType.Source = bitmap;
            }
            else if(car is LuxuryCar)
            {
                LoadImage($"LuxuryCar");
                //string selectedFileName = @"pack://application:,,,/Images/LuxuryCar.jpg";
                //BitmapImage bitmap = new BitmapImage();
                //bitmap.BeginInit();
                //bitmap.UriSource = new Uri(selectedFileName);
                //bitmap.EndInit();
                //imageCarType.Source = bitmap;
            }
            else if(car is Truck)
            {
                LoadImage($"Truck");
            }
        }

        private void LoadImage(string imageName)
        {
            string selectedFileName = $@"pack://application:,,,/Images/{imageName}.jpg";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(selectedFileName);
            bitmap.EndInit();
            imageCarType.Source = bitmap;
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

        private void ButtonOkay_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
