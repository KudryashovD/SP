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
    /// Логика взаимодействия для MobileEasyTest.xaml
    /// </summary>
    public partial class MobileEasyTest : Window
    {
        int id;
        public MobileEasyTest(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            MobileTest window = new MobileTest(id);
            window.Show();
            this.Close();
        }
    }

}
