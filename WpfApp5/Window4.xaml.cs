using System;
using System.Windows;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
            saleGrid.ItemsSource = applicationContext.ShowGridSale();
            Stuff.ItemsSource = applicationContext.ShowGridStuff();
            Customer.ItemsSource = applicationContext.ShowGridCustomer();
            Product.ItemsSource = applicationContext.ShowGridProducts();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if((Sale)saleGrid.SelectedItem != null)
            {
                Sale item = ((Sale)saleGrid.SelectedItem);
                using (applicationContext db = new applicationContext())
                {
                    if (item.customersid == null)
                    {
                        item.customersid = 0;
                    }
                    var t = (db.products.Find(item.productsid));
                    if (item.kolvo > 0)
                    {
                        if (t.kolvo >= item.kolvo)
                        {
                            item.price = t.Price * item.kolvo;
                            item.date = DateTime.Now;
                            applicationContext.AddSale(item);
                            saleGrid.ItemsSource = applicationContext.ShowGridSale();
                            t.kolvo -= item.kolvo;
                            db.Update(t);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Колличество больше чем товара на складе");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите корректные значения");
                    }
                }

            }
            else
            {
                MessageBox.Show("Выберите строку");
            }
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if ((Sale)saleGrid.SelectedItem != null)
            {
                applicationContext.RemoveSale((Sale)saleGrid.SelectedItem);
                saleGrid.ItemsSource = applicationContext.ShowGridSale();
            }
            else
            {
                MessageBox.Show("Вы пытаетесь удалить пустое поле");
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if ((Sale)saleGrid.SelectedItem != null)
            {
                Sale item = ((Sale)saleGrid.SelectedItem);
                using (applicationContext db = new applicationContext())
                {
                    if (item.kolvo > 0)
                    {
                        var t = (db.products.Find(item.productsid));
                        var lastItem = (db.sale.Find(item.id));
                        if (t.kolvo >= item.kolvo)
                        {
                            item.price = t.Price * item.kolvo;
                            item.date = DateTime.Now;
                            applicationContext.UpdateSale(item);
                            saleGrid.ItemsSource = applicationContext.ShowGridSale();
                            if (item.kolvo < lastItem.kolvo)
                            {
                                t.kolvo += lastItem.kolvo - item.kolvo;
                            }
                            else
                            {
                                t.kolvo -= item.kolvo - lastItem.kolvo;
                            }
                            db.Update(t);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Колличество больше чем товара на складе");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите корректные значения");
                    }
                }

            }
            else
            {
                MessageBox.Show("Выберите строку");
            }
        }
    }
    public class Sale
    {
        public int id { get; set; }
        public int customersid { get; set; }
        public int stuffid { get; set; }
        public int productsid { get; set; }
        public int kolvo { get; set; }
        public decimal price { get; set; }
        public DateTime date { get; set; }
    }
}
