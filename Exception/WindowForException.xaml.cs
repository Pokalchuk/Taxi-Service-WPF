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

namespace TaxiServiceWPF
{
    /// <summary>
    /// Interaction logic for WindowForException.xaml
    /// </summary>
    public partial class WindowForException : Window
    {
        public WindowForException(string expection)
        {
            InitializeComponent();
            labelException.Content = expection;
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        private void buttonClose_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
