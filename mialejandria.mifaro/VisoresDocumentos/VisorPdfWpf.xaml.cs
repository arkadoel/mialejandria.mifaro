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


namespace Diseños
{
    /// <summary>
    /// Interaction logic for VisorPdfWpf.xaml
    /// </summary>
    public partial class VisorPdfWpf : UserControl
    {
        private string ruta { get; set; }
        private string CodigoReferencia { get; set; }
        
        public VisorPdfWpf(string path, string codigo)
        {
            InitializeComponent();
            ruta = path;
            CodigoReferencia = codigo;
            this.Loaded += new RoutedEventHandler(VisorPdfWpf_Loaded);
        }

        void VisorPdfWpf_Loaded(object sender, RoutedEventArgs e)
        {
            visorPDF v = new visorPDF();
            v.axAcroPDF1.LoadFile(ruta);
            v.axAcroPDF1.src = ruta;
            v.axAcroPDF1.setShowToolbar(false);
            v.axAcroPDF1.setView("FitH");
            v.axAcroPDF1.setShowScrollbars(false);
            v.axAcroPDF1.setLayoutMode("SinglePage");
            v.axAcroPDF1.Show();
            windowsFormsHost1.Child = v;
            
            this.Height = 250;
            this.Width = 170;
        }

        private void btnVer_Click(object sender, RoutedEventArgs e)
        {
           mialejandria.mifaro.VisoresDocumentos.VentanaDocumentos vi = new mialejandria.mifaro.VisoresDocumentos.VentanaDocumentos();
            visorPDF v = new visorPDF();
            v.axAcroPDF1.LoadFile(ruta);
            v.axAcroPDF1.src = ruta;
            v.axAcroPDF1.setShowToolbar(false);
            v.axAcroPDF1.setView("FitH");
            v.axAcroPDF1.setShowScrollbars(true);
            v.axAcroPDF1.setLayoutMode("SinglePage");
            v.axAcroPDF1.Show();
            vi.windowsFormsHost1.Child = v;
            vi.Show();
            
        }

        private void btnCompartir_Click(object sender, RoutedEventArgs e)
        {
            //comun.vPrincipal.pnlCompartir1.MostrarOcultarMenu();
            
        }

        private void btnLocalizar_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
