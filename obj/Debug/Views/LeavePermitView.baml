   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      '    !UnderTheSea.Views.LeavePermitView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Leave Permit��6   $��1��6'   $��2��64   $
��0 20q�6H   $��Center=�6V   $��40(�6s   $��DemiBold"�6�   �� 5   
   $��
Leave Date��6   $��2��6%   $��0��62   $��30(�6B   $��Center=�6P   $
��0 20q�6m   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	LeaveDate��5      $��2��6(   $��1��65   $��20(�6E   $��Center=�6S   $
��0 20q�6p   $��350px��6~   �� 5   
   -   5         ��Name$ Reason��5      $��3��6"   $��2��6/   $��50, 25q�6D    �� TextWrapping$
 Wrap=�6T    �� AcceptsReturn . $ �� HorizontalScrollBarVisibility$ Disabled=�6}   " �� VerticalScrollBarVisibility$
 Auto=�6�   �� 5   
   -   5         ��Name$ SendBtn��5       $
��Send��6   $��4��61   $��0��6>   $��50 20q�6N   $��20(�6]   $��DemiBold"�6k   �� 5   
   -   5        $ 	CancelBtn��5   "   $��Cancel��6   $��4��65   $��1��6B   $��50 20q�6R   $��20(�6a   $��DemiBold"�6o   5      5      