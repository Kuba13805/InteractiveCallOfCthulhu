   M S B A M L   `   `   `  ����L  HCthulhuPlayerCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CthulhuPlayerCardCthulhuPlayerCard  5   	   /    )CthulhuPlayerCard.AddNewPersonalThingType   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CthulhuPlayerCard     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ AddNewPersonalThingType��5   	   $	��500��6)   $	��800��66   ���	#FFD6DBDE$	��800��6p   $	��500��6   $	��800��6�   $	��500��6�    � 	Resources 5	      .   (CthulhuPlayerCard.Projekt_CthulhuDataSet   projekt_CthulhuDataSet  typy_przedmiotowViewSource �� Source �� Source��%a   &	        &	      7     5
   
   6'   �� 5   
    6B   �� *Typy_przedmiotow+8   5      .��5      �  � DataContext# [ 6   .+�5   
   � $
��Left=�6   $	��240��6*   $��
10,219,0,0q�67   $	��Top=�6K   $	��772��6c   .+�5      � $
��Left=�6   $	��100��6.   $��	10,10,0,0q�6;   $	��Top=�6N   $	��752��6f   .+�5      �� -   5         ��Name$ EnterTypeName��5      $��20��61   $��	0,10,26,0q�6=    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $��Rockwell)�6|   $��Right=�6�   $	��230��6�   �� 5      -   5        $ EnterID��5      $��20��6+   $��	80,10,0,0q�67   $
 Wrap=�6J   $	��Top=�6^   $��Rockwell)�6v   $
��Left=�6�   $	��230��6�   �� 5      $
��Left=�6   $��20��67   $��
372,10,0,0q�6C   $
��Wrap=�6W   $	��Top=�6k   $	��120��6�   $��Rockwell)�6�   �� 6�   $��15(�6�   $�Enter ��6�   �� 6�   $��15(�6�   $
�type��6�   �� 6�   $��15(�6�   $� name��6�   �� 6	  $�:��6  6  �� 5      $
��Left=�6   $��20��67   $��	26,10,0,0q�6C   $
��Wrap=�6V   $	��Top=�6j   $��49��6�   $��Rockwell)�6�   $��	Enter ID:��6�   5      � 5      $
��Left=�6   $	��125��6.   $��
10,115,0,0q�6;   $	��Top=�6O   $	��752��6g   .+�5      �� -   5         ��Name$ AddType��5      $	��Add��6*   $
��Left=�68   $��50��6S   $��	40,10,0,0q�6_   $	��Top=�6r   $	��150��6�   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   	 J� RenderTransformOrigin$	 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF60  �� 5      -   5        $ 
ClearSpace��5      $��Clear��6-   $��50��6=   $��301,10,301,0q�6I   $	��Top=�6_   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $	 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF6  �� 5      -   5        $ 
DeleteType��5      $��Delete��6-   $��Right=�6>   $��50��6Z   $��	0,10,40,0q�6f   $	��Top=�6y   $	��150��6�   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $	 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF67  �� 5      -   5        $ 
BackButton��5      $
��Back��6-   $��50��6<   $��
170,75,0,0q�6H   $	��Top=�6\   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $	 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF$
��Left=�6&  $	��150��6A  �� 5      -   5        $ AddName_Copy1��5      $�� ��60   $��50��6;   $��
0,75,170,0q�6G   $	��Top=�6[   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $	 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF$��Right=�6  $	��150��6)  5      5      &   System.Windows.Controls.DataGrid  5   
   -	   5        
  Name$
 typy_przedmiotowDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��196,10,196,259q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�      
IsReadOnly .    MinColumnWidth$ 70Q�6     RowHeaderWidth$ 0Q�62     CanUserResizeColumns .     CanUserReorderColumns .  ��6p   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -
   5        id_typuColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Type id��5   X      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6i   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *	Id_typu+6i     5       -   5        nazwa_typuColumn��$ 	Type name��5    ^   $ SizeToHeader 6q    6?   �� *
Nazwa_typu+6q   5"      5$      5%      