   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      0    *UnderTheSea.Views.EditRideorAttractionView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ label��5      $��4��6   $��0��63   $��Ride and Attraction��6@   $��Center=�6^   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Facility��5   T   $��4��6    �� SelectedItem$ SelectedFacility��6'   $��1��6G      AlternatingRowBackground
 �����   CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .  	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6%      Header$ Facility Name��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   ��  �� Path$ FacilityName�  5      $
 * 6%   $ Facility Type��6/    6F   �� $ FacilityType�  5      $
 * 6%   $ Price��6/    6>   �� $ Price�  5      $
 * 6%   $ Status��6/    6?   �� $ Status�5!      �� 5"   
   $��0��6   $��2��6    $��Facility Name��6-   �� 5#   
   -   5         ��Name$# SelectedFacility_FacilityName��5#      $��2��69   $��1��6F   �� 5$   
   $��2��6   $��2��6    $��Price��6-   �� 5%   
   -   5        $ SelectedFacility_Price��5%      $��2��62   $��3��6?   �� 5&   
   -   5         ��Name$ 	FacUpdate��5&      $��Update��6$   $��3��65   $��0��6B   $��2��6R   �� 5'   
   -   5        $ 	FacDelete��5'      $��Delete��6$   $��3��65   $��2��6B   $��2��6R   5)      5*      