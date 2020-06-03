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
    /// Interaction logic for UserLuxurySettings.xaml
    /// </summary>
    public partial class UserLuxurySettings : Window
    {
        public LuxuryCar luxuryCar;
        public UserLuxurySettings()
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
            List<LuxuryCar> luxuryCars = new List<LuxuryCar>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<LuxuryCar>));
            using (Stream stream = File.OpenRead(@"..\..\XML\LuxuryCars.xml"))
            {
                luxuryCars = (List<LuxuryCar>)xmlSerializer.Deserialize(stream);
            }

            luxuryCar = new LuxuryCar();
            luxuryCar.IsTv = Convert.ToBoolean(checkBoxTv.IsChecked);
            luxuryCar.IsAlcohol = Convert.ToBoolean(checkBoxAlcohol.IsChecked);
            luxuryCar.NumberOfSeats = numericUpDownAmountPeople.Value;

            for (int i = 0; i < luxuryCars.Count; ++i)
            {
                if ((luxuryCars[i].IsMatch(luxuryCar)) != null)
                {
                    luxuryCar = luxuryCars[i];
                    break;
                }
            }
            DialogResult = true;
        }
    }
}
