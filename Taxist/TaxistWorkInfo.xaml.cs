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

namespace TaxiServiceWPF.Taxist
{
    /// <summary>
    /// Interaction logic for TaxistWorkInfo.xaml
    /// </summary>
    public partial class TaxistWorkInfo : Window
    {
        public User user;
        public TaxistWorkInfo(User _user)
        {
            InitializeComponent();
            user = _user;
            string[] street = user.Street.Split(new char[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            labelNameChange.Content = user.Name;
            labelStreetChange.Content = street[0] + " " + street[1];
            labelEntranceChange.Content = street[street.Length - 1];
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
    }
}
