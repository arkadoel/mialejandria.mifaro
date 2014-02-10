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
using System.Windows.Shapes;

namespace mialejandria.mifaro.VisoresDocumentos
{
    /// <summary>
    /// Interaction logic for VentanaDocumentos.xaml
    /// </summary>
    public partial class VentanaDocumentos : Window
    {
        private data.Externo.UnidadSimple usimple { get; set; }

        public VentanaDocumentos(string codigoArchivistico)
        {
            InitializeComponent();
            usimple = logic.Archivistica.getUnidadSimpleByCodigo(codigoArchivistico);
            this.Loaded += new RoutedEventHandler(VentanaDocumentos_Loaded);
        }

        void VentanaDocumentos_Loaded(object sender, RoutedEventArgs e)
        {


            panelEtiquetas.Children.Add(new Controles.Etiqueta("Contabilidad", new SolidColorBrush(Colors.Yellow)));
            panelEtiquetas.Children.Add(new Controles.Etiqueta("2013", new SolidColorBrush(Colors.Red)));
            panelEtiquetas.Children.Add(new Controles.Etiqueta("Empresa 32", new SolidColorBrush(Colors.Blue)));
        }

        private void fondo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch { }
        }
        private void CambiarEstadoVentana()
        {
            if (this.WindowState == System.Windows.WindowState.Maximized)
            {
                this.WindowState = System.Windows.WindowState.Normal;
            }
            else this.WindowState = System.Windows.WindowState.Maximized;
        }

        private void btnCerrar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void btnRestaurar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CambiarEstadoVentana();
        }
    }
}
