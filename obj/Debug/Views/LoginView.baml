   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      !    UnderTheSea.Views.LoginView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��40 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��LOGIN��6   $��2��6    $��2��6-   $��Center=�6A   $��Center=�6\   $��40(�6y   $��0q�6�   $��DemiBold"�6�   �� 5   
   $��Username��6   $��4��6#   $��0��60   $��Center=�6@   $��Center=�6[   $��30(�6x   $��0q�6�   �� 5   
   $��Password��6   $��6��6#   $��0��60   $��Center=�6@   $��Center=�6[   $��30(�6x   $��0q�6�   �� 5   
   -   5         ��Name$ UsernameTxt��5      $��4��6'   $��1��64   $��40��6D   $��20q�6P    �� TextWrapping$
 Wrap=�6\   $��30(�6p   �� 5   
   -   5        $ Password��5      $��6��6$   $��1��61   $��40��6A   $��20q�6M   $
 Wrap=�6Y   $��30(�6m   �� 5   
   -   5         ��Name$ LoginBtn��5      $��LOGIN��6#   $��8��63   $��2��6@   $
��30pxq�6T   $��20(�6b   $��DemiBold"�6p   $��100px��6�   �� 5    
   -   5         ��Name$ errorLbl��5       $�� ��6"   $��Center=�6-   $��Center=�6J   $��10��6e   $��2��6s   5!      5"      