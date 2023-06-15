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

namespace SimpleProgrammer.UserFolder
{
    /// <summary>
    /// Логика взаимодействия для Themes.xaml
    /// </summary>
    public partial class Themes : Window
    {
        int id;
        public Themes(int ID)
        {
            InitializeComponent();
           id = ID;
        }
        private void Account(object sender, RoutedEventArgs e)
        {
            Entities entity = new Entities();
            List<User_registration> registr = entity.User_registration.ToList();
            List<Users> user = entity.Users.ToList();
            AccountWindow window = new AccountWindow(id);
            foreach (var item in user)
            {
                foreach (var item2 in registr)
                {
                    if (id == item.ID && id == item2.ID)
                    {
                        window.FIO.Text = item2.FIO;
                        window.Phone.Text = item2.Phone;
                        window.Hobby.Text = item2.Hobby;
                        window.Login.Text = item.Login;
                        window.Password.Password = item.Password;
                    }
                }
            }
            window.Show();
        }
        private void Data(object sender, RoutedEventArgs e)
        {
            DataWindow window = new DataWindow(id);
            window.Show();
            this.Close();
        }
        private void Games(object sender, RoutedEventArgs e)
        {
            GameWindow window = new GameWindow(id);
            window.Show();
            this.Close();
        }
        private void Mobile(object sender, RoutedEventArgs e)
        {
            MobileWindow window = new MobileWindow(id);
            window.Show();
            this.Close();
        }
    }
}
