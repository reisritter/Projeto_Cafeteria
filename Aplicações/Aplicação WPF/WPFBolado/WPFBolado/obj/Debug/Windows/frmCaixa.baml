   M S B A M L   `   `   `  ����D  @WPFBolado, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WPFBolado.WindowsWPFBolado.Windows  5   	        WPFBolado.Windows.frmCaixa   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WPFBolado.Windows     5   	   -   5          � Title$  Caixa��5   	   $	��435��6   $	��647��6$    � WindowStartupLocation$ CenterScreen=�60    � 
ResizeMode$ NoResize=�6U   .��5	      � .+�5
   
   �� 
�������$
��Left=�6!   $	��367��6<   $��	13,11,0,0q�6I   ���	#FFAAAAAA$	��Top=�6o   $	��124��6�   �� 5   
   
�������$
��Left=�6!   $��65��6<   $��	13,11,0,0q�6H   ���	#FFAAAAAA$	��Top=�6n   $	��124��6�   �� 5   
   
�������$
��Left=�6!   $	��168��6<   $��
13,210,0,0q�6I   ���	#FFAAAAAA$	��Top=�6p   $	��124��6�   �� 5   
   -   5         ��Name$ txtCaixa��5      $
��Left=�6$   $��23��6?   $��
25,256,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $��95��6�   $
��0,00��6�   $��16(�6�   $��Segoe UI Light)�6�   �� 5   
   -   5         ��Name$ btnAbrirFechar��5   >      Button-Cad-orange#���   6   $
��Left=�6V   $��
25,307,0,0q�6q   $	��Top=�6�   $��95��6�   .��5      ��  �� Orientation$ 
Horizontal=�6   $��85��62   .+�5      �� $��/Img/Hand.png��6   $��5 0 10 0q�6/   $��25��6A   $��25��6L   �� 5      -   5         ��Name$ txtbAbrirFechar��5      $��Abrir��65   $��Center=�6B   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5   ;   	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 6   $
��Left=�6M   $��
163,76,0,0q�6h   $	��Top=�6|   $	��231��6�   $	��434��6�   ��6#   �� 6�   �� 5   
   -   5        $ 	txtbCaixa��5      $
��Left=�6'   $��	25,26,0,0q�6B   $
��Wrap=�6U   $��Fechado��6i   $	��Top=�6x   $��25(�6�   �� 5   
   -   5        $ 	textBlock��5      $
��Left=�6'   $��
163,25,0,0q�6B   $
��Wrap=�6V   $��Movimentação de caixa��6j   $	��Top=�6�   $��32(�6�   $��Segoe UI Light)�6�   �� 5   
   -   5        $ 
textBlock1��5      $
��Left=�6(   $��
25,230,0,0q�6C   $
��Wrap=�6W   $��Saldo inicial��6k   $	��Top=�6�   $��16(�6�   $��Segoe UI Light)�6�   �� 5   
   -	   5        $ btnSair��5   =   #���   6   $
��Left=�6O   $��532,328,0,0q�6j   $	��Top=�6   $��65��6�   .��5      �� $ 
Horizontal=�6   .+�5      �� $��
/Img/X.png��6   $��0 0 0 0q�6,   $��25��6=   $��25��6H   �� 5      $��Center=�6   5      5      �� 5   
   -
   5        $ 
textBlock2��5      $
��Left=�6(   $��	25,81,0,0q�6C   $
��Wrap=�6V   $��Dados:��6j   $	��Top=�6x   $��16(�6�   $��Segoe UI Light)�6�   �� 5   
   -   5        $ txtbInformacao��5      $
��Left=�6,   $��
25,125,0,0q�6G   $
��Wrap=�6[   $��-��6o   $	��Top=�6x   
 J� RenderTransformOrigin$
 
0.551,0.25&�6�   $��95��6�   $��85��6�   $��Segoe UI Light)�6�   �� 5    
   -   5        $ 
textBlock3��5       $
��Left=�6(   $��
25,104,0,0q�6C   $
��Wrap=�6W   $	��Top=�6k   $��Segoe UI Light)�6�   �� 6�   $�Funcionario��6�   �� 6�   $�:��6�   6�   5!      5"      