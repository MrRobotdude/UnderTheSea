   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5   	   &     UnderTheSea.Views.FODPaymentView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:UnderTheSea.Views     5   	     � Title$  FODPaymentView��5   	   $	��300��6    $	��300��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��Room Payment��6   $��0��6'   $��0��64   $��3��6D   $��Center=�6X   �� 5   
   -   5         ��Name$ 
RoomNumber��5      $�� ��6(   $��1��60   $��0��6=   $��3��6M   �� 5   
   -   5        $ CheckIn��5      $��2��6\   $��0��6i   $��3��6y   ��6%   ��  �� Path$ CheckIn� �� StringFormat$ 
dd-MM-yyyy��6y   �� 5   
   -   5        $ CheckOut��5      $��3��6^   $��0��6k   $��3��6{   ��6&   �� $ CheckOut�$ 
dd-MM-yyyy��6{   �� 5   
   -   5        $ Total��5      $�� ��6#   $��4��6+   $��0��68   $��3��6H   �� 5   
   $��Amount of money: ��6   $��5��6,   �� 5   
   -   5         ��Name$ MoneyTxt��5      $��5��6$   $��5��61   $	��120��6A   �� 5    
   -   5         ��Name$ payBtn��5       $	��Pay��6!   $��6��6/   $��0��6<   $��3��6L   5!      5"      