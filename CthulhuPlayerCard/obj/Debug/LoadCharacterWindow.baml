   M S B A M L   `   `   `  ����L  HCthulhuPlayerCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CthulhuPlayerCardCthulhuPlayerCard  5   	   +    %CthulhuPlayerCard.LoadCharacterWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CthulhuPlayerCard     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ LoadCharacterWindow��5   	   $	��450��6%   $	��800��62   ���	#FFD6DBDE$	��800��6l   $	��450��6{   $	��800��6�   $	��450��6�    � 	Resources 5	      .   (CthulhuPlayerCard.Projekt_CthulhuDataSet   projekt_CthulhuDataSet  listaPostaciViewSource �� Source �� Source��%]   &	        &	      7     5
   
   6'   �� 5   
    6>   �� *ListaPostaci+8   5      .��5      �  � DataContext# [ 6   $��	0,0,2,-21q�6A   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ listaPostaciDataGrid��5      ��. $
��Auto=�6V   $
��Auto=�6�      
IsReadOnly .    EnableRowVirtualization . $��470,10,10,40q�6  	   RowDetailsVisibilityMode$	 VisibleWhenSelected=�6  
�������
���   �
   	RowHeight$
 25Q�6m  $	��380��6|     RowHeaderWidth$ 30Q�6�     ColumnHeaderHeight$ 30Q�6�     CanUserResizeRows .     AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6$     CanUserResizeColumns .     MinColumnWidth$ 40Q�6T  $	��300��6h     GridLinesVisibility$ 
Horizontal=�6t  ��6�   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        id_postaciColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Character Id��5   ^      Width$ SizeToHeader 6t   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *
Id_postaci+6t     5      -   5        
imieColumn��$
 Name��5   R   $ SizeToHeader 6`    69   �� *Imie+6`     5      -   5        nazwiskoColumn��$ Surname��5   Z   $ SizeToHeader 6k    6=   �� *
Nazwisko+6k     5      -   5        nazwa_zawoduColumn��$ 
Profession��5   b   $ SizeToHeader 6v    6A   �� *Nazwa_zawodu+6v   5      �� 5   
   -   5         ��Name$ CharacterIdInput��5      $
��Left=�6,   $��25��6G   $��240,234,0,0q�6S   $	��Top=�6h   $��95��6�   
���   � J� RenderTransformOrigin$ 	0.48,0.56&�6�   �� 5   
   $��Enter Character Id:��6   $
��Left=�6.   $��25��6I   $��125,234,0,0q�6U   $	��Top=�6j   $	��110��6�   �� 5   
   -   5         ��Name$ LoadCharacterButton��5      $��Load Character��6.   $
��Left=�6G   $��50��6b   $��
45,280,0,0q�6n   $	��Top=�6�   $	��150��6�   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $ 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF6@  �� 5   
   -	   5        $ DeleteCharacterButton��5      $��Delete Character��60   $��240,280,0,0q�6K   
���   �$��18(�6t   $��Rockwell)�6�   $��1q�6�   $ 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF$
��Left=�6  $	��185��69  $��50��6E  $	��Top=�6Q  �� 5   
   -
   5        $ MainMenuButton��5      $��	Main Menu��6)   $
��Left=�6=   $��50��6X   $��
45,345,0,0q�6d   $	��Top=�6x   $	��150��6�   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $ 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF66  � 5   
   $
��Left=�6   $	��100��6*   $��	45,15,0,0q�67   $	��Top=�6J   $	��380��6b   ���	#FF2C374F.+�5      �� $
��Left=�6   $��80��63   $
��Wrap=�6?   $	��Top=�6S   $	��360��6k   $��20(�6w   $��Rockwell)�6�   
�������$��	10,10,0,0q�6�   �� 6�   $+�%Choose which character will be loaded��6�   �� 6�   $� or deleted��6�   �� 6  $� by entering its ID��6  �� 6/  $� ��63  �� 6>  $�in the empty space.��6B  6`  5      5      5      