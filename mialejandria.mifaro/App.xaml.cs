using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace mialejandria.mifaro
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (logic.Licencia.LicenciaVigente())
            {
                //Licencia vigente puede seguir
                new MainWindow().Show();
            }
        }
    }
}
