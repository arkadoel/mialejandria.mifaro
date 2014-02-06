using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Threading;
using System.IO;

namespace mialejandria.mifaro.logic
{
    public class Util
    {
        /// <summary>
        /// Permite cambiar el estado de la ventana pasada como parametro
        /// </summary>
        /// <param name="win"></param>
        public static void CambiarEstadoVentana(Window win)
        {
            if (win.WindowState == System.Windows.WindowState.Maximized)
            {
                win.WindowState = System.Windows.WindowState.Normal;
            }
            else win.WindowState = System.Windows.WindowState.Maximized;
        }

        /// <summary>
        /// Actualizar la interfaz de forma automatica
        /// </summary>
        /// <param name="dis"></param>
        public static void DoEvents(Dispatcher dis)
        {
            dis.Invoke(DispatcherPriority.Background, new Action(delegate
            {
            }));
        }

        /// <summary>
        /// Listar archivos de un directorio
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public static List<FileInfo> ListarFicheros(string ruta)
        {
            DirectoryInfo dir = new DirectoryInfo(ruta);
            return dir.GetFiles().ToList();
        }
    }
}
