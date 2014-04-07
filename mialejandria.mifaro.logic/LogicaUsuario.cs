using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mialejandria.mifaro.data;

namespace mialejandria.mifaro.logic
{
    public class LogicaUsuario
    {

        /* TODO: 
         *      hacer que se guarde forma automatica el usuario tambien en la base de datos biblioDB 
         */

        /// <summary>
        /// Obtiene el nombre del usuario que usa la aplicacion
        /// </summary>
        /// <returns></returns>
        public static string getUserName()
        {
            var lst = from un in DB.Tablas.Configuraciones
                      where un.Nombre.Contains("NombreUsuario") == true
                      select un;

            if (lst.Count() > 0)
            {
                //el usuario esta registrado
                return lst.First().Valor.ToString();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Obtiene el email del usuario
        /// </summary>
        /// <returns></returns>
        public static string getUserEmail()
        {
            var lst = from un in DB.Tablas.Configuraciones
                      where un.Nombre.Contains("EmailUsuario") == true
                      select un;

            if (lst.Count() > 0)
            {
                //el usuario esta registrado
                return lst.First().Valor.ToString();
            }
            else
            {
                return null;
            }
        }

        public static Boolean guardarConfiguracion(string nombre, string valor)
        {
            Boolean correcto=true;
            try
            {
                var lst = from un in DB.Tablas.Configuraciones
                          where un.Nombre.Contains(nombre) == true
                          select un;

                if (lst.Count() > 0)
                {
                    //modificar valor variable
                    lst.First().Valor = valor;
                }
                else
                {
                    //crear nueva configuraicon
                    Configuracion conf = new Configuracion();
                    conf.Nombre = nombre;
                    conf.Valor = valor;
                    DB.Tablas.AddToConfiguraciones(conf);
                }

                DB.Tablas.SaveChanges(System.Data.Objects.SaveOptions.AcceptAllChangesAfterSave);
            }
            catch (Exception ex)
            {
                debug.Log.WriteError("Error al guardar configuracion", ex);
                correcto = false;
                return correcto;
            }

            return correcto;
        }

    }
}
