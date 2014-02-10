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

namespace mialejandria.mifaro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
           initEventHandlers();
        }


        private void initEventHandlers()
        {

        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            comun.PRINCIPAL = this;
            comun.PRINCIPAL.ZonaVisores.Children.Clear();
            comun.PRINCIPAL.ZonaVisores.Children.Add(new PanelesVisores.pnlVisor3d());
        }


        #region "Control de ventana"

        private void fondo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch { }
        }        

        private void btnCerrar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void btnRestaurar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            logic.Util.CambiarEstadoVentana(this);
        }

        #endregion

        private void lblDarOpinion_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            comun.PRINCIPAL.ZonaVisores.Children.Clear();
            comun.PRINCIPAL.ZonaVisores.Children.Add(new PanelesVisores.pnlDarOpinion());
        }
    }
}
