   M S B A M L   `   `   `  ����F  BFilmEditor2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:FilmEditor2.Views.UtilityViewsFilmEditor2.Views.UtilityViews  5   	   /    )FilmEditor2.Views.UtilityViews.FilmDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:FilmEditor2.Views.UtilityViews     5   	     � Title$  
FilmDialog��5   	   $	��300��6   $	��300��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��3.3* �6   �� 5      $
��3.3* �6   �� 5      $
��3.4* �6   .+�5   
   ]� ��. .+�5      �� $��
Film Title��6   $
��Left=�6)   �� 5      -   5         ��Name$ filmTitleTextBox��5      $��Right=�6X   ��60   �� *	FilmTitle+ �� Mode$ TwoWay=�6X   5      ]� 5   
   $��1��6   ��. .+�5      �� $��Blu-ray only?��6   $
��Left=�6,   �� 5      -   5         ��Name$ blurayCheckBox��5      $��Right=�6[    d� 	IsChecked 6/   �� *
IsBluray+$ TwoWay=�6[   �� 5      5      ]� 5   
   $��2��6   ��. .+�5      �� -   5        $��Accept��5      $
��Left=�67   �� 5      -   5        $��Reject��5      $��Right=�67   �� 5      5      5      5      