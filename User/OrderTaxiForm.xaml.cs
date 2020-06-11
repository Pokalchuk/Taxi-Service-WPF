using MaterialDesignThemes.Wpf;
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
using TaxiService;

namespace TaxiServiceWPF
{
    /// <summary>
    /// Interaction logic for OrderTaxiForm.xaml
    /// </summary>
    public partial class OrderTaxiForm : Window
    {
        Car car;
        public OrderTaxiForm()
        {
            InitializeComponent();
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

        private void buttonFindCar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxCurrentAdress.Text) || string.IsNullOrEmpty(textBoxFinalAddress.Text))
                {
                    throw new Exception("Some field is empty");
                }

                if (comboBoxCarsType.SelectedIndex == -1)
                {
                    throw new Exception("Make choice of car type");
                }

                if (comboBoxCarsType.Text == "Econom")
                {
                    UserEconomSettings economSettings = new UserEconomSettings();
                    if (economSettings.ShowDialog() == true)
                    {
                        car = economSettings.economCar;
                    }
                }
                else if (comboBoxCarsType.Text == "Luxury")
                {
                    UserLuxurySettings luxurySettings = new UserLuxurySettings();
                    if (luxurySettings.ShowDialog() == true)
                    {
                        car = luxurySettings.luxuryCar;
                    }
                }
                else if (comboBoxCarsType.Text == "Truck")
                {
                    UserTruckSettings truckSettings = new UserTruckSettings();
                    if (truckSettings.ShowDialog() == true)
                    {
                        car = truckSettings.truck;
                    }
                }
                this.Hide();
                DetailsArrivalCar detailsArrivalCar = new DetailsArrivalCar(car);
                detailsArrivalCar.ShowDialog();

            }
            catch (Exception ex)
            {
                WindowForException windowForException = new WindowForException(ex.Message);
                windowForException.Show();
            }
        }
    }
}
