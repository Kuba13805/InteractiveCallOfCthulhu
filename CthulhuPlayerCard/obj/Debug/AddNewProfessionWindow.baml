   M S B A M L   `   `   `  ����L  HCthulhuPlayerCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CthulhuPlayerCardCthulhuPlayerCard  5   	   .    (CthulhuPlayerCard.AddNewProfessionWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CthulhuPlayerCard     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ AddNewProfessionWindow��5   	   $	��500��6(   $	��800��65   ���	#FFD6DBDE$	��800��6o   $	��500��6~   $	��800��6�   $	��500��6�    � 	Resources 5	      .   (CthulhuPlayerCard.Projekt_CthulhuDataSet   projekt_CthulhuDataSet  zawodyViewSource �� Source �� Source  nazwiskaViewSource  listaZawodowViewSource��%�   &	        &	      7   &	 ?     7   &	 m     7     5
   
   6'   �� 5   
    68   �� *Zawody+8   �� 5   
    6:   �� *
Nazwiska+8   �� 5   
    6>   �� *ListaZawodow+8   5      .��5      �  � DataContext# [ 6   $��	0,0,0,-21q�6=   .+�5   
   � $
��Left=�6   $	��240��6*   $��
10,219,0,0q�67   $	��Top=�6K   $	��772��6c   .+�5      � $
��Left=�6   $	��100��6.   $��	10,10,0,0q�6;   $	��Top=�6N   $	��752��6f   .+�5      �� -   5         ��Name$ EnterProfessionName��5      $��20��67   $��	0,10,26,0q�6C    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $��Rockwell)�6�   $��Right=�6�   $	��230��6�   �� 5      -   5        $ EnterID��5      $��20��6+   $��	80,10,0,0q�67   $
 Wrap=�6J   $	��Top=�6^   $��Rockwell)�6v   $
��Left=�6�   $	��230��6�   �� 5      $
��Left=�6   $��20��67   $��
330,10,0,0q�6C   $
��Wrap=�6W   $	��Top=�6k   $	��161��6�   $��Rockwell)�6�   �� 6�   $��15(�6�   $�Enter ��6�   �� 6�   $��15(�6�   $�profession name��6�   �� 6�   $�:��6�   6  �� 5      $
��Left=�6   $��20��67   $��	26,10,0,0q�6C   $
��Wrap=�6V   $	��Top=�6j   $��49��6�   $��Rockwell)�6�   $��	Enter ID:��6�   � 5      $
��Left=�6   $��55��62   $��	10,35,0,0q�6>   $	��Top=�6Q   $	��732��6i   .+�5      �� $��20��6    $��306,5,306,0q�6,   $
��Wrap=�6A   $	��Top=�6U   $��Rockwell)�6m   $��Main profession skills��6�   $	��120��6�   �� 5      -   5         ��Name$ PerceptivityCheckBox��5      $��Perceptivity��6=   $
��Left=�6T   $��
200,30,0,0q�6o   $	��Top=�6�   $	��100��6�   $��Rockwell)�6�   5      � 5      $
��Left=�6   $��55��62   $��	10,35,0,0q�6>   $	��Top=�6Q   $	��732��6i   .+�5      �� -   5        $ HistoryCheckBox��5      $��History ��68   $
��Left=�6K   $��0,30,0,0q�6f   $	��Top=�6x   $	��100��6�   $��Rockwell)�6�   �� 5      $��20��6    $��306,5,306,0q�6,   $
��Wrap=�6A   $	��Top=�6U   $��Rockwell)�6m   $��Main profession skills��6�   $	��120��6�   �� 5      -   5        $ BrawlCheckBox��5      $��Brawl��66   $
��Left=�6F   $��
100,30,0,0q�6a   $	��Top=�6u   $	��100��6�   $��Rockwell)�6�   �� 5      -   5        $ FirearmCheckBox��5      $��Firearm��68   $��
400,30,0,0q�6J   $	��Top=�6^   $��Rockwell)�6v   $
��Left=�6�   $	��100��6�   �� 5      -   5        $ FirstAidCheckBox��5      $��	First Aid��69   $
��Left=�6M   $��
300,30,0,0q�6h   $	��Top=�6|   $	��100��6�   $��Rockwell)�6�   5       5!      � 5"      $
��Left=�6   $	��125��6.   $��
10,115,0,0q�6;   $	��Top=�6O   $	��752��6g   .+�5#      �� -	   5        	 ��Name$	 AddProfession��5#      $	��Add��60   $
��Left=�6>   $��50��6Y   $��	40,10,0,0q�6e   $	��Top=�6x   $	��150��6�   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   
 J� RenderTransformOrigin$
 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF66  �� 5$      -
   5        $	 
ClearSpace��5$      $��Clear��6-   $��50��6=   $��301,10,301,0q�6I   $	��Top=�6_   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $
 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF6  �� 5%      -   5        $	 DeleteSurname��5%      $��Delete��60   $��Right=�6A   $��50��6]   $��	0,10,40,0q�6i   $	��Top=�6|   $	��150��6�   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $
 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF6:  �� 5&      -   5        $	 
BackButton��5&      $
��Back��6-   $��50��6<   $��
170,75,0,0q�6H   $	��Top=�6\   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $
 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF$
��Left=�6&  $	��150��6A  �� 5'      -   5        $	 AddName_Copy1��5'      $�� ��60   $��50��6;   $��
0,75,170,0q�6G   $	��Top=�6[   
���   �$��18(�6�   $��Rockwell)�6�   $��1q�6�   $
 0.5,0.5&�6�   ���	#FF2C374F���	#FFD7DADF$��Right=�6  $	��150��6)  5(      5)      &   System.Windows.Controls.DataGrid  5*   
   -   5          Name$ listaZawodowDataGrid��5*         AutoGenerateColumns .     EnableRowVirtualization . $��221,19,171,271q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�      RowHeaderWidth$ 0Q�6�      
IsReadOnly .    CanUserResizeColumns .     CanUserReorderColumns .     MinColumnWidth$ 70Q�6Z  ��6l   �� # [    Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      -   5        id_zawoduColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Profession id��5,   \      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6s   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *	Id_zawodu+6s     5-      -   5        nazwa_zawoduColumn��$ Profession name��5-   b   $ SizeToHeader 6{    6A   �� *Nazwa_zawodu+6{   5/      51      52      