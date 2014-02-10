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
    /// Interaction logic for pnlConfiguracion.xaml
    /// </summary>
    public partial class pnlConfiguracion : UserControl
    {
        public pnlConfiguracion()
        {
            InitializeComponent();
            string nombreUsuario = logic.LogicaUsuario.getUserName();
            string emailUsuario = logic.LogicaUsuario.getUserEmail();
            string rutaBiblio = logic.gestionBiblioDB.getRutaBiblioteca();

            if (string.IsNullOrEmpty(nombreUsuario) == false)
            {
                txtNombre.Text = nombreUsuario;
            }
            if (string.IsNullOrEmpty(emailUsuario) == false)
            {
                txtEmail.Text = emailUsuario;
            }
            if (string.IsNullOrEmpty(rutaBiblio) == false)
            {
                txtRutaBiblio.Text = rutaBiblio;
            }
        }

        private void btnGuardar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Boolean correctoTodo = true;
            int validaciones = 0;

            if (string.IsNullOrWhiteSpace(txtNombre.Text) == false)
            {
               correctoTodo =  logic.LogicaUsuario.guardarConfiguracion("NombreUsuario", txtNombre.Text);
                if (correctoTodo) validaciones++;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text) == false)
            {
                correctoTodo= logic.LogicaUsuario.guardarConfiguracion("EmailUsuario", txtEmail.Text);
                if (correctoTodo) validaciones++;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text) == false)
            {
                correctoTodo = logic.LogicaUsuario.guardarConfiguracion("RutaBiblio", txtRutaBiblio.Text);
                if (correctoTodo) validaciones++;
            }


            if(validaciones == 3)
            {
                MessageBox.Show("Guardado con exito", "Guardado");
            }
            else MessageBox.Show("Sucedio un error y no se pudo guardar", "Error");


        }
    }
}
