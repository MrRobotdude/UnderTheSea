   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5   	   (    "UnderTheSea.Views.ResignLetterView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:UnderTheSea.Views     5   	     � Title$  ResignLetterView��5   	   $	��600��6"   $	��800��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Resign Letter��6   $��0��6(   $��2��65   $��25q�6I   $��Center=�6U   $��30(�6r   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ SelectedDate��5      $��1��6+   $��2��68   $��25q�6L   $��20(�6X   �� 5   
   $��Detail��6   $��2��6!   $��2��6.   $��20(�6B   $��50, 25q�6P   �� 5   
   -   5         ��Name$ Reason��5      $��3��6"   $��2��6/   $��50, 25q�6D    �� TextWrapping$
 Wrap=�6T    �� AcceptsReturn . $ �� HorizontalScrollBarVisibility$ Disabled=�6}   " �� VerticalScrollBarVisibility$
 Auto=�6�   ��6�   �� *Reason+�� 5   
   -   5        	 ��Name$	 SendBtn��5       $
��Send��6   $��4��61   $��0��6>   $��20(�6N   $��50,25q�6\   �� 5   
   -   5        $	 	CancelBtn��5   "   $��Cancel��6   $��4��65   $��1��6B   $��20(�6R   $��50,25q�6`   5      5      