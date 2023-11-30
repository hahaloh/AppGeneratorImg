using AppGeneratorImg.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для Girl.xaml
    /// </summary>
    public partial class Girl : Window
    {
        
        
        public Girl()
        {
            InitializeComponent();


            
        }
        int k = 0;
        int kk = 0;

        

        private void butt_Click_1(object sender, RoutedEventArgs e)
        {
            List<BitmapImage> imgghair = new List<BitmapImage>();
            imgghair = myimg.getImgGirlHair();

            imghair.Source = imgghair[k]; 
            k += 1;
            if (k >= 3)
            {
                k = 0;
            }
        }
        
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            List<BitmapImage> bg = new List<BitmapImage>();
            bg = myimg.getImgBG();

            back.Source = bg[kk];
            kk += 1;
            if (kk >= 2)
            {
                kk = 0;
            }
        }
        
        private void butt_Click(object sender, RoutedEventArgs e)
        {
            List<BitmapImage> imggtop = new List<BitmapImage>();
            imggtop = myimg.getImgGirlTop();

            imgd.Source = imggtop[k];
            k += 1;
            if (k >= 3)
            {
                k = 0;
            }
        }

        private void butt_Click_2(object sender, RoutedEventArgs e)
        {
            imghair.Source = new BitmapImage();
            imgd.Source = new BitmapImage();
            k = 0;
        }

        private void butt_Click_3(object sender, RoutedEventArgs e)
        {
            hair.Visibility = Visibility.Collapsed;
            dress.Visibility = Visibility.Collapsed;
            res.Visibility = Visibility.Collapsed;
            conf.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            screen.SaveToPNG(cangirl, new System.Windows.Size(450.0, 450.0), "скрин");
        }
    }
}
