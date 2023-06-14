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
    /// Логика взаимодействия для GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        int id;
        public GameWindow(int ID)
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
                        window.Login.Text = item.Login;
                        window.Password.Password = item.Password;
                    }
                }
            }
            window.Show();
            this.Close();
        }
        private void Themes(object sender, RoutedEventArgs e)
        {
            Themes window = new Themes(id);
            window.Show();
            this.Close();
        }
        private void Test(object sender, RoutedEventArgs e)
        {
            GameTest window = new GameTest(id);
            window.Show();
            this.Close();
        }
    }
}
