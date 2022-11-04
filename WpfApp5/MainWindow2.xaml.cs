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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public MainWindow2()
        {
            InitializeComponent();
        }
        private void Products_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Owner = this;
            w1.Show();
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
    }
}
