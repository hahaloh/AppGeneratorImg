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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppGeneratorImg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void butt_Clickm(object sender, RoutedEventArgs e)
        {
            Men men = new Men();
            men.Show();
            menbt.IsEnabled = true;
        }

        private void butt_ClickG(object sender, RoutedEventArgs e)
        {
            Girl girl = new Girl();
            girl.Show();
            girlbt.IsEnabled = true;
        }
    }
}
