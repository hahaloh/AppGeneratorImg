using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows;

namespace AppGeneratorImg
{
    public class screen
    {
        public static void SaveToPNG(FrameworkElement frameworkElement, System.Windows.Size size, string fileName)
        {
            using (FileStream stream = new FileStream(string.Format("{0}.png", fileName), FileMode.Create))
            {
                SaveToPNG(frameworkElement, size, stream);
            }
        }

        public static void SaveToPNG(FrameworkElement frameworkElement, System.Windows.Size size, Stream stream)
        {
            Transform transform = frameworkElement.LayoutTransform;
            frameworkElement.LayoutTransform = null;
            Thickness margin = frameworkElement.Margin;
            frameworkElement.Margin = new Thickness(0, 0, margin.Right - margin.Left, margin.Bottom - margin.Top);
            frameworkElement.Measure(size);
            frameworkElement.Arrange(new Rect(size));
            RenderTargetBitmap bmp = new RenderTargetBitmap((int)size.Width, (int)size.Height, 96, 96, PixelFormats.Pbgra32);
            bmp.Render(frameworkElement);
            frameworkElement.LayoutTransform = transform;
            frameworkElement.Margin = margin;
            PngBitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Interlace = PngInterlaceOption.On;
            encoder.Frames.Add(BitmapFrame.Create(bmp));
            encoder.Save(stream);
        }
    }
}