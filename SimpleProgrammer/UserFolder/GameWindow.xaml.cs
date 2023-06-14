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
        public GameWindow()
        {
            InitializeComponent();
        }
        private void Account(object sender, RoutedEventArgs e)
        {
            AccountWindow window = new AccountWindow();
            window.Show();
            this.Close();
        }
        private void Themes(object sender, RoutedEventArgs e)
        {
            Themes window = new Themes();
            window.Show();
            this.Close();
        }
        private void Test(object sender, RoutedEventArgs e)
        {
            GameTest window = new GameTest();
            window.Show();
            this.Close();
        }
    }
}
