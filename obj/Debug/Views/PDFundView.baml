   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      "    UnderTheSea.Views.PDFundView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��Fund Request��6   $��0��6'   $��Center=�64   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ FundRequests��5      $��1��6R      AlternatingRowBackground
 �����   CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .   �� SelectedItem 6)   �� *SelectedRequest+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Amount of Money��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6>   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6H   ��  �� Path$ Amount�  5      $ Status��6%   $	 * 65   
 6?   �� $ Request.Status�  5      $ Description��6%   $	 * 6:   
 6D   �� $ Description�5      �� 5   
   -   5         ��Name$ 
BtnProceed��5      $��Proceed��6%   $��2��67   5      5      