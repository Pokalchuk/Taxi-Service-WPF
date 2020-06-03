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
using TaxiServiceWPF.Taxist;

namespace TaxiServiceWPF
{
    /// <summary>
    /// Interaction logic for TaxistWorking.xaml
    /// </summary>
    public partial class TaxistWorking : Window
    {
        public Car carTaxist;
        public District district;
        public Car rightCar;
        public User user;
        public TaxistWorking(Car car)
        {
            InitializeComponent();
            carTaxist = car;
            user = new User();
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

        private void ButtonWork_Click(object sender, RoutedEventArgs e)
        {
            comboBoxDistrict.IsEnabled = false;
            district = new District(comboBoxDistrict.Text);
            List<EconomCar> usersEconomBase = new List<EconomCar>();
            List<LuxuryCar> usersLuxuryBase = new List<LuxuryCar>();
            List<Truck> usersTruckBase = new List<Truck>();

            XmlSerializer xmlSerializerEconom = new XmlSerializer(typeof(List<EconomCar>));
            using (Stream stream = File.OpenRead(@"..\..\XML\UserBase\UsersEconomCars.xml"))
            {
                usersEconomBase = (List<EconomCar>)xmlSerializerEconom.Deserialize(stream);
            }

            XmlSerializer xmlSerializerLuxury = new XmlSerializer(typeof(List<LuxuryCar>));
            using (Stream stream = File.OpenRead(@"..\..\XML\UserBase\UsersLuxuryCars.xml"))
            {
                usersLuxuryBase = (List<LuxuryCar>)xmlSerializerLuxury.Deserialize(stream);
            }

            XmlSerializer xmlSerializerTruck = new XmlSerializer(typeof(List<Truck>));
            using (Stream stream = File.OpenRead(@"..\..\XML\UserBase\UsersTrucks.xml"))
            {
                usersTruckBase = (List<Truck>)xmlSerializerTruck.Deserialize(stream);
            }

            if (carTaxist is EconomCar)
            {
                user = ((EconomCar)carTaxist).UserMatchTaxistWork(usersEconomBase, district);
            }
            else if (carTaxist is LuxuryCar)
            {
                user = ((LuxuryCar)carTaxist).UserMatchTaxistWork(usersLuxuryBase, district);
            }
            else if (carTaxist is Truck)
            {
                user = ((Truck)carTaxist).UserMatchTaxistWork(usersTruckBase, district);
            }
            TaxistWorkInfo taxistWorkInfo = new TaxistWorkInfo(user);
            this.Close();
            taxistWorkInfo.ShowDialog();
        }
    }
}
