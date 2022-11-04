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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Owner = this;
            w1.Show();
        }

        private void Stuff_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            w2.Owner = this;
            w2.Show();
        }

        private void Supplies_Click(object sender, RoutedEventArgs e)
        {
            Window3 w3 = new Window3();
            w3.Owner = this;
            w3.Show();
        }

        private void Accounting_Click(object sender, RoutedEventArgs e)
        {
            Window4 w4 = new Window4();
            w4.Owner = this;
            w4.Show();
        }

        private void Customers_Click(object sender, RoutedEventArgs e)
        {
            Window5 w5 = new Window5();
            w5.Owner = this;
            w5.Show();
        }

        private void Income_Click(object sender, RoutedEventArgs e)
        {
            Window6 w6 = new Window6();
            w6.Owner = this;
            w6.Show();
        }
    }
}
