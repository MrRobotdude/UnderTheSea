   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      #    UnderTheSea.Views.HRDFireView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      � .+�5
   
   �� -   5          ��Name$  label��5
      $��Raise Salary��6   $��Center=�66   $��
101,10,0,0q�6S   $	��Top=�6g   $	��121��6   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Employee��5      $��
0,36,0,213q�6%      AlternatingRowBackground
 �����   CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Employee ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� 	 �� Path$	 
EmployeeID�  5      $ Employee Name��6%    6<   �� $	 UserName�  5      $ Salary��6%    65   �� $	 Salary�  5      $ Status��6%    65   �� $	 Status�5      �� 5   
   -   5        
 ��Name$
 fireBtn��5      $
��Fire��6"   $
��Left=�61   $��328,555,0,0q�6L   $	��Top=�6a   $��74��6y   6�   �� 5   
   -   5         ��Name$ detailTextBox��5      $
��Left=�6-   $	��126��6H   $��244,414,0,0q�6U   $	��Top=�6j   $	��401��6�   . �5      /� .T�5      J� .*�6   .*�5      �� $� ��6   5      5      5      �� 5   
   -   5        $  label2��5      $��Description��6    $
��Left=�66   $��141,410,0,0q�6Q   $	��Top=�6f   $��98��6~   5      5      