   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      &     UnderTheSea.Views.RADRequestView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      � .+�5
   
   �� -   5          ��Name$  label��5
      $��Request��6   $
��Left=�61   $��
117,10,0,0q�6L   $	��Top=�6`   $	��106��6x   $��20(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Request��5      $��	0,51,0,56q�6$      AlternatingRowBackground
 �����   CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Request Type��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� 	 �� Path$	 RequestType�  5      $ Facility Name��6%    6<   �� $	 FacilityInfo.FacilityName�  5      $ Facility Price��6%    6=   �� $	 FacilityInfo.Price�  5      $ Status��6%    65   �� $	 Status�5      �� 5   
   -   5        
 ��Name$
 
proceedBtn��5      $��Proceed��6%   $
��Left=�67   $��105,275,0,0q�6R   $	��Top=�6g   $��75��6   6�   �� 5   
   -   5        $	  err��5      $�� ��6   $
��Left=�6(   $��
10,249,0,0q�6C   $	��Top=�6W   $	��280��6o   5      5      