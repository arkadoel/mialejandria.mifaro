using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mialejandria.mifaro.data;
using System.Windows;

namespace mialejandria.mifaro.logic
{
    public class Licencia
    {
        /// <summary>
        /// Periodo durante el cual aun puede usar el programa a pesar de 
        /// estar caducado
        /// </summary>
        private const int VIGENCIA_TRAS_CADUCIDAD = 3; 

        public static Boolean LicenciaVigente()
        {
            var fechas = from u in DB.Tablas.Configuraciones
                         where u.Nombre.Contains("FechaCaducidad") == true
                         select u;
            if (fechas.Count() > 0)
            {
                Configuracion c = fechas.First();
                //DateTime fecha = DateTime.Parse(c.Valor);
                DateTime fecha = DateTime.Parse(c.Valor);

                if (fecha <= DateTime.Today)
                {
                    /*
                     * Del dia que caduca hasta que pasa el periodo de vigencia,
                     * debe aparecer un formulario para poder pedir otra licencia o 
                     * actualizar
                     */
                    new logic.VentanaLicencias().Show();
                }

                fecha = fecha.AddMonths(VIGENCIA_TRAS_CADUCIDAD);

                if (fecha <= DateTime.Today)
                {
                    //La licencia esta caducada
                    return false;
                }
                else return true;
            }
            return false;
        }
    }
}
