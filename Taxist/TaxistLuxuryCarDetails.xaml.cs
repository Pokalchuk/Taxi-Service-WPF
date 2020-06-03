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
    /// Interaction logic for TaxistLuxuryCarDetails.xaml
    /// </summary>
    public partial class TaxistLuxuryCarDetails : Window
    {
        private LuxuryCar car;
        public TaxistLuxuryCarDetails(Car mainCar)
        {
            InitializeComponent();
            car = (LuxuryCar)mainCar;
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        private void buttonOk_Click(object sender, RoutedEventArgs e)
        {
            car.NumberOfSeats = numericUpDownAmountPeople.Value;
            car.IsTv = Convert.ToBoolean(checkBoxTv.IsChecked);
            car.IsAlcohol = Convert.ToBoolean(checkBoxAlcohol.IsChecked);
            this.Close();
        }
    }
}
