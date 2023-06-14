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
                        window.Email.Text = item2.E_mail;
                        window.Login.Text = item.Login;
                        window.Password.Text = item.Password;
                    }
                }
            }
            window.Show();
            this.Close();
        }
        private void Data(object sender, RoutedEventArgs e)
        {
            DataWindow window = new DataWindow();
            window.Show();
            this.Close();
        }
        private void Games(object sender, RoutedEventArgs e)
        {
            GameWindow window = new GameWindow();
            window.Show();
            this.Close();
        }
        private void Mobile(object sender, RoutedEventArgs e)
        {
            MobileWindow window = new MobileWindow();
            window.Show();
            this.Close();
        }
    }
}
