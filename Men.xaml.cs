using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace AppGeneratorImg
{
    /// <summary>
    /// Логика взаимодействия для Men.xaml
    /// </summary>
    public partial class Men : Window
    {
        public Men()
        {
            InitializeComponent();

        }
        int k = 0;
        int kk = 0;
        int kkk = 0;
        
        private void butt_Click(object sender, RoutedEventArgs e)
        {
            List<BitmapImage> imgmhair = new List<BitmapImage>();
            imgmhair = myimg.getImgMenHair();

            imghair.Source = imgmhair[k];
            k += 1;
            if (k>=3)
            {
                k = 0;
            }
        }
        
        private void butt_Click_1(object sender, RoutedEventArgs e)
        {
            List<BitmapImage> imgmtop = new List<BitmapImage>();
            imgmtop = myimg.getImgMenTop();

            imgtop.Source = imgmtop[k];
            k += 1;
            if (k >= 3)
            {
                k = 0;
            }
        }
        
        private void butt_Click_2(object sender, RoutedEventArgs e)
        {
            List<BitmapImage> imgmp = new List<BitmapImage>();
            imgmp = myimg.getImgMenPants();

            imgp.Source = imgmp[kkk];
            kkk += 1;
            if (kkk >= 2)
            {
                kkk = 0;
            }
        }

        private void butt_Click_3(object sender, RoutedEventArgs e)
        {
            hair.Visibility = Visibility.Collapsed;
            top.Visibility = Visibility.Collapsed;
            pants.Visibility = Visibility.Collapsed;
            confirm.Visibility = Visibility.Collapsed;
            res.Visibility = Visibility.Collapsed;
        }

        private void butt_Click_4(object sender, RoutedEventArgs e)
        {
            imghair.Source = new BitmapImage();
            imgtop.Source = new BitmapImage();
            imgp.Source = new BitmapImage();
            k = 0;
            kk = 0;
            kkk=0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            screen.SaveToPNG(canboy, new System.Windows.Size(450.0, 450.0), "скрин");
        }
    }
}
