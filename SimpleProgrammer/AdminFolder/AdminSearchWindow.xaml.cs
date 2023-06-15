using SimpleProgrammer.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SimpleProgrammer.AdminFolder
{
    /// <summary>
    /// Логика взаимодействия для AdminSearchWindow.xaml
    /// </summary>
    public partial class AdminSearchWindow : Window
    {
        int id;
        string FIO2;
        public AdminSearchWindow()
        {
            InitializeComponent();
        }
        private void Search(object sender, RoutedEventArgs e)
        {
            Entities entity = new Entities();
            List<User_registration> registr = entity.User_registration.ToList();
            Regex fio = new Regex("^[А-Я]{1}[а-я].+ [А-Я]{1}[а-я].+ [А-Я]{1}[а-я].+");
            bool fl = fio.IsMatch(FIO.Text);
            foreach(var item in registr)
            {
                if (FIO.Text == item.FIO)
                {
                    FIO2=FIO.Text;
                    FIO1.Text = item.FIO;
                    Phone.Text = item.Phone;
                    Hobby.Text = item.Hobby;
                }
            }
        }
        private void Tests(object sender, RoutedEventArgs e)
        {
            float k = 0;
            float result = 0;
            float sum = 0;
            Entities entity = new Entities();
            List<User_registration> registr = entity.User_registration.ToList();
            List<Users> user = entity.Users.ToList();
            List<Test_results> test = entity.Test_results.ToList();
            TestAdminWindow window = new TestAdminWindow();
            foreach (var item4 in registr)
            { 
                if(FIO2 == item4.FIO)
                {
                    id = item4.ID;
                }
            }
            foreach (var item3 in  test)
            {
                if(id== item3.User)
                {
                    k++;
                    sum= (float)(sum +item3.Result);
                }
            }
            result = sum / k;
            foreach (var item in user)
            {
                foreach (var item2 in registr)
                {
                    if (id == item2.ID && id == item.ID)
                    {
                        window.FIO.Text = item2.FIO;
                        window.Login.Text = item.Login;
                        window.Tests.Text = Convert.ToString(k);
                        window.Ball.Text = Convert.ToString(result);
                    }
                }
            }
            window.Show();
            this.Close();
        }
    }
}
