   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      7    1UnderTheSea.Views.AccountingFinanceDepartmentView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      � .+�5
   
   �� $#��Accounting Finance Department��6   $��20(�68   $��Center=�6F   $��493,0,478,666q�6c   $	��309��6z   &   System.Windows.Controls.DataGrid  5   
   -   5           Name$  FundRequest��5      $��
0,51,0,100q�6(      AlternatingRowBackground
 �����   CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ Sender��6/      FontSize$ 20Q�6_   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6?   �� 
 �� Path$
 Sender�6_     5      $ * 6%   $ Status��6/   	 6?   �� $
 Status�  5      $ * 6%   $ Price��6/   	 6>   �� $
 Price�  5      $ * 6%   $ Description��6/   $ 20Q�6j      MinWidth$ 50Q�6x   	 6D   �� $
 Description�6x   5      �� 5   
   -   5         ��Name$ 
confirmBtn��5      $��Confirm��6%   $
��Left=�67   $��224,651,0,0q�6R   $	��Top=�6g   $	��219��6   $��42��6�   6�   �� 5   
   -   5        $ 	rejectBtn��5      $��Reject��6$   $
��Left=�65   $��771,651,0,0q�6P   $	��Top=�6e   $	��214��6}   $��42��6�   6�   �� 5   
   -   5        $ BtnLeave��5      $��Leave Permit��6#   $
��Left=�6:   $��1121,625,0,0q�6U   $	��Top=�6k   $	��149��6�   $��42��6�   �� 5   
   -   5        $ 
BtnSignOut��5      $��Sign Out��6%   $
��Left=�68   $��	10,12,0,0q�6S   $	��Top=�6f   $	��136��6~   $��34��6�   �� 5   
   -   5        $ 	BtnResign��5      $��Resign��6$   $
��Left=�65   $��1121,674,0,0q�6P   $	��Top=�6f   $	��149��6~   $��36��6�   5      5      