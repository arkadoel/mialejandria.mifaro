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
using System.IO;

namespace mialejandria.mifaro.muebles
{
    /// <summary>
    /// Interaction logic for Estanteria.xaml
    /// </summary>
    public partial class Estanteria : UserControl
    {
        //ES\1231321\GES99\RECSI\1\2\123\32\
        public string CodigoEstanteria { get; set; }

        public Estanteria()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<data.Externo.UnidadCompuesta> unidades = logic.Archivistica.getUnidadesCompuestas(CodigoEstanteria);

            foreach (var unidad in unidades)
            {
                if (unidad.TipoObjeto == logic.gestionBiblioDB.TIPO_OBJETO.CARPESANO)
                {
                    muebles.Carpesano carpesan = new muebles.Carpesano();
                    carpesan.CodigoEstante = unidad.CodigoReferencia;
                    carpesan.MouseDoubleClick += new MouseButtonEventHandler(carpesan_MouseDoubleClick);

                    string coordenadas = unidad.CodRefPadre.Replace(this.CodigoEstanteria, "").ToString();
                    int ejeX = Convert.ToInt32( coordenadas[1].ToString());
                    int ejeY = Convert.ToInt32(coordenadas[3].ToString());
                    string huecoord = ejeX + "." + ejeY;


                    var hueco = from StackPanel u in gridHuecos.Children
                                where u.Tag.ToString().Contains(huecoord) == true
                                select u;

                    if (hueco.Count() > 0)
                    {
                        hueco.First<StackPanel>().Children.Add(carpesan);
                    }

                    logic.Util.DoEvents(this.Dispatcher);
                }
            }
            
        }

        void carpesan_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Ver los documentos de la carpeta en la mesa
            Carpesano c = sender as Carpesano;
            string ruta = logic.gestionBiblioDB.getRutaBiblioteca() + "\\" + c.CodigoEstante.Replace(".", "\\");
            List<FileInfo> ficheros = mifaro.logic.Util.ListarFicheros(ruta);


            comun.Visor3D.mesaDocumentos.Children.Clear();
            foreach (FileInfo documento in ficheros)
            {
                string codigo = documento.Name.Replace(documento.Extension, "");
                codigo = codigo.Replace("_", ".");
                Diseños.VisorPdfWpf vi = new Diseños.VisorPdfWpf(documento.FullName, codigo);
                /*
                visorPDF v = new visorPDF();
                v.axAcroPDF1.LoadFile(documento.FullName);
                vi.windowsFormsHost1.Child = v;
                vi.Height=220;
                vi.Width =170;
                */
                comun.Visor3D.mesaDocumentos.Children.Add(vi);
                logic.Util.DoEvents(this.Dispatcher);
            }

        }
    }
}
