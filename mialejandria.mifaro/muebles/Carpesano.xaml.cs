﻿using System;
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

namespace mialejandria.mifaro.muebles
{
    /// <summary>
    /// Interaction logic for Carpesano.xaml
    /// </summary>
    public partial class Carpesano : UserControl
    {
        public string CodigoEstante { get; set; }

        public Carpesano()
        {
            InitializeComponent();

        }
    }
}
