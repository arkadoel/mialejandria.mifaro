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
            ConexionBiblioDB = @"metadata=res://*/Externo.ModeloBiblioDB.csdl|res://*/Externo.ModeloBiblioDB.ssdl|res://*/Externo.ModeloBiblioDB.msl;provider=System.Data.SqlClient;provider connection string=""Data Source=.\SQLEXPRESS;AttachDbFilename=" + path + @"\Config\biblioDB.mdf;Integrated Security=True;Persist Security Info=True;User ID=mialejandria;Asynchronous Processing=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;User Instance=True;MultipleActiveResultSets=True""";
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

        public static void guardarCambiosBiblioDB()
        {
            DB.TablasBiblioDB.SaveChanges(System.Data.Objects.SaveOptions.AcceptAllChangesAfterSave);
        }
    }
}
