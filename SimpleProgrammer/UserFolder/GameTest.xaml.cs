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
    /// Логика взаимодействия для GameTest.xaml
    /// </summary>
    public partial class GameTest : Window
    {
        int id;
        public GameTest(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        private void End(object sender, RoutedEventArgs e)
        {
            Entities entity = new Entities();
            GameWindow window = new GameWindow(id);
            Test_results test = new Test_results();
            List<Test_results> result = entity.Test_results.ToList();
            test.Admin = 2;
            test.User = id;
            int k = 0;
            if(QOne.Text == "Да")
            {
                k++;
            }
            if(QTwo.Text == "Видеоигры" || QTwo.Text == "видеоигры")
            {
                k++;
            }
            if(QThree.Text == "Да")
            {
                k++;
            }
            if(QFour.Text == "Нет")
            {
                k++;
            }
            if(QFive.Text == "Нет")
            {
                k++;
            }
            test.Result = k;
            test.Test = 3;
            entity.Test_results.Add(test);
            entity.SaveChanges();
            entity.Dispose();
            window.Show();
            this.Close();
            MessageBox.Show("Вы прошли тест! Ваша оценка: " + k);
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            GameWindow window = new GameWindow(id);
            window.Show();
            this.Close();
        }
    }
}
