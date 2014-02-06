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
            CodigoEstanteria = "ES.1231321.GES99.RECSI.1.2.123.32.1.2.";
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            /*muebles.Carpesano carpesan = null;
            
            //carpesano 1
                carpesan = new muebles.Carpesano();
                carpesan.CodigoEstante = CodigoEstanteria+ "1.";
                carpesan.MouseDoubleClick += new MouseButtonEventHandler(carpesan_MouseDoubleClick);
                hueco1.Children.Add(carpesan);
                comun.DoEvents(this.Dispatcher);

                //carpesano 3
                carpesan = new muebles.Carpesano();
                carpesan.CodigoEstante = CodigoEstanteria + "3.";
                carpesan.MouseDoubleClick += new MouseButtonEventHandler(carpesan_MouseDoubleClick);
                hueco1.Children.Add(carpesan);
                comun.DoEvents(this.Dispatcher);

                //carpesano 5
                carpesan = new muebles.Carpesano();
                carpesan.CodigoEstante = CodigoEstanteria + "5.";
                carpesan.MouseDoubleClick += new MouseButtonEventHandler(carpesan_MouseDoubleClick);
                hueco1.Children.Add(carpesan);
                comun.DoEvents(this.Dispatcher);
            */
        }

        void carpesan_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Ver los documentos de la carpeta en la mesa
            /*Carpesano c = sender as Carpesano;
            string ruta = comun.rutaBiblio +  c.CodigoEstante.Replace(".","\\");
            List<FileInfo> ficheros = mifaro.logic.util.ListarFicheros(ruta);


            comun.vPrincipal.mesaDocumentos.Children.Clear();
            foreach (FileInfo documento in ficheros)
            {
                Diseños.VisorPdfWpf vi = new Diseños.VisorPdfWpf(documento.FullName);
                /*
                visorPDF v = new visorPDF();
                v.axAcroPDF1.LoadFile(documento.FullName);
                vi.windowsFormsHost1.Child = v;
                vi.Height=220;
                vi.Width =170;
                */
                //comun.vPrincipal.mesaDocumentos.Children.Add(vi);
                //comun.DoEvents(this.Dispatcher);
            }
         
        }
    
}
