using System;
using System.Windows;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            stuffGrid.ItemsSource = applicationContext.ShowGridStuff();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if((Stuff)stuffGrid.SelectedItem != null)
            {
                applicationContext.AddStuff((Stuff)stuffGrid.SelectedItem);
                stuffGrid.ItemsSource = applicationContext.ShowGridStuff();
            }
            else
            {
                MessageBox.Show("Выберите строку");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if ((Stuff)stuffGrid.SelectedItem != null)
            {
                applicationContext.RemoveStuff((Stuff)stuffGrid.SelectedItem);
                stuffGrid.ItemsSource = applicationContext.ShowGridStuff();
            }
            else
            {
                MessageBox.Show("Вы пытаетесь удалить пустое поле");
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if ((Stuff)stuffGrid.SelectedItem != null)
            {
                applicationContext.UpdateStuff((Stuff)stuffGrid.SelectedItem);
                stuffGrid.ItemsSource = applicationContext.ShowGridStuff();
            }
            else
            {
                MessageBox.Show("Выберите строку");
            }
        }
    }
    public class Stuff
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string position { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}
