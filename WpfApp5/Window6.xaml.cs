using System;
using System.Windows;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
            accountingGrid.ItemsSource = applicationContext.ShowGridAccounting();
            decimal incoms = 0;
            decimal expense = 0;
            decimal profits = 0;
            foreach (var item in applicationContext.ShowGridSale())
            {
                if (DateTime.Now.Month == item.date.Month)
                {
                    incoms += item.price;
                }
            }
            foreach (var item in applicationContext.ShowGridSupply())
            {
                if (DateTime.Now.Month == item.supply_date.Month)
                {
                    expense += item.price;
                }
            }
            profits = incoms - expense;
            Accounting selectedItem = null;
            foreach (var item in applicationContext.ShowGridAccounting())
            {
                if (item.date.Month == DateTime.Now.Month)
                {
                    selectedItem = item;
                }
            }

            if (selectedItem != null)
            {
                selectedItem.income = incoms;
                selectedItem.expenses = expense;
                selectedItem.profit = profits;
                selectedItem.date = DateTime.Now;
                applicationContext.UpdateAccounting(selectedItem);
                accountingGrid.ItemsSource = applicationContext.ShowGridAccounting();
            }
            else
            {
                applicationContext.AddAccounting(new Accounting()
                {
                    income = incoms,
                    expenses = expense,
                    profit = profits,
                    date = DateTime.Now,
                });
                accountingGrid.ItemsSource = applicationContext.ShowGridAccounting();
            }

        }
    }

    public class Accounting
    {
        public int id { get; set; }
        public decimal income { get; set; }
        public decimal expenses { get; set; }
        public decimal profit { get; set; }
        public DateTime date { get; set; }
    }
}