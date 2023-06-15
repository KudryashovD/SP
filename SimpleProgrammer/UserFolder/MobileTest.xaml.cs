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
    /// Логика взаимодействия для MobileTest.xaml
    /// </summary>
    public partial class MobileTest : Window
    {
        int id;
        public MobileTest(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        private void End(object sender, RoutedEventArgs e)
        {
            Entities entity = new Entities();
            MobileWindow window = new MobileWindow(id);
            Test_results test = new Test_results();
            List<Test_results> result = entity.Test_results.ToList();
            test.Admin = 3;
            test.User = id;
            int k = 1;
            if (QOne.Text == "портативных" || QOne.Text == "Портативных")
            {
                k++;
            }
            if (QTwo.Text == "java" || QTwo.Text == "Java" || QTwo.Text == "JAVA")
            {
                k++;
            }
            if (QThree.Text == "Нет")
            {
                k++;
            }
            if (QFour.Text == "Android Studio")
            {
                k++;
            }
            test.Result = k;
            test.Test = 2;
            entity.Test_results.Add(test);
            entity.SaveChanges();
            entity.Dispose();
            window.Show();
            this.Close();
            MessageBox.Show("Вы прошли тест! Ваша оценка: "+k);
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            MobileWindow window = new MobileWindow(id);
            window.Show();
            this.Close();
        }
    }
}
