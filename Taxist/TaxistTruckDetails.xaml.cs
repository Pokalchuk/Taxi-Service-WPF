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
    /// Interaction logic for TaxistTruckDetails.xaml
    /// </summary>
    public partial class TaxistTruckDetails : Window
    {
        private Truck truck;
        public TaxistTruckDetails(Car carMain)
        {
            InitializeComponent();
            truck = (Truck)carMain;
        }

        private void tbMaxKilogramsCargo_LostFocus(object sender, RoutedEventArgs e)
        {
           
           
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        private void buttonOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.Parse(tbMaxKilogramsCargo.Text) > 10000 || int.Parse(tbMaxKilogramsCargo.Text) < 100)
                {
                    throw new Exception("Kilograms of cargo must me more than 100 and less than 10000\nPlease, change the value");
                }
                truck.MaxKilogramsOfCargo = Convert.ToInt32(tbMaxKilogramsCargo.Text);
                truck.NumberOfSeats = numericUpDownAmountPeople.Value;
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
