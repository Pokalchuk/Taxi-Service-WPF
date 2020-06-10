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

            if (carTaxist is EconomCar)
            {
                WorkingWithXML.DeserializeEconomBase(ref usersEconomBase);
                user = ((EconomCar)carTaxist).UserMatchTaxistWork(usersEconomBase, district);
            }
            else if (carTaxist is LuxuryCar)
            {
                WorkingWithXML.DeserializeLuxuryBase(ref usersLuxuryBase);
                user = ((LuxuryCar)carTaxist).UserMatchTaxistWork(usersLuxuryBase, district);
            }
            else if (carTaxist is Truck)
            {
                WorkingWithXML.DeserializeTruckBase(ref usersTruckBase);
                user = ((Truck)carTaxist).UserMatchTaxistWork(usersTruckBase, district);
            }
            TaxistWorkInfo taxistWorkInfo = new TaxistWorkInfo(user);
            this.Close();
            taxistWorkInfo.ShowDialog();
        }
    }
}
