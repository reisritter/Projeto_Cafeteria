   M S B A M L   `   `   `  ����D  @WPFBolado, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WPFBolado.WindowsWPFBolado.Windows  5   	   $    WPFBolado.Windows.frmPagamento   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WPFBolado.Windows     5   	     � Title$  frmPagamento��5   	   $��456.383��6   $��605.824��6/    � WindowStartupLocation$ CenterScreen=�6?    � 
ResizeMode$ NoResize=�6d   .��5	      � .+�5
   
   �� -   5         ��Name$ 	txtbTotal��5
      $
��Left=�6'   $��
175,30,0,0q�6B   $
��Wrap=�6V   $��-��6j   $	��Top=�6s   $	��107��6�   $��24(�6�   ���	#FF32C24D6�   �� 5   
   -   5        $ 	textBlock��5      $
��Left=�6'   $��	43,36,0,0q�6B   $
��Wrap=�6U   $��Total a pagar:��6i   $	��Top=�6   $(��"/WPFBolado;component/Font/#Raleway)�6�   $��21.333(�6�   ���	#FF00A4006�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgPag��5   +      AutoGenerateColumns .  $
��Left=�6W   $��316,101,0,0q�6r   $	��Top=�6�   $	��154��6�   $	��244��6�   ��6   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Pagamento��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *Nome+  5      $ Valor��6%    64   �� *Valor+5      �� 5   
   -   5        $ txtbRecebido��5      $
��Left=�6*   $��312,279,0,0q�6E   $
��Wrap=�6Z   $	��0,0��6n   $	��Top=�6y   $��21.333(�6�   ���	#FFFFC500$��71��6�   �� 5   
   -   5        $ 	txtbFalta��5      $
��Left=�6'   $��312,315,0,0q�6B   $
��Wrap=�6W   $	��0,0��6k   $	��Top=�6v   $��21.333(�6�   
���  ��$��71��6�   �� 5   
   -   5        	 ��Name$	 grbPag��5      $��GroupBox��6#   $
��Left=�65   $��
20,101,0,0q�6P   $	��Top=�6d   $	��154��6|   $	��281��6�   .��5      � $
��Left=�6   $	��144��6.   $	��Top=�6;   $	��271��6S   $��
0,0,-2,-12q�6_   
 � ColumnDefinitions
 5      �� 5      $��8* �6'   �� 5      $	��27* �6'   �� 5      $
��236* �6'   .+�5      �� -   5         ��Name$ txtDinheiro��5      $
��Left=�6/   $��23��6J   $��	10,10,0,0q�6V    �� TextWrapping$
 Wrap=�6i   $	��Top=�6}   $	��120��6�   $��2��6�   $��1��6�   6�   �� 5      -   5         ��Name$ 	btnAddDin��5   C      Button-Cad-blue#���   6   $��Dinheiro��6V   $
��Left=�6i   $��
120,10,0,0q�6�   $	��Top=�6�   $��75��6�   $��2��6�   $��23��6�   $��12(�6�   �� 5      -	   5        $ 	txtDebito��5      $
��Left=�6-   $��23��6H   $��	10,46,0,0q�6T   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   $��2��6�   $��1��6�   6�   �� 5      -
   5        $ 	btnAddDeb��5   D   #���   6   $��Débito��6W   $
��Left=�6h   $��
120,46,0,0q�6�   $	��Top=�6�   $��75��6�   $��2��6�   $��23��6�   $��12(�6�   �� 5      -   5        $ 
txtCredito��5      $
��Left=�6.   $��23��6I   $��	10,85,0,0q�6U   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   $��2��6�   $��1��6�   6�   �� 5       -   5        $ 	btnAddCre��5    C   #���   6   $��Crédito��6V   $
��Left=�6h   $��
120,85,0,0q�6�   $	��Top=�6�   $��75��6�   $��2��6�   $��23��6�   $��12(�6�   5!      5"      �� 5#   
   -   5        $ btnConcluir��5#   <     Button-Cad-blue2#���  6   $��Concluir��6Q   $
��Left=�6d   $��
33,354,0,0q�6   $	��Top=�6�   $��75��6�   6�   �� 5$   
   -   5        $ btnDel��5$   <   #���  6   $	��Del��6L   $
��Left=�6Z   $��
479,36,0,0q�6u   $	��Top=�6�   $��75��6�   6�   �� 5%   
   -   5        $ 
textBlock1��5%      $
��Left=�6(   $��222,284,0,0q�6C   $
��Wrap=�6X   $	��Top=�6l   $(��"/WPFBolado;component/Font/#Raleway)�6�   $��18.667(�6�   �� 6�   $�Recebido��6�   �� 6�   $�:��6�   6�   �� 5&   
   -   5        $ 
textBlock2��5&      $
��Left=�6(   $��222,320,0,0q�6C   $
��Wrap=�6X   $��	Faltando:��6l   $	��Top=�6}   $��18.667(�6�   $(��"/WPFBolado;component/Font/#Raleway)�6�   
���  ��6�   �� 5'   
   -   5        $ txtbDinheiro��5'      $
��Left=�6*   $��497,279,0,0q�6E   $
��Wrap=�6Z   $	��0,0��6n   $	��Top=�6y   $��21.333(�6�   ���	#FFFFC500$��57��6�   �� 5(   
   -   5        $ 	txtbTroco��5(      $
��Left=�6'   $��497,314,0,0q�6B   $
��Wrap=�6W   $	��0,0��6k   $	��Top=�6v   $��21.333(�6�   ���	#FF32C24D$��57��6�   �� 5)   
   -   5        $ 
textBlock3��5)      $
��Left=�6(   $��419,284,0,0q�6C   $
��Wrap=�6X   $��	Dinheiro:��6l   $	��Top=�6}   $(��"/WPFBolado;component/Font/#Raleway)�6�   $��18.667(�6�   �� 5*   
   -   5        $ 
textBlock4��5*      $
��Left=�6(   $��419,320,0,0q�6C   $
��Wrap=�6X   $	��Top=�6l   $��22��6�   $(��"/WPFBolado;component/Font/#Raleway)�6�   $��18.667(�6�   ���	#FF00A400�� 6�   $�Troco��6�   �� 6�   �� 6	  $�:��6  6  5+      5,      