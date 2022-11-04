using System;
using System.Windows;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
            customersGrid.ItemsSource = applicationContext.ShowGridCustomer();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if((Customers)customersGrid.SelectedItem != null)
            {
                applicationContext.AddCustomer((Customers)customersGrid.SelectedItem);
                customersGrid.ItemsSource = applicationContext.ShowGridCustomer();
            }
            else
            {
                MessageBox.Show("Выберите строку");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if ((Customers)customersGrid.SelectedItem != null)
            {
                applicationContext.RemoveCustomer((Customers)customersGrid.SelectedItem);
                customersGrid.ItemsSource = applicationContext.ShowGridCustomer();
            }
            else
            {
                MessageBox.Show("Вы пытаетесь удалить пустое поле");
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if ((Customers)customersGrid.SelectedItem != null)
            {
                applicationContext.UpdateCustomer((Customers)customersGrid.SelectedItem);
                customersGrid.ItemsSource = applicationContext.ShowGridCustomer();
            }
            else
            {
                MessageBox.Show("Выберите строку");
            }
        }
    }
    public class Customers
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
    }
}
