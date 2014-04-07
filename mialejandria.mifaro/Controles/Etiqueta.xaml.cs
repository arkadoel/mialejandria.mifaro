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
using mialejandria.mifaro.VisoresDocumentos;

namespace mialejandria.mifaro.Controles
{
    /// <summary>
    /// Interaction logic for Etiqueta.xaml
    /// </summary>
    public partial class Etiqueta : UserControl
    {
        private data.Externo.EtiquetasUsuario datosEtiqueta { get; set; }
        private VentanaDocumentos Parent { get; set; }

        public Etiqueta(data.Externo.EtiquetasUsuario et, SolidColorBrush color, VentanaDocumentos _parent)
        {
            InitializeComponent();
            Parent = _parent;
            lblEtiqueta.Content = et.Etiqueta;
            Fondo.Fill = color;
            datosEtiqueta = et;
            this.Loaded += new RoutedEventHandler(Etiqueta_Loaded);
            
            
        }

        void Etiqueta_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsLoaded == true)
            {
                int caracteres = datosEtiqueta.Etiqueta.Length;
                if (caracteres <=5)
                {
                    this.Width = caracteres * 18;
                }
                else if (caracteres < 13)
                {
                    this.Width = caracteres * 16;
                }
                else this.Width = caracteres * 9.8;
            }
        }

        private void btnEliminar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            logic.Archivistica.EliminarEtiqueta(datosEtiqueta);
            Parent.panelEtiquetas.Children.Remove(this);
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
