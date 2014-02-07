using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mialejandria.mifaro.data
{
    public class DB
    {
        private static MifaroLocalDBEntities tablas;
        private static Externo.biblioDBEntities tablasBiblioDB;
        public static string ConexionBiblioDB { get; set; }

        public static MifaroLocalDBEntities Tablas
        {
            get
            {
                if (tablas == null)
                {
                    tablas = new MifaroLocalDBEntities();
                    
                }
                return tablas;
            }
            set
            {
                tablas = value;
            }
        }

        public static void setBiblioDBConexion(string path)
        {
            ConexionBiblioDB = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + path + @"\Config\biblioDB.mdf;Integrated Security=True;Persist Security Info=True;User ID=mialejandria;Password=FaroMiFaro;Asynchronous Processing=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;User Instance=True";
        }

        public static Externo.biblioDBEntities TablasBiblioDB
        {
            get
            {
                if (tablasBiblioDB == null)
                {
                    
                    tablasBiblioDB = new Externo.biblioDBEntities(ConexionBiblioDB);
                }
                return tablasBiblioDB;
            }
            set
            {
                tablasBiblioDB = value;
            }
        }

    }
}
