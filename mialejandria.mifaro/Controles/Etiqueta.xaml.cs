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

namespace mialejandria.mifaro.Controles
{
    /// <summary>
    /// Interaction logic for Etiqueta.xaml
    /// </summary>
    public partial class Etiqueta : UserControl
    {
        private string nombreEtiqueta { get; set; }
        public Etiqueta(string nombre, SolidColorBrush color)
        {
            InitializeComponent();
            lblEtiqueta.Content = nombre;
            Fondo.Fill = color;
        }
    }
}
