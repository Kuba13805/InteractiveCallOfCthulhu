   M S B A M L   `   `   `  ����L  HCthulhuPlayerCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CthulhuPlayerCardCthulhuPlayerCard  5   	   (    "CthulhuPlayerCard.AddNewNameWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CthulhuPlayerCard     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ AddNewNameWindow��5   	   $	��500��6"   $	��800��6/   ���	#FFD6DBDE$	��800��6i   $	��500��6x   $	��800��6�   $	��500��6�    � 	Resources 5
      .   (CthulhuPlayerCard.Projekt_CthulhuDataSet   projekt_CthulhuDataSet  imionaViewSource �� Source �� Source��%W   &	        &	      7     5   
   6'   �� 5   
    68   �� *Imiona+8   5      .��5      �  � DataContext# [ 6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ imionaDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��196,10,196,259q�6~   	   RowDetailsVisibilityMode$	 VisibleWhenSelected=�6�   
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 SizeToHeader 6�      RowHeaderWidth$ 0Q�6�      CanUserResizeColumns .     MinColumnWidth$ 70Q�6     
IsReadOnly . ��6f   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        id_imieniaColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Name Id��5   ^      
IsReadOnly .    Width$ SizeToHeader 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *
Id_imienia+6�     5      -   5        
imieColumn��$
 Name��5   R   $ SizeToHeader 6`    69   �� *Imie+6`     5      -   5        pochodzenie_imieniaColumn��$ Name Origin��5   p   $ SizeToHeader 6�    6H   �� *Pochodzenie_imienia+6�     5      -   5        plec_imieniaColumn��$ Name Sex��5   b   $ SizeToHeader 6t    6A   �� *Plec_imienia+6t   5      � 5   
   $
��Left=�6   $	��240��6*   $��
10,219,0,0q�67   $	��Top=�6K   $	��772��6c   .+�5      � $
��Left=�6   $	��100��6.   $��	10,10,0,0q�6;   $	��Top=�6N   $	��752��6f   .+�5      �� -   5         ��Name$ EnterNewName��5      $��20��60   $��442,10,80,0q�6<    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $��Rockwell)�6}   �� 5      -   5        $ EnterID��5      $��20��6+   $��	80,10,0,0q�67   $
 Wrap=�6J   $	��Top=�6^   $��Rockwell)�6v   $
��Left=�6�   $	��230��6�   �� 5      $
��Left=�6   $��20��67   $��
352,10,0,0q�6C   $
��Wrap=�6W   $	��Top=�6k   $��85��6�   $��Rockwell)�6�   �� 6�   $��15(�6�   $�Enter ��6�   �� 6�   $��15(�6�   $
�name��6�   �� 6�   $�:��6�   6�   �� 5      $
��Left=�6   $��20��67   $��	26,10,0,0q�6C   $
��Wrap=�6V   $	��Top=�6j   $��49��6�   $��Rockwell)�6�   $��	Enter ID:��6�   �� 5      -	   5        $ EnterNameSex��5      $��20��60   $��442,47,80,0q�6<   $
 Wrap=�6Q   $	��Top=�6e   $��Rockwell)�6}   �� 5      -
   5        $ EnterNameOrigin��5      $��20��63   $��
119,47,0,0q�6?   $
 Wrap=�6S   $	��Top=�6g   $��Rockwell)�6   $
��Left=�6�   $	��191��6�   �� 5      $
��Left=�6   $��20��67   $��
325,47,0,0q�6C   $
��Wrap=�6W   $	��Top=�6k   $	��112��6�   $��Rockwell)�6�   �� 6�   $��15(�6�   $�Enter ��6�   �� 6�   $��15(�6�   $
�name��6�   �� 6�   $��15(�6�   $� sex:��6�   6
  �� 5       $
��Left=�6   $��20��67   $��	10,47,0,0q�6C   $
��Wrap=�6V   $	��Top=�6j   $	��104��6�   $��Rockwell)�6�   �� 6�   $�Enter name origin��6�   �� 6�   $�:��6�   6�   5!      � 5"      $
��Left=�6   $	��125��6.   $��
10,115,0,0q�6;   $	��Top=�6O   $	��752��6g   .+�5#      �� -   5         ��Name$ AddName��5#      $	��Add��6*   $
��Left=�68   $��50��6S   $��	40,10,0,0q�6_   $	��Top=�6r   $	��150��6�   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF60  �� 5$      -   5        $ 
ClearSpace��5$      $��Clear��6-   $��50��6=   $��301,10,301,0q�6I   $	��Top=�6_   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $ 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF6  �� 5%      -   5        $ 
DeleteName��5%      $��Delete��6-   $��Right=�6>   $��50��6Z   $��	0,10,40,0q�6f   $	��Top=�6y   $	��150��6�   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $ 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF67  �� 5&      -   5        $ 
BackButton��5&      $
��Back��6-   $��50��6<   $��
170,75,0,0q�6H   $	��Top=�6\   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $ 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF$
��Left=�6&  $	��150��6A  �� 5'      -   5        $ AddName_Copy1��5'      $�� ��60   $��50��6;   $��
0,75,170,0q�6G   $	��Top=�6[   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $ 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF$��Right=�6  $	��150��6)  5(      5)      5*      5+      