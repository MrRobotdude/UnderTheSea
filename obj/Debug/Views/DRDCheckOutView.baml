   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      '    !UnderTheSea.Views.DRDCheckOutView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��	Check Out��6   $��Center=�6$   $��0��6A   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Order��5      $��1��6#      AlternatingRowBackground
 �����   CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ OrderID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� 	 �� Path$	 OrderID�  5      $ Table Number��6%    6;   �� $	 TableNumber�  5      $ Status��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 65    6?   �� $	 Status�5      �� 5   
   -   5         ��Name$ 
receiptBtn��5      $��Generate Receipt��6%   $��2��6@   $��20��6f   $��
0,76.4,0,0q�6r   $��3��6�   $	��Top=�6�   5      5      