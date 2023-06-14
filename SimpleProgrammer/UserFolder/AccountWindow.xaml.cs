using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace SimpleProgrammer.UserFolder
{
    /// <summary>
    /// Логика взаимодействия для AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        int id;
        public AccountWindow(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        private void Save(object sender, RoutedEventArgs e)
        {
            Entities entity = new Entities();
            List<Users> user = entity.Users.ToList();
            List<User_registration> registr = entity.User_registration.ToList();
            User_registration Oleg2 = entity.User_registration.Where(a => a.ID == id).First();
            Users Oleg = entity.Users.Where(a => a.ID == id).First();
            Regex fio = new Regex("^[А-Я]{1}[а-я].+ [А-Я]{1}[а-я].+ [А-Я]{1}[а-я].+");
            bool fl = fio.IsMatch(FIO.Text);
            Regex login = new Regex("^[A-Z 0-9 a-z].+");
            bool fg = login.IsMatch(Login.Text);
            Regex password = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])[0-9 a-z A-Z]{6,}$");
            bool rg = password.IsMatch(Password.Password);
            Regex phone = new Regex(@"^\+79|89[0-9]{9}$");
            bool ph = phone.IsMatch(Phone.Text);
            if (fl == false || fg == false || rg == false || ph == false)
            {
                MessageBox.Show("Не все данные введены верно");
                return;
            }
            if (rg == false)
            {
                MessageBox.Show("В пароле должны содержаться заглавные и строчные буквы Латинского алфавита, а также цифры! Количество символов в пароле должно быть больше 6!");
                return;
            }
            if (Password.Password == Login.Text)
            {
                MessageBox.Show("Пароль и логин не должны совпадать!");
                return;
            }
            if (fl && fg && rg && ph)
            {
                Oleg.Login = Login.Text;
                Oleg.Password = Password.Password;
                Oleg2.FIO = FIO.Text;
                Oleg2.Phone = Phone.Text;
                entity.SaveChanges();
                entity.Dispose();
                Themes cat = new Themes(id);
                cat.Show();
                this.Close();
                MessageBox.Show("Редактирование данных успешно!");
                return;
            }
        }
    }
}
