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

namespace mialejandria.mifaro.PanelesVisores
{
    /// <summary>
    /// Interaction logic for pnlVerFondoSeries.xaml
    /// </summary>
    public partial class pnlVerFondoSeries : UserControl
    {
        private const int MIN_SIZE = 0;
        private const int MAX_SIZE = 300;
        private DropShadowEffect sombra = null;

        public pnlVerFondoSeries()
        {
            InitializeComponent();
            sombra = new DropShadowEffect();
            sombra.Direction = -90;
            sombra.ShadowDepth = 20;
            sombra.BlurRadius = 20;
            sombra.RenderingBias = RenderingBias.Performance;

            this.Height = MIN_SIZE;
            this.Loaded += new RoutedEventHandler(pnlVerFondoSeries_Loaded);
        }

        void pnlVerFondoSeries_Loaded(object sender, RoutedEventArgs e)
        {
            if (logic.gestionBiblioDB.ExisteBiblioteca())
            {
                List<data.Externo.Fondo> fondos = logic.Archivistica.getFondos();

                foreach (data.Externo.Fondo fondo in fondos)
                {
                    if (fondo.TipoObjeto == logic.gestionBiblioDB.TIPO_OBJETO.SUCURSAL)
                    {
                        cmbSucursal.Items.Add(fondo.Titulo);
                    }
                    else if (fondo.TipoObjeto == logic.gestionBiblioDB.TIPO_OBJETO.EDIFICIO)
                    {
                        cmbEdificio.Items.Add(fondo.Titulo);
                    }
                }

                List<data.Externo.Serie> series = logic.Archivistica.getSeries();
                foreach (data.Externo.Serie serie in series)
                {

                    if (serie.TipoObjeto == logic.gestionBiblioDB.TIPO_OBJETO.PLANTA)
                    {
                        cmbPlanta.Items.Add(serie.Titulo);
                    }
                    else if (serie.TipoObjeto == logic.gestionBiblioDB.TIPO_OBJETO.DESPACHO)
                    {
                        cmbDespacho.Items.Add(serie.Titulo);
                    }
                    else if (serie.TipoObjeto == logic.gestionBiblioDB.TIPO_OBJETO.ESTANTERIA)
                    {
                        comun.Visor3D.cmbMueble.Items.Add(serie);
                    }
                    else if (serie.TipoObjeto == logic.gestionBiblioDB.TIPO_OBJETO.CAJONERA)
                    {
                        comun.Visor3D.cmbMueble.Items.Add(serie);
                    }
                }


                cmbSucursal.SelectedIndex = 0;
                cmbEdificio.SelectedIndex = 0;
                cmbPlanta.SelectedIndex = 0;
                cmbDespacho.SelectedIndex = 0;
                comun.Visor3D.cmbMueble.SelectedIndex = 0;
            }
        }

        public void MostrarOcultar()
        {
            logic.Efectos.MostrarOcultarMenu(this, MAX_SIZE, MIN_SIZE, sombra);
        }
    }
}
