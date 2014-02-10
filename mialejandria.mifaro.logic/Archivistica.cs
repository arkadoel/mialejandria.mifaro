using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mialejandria.mifaro.data;

namespace mialejandria.mifaro.logic
{
    public class Archivistica
    {
        /// <summary>
        /// Obtiene los fondos
        ///     -Edificios
        ///     -Sucursales
        /// </summary>
        /// <returns></returns>
        public static List<data.Externo.Fondo> getFondos()
        {
            return DB.TablasBiblioDB.Fondos.ToList();
        }

        /// <summary>
        /// Obtiene las series
        ///     -Plantas
        ///     -Despachos
        ///     -Estanterias
        /// </summary>
        /// <returns></returns>
        public static List<data.Externo.Serie> getSeries()
        {
            return DB.TablasBiblioDB.Series.ToList();
        }

        /// <summary>
        /// Obtiene las unidades compuestas de una serie
        /// </summary>
        /// <param name="codigoReferencia"></param>
        /// <returns></returns>
        public static List<data.Externo.UnidadCompuesta> getUnidadesCompuestas(string codigoReferencia)
        {
            List<data.Externo.UnidadCompuesta> lista = new List<data.Externo.UnidadCompuesta>();
            var elementos = from u in DB.TablasBiblioDB.UnidadesCompuestas
                            where u.CodRefPadre.Contains(codigoReferencia) == true
                            select u;

            if (elementos.Count() > 0)
            {
                lista = elementos.ToList<data.Externo.UnidadCompuesta>();
            }
            return lista;
        }

        /// <summary>
        /// Obtiene los archivos sabiendo la unidad compuesta de la que salen
        /// </summary>
        /// <param name="codigoReferencia"></param>
        /// <returns></returns>
        public static List<data.Externo.UnidadSimple> getUnidadesSimples(string codigoReferencia)
        {
            List<data.Externo.UnidadSimple> lista = new List<data.Externo.UnidadSimple>();
            var elementos = from u in DB.TablasBiblioDB.UnidadesSimples
                            where u.CodRefPadre.Contains(codigoReferencia) == true
                            select u;

            if (elementos.Count() > 0)
            {
                lista = elementos.ToList<data.Externo.UnidadSimple>();
            }
            return lista;
        }

        /// <summary>
        /// Obtiene una unidad simple al pasar el codigo de referencia archivistico
        /// </summary>
        /// <param name="codigoReferencia"></param>
        /// <returns></returns>
        public static data.Externo.UnidadSimple getUnidadSimpleByCodigo(string codigoReferencia)
        {
            
            var elementos = from u in DB.TablasBiblioDB.UnidadesSimples
                            where u.CodRefPadre.Contains(codigoReferencia) == true
                            select u;

            if (elementos.Count() > 0)
            {
                return elementos.First();             

            }
            return null;
        }

        /// <summary>
        /// Obtiene las etiquetas que estan asociadas a una unidad simple, archivo por el usuario actual
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static List<data.Externo.EtiquetasUsuario> getEtiquetasUnidadSimple(string codigo, long usuario)
        {
            var elementos = from u in DB.TablasBiblioDB.EtiquetasUsuarios
                            where u.CodUnidadSimple.Contains(codigo) == true && u.IDusuario == usuario
                            select u;

            if (elementos.Count() > 0)
            {
                return elementos.ToList<data.Externo.EtiquetasUsuario>();
            }
            else return new List<data.Externo.EtiquetasUsuario>();
        }

    }
}
