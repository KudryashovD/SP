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
        public MobileTest()
        {
            InitializeComponent();
        }
        private void Easy(object sender, RoutedEventArgs e)
        {
            MobileEasyTest window = new MobileEasyTest();
            window.Show();
            this.Close();
        }
        private void Hard(object sender, RoutedEventArgs e)
        {
            MobileHardTest window = new MobileHardTest();
            window.Show();
            this.Close();
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            MobileWindow window = new MobileWindow();
            window.Show();
            this.Close();
        }
    }
}
