   M S B A M L   `   `   `  ����F  BFilmEditor2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:FilmEditor2.Views.BaseViewsFilmEditor2.Views.BaseViews  5   	   ,    &FilmEditor2.Views.BaseViews.PersonView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:FilmEditor2.Views.BaseViews     5   	   $
��Bold"�5   	   $��18(�5	   	   
����  �$��4q�5   
     � Title$  
PersonView��5   	   $	��200��6   $	��300��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �  � Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��Close��5      6%   5      � 5   
   $��1��6    5      �� 5      $
��3.3* �6    �� 5      $
��3.3* �6    �� 5      $
��3.4* �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5      �� $��
First Name��6   �� 5       -   5         ��Name$ firstNameTextBox��5       $��1��60   ��6@   �� *FirstMidName+ �� Mode$ TwoWay=��� 5!      $��	Last Name��6   $��1��6(   �� 5"      -   5        $ lastNameTextBox��5"      $��1��6/   $��1��6<   ��6L   �� *
LastName+$ TwoWay=��� 5#      $��	Birthdate��6   $��2��6(   �� 5$      -   5        $ birthdateTextBox��5$      $��2��60   $��1��6=   ��6M   �� *BirthdateString+$ TwoWay=�5%      5&      5'      