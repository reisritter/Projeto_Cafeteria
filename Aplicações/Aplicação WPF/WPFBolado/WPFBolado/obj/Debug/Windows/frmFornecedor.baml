   M S B A M L   `   `   `  ����D  @WPFBolado, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WPFBolado.WindowsWPFBolado.Windows  5   	   %    WPFBolado.Windows.frmFornecedor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WPFBolado.Windows     5   	   -   5          � Title$  frmFornecedor��5   	   $	��503��6   $	��730��6,    � WindowStartupLocation$ CenterScreen=�6O   .��5	      � -   5        $��Center=�5	      $��24,0,24,-21q�6=   $	��674��6R    � ColumnDefinitions 5
   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dtgFornecedor��5   ;      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6   $��Right=�6R   $��	0,101,4,0q�6n   $	��Top=�6�   $	��284��6�   $	��660��6�      
IsReadOnly . ��6#   �� 6�   �� 5   
   -   5         ��Name$ txtPesquisa��5      $
��Left=�6'   $��22��6B   $��	10,37,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��148��6�   �� 5   
   -   5         ��Name$ btnPesquisa��5   :      Button-Cad-red#���   6   $
��Left=�6P   $��
176,24,0,0q�6k   $	��Top=�6   $	��115��6�   .��5      �� 	 �� Orientation$	 
Horizontal=�6   $	��109��62   .+�5      �� $��/Img/lupa1.png��6   $��5 0 10 0q�60   $��25��6B   $��25��6M   �� 5      $��	Pesquisar��6   $��Center=�6-   5      5      �� 5   
   -   5        $ btnUpd��5   :   #���   6   $
��Left=�6J   $��
555,24,0,0q�6e   $	��Top=�6y   $	��115��6�   .��5      �� $	 
Horizontal=�6   $	��109��62   .+�5      �� $��/Img/engrenagem.png��6   $��5 0 10 0q�65   $��25��6G   $��25��6R   �� 5      $��	Atualizar��6   $��Center=�6-   5      5      �� 5   
   -   5        $ btnCadastra��5   :   #���   6   $
��Left=�6O   $��
435,24,0,0q�6j   $	��Top=�6~   $	��115��6�   .��5      �� $	 
Horizontal=�6   $	��109��62   .+�5      �� $��/Img/pen1.png��6   $��5 0 10 0q�6/   $��25��6A   $��25��6L   �� 5      $��	Cadastrar��6   $��Center=�6-   5       5!      �� 5"   
   -   5        $ btnSair��5"   :   #���   6   $
��Left=�6L   $��605,402,0,0q�6g   $	��Top=�6|   $��65��6�   .��5#      �� $	 
Horizontal=�6   .+�5$      �� $��
/Img/X.png��6   $��0 0 0 0q�6,   $��25��6=   $��25��6H   �� 5%      $��Center=�6   5&      5'      5(      5)      