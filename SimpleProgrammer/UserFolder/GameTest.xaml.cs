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
        private void Easy(object sender, RoutedEventArgs e)
        {
            GamesEasyTest window = new GamesEasyTest(id);
            window.Show();
            this.Close();
        }
        private void Hard(object sender, RoutedEventArgs e)
        {
            GamesHardTest window = new GamesHardTest(id);
            window.Show();
            this.Close();
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            GameWindow window = new GameWindow(id);
            window.Show();
            this.Close();
        }
    }
}
