   M S B A M L   `   `   `  ����N  Jmialejandria.mifaro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:mialejandria.mifaro.mueblesmialejandria.mifaro.muebles  5      W0clr-namespace:mialejandria.mifaro.PanelesVisores"mialejandria.mifaro.PanelesVisores  5   7   3    -mialejandria.mifaro.PanelesVisores.pnlVisor3d   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9my1)clr-namespace:mialejandria.mifaro.muebles     5      ?my0clr-namespace:mialejandria.mifaro.PanelesVisores     5   7   .��5	      � -   5        $��Visor3d��5	      $��0q�6   .+�5   
   � $��	0,0,0,260q�6   .+�5      �� $
��Auto=�6   $��0,0,0,20q�6?   $
��Auto=�6Q   .��5      �� -   5        $��	navegador��5        �� Orientation$  Vertical=�6.   $��1��6F   $��5,3,0,0q�6S    � LayoutTransform 5      �� 5       �� ScaleX 6*   ��  �� ElementName$ 
zoomSlider�� �� Path$ Value� �� ScaleY 6_   �� $ 
zoomSlider��$ Value�5      ��5      �� 5       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5      �  � Color$ 	#FF454545��6'   	 � Offset$	 0.164Q�69   � 5      $ 	#FF515151��6'   $	 0.764Q�69   5      5      �� 5      -   5        
 ��Name$
 
zoomSlider��5       � Minimum$
 0.01Q�6)    � Maximum$ 1Q�68    � Value$	 0.1Q�6D    �� Orientation$ 
Horizontal=�6P   $��20��6i   $��Bottom=�6u   $��0,0,15,0q�6�   $��Right=�6�   $	��120��6�   �� 5       -   5        $��btnVerFondos��5        $��20��6   $
��Fill=�64   $��24��6C   $��Bottom=�6N   $
��Left=�6i   $��	10,0,0,-3q�6�   $:��4/mialejandria.mifaro;component/Images/archivador.png��6�   �� 5!      -   5        $��	cmbMueble��5!   Q   $��23��6   $
��Left=�6#   $��	40,0,0,-3q�6>   $��Bottom=�6b   $	��273��6}    �� DisplayMemberPath$ Titulo��6�    �� Text 6�   �� $ data.Externo.Serie�5"      � 5#   
   -   5        $��grid1��5#       $��0,0,0,0q�6   $	��260��6-   $��Bottom=�6:   .+�5$      �� $��0,5,3,5q�6   $
��Fill=�6%   $F��@/mialejandria.mifaro;component/Images/wood-textures_00394149.jpg��64    J� Opacity$	 0.8Q�6~   �� 5%      $
��Auto=�6   $��3,3,10,3q�6?   $
��Auto=�6S   .��5&      �� -   5        $��mesaDocumentos��5&      $  
Horizontal=�64   5(      5)      5+      :   4mialejandria.mifaro.PanelesVisores.pnlVerFondoSeries  5,   
   -   5          Name$ pnlVerFondoSeries1��5,   q   $��0��6   $	��Top=�6*   $��Center=�6B   $��0,-5,0,0q�6_   $	��600��6�   5-      5.      