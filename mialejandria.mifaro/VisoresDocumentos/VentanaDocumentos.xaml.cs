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
        private string CodigoArchivistico { get; set; }
        private List<SolidColorBrush> colores { get; set; }

        public VentanaDocumentos(string codigoArchivistico)
        {
            InitializeComponent();
            usimple = logic.Archivistica.getUnidadSimpleByCodigo(codigoArchivistico);
            CodigoArchivistico = codigoArchivistico;
            colores = new List<SolidColorBrush>
            {
                new SolidColorBrush(Colors.Orange),
                new SolidColorBrush(Colors.Yellow),
                new SolidColorBrush(Colors.Green),
                new SolidColorBrush(Colors.Blue),
                new SolidColorBrush(Colors.Indigo),
                new SolidColorBrush(Colors.Cyan),
                new SolidColorBrush(Colors.Violet)

            };
            this.Loaded += new RoutedEventHandler(VentanaDocumentos_Loaded);
            this.btnAddEtiqueta.MouseLeftButtonDown += new MouseButtonEventHandler(btnAddEtiqueta_MouseLeftButtonDown);
            this.Closing += new System.ComponentModel.CancelEventHandler(VentanaDocumentos_Closing);
            this.txtAddLabel.KeyUp += new KeyEventHandler(txtAddLabel_KeyUp);
        }

        void txtAddLabel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnAddEtiqueta_MouseLeftButtonDown(sender, null);
            }
        }

        void VentanaDocumentos_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            //Guardar etiquetas y descripcion
            foreach (Controles.Etiqueta etPrograma in panelEtiquetas.Children)
            {
                data.Externo.EtiquetasUsuario et = new data.Externo.EtiquetasUsuario();  

                et.CodUnidadSimple = usimple.CodigoReferencia;
                et.Etiqueta = etPrograma.lblEtiqueta.Content.ToString();
                et.IDusuario = logic.LogicaUsuario.getUserName();
                logic.Archivistica.GuardarEtiqueta(et);
            }
        }

        void btnAddEtiqueta_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            data.Externo.EtiquetasUsuario et = new data.Externo.EtiquetasUsuario();

            et.CodUnidadSimple = usimple.CodigoReferencia;
            et.Etiqueta = txtAddLabel.Text;
            et.IDusuario = logic.LogicaUsuario.getUserName();

            panelEtiquetas.Children.Add(new Controles.Etiqueta(et, new SolidColorBrush(Colors.Red),this));
            txtAddLabel.Text = "";
        }

        void VentanaDocumentos_Loaded(object sender, RoutedEventArgs e)
        {
            if (usimple != null)
            {
                //El archivo puede tener  etiquetas o descripcion
                ConseguirEtiquetas();
            }
            else
            {
                //El archivo carece de etiquetas y descripcion fijo
                usimple = new data.Externo.UnidadSimple();
                usimple.CodigoReferencia = CodigoArchivistico;
                usimple.CodRefPadre = logic.Archivistica.ObtenerCodigoPadre(CodigoArchivistico);
                usimple.Fecha = DateTime.Today;
                usimple.Nivel = "ITEM";
                usimple.Titulo = "";
                usimple.VolumenSoporte = "";
                logic.Archivistica.GuardarUnidadSimple(usimple);
            }
        }

        private void ConseguirEtiquetas()
        {
            List<data.Externo.EtiquetasUsuario> ets = logic.Archivistica.getEtiquetasUnidadSimple(usimple.CodigoReferencia, logic.LogicaUsuario.getUserName());
            if (ets.Count() > 0)
            {
                int i = 0;
                foreach (var et in ets)
                {
                    panelEtiquetas.Children.Add(new Controles.Etiqueta(et, colores[i], this));
                    i++;
                    if (i >= colores.Count)
                    {
                        i = 0;
                    }
                }
            }
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
