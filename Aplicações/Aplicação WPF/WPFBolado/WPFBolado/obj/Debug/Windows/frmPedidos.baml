   M S B A M L   `   `   `  ����D  @WPFBolado, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WPFBolado.WindowsWPFBolado.Windows  5   	   "    WPFBolado.Windows.frmPedidos   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WPFBolado.Windows     5   	     � Title$  
frmPedidos��5   	   $	��482��6   $	��600��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5
   Y      
IsReadOnly .    AutoGenerateColumns .  $��Center=�6k   $��10,123,193,0q�6�   $	��Top=�6�   $	��234��6�   $	��389��6�   ��6%   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��6%      MinWidth$	 215Q�6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Nome+5        5      $ Preço��6%    64   �� *Preco+5        5      $	 Qtd��6%    62   �� *Qtd+5        5      $ Subtotal��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6T    67   �� *
Subtotal+6T   5      �� 5   
   -   5        
 ��Name$
 btnAdicionar��5   <      Button-Cad-blue2#���   6   $��	Adicionar��6R   $
��Left=�6f   $��
416,78,0,0q�6�   $	��Top=�6�   $��75��6�   6�   �� 5   
   -   5        $
 btnPagamento��5   <   #���   6   $��	Pagamento��6R   $
��Left=�6f   $��
10,377,0,0q�6�   $	��Top=�6�   $��75��6�   6�   �� 5   
   -   5        $
 btnSair��5   <   #���   6   $
��Sair��6M   $
��Left=�6\   $��324,377,0,0q�6w   $	��Top=�6�   $��75��6�   6�   �� 5   
   -   5         ��Name$ cmbProd��5   +   $
��Left=�6<   $��	10,85,0,0q�6W   $	��Top=�6j   $	��166��6�   $��23��6�   $��13(�6�   ��6   �� 6�   �� 5   
   -   5         ��Name$ txtQtd��5      $
��Left=�6"   $��36��6=   $��
347,78,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6r   $��39��6�    �� 
IsReadOnly . 6�   �� 5   
   -   5        $ txtTotal��5      $
��Left=�6$   $��23��6?   $��425,334,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�    . 6�   �� 5   
   -   5        $
 btnDel��5   <   #���   6   $��Remover��6L   $
��Left=�6^   $��416,155,0,0q�6y   $	��Top=�6�   $��75��6�   6�   �� 5   
   -	   5        $
 btnUpd��5   <   #���   6   $��Editar��6L   $
��Left=�6]   $��416,210,0,0q�6x   $	��Top=�6�   $��75��6�   6�   �� 5   
   -
   5        $
 btnAdd��5      $��Right=�6!   $	��Top=�6D   $	��▲��6c   $
��Left=�6o   $��
386,78,0,0q�6�   $	��Top=�6�   $��14��6�   $��18��6�    J� RenderTransformOrigin$ 0.462,0.467&�6�   �� 5   
   -   5        $
 btnDadd��5      $��Right=�6"   $	��Top=�6E   $	��▼��6d   $��386,0,0,337q�6p   $��Bottom=�6�   $��18��6�   $
��Left=�6�   $��14��6�   $ 	0.5,0.391&�6�   �� 5   
   -   5         ��Name$ 	textBlock��5   <     raleway-light#���  6   $
��Left=�6O   $��
236,92,0,0q�6j   $
��Wrap=�6~   $��Quantidade:��6�   $	��Top=�6�   $(��"/WPFBolado;component/Font/#Raleway)�6�   $��13.333(�6�   5!      5"      