using System;
using System.Linq;
using System.Windows;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }
        private void entrance_Click(object sender, RoutedEventArgs e)
        {
            var login = Login.Text;
            var Password = Pass.Password;
            using (applicationContext db = new applicationContext())
            {
                try
                {
                    var item = db.stuff.Single(x => x.login == login);
                    if (Password == item.password)
                    {
                        if (item.position == "Администратор")
                        {
                            MainWindow mw = new MainWindow();
                            mw.Show();
                            this.Close();
                        }
                        else
                        {
                            MainWindow2 mw2 = new MainWindow2();
                            mw2.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введены неверные данные");
                        Login.Text = "";
                        Pass.Password = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Введены неверные данные");
                    Login.Text = "";
                    Pass.Password = "";
                }
            }
        }
    }
}
