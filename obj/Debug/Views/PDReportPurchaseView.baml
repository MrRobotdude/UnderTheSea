   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5   	   ,    &UnderTheSea.Views.PDReportPurchaseView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:UnderTheSea.Views     5   	     � Title$  PDReportPurchaseView��5   	   $	��300��6&   $	��300��63   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��Purchase Report��6   $��Center=�6*   $��3��6G   �� 5   
   $��Item Name: ��6   $��1��6&   $��0��63   �� 5   
   $��Item Price: ��6   $��1��6'   $��1��64   �� 5   
   $��Item Quantity: ��6   $��1��6*   $��2��67   �� 5   
   $��1.2 1.2 1.2 1q�6   
���   �
�������$��2��6\   ._�5      �� -   5         ��Name$ ItemName��5       �� TextWrapping$
 Wrap=�6(    �� AcceptsReturn . 
������ " �� VerticalScrollBarVisibility$
 Auto=�6j   5      �� 5   
   $��1.2 1.2 1.2 1q�6   
���   �
�������$��1��6X   $��2��6h   ._�5      �� -   5        $ 	ItemPrice��5      $
 Wrap=�6)    . $
 Auto=�6R   
������ 6u   5      �� 5   
   $��1.2 1.2 1.2 1q�6   
���   �
�������$��2��6\   $��2��6l   ._�5       �� -   5        $ ItemQuantity��5       $
 Wrap=�6,    . $
 Auto=�6U   
������ 6x   5!      �� 5"   
   -   5         ��Name$ 	btnReport��5"      $��Report��6$   $��3��65   $��1��6B   5#      5$      