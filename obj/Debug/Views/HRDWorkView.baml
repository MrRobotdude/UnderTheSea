   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      #    UnderTheSea.Views.HRDWorkView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��Work Performance��6   $��Center=�6+   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Report��5      $��1��6#      AlternatingRowBackground
 �����   CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ Employee Name��6/   	   FontSize$	 20Q�6l   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6F   ��  �� Path$ EmployeeName�6l     5      $ * 6%   $
 Date��6/   
 6=   �� $ perform.WorkDate�  5      $ * 6%   $ Description��6/   
 6D   �� $ perform.WorkReport�5      5      5      