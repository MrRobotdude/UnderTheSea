   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      &     UnderTheSea.Views.FODReserveView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��Reserve Room��6   $��Center=�6'   $��0��6D   $��0��6Q   $��2��6a   �� 5   
   $��Check In Date��6   $��1��6(   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ CheckInDate��5      $��1��6*   $��1��67   �� 5   
   $��Check Out Date��6   $��2��6)     5   
   -   5        $ CheckOutDate��5      $��2��6+   $��1��68   �� 5   
   $��Room Number��6   $��3��6&   �� 5   
   -   5         ��Name$ 
roomNumber��5      $��3��6&   $��1��63   �� 5    
   $��Passport��6   $��4��6#   �� 5!   
   -   5        $ passport��5!      $��4��6$   $��1��61   �� 5"   
   $��Customer Name��6   $��5��6(   �� 5#   
   -   5        $ customerName��5#      $��5��6(   $��1��65   �� 5$   
   -   5         ��Name$ 
reserveBtn��5$      $��3��6%   $��Reserve��69   $��Center=�6K   $��6��6h   $��0��6u   $	��130��6�   6�   5&      5'      