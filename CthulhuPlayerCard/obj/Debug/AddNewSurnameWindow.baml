   M S B A M L   `   `   `  ����L  HCthulhuPlayerCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CthulhuPlayerCardCthulhuPlayerCard  5   	   +    %CthulhuPlayerCard.AddNewSurnameWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CthulhuPlayerCard     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ AddNewSurnameWindow��5   	   $	��500��6%   $	��800��62   $	��800��6U   $	��500��6d   $	��800��6t   $	��500��6�   ���	#FFD6DBDE � 	Resources 5	      .   (CthulhuPlayerCard.Projekt_CthulhuDataSet   projekt_CthulhuDataSet  nazwiskaViewSource �� Source �� Source��%Y   &	        &	      7     5
   
   6'   �� 5   
    6:   �� *
Nazwiska+8   5      .��5      �  � DataContext# [ 6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ nazwiskaDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��196,10,196,259q�6�   	   RowDetailsVisibilityMode$	 VisibleWhenSelected=�6�   
   
IsReadOnly
 .    MinColumnWidth$ 70Q�6�      CanUserReorderColumns .     CanUserResizeColumns .     RowHeaderWidth$ 0Q�6(  ��6h   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        id_nazwiskaColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Id nazwiska��5   `      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *Id_nazwiska+6�     5      -   5        nazwiskoColumn��$ Nazwisko��5   Z   $ SizeToHeader 6l    6=   �� *
Nazwisko+6l     5      -   5        pochodzenie_nazwiskaColumn��$ Pochodzenie nazwiska��5   r   $ SizeToHeader 6�    6I   �� *Pochodzenie_nazwiska+6�   5      � 5   
   $
��Left=�6   $	��240��6*   $��
10,219,0,0q�67   $	��Top=�6K   $	��772��6c   .+�5      � $
��Left=�6   $	��100��6.   $��	10,10,0,0q�6;   $	��Top=�6N   $	��752��6f   .+�5      �� -   5         ��Name$ EnterNewSurname��5      $��20��63   $��442,10,80,0q�6?    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $��Rockwell)�6�   �� 5      -   5        $ EnterID��5      $��20��6+   $��	80,10,0,0q�67   $
 Wrap=�6J   $	��Top=�6^   $��Rockwell)�6v   $
��Left=�6�   $	��230��6�   �� 5      $
��Left=�6   $��20��67   $��
332,10,0,0q�6C   $
��Wrap=�6W   $	��Top=�6k   $	��105��6�   $��Rockwell)�6�   �� 6�   $��15(�6�   $�Enter ��6�   �� 6�   $��15(�6�   $	�sur��6�   �� 6�   $��15(�6�   $
�name��6�   �� 6  $�:��6  6  �� 5      $
��Left=�6   $��20��67   $��	26,10,0,0q�6C   $
��Wrap=�6V   $	��Top=�6j   $��49��6�   $��Rockwell)�6�   $��	Enter ID:��6�   �� 5      -   5        $ EnterSurnameOrigin��5      $��20��66   $��
344,47,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $��Rockwell)�6�   $
��Left=�6�   $	��191��6�   �� 5      $
��Left=�6   $��20��67   $��
218,47,0,0q�6C   $
��Wrap=�6W   $	��Top=�6k   $	��121��6�   $��Rockwell)�6�   �� 6�   $�Enter ��6�   �� 6�   $	�sur��6�   �� 6�   $�name origin��6�   �� 6�   $�:��6�   6�   5      � 5      $
��Left=�6   $	��125��6.   $��
10,115,0,0q�6;   $	��Top=�6O   $	��752��6g   .+�5      �� -	   5         ��Name$ 
AddSurname��5      $	��Add��6-   $
��Left=�6;   $��50��6V   $��	40,10,0,0q�6b   $	��Top=�6u   $	��150��6�   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF63  �� 5       -
   5        $ 
ClearSpace��5       $��Clear��6-   $��50��6=   $��301,10,301,0q�6I   $	��Top=�6_   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $ 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF6  �� 5!      -   5        $ DeleteSurname��5!      $��Delete��60   $��Right=�6A   $��50��6]   $��	0,10,40,0q�6i   $	��Top=�6|   $	��150��6�   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $ 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF6:  �� 5"      -   5        $ 
BackButton��5"      $
��Back��6-   $��50��6<   $��
170,75,0,0q�6H   $	��Top=�6\   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $ 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF$
��Left=�6&  $	��150��6A  �� 5#      -   5        $ AddName_Copy1��5#      $�� ��60   $��50��6;   $��
0,75,170,0q�6G   $	��Top=�6[   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $ 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF$��Right=�6  $	��150��6)  5$      5%      5'      5(      