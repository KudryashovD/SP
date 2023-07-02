using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleProgrammer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int id;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Themes(object sender, RoutedEventArgs e)
        {
            Entities entities = new Entities();
            List<Users> agents = entities.Users.ToList();
            List<Administration> agents2 = entities.Administration.ToList();
            foreach (var item in agents)
            {
                if (Password.Password == item.Password && Login.Text == item.Login)
                {
                    UserFolder.Themes window = new UserFolder.Themes(item.ID);
                    id = item.ID;
                    UserFolder.AccountWindow window2 = new UserFolder.AccountWindow(item.ID);
                    UserFolder.DataWindow window3 = new UserFolder.DataWindow(item.ID);
                    UserFolder.GameWindow window4 = new UserFolder.GameWindow(item.ID);
                    UserFolder.MobileWindow window5 = new UserFolder.MobileWindow(item.ID);
                    window.Show();
                    this.Close();
                    Login.Text = item.Login;
                    Trace.Listeners.Add(new TextWriterTraceListener(File.Open("svodkalogin.txt", FileMode.OpenOrCreate)));
                    Trace.AutoFlush = true;
                    MessageBox.Show("Добро пожаловать " + item.Login + "!");
                    Trace.WriteLine("-------------------------------");
                    Trace.WriteLine(Login.Text);
                    Trace.WriteLine(Password.Password);
                    Trace.WriteLine("-------------------------------");
                    return;
                }
            }
            foreach (var item2 in agents2)
            {
                if (Password.Password == item2.Password && Login.Text == item2.Login)
                {
                    AdminFolder.AdminSearchWindow window = new AdminFolder.AdminSearchWindow();
                    window.Show();
                    this.Close();
                    Trace.Listeners.Add(new TextWriterTraceListener(File.Open("svodkalogin.txt", FileMode.OpenOrCreate)));
                    Trace.AutoFlush = true;
                    MessageBox.Show("Добро пожаловать!");
                    Trace.WriteLine("-------------------------------");
                    Trace.WriteLine(Login.Text);
                    Trace.WriteLine(Password.Password);
                    Trace.WriteLine("-------------------------------");
                    return;
                }
            }
            foreach (var item in agents)
            {
                foreach (var item2 in agents2)
                {
                    if (Password.Password != item2.Password && Login.Text != item2.Login || Password.Password != item.Password && Login.Text != item.Login)
                    {
                        MessageBox.Show("Такого пользователя не существует");
                        return;
                    }
                }
            }
        }
        private void Registration(object sender, RoutedEventArgs e)
        {
            LoginFolder.RegistrationWindow window = new LoginFolder.RegistrationWindow(id);
            window.Show();
            this.Close();
        }
    }
}
