   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      +    %UnderTheSea.Views.PurchaseRequestView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��All Purchase Request��6   $��0��6/   $��Center=�6<   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ PurchaseRequest��5      $��1��6,      AlternatingRowBackground
 �����   CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Sender��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� 	 �� Path$	 Sender�  5      $ Status��6%    65   �� $	 Status�  5      $ Price��6#    62   �� $	 Price�  5      $ Description��6%    6:   �� $	 Description�5      �� 5   
   -   5        
 ��Name$
 textBox��5      $��3��6   $��Center=�60   $��26��6M    �� TextWrapping$
 Wrap=�6Y   $�� ��6m   $	��164��6u   �� 5   
   -   5         ��Name$ label��5      $��2��6   $��Amount of Fund��6,   $
��Left=�6E   $	��Top=�6`   �� 5   
   -   5         ��Name$ 
reqFundBtn��5      $��4��6   $��Send Fund Request��62   $
��Left=�6N   $	��Top=�6i   $	��125��6�   6�   5      5       