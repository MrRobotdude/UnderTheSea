   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      '    !UnderTheSea.Views.SMDPurchaseView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      � .+�5
   
   �� -   5          ��Name$  label��5
      $��Purchase��6   $
��Left=�62   $��
124,10,0,0q�6M   $	��Top=�6a   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Advertisement��5      $��	0,51,0,78q�6*      AlternatingRowBackground
 �����   CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� 	 �� Path$	 AdvertisementID�  5      $ Advertisement Name��6%    6A   �� $	 AdvertisementName�  5      $ Description��6%    6:   �� $	 AdvertisementDescription�5      �� 5   
   -   5        
 ��Name$
 priceTxtBox��5      $
��Left=�6'   $��23��6B   $��
84,227,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��216��6�   �� 5   
   -   5         ��Name$ purchaseBtn��5      $
��Send��6&   $
��Left=�65   $��106,270,0,0q�6P   $	��Top=�6e   $��75��6}   6�   �� 5   
   -   5        $  label1��5      $��Money��6    $
��Left=�60   $��
10,224,0,0q�6K   $	��Top=�6_   $��58��6w   5      5      