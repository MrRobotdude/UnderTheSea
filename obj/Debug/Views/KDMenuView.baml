   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      "    UnderTheSea.Views.KDMenuView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $
��Menu��6   $��0��6   $��4��6/   $��Center=�6C   $��0��6`   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$
 Menu��5       �� SelectedItem$ SelectedMenu��6!   $��0��6=   $��4��6M   $��1��6a      AlternatingRowBackground
 �����   CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6%   
   Header$
 	Menu Name��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   ��  �� Path$ MenuName�  5      $	 * 6%   $
 
Menu Price��6/    6C   �� $ 	MenuPrice�  5      $
 Status��6%   $	 * 6Z    65   �� $ 
MenuStatus�6Z   5      �� 5    
   $��	Menu Name��6   $��2��6$   $��0��61   �� 5!   
   -   5         ��Name$ SelectedMenu_MenuName��5!      $��2��61   $��1��6>   �� 5"   
   $��
Menu Price��6   $��3��6%   $��1��62   �� 5#   
   -   5        $ SelectedMenu_MenuPrice��5#      $��3��62   $��2��6?   �� 5$   
   $��Menu Status��6   $��2��6&   $��2��63   �� 5%   
   -   5        $ SelectedMenu_MenuStatus��5%      $��2��63   $��3��6@   �� 5&   
   -   5         ��Name$ 	btnCreate��5&      $��4��6$   $��Create��61   $��0��6B   �� 5'   
   -   5        $ 	btnUpdate��5'      $��4��6$   $��Update��61   $��1��6B   $��2��6R   �� 5(   
   -   5        $ 	btnDelete��5(      $��4��6$   $��Delete��61   $��3��6B   5)      5*      