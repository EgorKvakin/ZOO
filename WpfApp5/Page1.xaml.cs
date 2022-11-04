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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            providerGrid.ItemsSource = applicationContext.ShowGridProvider();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if((Provider)providerGrid.SelectedItem != null)
            {
                applicationContext.AddProvider((Provider)providerGrid.SelectedItem);
                providerGrid.ItemsSource = applicationContext.ShowGridProvider();
            }
            else
            {
                MessageBox.Show("Выберите строку");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if((Provider)providerGrid.SelectedItem != null)
            {
                applicationContext.RemoveProvider((Provider)providerGrid.SelectedItem);
                providerGrid.ItemsSource = applicationContext.ShowGridProvider();
            }
            else
            {
                MessageBox.Show("Вы пытаетесь удалить пустое поле");
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if((Provider)providerGrid.SelectedItem != null)
            {
                applicationContext.UpdateProvider((Provider)providerGrid.SelectedItem);
                providerGrid.ItemsSource = applicationContext.ShowGridProvider();
            }
            else
            {
                MessageBox.Show("Выберите строку");
            }
        }
    }
    public class Provider
    {
        public int id { get; set; }
        public string firm_name { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string firm_addres { get; set; }
        public string telephone_number { get; set; }
    }
}
