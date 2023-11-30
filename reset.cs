using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace AppGeneratorImg
{
    class reset : butt
    {
        public reset() : base()
        {
            Background = Brushes.Gray;
        }

        protected override void OnClick()
        {
            base.OnClick();
            Application.Current.Shutdown();
        }
       

    }
}