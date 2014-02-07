using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mialejandria.mifaro.data;

namespace mialejandria.mifaro.logic
{
    public class gestionBiblioDB
    {
        /// <summary>
        /// Inicializa la conexion con la biblioteca externa
        /// </summary>
        public static void InitConexionBiblioDB()
        {
            var rutas = from u in DB.Tablas.Configuraciones
                        where u.Nombre.Contains("rutaBiblioteca")==true
                        select u;

            if(rutas.Count()>0)
            {
                string ruta = rutas.First().Valor.ToString();
                DB.setBiblioDBConexion(ruta);
            }
        }
    }
}
