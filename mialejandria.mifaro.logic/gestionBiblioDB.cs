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
            string ruta = gestionBiblioDB.getRutaBiblioteca();
            if (ruta != null)
            {
                DB.setBiblioDBConexion(ruta);
            }
        }

        public static string getRutaBiblioteca()
        {
            var rutas = from u in DB.Tablas.Configuraciones
                        where u.Nombre.Contains("rutaBiblioteca")==true
                        select u;

            if (rutas.Count() > 0)
            {
                string ruta = rutas.First().Valor.ToString();
                return ruta;
            }
            else return null;
        }

        public static bool ExisteBiblioteca()
        {
            if (System.IO.Directory.Exists(getRutaBiblioteca()))
            {
                return true;
            }
            return false;
        }

        public class TIPO_OBJETO
        {
            public const string SUCURSAL = "SUCURSAL";
            public const string EDIFICIO = "EDIFICIO";
            public const string PLANTA = "PLANTA";
            public const string DESPACHO = "DESPACHO";

            public const string ESTANTERIA = "ESTANTERIA";
            public const string HUECO = "HUECO";
            public const string ESTANTE = "ESTANTE";

            public const string CAJONERA = "CAJONERA";
            public const string CAJON = "CAJON";

            public const string CARPETA = "CARPETA";
            public const string CARPESANO = "CARPESANO";
            public const string ARCHIVO_DEFINITIVO = "ARCHIVO_DEFINITIVO";
            public const string CAJA = "CAJA";

        }
    }
}
