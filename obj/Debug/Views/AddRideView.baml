   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      #    UnderTheSea.Views.AddRideView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ label3��5      $��Add New Ride��6    $��2��67   $��0��6K   $��Center=�6[   $��40(�6x   �� 5   
   -   5        $ label��5      $��	Ride Name��6   $��0��63   $��1��6C   $��Center=�6P   $��30(�6m   $��10q�6{   $��Center=�6�   �� 5   
   -   5         ��Name$ nameTextBox��5      $��1��6'   $��1��67   $��Center=�6D   $��30(�6a    �� TextWrapping$
 Wrap=�6o   $�� ��6�   $��Center=�6�   $	��300��6�   $��10q�6�   �� 5   
   -   5        $ label1��5      $��Detail��6    $��0��61   $��3��6A   $��Center=�6N   $��30(�6k   $��Center=�6y   �� 5   
   -   5         ��Name$ detailTextBox��5      $��1��6-   $��3��6=   $��Center=�6J   $��30(�6g   $��Center=�6u   $	��300��6�   $	��300��6�   . �5      /� .T�5      J� .*�6   .*�5      �� $� ��6   5      5      5      �� 5    
   -   5         ��Name$ 
addRideBtn��5       $��Send Ride Request��6%   $��5��6A   $��2��6N   $��Center=�6b   $��20(�6   $��Center=�6�   $��20q�6�   �� 5!   
   -   5        $ label2��5!      $��Price��6    $��0��60   $��2��6@   $��Center=�6M   $��30(�6j   �� 5"   
   -   5        $ priceTextBox��5"      $��1��6)   $��2��69   $��Center=�6F   $��30(�6c   $
 Wrap=�6q   $�� ��6�   $��Center=�6�   $	��300��6�   $��10q�6�   5$      5%      