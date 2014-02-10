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
    /// Interaction logic for pnlDarOpinion.xaml
    /// </summary>
    public partial class pnlDarOpinion : UserControl
    {
        public pnlDarOpinion()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(pnlDarOpinion_Loaded);
        }

        void pnlDarOpinion_Loaded(object sender, RoutedEventArgs e)
        {
            lbl.Text = "Tu opinión nos importa. Cuentanos que partes te han gustado, que cambiarias, cuentanoslo todo. ";
        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            string texto = debug.Log.GetDatosOrdenador() + "\r\n\r\nTexto enviado por usuario: \r\n" + txtMensaje.Text;
            debug.LogicaEmails.emailForMeSilencioso(texto, debug.Log.APP_NAME + " " + debug.Log.APP_VERSION + " User");
        }
    }
}
