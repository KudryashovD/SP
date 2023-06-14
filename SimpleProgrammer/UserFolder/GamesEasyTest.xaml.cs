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
    /// Логика взаимодействия для GamesEasyTest.xaml
    /// </summary>
    public partial class GamesEasyTest : Window
    {
        int id;
        public GamesEasyTest(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            GameTest window = new GameTest(id);
            window.Show();
            this.Close();
        }
    }
}
