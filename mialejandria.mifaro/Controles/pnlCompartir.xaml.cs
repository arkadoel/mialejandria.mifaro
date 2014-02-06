using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Effects;

namespace mialejandria.mifaro.Controles
{
    /// <summary>
    /// Interaction logic for pnlCompartir.xaml
    /// </summary>
    public partial class pnlCompartir : UserControl
    {
        private int MAX_SIZE = 250;
        private int MIN_SIZE = 0;
        private DropShadowEffect sombra = null;

        public pnlCompartir()
        {
            InitializeComponent();
            sombra = new DropShadowEffect();
            sombra.Direction = -90;
            sombra.ShadowDepth = 10;
            sombra.BlurRadius = 10;
            sombra.RenderingBias = RenderingBias.Performance;

            this.Height = MIN_SIZE;
            this.Visibility = System.Windows.Visibility.Hidden;
            
        }

        public void MostrarOcultarMenu()
        {
            logic.Efectos.MostrarOcultarMenu(this, MAX_SIZE,MIN_SIZE,sombra );
        }

        private void image1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MostrarOcultarMenu();
        }
    }
}
