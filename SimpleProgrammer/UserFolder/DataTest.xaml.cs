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
        private void Easy(object sender, RoutedEventArgs e)
        {
            DataEasyTest window = new DataEasyTest(id);
            window.Show();
            this.Close();
        }
        private void Hard(object sender, RoutedEventArgs e)
        {
            DataHardTest window = new DataHardTest(id);
            window.Show();
            this.Close();
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            DataWindow window = new DataWindow(id);
            window.Show();
            this.Close();
        }
    }
}
