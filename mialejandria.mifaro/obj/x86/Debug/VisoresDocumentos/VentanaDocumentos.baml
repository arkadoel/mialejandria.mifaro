   M S B A M L   `   `   `  ����N  Jmialejandria.mifaro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:mialejandria.mifaro.Controlesmialejandria.mifaro.Controles  5   `   =    7mialejandria.mifaro.VisoresDocumentos.VentanaDocumentos   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   :my+clr-namespace:mialejandria.mifaro.Controles     5   `     � Title$  Visor para documentos��5   	   $	��550��6'   $	��900��64    � WindowStartupLocation$ CenterScreen=�6@    � WindowStyle$
 None=�5   	   $��Verdana)�6    � 
ResizeMode$ 	CanResize=�62   ���	#FFB3C6E2 � Icon$@ :/mialejandria.mifaro;component/Images/LogoMiAlejandria.png��6�   .��5      � -   5        $��fondo��5   "   ���	#FFD6D6F5.+�5   
   �� -   5        $��label2��5   �   $'��!Mi Alejandría -> Visor Documento��6   $��16(�6;   ���	#FF6890FF$��Heavy"�6`   $��32��6s   $
��Left=�6   $��35,0,0,0q�6�   $	��Top=�6�   $	��387��6�   5	      �� 5
   
   -   5        $��image1��5
   H   $��28��6   $
��Left=�6   $��8,3,0,0q�67   $
��Fill=�6V   $	��Top=�6e   $��28��6}   $@��:/mialejandria.mifaro;component/Images/LogoMiAlejandria.png��6�   0   *mialejandria.mifaro.Controles.BotonCerrado  5   
   -   5          Name$ 	btnCerrar��5   S   0   *mialejandria.mifaro.Controles.BotonCerrado   MouseLeftButtonDown$# btnCerrar_MouseLeftButtonDown��6f   $��Right=�6   $��24��66   $��0,0,15,0q�6A   $��24��6�   $	��Top=�6�   2   ,mialejandria.mifaro.Controles.BotonRestaurar  5   
   -   5          Name$ btnRestaurar��5   a   2   ,mialejandria.mifaro.Controles.BotonRestaurar   MouseLeftButtonDown$&  btnRestaurar_MouseLeftButtonDown��6�   $��Right=�6   $��0,0,47,0q�68   $��24��6J   $��24��6U   $	��Top=�6w   6�   �� 5   
   $��9,39,316,11q�6   ���	#FFD6D6F5
���   �$��3��6I   	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   	Direction$
 0Q�6#      
BlurRadius$ 10Q�61      ShadowDepth$	 -10Q�6A   6U   5      7  1System.Windows.Forms.Integration.WindowsFormsHost  5   
   -   5        $��windowsFormsHost1��5   1   $��10,38,317,12q�6   5      �� 5   
   -   5        $��label1��5   �   $��	Etiquetas��6   $��14(�6$   $��Heavy"�62   
�������$��30��6W   $��Right=�6c   $��Center=�6   $��
0,38,133,0q�6�   $	��Top=�6�   $��Center=�6�   $	��128��6�   �� 5   
   $	��295��6   $��Right=�6#   $
��Auto=�6?   $��
0,94,5,210q�6b   $��Disabled=�6w   .��5      � -   5        $��panelEtiquetas��5      $	��290��60   $
��Left=�6<   5      �� 5   
   -	   5        $��label3��5   �   $��Descripción��6   $��14(�6&   $��Heavy"�64   
�������$��30��6Y   $��Right=�6e   $��Center=�6�   $��0,0,133,176q�6�   $��Bottom=�6�   $��Center=�6�   $	��128��6  �� 5   
   -
   5        $��
textBlock1��5   C   $��Right=�6   $��	0,0,12,12q�60   $
��Wrap=�6U   $��Verdana)�6i   ���	#FF4E4848$	��289��6�   $j��dDocumento que se manda todos los veranos para su verificacion por el procesador de datos de la Junta��6�   $	��158��6  $��Bottom=�6  	 5        5      $ 0Q�6#   $ 1Q�63   $
 0Q�6B   5      �� 5   
   -   5        $��txtAddLabel��5   x   $��27��6   $��Right=�6   $��	0,66,39,0q�6:   
���iii�$	��Top=�6�   
���   �$��2q�6�   $	��261��6�   ��6b   Z� 6�   �� 5    
   -   5        $��btnAddEtiqueta��5    K   $��24��6   $��Right=�6   $��	0,66,10,0q�68   $
��Fill=�6a   $	��Top=�6p   $��24��6�   $D��>/mialejandria.mifaro;component/Images/Mathematic-Plus-icon.png��6�   5!      5"      