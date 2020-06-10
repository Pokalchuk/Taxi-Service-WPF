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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            Base.CreateBaseCars();
            Base.CreateBaseUsers();
            radioButtonUser.IsChecked = true;
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

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            if (radioButtonUser.IsChecked==true)
            {
                LoginUser loginUser = new LoginUser();
                this.Hide();
                loginUser.ShowDialog();
                OrderTaxiForm orderTaxi = new OrderTaxiForm();
                orderTaxi.ShowDialog();
              
            }
            else
            {
                LoginTaxist loginTaxist = new LoginTaxist();
                this.Close();
                loginTaxist.ShowDialog();
            }
        }

        private void ButtonRegistration_Click(object sender, RoutedEventArgs e)
        {
            if (radioButtonUser.IsChecked==true)
            {
                RegistrationUser registrationUser = new RegistrationUser();
                this.Hide();
                registrationUser.ShowDialog();
                OrderTaxiForm orderTaxi = new OrderTaxiForm();
                this.Close();
                orderTaxi.ShowDialog();
            }
            else
            {
                RegistrationTaxist registrationTaxist = new RegistrationTaxist();
                this.Close();
                registrationTaxist.ShowDialog();
            }
        }
    }
}
