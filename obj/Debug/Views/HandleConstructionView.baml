   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      .    (UnderTheSea.Views.HandleConstructionView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      � .+�5
   
   �� $��Construction��6   $��108,10,105,259q�6'   &   System.Windows.Controls.DataGrid  5   
   -   5           Name$  Facility��5      $��	0,51,0,73q�6%      AlternatingRowBackground
 �����   CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Ride Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   ��  �� Path$ FacilityName�  5      $ Status��6%    65   �� $ Status�  5      $ Detail��6%    65   �� $ FacilityDetail�5      �� 5   
   -   5        	 ��Name$	 	handleBtn��5      $��Handle Construction��6$   $
��Left=�6B   $��
88,271,0,0q�6]   $	��Top=�6q   $	��124��6�   6�   �� 5   
   -   5        
 ��Name$
 detailTxtBox��5      $
��Left=�6(   $��23��6C   $��	0,243,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��300��6�   5      5      