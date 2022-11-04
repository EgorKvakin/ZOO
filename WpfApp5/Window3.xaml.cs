using System;
using System.Windows;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            supplyGrid.ItemsSource = applicationContext.ShowGridSupply();
            Product.ItemsSource = applicationContext.ShowGridProducts();
            Provider.ItemsSource = applicationContext.ShowGridProvider();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if((Supply)supplyGrid.SelectedItem != null)
            {
                Supply item = ((Supply)supplyGrid.SelectedItem);
                if (item.kolvo >= 0)
                {
                    using (applicationContext db = new applicationContext())
                    {
                        var t = (db.products.Find(item.productsid));
                        item.price = (t.Price * item.kolvo) - (t.Price * item.kolvo / 100 * 25);
                        applicationContext.AddSupply(item);
                        supplyGrid.ItemsSource = applicationContext.ShowGridSupply();
                        t.kolvo += item.kolvo;
                        db.Update(t);
                        db.SaveChanges();
                    }
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
            if ((Supply)supplyGrid.SelectedItem != null)
            {
                applicationContext.RemoveSupply((Supply)supplyGrid.SelectedItem);
                supplyGrid.ItemsSource = applicationContext.ShowGridSupply();
            }
            else
            {
                MessageBox.Show("Вы пытаетесь удалить пустое поле");
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if ((Supply)supplyGrid.SelectedItem != null)
            {
                Supply item = ((Supply)supplyGrid.SelectedItem);
                if (item.kolvo >= 0)
                {
                    using (applicationContext db = new applicationContext())
                    {
                        var t = (db.products.Find(item.productsid));
                        var lastItem = (db.supply.Find(item.id));
                        item.price = (t.Price * item.kolvo) - (t.Price * item.kolvo / 100 * 25);
                        applicationContext.UpdateSupply(item);
                        supplyGrid.ItemsSource = applicationContext.ShowGridSupply();
                        if(item.kolvo < lastItem.kolvo)
                        {
                            t.kolvo -= lastItem.kolvo - item.kolvo;
                        }
                        else
                        {
                            t.kolvo += item.kolvo - lastItem.kolvo;
                        }
                        db.Update(t);
                        db.SaveChanges();
                    }
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

        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            Window3 w3 = new Window3();
            w3.Content = new Page1();
            w3.Show();
        }
    }
    public class Supply
    {
        public int id { get; set; }
        public int providerid { get; set; }
        public int productsid { get; set; }
        public DateTime supply_date { get; set; }
        public int kolvo { get; set; }
        public decimal price { get; set; }
    }
}
