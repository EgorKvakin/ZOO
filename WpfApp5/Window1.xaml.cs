using System;
using System.Windows;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            zooGrid.ItemsSource = applicationContext.ShowGridProducts();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if((Products)zooGrid.SelectedItem != null)
            {
                var item = ((Products)zooGrid.SelectedItem);
                if (item.Price >= 0 && item.kolvo >= 0)
                {
                    applicationContext.AddProduct(item);
                    zooGrid.ItemsSource = applicationContext.ShowGridProducts();
                }
                else
                {
                    MessageBox.Show("Введите корректные данные");
                }
            }
            else
            {
                MessageBox.Show("Выберите строку");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if ((Products)zooGrid.SelectedItem != null)
            {
                applicationContext.RemoveProduct((Products)zooGrid.SelectedItem);
                zooGrid.ItemsSource = applicationContext.ShowGridProducts();
            }
            else
            {
                MessageBox.Show("Вы пытаетесь удалить пустое поле");
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if ((Products)zooGrid.SelectedItem != null)
            {
                var item = ((Products)zooGrid.SelectedItem);
                if (item.Price >= 0 && item.kolvo >= 0)
                {
                    applicationContext.UpdateProduct((Products)zooGrid.SelectedItem);
                    zooGrid.ItemsSource = applicationContext.ShowGridProducts();
                }
                else
                {
                    MessageBox.Show("Введите корректные данные");
                }
            }
            else
            {
                MessageBox.Show("Выберите строку");
            }
        }
    }
    public class Products
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int kolvo { get; set; }
        public decimal Price { get; set; }
    }
}
