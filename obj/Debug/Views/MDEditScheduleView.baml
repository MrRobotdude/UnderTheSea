   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      *    $UnderTheSea.Views.MDEditScheduleView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Edit Schedule��6   $��Center=�6(   $��2��6E   $��0��6Y   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Schedule��5      $��1��6O   $��2��6\      AlternatingRowBackground
 �����   CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .   �� SelectedItem 6%   �� *SelectedSchedule+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6%   
   Header$
 Schedule Date��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   ��  �� Path$ ScheduleDate�  5      $	 * 6%   $
 	Ride Name��6/    6B   �� $ RideName�  5      $	 * 6%   $
 Status��6/    6?   �� $ 
RideStatus�5      �� 5   
   $��Schedule��6   $��2��6#   $��0��60   (  "System.Windows.Controls.DatePicker  5    
   -   5          Name$# SelectedSchedule_ScheduleDate��5       $��2��6<   $��1��6I   �� 5!   
   -   5         ��Name$ 	btnUpdate��5!      $��3��6$   $��0��61   $��Update��6A   �� 5"   
   -   5        $ 	btnDelete��5"      $��3��6$   $��1��61   $��Delele��6A   5$      5%      