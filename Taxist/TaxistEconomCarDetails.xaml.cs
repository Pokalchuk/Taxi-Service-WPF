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
    /// Interaction logic for TaxistEconomCarDetails.xaml
    /// </summary>
    public partial class TaxistEconomCarDetails : Window
    {
        private EconomCar car;
        public TaxistEconomCarDetails(Car mainCar)
        {
            InitializeComponent();
            car = (EconomCar)mainCar;
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        private void buttonOk_Click(object sender, RoutedEventArgs e)
        {
            car.IsChildSeat = Convert.ToBoolean(checkBoxChildSeat.IsChecked);
            car.IsWheelChair = Convert.ToBoolean(checkBoxWheelChair.IsChecked);
            car.NumberOfSeats = numericUpDownAmountPeople.Value;
            this.Close();
        }

    }
}
