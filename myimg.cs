using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppGeneratorImg
{
    public static class myimg 
    {
        public static List<BitmapImage> getImgBG()
        {
            List<BitmapImage> img = new List<BitmapImage>();

            img.Add(new BitmapImage(new Uri("pack://application:,,,/img/bg1.jpg")));
            img.Add(new BitmapImage(new Uri("pack://application:,,,/img/bg2.png")));

            return img;
        }
        public static List<BitmapImage> getImgGirlHair()
        {
            List<BitmapImage> img = new List<BitmapImage>();

            img.Add(new BitmapImage(new Uri("pack://application:,,,/img/ghair2.png")));
            img.Add(new BitmapImage(new Uri("pack://application:,,,/img/ghai4.png")));
            img.Add(new BitmapImage(new Uri("pack://application:,,,/img/ghair1.png")));
            
            return img;
        }
        public static List<BitmapImage> getImgGirlTop()
        {
            List<BitmapImage> img = new List<BitmapImage>();

            img.Add(new BitmapImage(new Uri("pack://application:,,,/img/gtop1.png")));
            img.Add(new BitmapImage(new Uri("pack://application:,,,/img/gtop2.png")));
            img.Add(new BitmapImage(new Uri("pack://application:,,,/img/gtop3.png")));

            return img;
        }

        public static List<BitmapImage> getImgMenHair()
        {
            List<BitmapImage> img = new List<BitmapImage>();

            img.Add(new BitmapImage(new Uri("pack://application:,,,/Resources/ghair3.png")));
            img.Add(new BitmapImage(new Uri("pack://application:,,,/img/ghair5.png")));
            img.Add(new BitmapImage(new Uri("pack://application:,,,/img/ghair6.png")));
          
            return img;
        }
        public static List<BitmapImage> getImgMenTop()
        {
            List<BitmapImage> img = new List<BitmapImage>();

            img.Add(new BitmapImage(new Uri("pack://application:,,,/img/mtop1.png")));
            img.Add(new BitmapImage(new Uri("pack://application:,,,/img/mtop2.png")));
            img.Add(new BitmapImage(new Uri("pack://application:,,,/img/mtop3.png")));
            
            return img;
        }
        public static List<BitmapImage> getImgMenPants()
        {
            List<BitmapImage> img = new List<BitmapImage>();

            img.Add(new BitmapImage(new Uri("pack://application:,,,/img/mp1.png")));
            img.Add(new BitmapImage(new Uri("pack://application:,,,/img/mp2.png")));
            
            return img;
        }
    }
}
