using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace mialejandria.mifaro.logic
{
    public class Efectos
    {

        /// <summary>
        /// Permite ocultar o mostrar un menu con un efecto de cortinilla
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="MAX_SIZE"></param>
        public static void MostrarOcultarMenu(UserControl menu, int MAX_SIZE, int MIN_SIZE, DropShadowEffect sombra)
        {
            
            if (menu.Height <= MIN_SIZE)
            {
                //mostrar panel
                menu.Effect = null;
                menu.Effect = sombra;
                menu.Visibility = System.Windows.Visibility.Visible;

                for (int i = 1; i < MAX_SIZE; i += 6)
                {
                    menu.Height = i;
                    logic.Util.DoEvents(menu.Dispatcher);
                    //System.Threading.Thread.Sleep(1);		
                }
            }
            else
            {
                for (int i = MAX_SIZE; i >= MIN_SIZE; i -= 6)
                {
                    menu.Height = i;
                    logic.Util.DoEvents(menu.Dispatcher);
                }

                menu.Height = MIN_SIZE;
                if (MIN_SIZE < 2)
                {
                    menu.Visibility = System.Windows.Visibility.Hidden;
                }
                menu.Effect = null;
                
            }
        }

        /// <summary>
        /// Efecto para cuando el raton esta encima de una etiqueta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            label.Foreground = Brushes.Blue;
        }

        /// <summary>
        /// Efecto para cuando el raton sale de la etiqueta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Label_MouseLeave(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            label.Foreground = Brushes.Black;
        }
    }
}
