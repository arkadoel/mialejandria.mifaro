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
    /// Interaction logic for pnlMenuLugar.xaml
    /// </summary>
    public partial class pnlMenuLugar : UserControl
    {
        private const int MIN_SIZE = 30;
        private const int MAX_SIZE = 150;
        private DropShadowEffect sombra=null;

        public pnlMenuLugar()
        {
            InitializeComponent();
            sombra = new DropShadowEffect();
            sombra.Direction = -90;
            sombra.ShadowDepth = 10;
            sombra.BlurRadius = 10;
            sombra.RenderingBias = RenderingBias.Performance;

            this.Height = MIN_SIZE;
            initEventHandlers();
        }

        private void initEventHandlers()
        {
            lblMiOrdenador.MouseEnter += logic.Efectos.Label_MouseEnter;
            lblMiOrdenador.MouseLeave += logic.Efectos.Label_MouseLeave;
            lblMiBiblioteca.MouseEnter += logic.Efectos.Label_MouseEnter;
            lblMiBiblioteca.MouseLeave += logic.Efectos.Label_MouseLeave;
            lblBuscador.MouseEnter += logic.Efectos.Label_MouseEnter;
            lblBuscador.MouseLeave += logic.Efectos.Label_MouseLeave;

            lblMiBiblioteca.MouseLeftButtonDown += new MouseButtonEventHandler(lblMiBiblioteca_MouseLeftButtonDown);
            lblMiOrdenador.MouseLeftButtonDown += new MouseButtonEventHandler(lblMiOrdenador_MouseLeftButtonDown);
            lblBuscador.MouseLeftButtonDown += new MouseButtonEventHandler(lblBuscador_MouseLeftButtonDown);
        }

        void lblBuscador_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            logic.Efectos.MostrarOcultarMenu(this, MAX_SIZE, MIN_SIZE, sombra);
            //Ver buscador
            comun.PRINCIPAL.ZonaVisores.Children.Clear();

        }

        void lblMiOrdenador_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            logic.Efectos.MostrarOcultarMenu(this, MAX_SIZE, MIN_SIZE, sombra);
            //Ver explorardor de carpetas internas
            comun.PRINCIPAL.ZonaVisores.Children.Clear();
            logic.Util.DoEvents(comun.PRINCIPAL.Dispatcher);
        }

        void lblMiBiblioteca_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            logic.Efectos.MostrarOcultarMenu(this, MAX_SIZE, MIN_SIZE, sombra);
            //ver panel visor 3d
            comun.PRINCIPAL.ZonaVisores.Children.Clear();
            logic.Util.DoEvents(comun.PRINCIPAL.Dispatcher);
            comun.PRINCIPAL.ZonaVisores.Children.Add(new PanelesVisores.pnlVisor3d());
        }

        private void label1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            logic.Efectos.MostrarOcultarMenu(this, MAX_SIZE, MIN_SIZE, sombra);
        }
    }
}
