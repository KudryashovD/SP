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
        public Themes()
        {
            InitializeComponent();
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
