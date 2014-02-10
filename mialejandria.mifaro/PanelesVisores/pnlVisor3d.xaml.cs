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

namespace mialejandria.mifaro.PanelesVisores
{
    /// <summary>
    /// Interaction logic for pnlVisor3d.xaml
    /// </summary>
    public partial class pnlVisor3d : UserControl
    {
        public pnlVisor3d()
        {
            logic.gestionBiblioDB.InitConexionBiblioDB();
            logic.Util.DoEvents(comun.PRINCIPAL.Dispatcher);
            InitializeComponent();
            logic.Util.DoEvents(comun.PRINCIPAL.Dispatcher);
            comun.Visor3D = this;
            
            btnVerFondos.MouseLeftButtonDown += new MouseButtonEventHandler(btnVerFondos_MouseLeftButtonDown);
            cmbMueble.SelectionChanged += new SelectionChangedEventHandler(cmbMueble_SelectionChanged);
        }

        void cmbMueble_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbMueble.SelectedItem != null)
            {
                data.Externo.Serie serie = (cmbMueble.SelectedItem as data.Externo.Serie);

                string tipo = serie.TipoObjeto;

                navegador.Children.Clear();
                switch (tipo)
                {
                    case logic.gestionBiblioDB.TIPO_OBJETO.CAJONERA:
                        muebles.Carpesano car = new muebles.Carpesano();
                        navegador.Children.Add(car);
                        break;
                    case logic.gestionBiblioDB.TIPO_OBJETO.ESTANTERIA:
                        
                        muebles.Estanteria estanteria = new muebles.Estanteria();
                        estanteria.CodigoEstanteria = serie.CodigoReferencia;
                        navegador.Children.Add(estanteria);
                        break;
                }
            }
        }

        void btnVerFondos_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            pnlVerFondoSeries1.MostrarOcultar();
        }
    }
}
