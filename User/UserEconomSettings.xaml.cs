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
    /// Interaction logic for UserEconomSettings.xaml
    /// </summary>
    public partial class UserEconomSettings : Window
    {
        public EconomCar economCar;
        public UserEconomSettings()
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
            List<EconomCar> economCars = new List<EconomCar>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<EconomCar>));
            using (Stream stream = File.OpenRead(@"..\..\XML\EconomCars.xml"))
            {
                economCars = (List<EconomCar>)xmlSerializer.Deserialize(stream);
            }

            economCar = new EconomCar();
            economCar.IsChildSeat = Convert.ToBoolean(checkBoxChildSeat.IsChecked);
            economCar.IsWheelChair = Convert.ToBoolean(checkBoxWheelChair.IsChecked);
            economCar.NumberOfSeats = numericUpDownAmountPeople.Value;

            for (int i = 0; i < economCars.Count; ++i)
            {
                if ((economCars[i].IsMatch(economCar)) != null)
                {
                    economCar = economCars[i];
                    break;
                }
            }
            DialogResult = true;
        }
    }
}
