using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mialejandria.mifaro.data
{
    public class DB
    {
        private static MifaroLocalDBEntities tablas;

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
    }
}
