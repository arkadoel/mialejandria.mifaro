using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mialejandria.mifaro.data;

namespace mialejandria.mifaro.logic
{
    public class Archivistica
    {
        #region "Archivistica General"

        /// <summary>
        /// Obtiene el elemento padre pasando un codigo de referencia archivistico
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static string ObtenerCodigoPadre(string codigo)
        {
            string resultado = "";

            string[] codigos = codigo.Split('.');
            for (int i = 0; i < codigos.Length - 1; i++)
            {
                resultado += codigos[i].ToString() + ".";
            }
            resultado = resultado.Remove(resultado.Length - 1,1);
            return resultado;
        }
        #endregion

        #region "Fondos"
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

        #endregion

        #region "Series"
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

        #endregion

        #region "Unidades Compuestas"
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

        #endregion

        #region "Unidades Simples"
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
                            where u.CodigoReferencia.Contains(codigoReferencia) == true
                            select u;

            if (elementos.Count() > 0)
            {
                return elementos.First();             

            }
            return null;
        }

        public static bool GuardarUnidadSimple(data.Externo.UnidadSimple usimple)
        {
            try
            {
                var unidad = getUnidadSimpleByCodigo(usimple.CodigoReferencia);

                if (unidad == null)
                {
                    //crear una nueva
                    DB.TablasBiblioDB.AddToUnidadesSimples(usimple);
                }
                else
                {
                    //actualizar
                    unidad.CodigoReferencia = usimple.CodigoReferencia;
                    unidad.CodRefPadre = usimple.CodRefPadre;
                    unidad.Fecha = usimple.Fecha;
                    unidad.Nivel = usimple.Nivel;
                    unidad.Titulo = usimple.Titulo;
                    unidad.VolumenSoporte = usimple.VolumenSoporte;

                }
                DB.guardarCambiosBiblioDB();
                return true;
            }
            catch (Exception ex)
            {
                debug.Log.WriteError("Error al guardar unidad simple", ex);
                return false;
            }

        }

        #endregion

        #region "Etiquetas y descripciones de archivo"

        /// <summary>
        /// Obtiene las etiquetas que estan asociadas a una unidad simple, archivo por el usuario actual
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static List<data.Externo.EtiquetasUsuario> getEtiquetasUnidadSimple(string codigo, string usuario)
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

        public static bool EliminarEtiqueta(data.Externo.EtiquetasUsuario etiqueta)
        {
            try
            {
                var lista = from un in DB.TablasBiblioDB.EtiquetasUsuarios
                            where un.CodUnidadSimple == etiqueta.CodUnidadSimple && 
                            un.IDusuario == etiqueta.IDusuario && un.Etiqueta == etiqueta.Etiqueta
                            select un;

                if (lista.Count() > 0)
                {
                    //Toca eliminarla
                    DB.TablasBiblioDB.EtiquetasUsuarios.DeleteObject(etiqueta);
                    DB.guardarCambiosBiblioDB();                    
                }
                return true;
            }
            catch (Exception ex)
            {
                debug.Log.WriteError("Error al eliminar etiqueta", ex);
                return false;
            }
        }

        public static Boolean GuardarEtiqueta(data.Externo.EtiquetasUsuario etiqueta)
        {
            try
            {
                var lista = from un in DB.TablasBiblioDB.EtiquetasUsuarios
                            where un.CodUnidadSimple == etiqueta.CodUnidadSimple && 
                            un.IDusuario == etiqueta.IDusuario && un.Etiqueta == etiqueta.Etiqueta
                            select un;

                if (lista.Count() > 0)
                {
                    //Ya existe, no hacer nada
                }
                else
                {
                    DB.TablasBiblioDB.AddToEtiquetasUsuarios(etiqueta);
                    DB.guardarCambiosBiblioDB();
                }
                return true;
            }
            catch (Exception ex)
            {
                debug.Log.WriteError("Error al guardar etiqueta", ex);
                return false;
            }
        }
        #endregion
    }
}
