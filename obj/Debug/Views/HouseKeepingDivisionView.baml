   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      0    *UnderTheSea.Views.HouseKeepingDivisionView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��House Keeping Division��6   $��0��61   $��0��6>   $��3��6N   $��20(�6b   $��Center=�6p   �� 5   
   $��Room Number��6   $��3��6&   $��0��63   $��2��6C   �� 5   
   -   5         ��Name$ 
RoomNumber��5      $��3��6&   $��2��63   �� 5   
   -   5         ��Name$ Property��5      $��4��6)   $��0��66   $��3��6F   ��5      �� 5      .R�5      � 5       ��5"      �� 5#      .R�5$      �� $
��Auto=�6#   .��5%      �� 
���   �$��1q�65   $��2q�6I    �� Padding$ 2q�6T   ._�5&      �� .+�5'   "   �� ��6,   �� *PropertyName+�� 5(   "   $��Center=�6+    d� 	IsChecked 6F   �� *
isBroken+5)      5*      5+      5,      5.      �� 5/   
   -   5         ��Name$ 	reportBtn��5/      $��Report��6$   $��4��65   $��2��6B   $��3��6R   �� 50   
   -   5        $ 
BtnSignOut��50      $��Sign Out��6%   $��0��68   $
��Left=�6H   $	��100��6c   �� 51   
   -   5        $ BtnLeave��51      $��Leave Permit��6#   $��6��6:   $��50��6G   �� 52   
   -   5        $ 	BtnResign��52      $��Resign��6$   $��7��65   $��50��6B   53      54      