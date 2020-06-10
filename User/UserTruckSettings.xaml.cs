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
    /// Interaction logic for UserTruckSettings.xaml
    /// </summary>
    public partial class UserTruckSettings : Window
    {
        public Truck truck;
        public UserTruckSettings()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        private void buttonFind_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.Parse(tbMaxKilogramsCargo.Text) > 10000 || int.Parse(tbMaxKilogramsCargo.Text) < 100)
                {
                    throw new Exception("Kilograms of cargo must me more than 100 and less than 10000\nPlease, change the value");
                }
                List<Truck> trucks = new List<Truck>();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Truck>));
                using (Stream stream = File.OpenRead(@"..\..\XML\Trucks.xml"))
                {
                    trucks = (List<Truck>)xmlSerializer.Deserialize(stream);
                }
                truck = new Truck();
                truck.KilogramsCargo = Convert.ToInt32(tbMaxKilogramsCargo.Text);
                truck.NumberOfSeats = numericUpDownAmountPeople.Value;
                for (int i = 0; i < trucks.Count; ++i)
                {
                    if ((trucks[i].IsMatch(truck)) != null)
                    {
                        truck = trucks[i];
                        break;
                    }
                }
                DialogResult = true;
            }
            catch (Exception ex)
            {
                WindowForException windowForException = new WindowForException(ex.Message);
                windowForException.Show();
            }
           
        }
    }
}
