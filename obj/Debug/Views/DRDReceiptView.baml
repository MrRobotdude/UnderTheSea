   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5   	   &     UnderTheSea.Views.DRDReceiptView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:UnderTheSea.Views     5   	     � Title$  DRDReceiptView��5   	   $	��300��6    $	��300��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��Receipt��6   $��Center=�6"   $	��150��6?   $��0��6K   $��0��6X   �� 5   
   -   5         ��Name$ OrderID��5      $��0��6!   $��1��6.   �� 5   
   -   5         ��Name$ Receipt��5      $��1��6(   $��2��65   ��5      �� 5      .R�5      �� 
���   �$��1q�61   $��0q�6E    �� Padding$ 5q�6P   ._�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� ��6(   ��  �� Path$ MenuName��� 5      ��6(   �� $ Quantity��� 5      ��6(   �� $ 	MenuPrice��� 5       ��6(   �� $ 
TotalPrice�5!      5"      5#      5%      �� 5&   
   -   5         ��Name$ 
grandTotal��5&      $��2��6(   $��2��65   $��Center=�6I   �� 5'   
   -   5        	 ��Name$	 money��5'      $��3��6!   $��2��6.   �� 5(   
   -   5        
 ��Name$
 payBtn��5(      $	��Pay��6!   $��4��6/   $��2��6<   6P   5)      5+      