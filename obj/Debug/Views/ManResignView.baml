   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      %    UnderTheSea.Views.ManResignView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Center=�6   $��2��6-   $��Resign Letter��6A   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ ResignLetters��5      $��1��6S   $��2��6`      AlternatingRowBackground
 �����   CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .   �� SelectedItem 6*   �� *SelectedRequest+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Sender��6%   
   FontSize$
 20Q�6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   ��  �� Path$ request.Sender�6]     5      $	 Employee��6%   $
 20Q�6^      MinWidth$ 50Q�6l    67   �� $ employeeName�6l     5      $	 Description��6%   $
 20Q�6h   $ 50Q�6v    6:   �� $ request.Description�6v     5      $	 Status��6%    65   �� $ request.Status�5      �� 5   
   -   5         ��Name$ 
BtnDecline��5      $��2��6%   $��Decline��62   �� 5   
   -   5        $ 
BtnConfirm��5      $��2��6%   $��1��62   $��Confirm��6B   5      5       