   M S B A M L   `   `   `  ����F  BFilmEditor2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FilmEditor2.ViewsFilmEditor2.Views  5   	   $    FilmEditor2.Views.FilmListView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:FilmEditor2.Views     5   	   $
��Bold"�5   	   $��18(�5	   	   
����  �$��4q�5   
     � Title$  FilmListView��5   	   $	��300��6   $	��920��6+   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   o� .@�5      m� -   5        $��Close��5      6&   m� 5      -   5        $
��Find��5      6%   m� 5      $
��Crud��6   .@�5      m� -   5        $	��New��5      6(   m� 5      -   5        $
��Save��5      6)   m� 5      -   5        $��Delete��5      6+   m� 5      -   5        $��Update��5      6+   5      m� 5      $�� Add a Contributor��6   .@�5      m� -   5        $��Actor��5      6*   m� 5      -   5        $��Director��5      6-   m� 5      -	   5        $��Composer��5      6-   5      m� 5       $��Show Contributors��6   .@�5!      m� -
   5        $��Actors��5!      6+   m� 5"      -   5        $��	Directors��5"      6.   m� 5#      -   5        $��	Composers��5#      6.   5$      m� 5%      -   5        $��Add  a Country��5%      6/   m� 5&      -   5        $��Show Countries��5&      6/   5'      �� 5(   
   $��1��6   .��5)      �� -   5         ��Name$ filmListView��5*      ��5,      �� *Films+ �� SelectedItem 5-      �� *CurrentFilm+ �� View 5/      �� 50      .P�51      �� $��Barcode��6)    �� Width$
 Auto��6:    �� DisplayMemberBinding 6G   �� *	Barcode+�� 52      $��Title��6)   $
 Auto��68    6E   �� *Title+�� 53      $
��Year��6)   $
 Auto��67    6D   �� *Year+�� 54      $��Length��6)   $
 Auto��69    6F   �� *Length+�� 55      $��Location��6)   $
 Auto��6;    6H   �� *Location.Description+�� 56      $��	Subtitles��6)   $
 Auto��6<    6I   �� *HasGermanSubtitles+�� 57      $��Blu-ray��6)   $
 Auto��6:    6G   �� *
IsBluray+58      5:      5;      5<      5=      