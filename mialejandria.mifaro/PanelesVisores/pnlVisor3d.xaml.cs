using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mialejandria.mifaro.PanelesVisores
{
    /// <summary>
    /// Interaction logic for pnlVisor3d.xaml
    /// </summary>
    public partial class pnlVisor3d : UserControl
    {
        public pnlVisor3d()
        {
            InitializeComponent();
            logic.Util.DoEvents(comun.PRINCIPAL.Dispatcher);
        }
    }
}
