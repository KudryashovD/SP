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

namespace SimpleProgrammer.AdminFolder
{
    /// <summary>
    /// Логика взаимодействия для TestAdminWindow.xaml
    /// </summary>
    public partial class TestAdminWindow : Window
    {
        public TestAdminWindow()
        {
            InitializeComponent();
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            AdminSearchWindow window = new AdminSearchWindow();
            window.Show();
            this.Close();
        }
    }
}
