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
    /// Логика взаимодействия для DataTest.xaml
    /// </summary>
    public partial class DataTest : Window
    {
        int id;
        public DataTest(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        private void End(object sender, RoutedEventArgs e)
        {
            Entities entity = new Entities();
            DataWindow window = new DataWindow(id);
            Test_results test = new Test_results();
            List<Test_results> result = entity.Test_results.ToList();
            test.Admin = 1;
            test.User = id;
            int k = 0;
            if (QOne.Text == "int" || QOne.Text == "Int" || QOne.Text == "INT")
            {
                k++;
            }
            if (QTwo.Text == "string" || QTwo.Text == "String" || QTwo.Text == "STRING")
            {
                k++;
            }
            if (QThree.Text == "bool" || QThree.Text == "Bool" || QThree.Text == "BOOL" || QThree.Text == "boolean" || QThree.Text == "Boolean" || QThree.Text == "BOOLEAN")
            {
                k++;
            }
            if (QFour.Text == "Да")
            {
                k++;
            }
            if (QFive.Text == "Запятой" || QFive.Text == "запятой" || QFive.Text == "Плавающей запятой" || QFive.Text == "плавающей запятой")
            {
                k++;
            }
            test.Result = k;
            test.Test = 1;
            entity.Test_results.Add(test);
            entity.SaveChanges();
            entity.Dispose();
            window.Show();
            this.Close();
            MessageBox.Show("Вы прошли тест! Ваша оценка: " + k);
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            DataWindow window = new DataWindow(id);
            window.Show();
            this.Close();
        }
    }
}
