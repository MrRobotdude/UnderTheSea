   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5      0    *UnderTheSea.Views.AttractionDepartmentView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UnderTheSea.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      $
��auto �6   �� 5      .+�5   
   �� $��Attraction Department��6   $��Center=�60   $��3��6M   $��30(�6a   $��0��6o   �� 5   
   -   5         ��Name$ sellTicketBtn��5      $��Sell Ticket��6(   $��1��6>   $��Center=�6K   $	��266��6h   $��80��6t   6�   �� 5   
   -   5        $ checkTicketBtn��5      $��Check Ticket��6)   $��1��6@   $��2��6M   $	��266��6z   $��80��6�   �� 5   
   -   5         ��Name$ 
WarningLbl��5      $�� ��6%   $��2��60   $��1��6=   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Tickets��5   R   $��3��6    �� SelectedItem$ selectedTicket��6'   $��3��6E      AlternatingRowBackground
 �����   CanUserAddRows .     CanUserDeleteRows .  	   AutoGenerateColumns	 .  
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ 	Ticket ID��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   ��  �� Path$ TicketID�  5!      $ * 6%   $ 
Enter Date��6/    6C   �� $ 
TicketDate�  5"      $ * 6%   $ Status��6/    6?   �� $ Status�5%      �� 5&   
   -   5        $ 
BtnSignOut��5&      $��Sign Out��6%   $��1��68   $��7��6H   $
��Left=�6U   $	��200��6p   �� 5'   
   -   5        $ 
WorkReport��5'      $��Work Report��6%   $��1��6;   $��6��6K   $
��Left=�6X   $	��200��6s   �� 5(   
   -   5        $ CancelTicket��5(      $��Cancel��6'   $��6��68   (  "System.Windows.Controls.DatePicker  5)   
   -   5          Name$ 
SelectDate��5)      $��5��6)   $��3��66   �� 5*   
   $��Input ID��6   $��0��6#   $��4��63   $��Center=�6@   �� 5+   
   -	   5         ��Name$ IDInput��5+      $��4��6#   $��2��60   $��1��6D   �� 5,   
   -
   5        $ UpdateTicket��5,      $��Update��6'   $��6��68   $��2��6E   �� 5-   
   -   5        $ LeavePermit��5-      $��Leave Permit��6&   $��7��6=   �� 5.   
   -   5        $ Resign��5.      $��Resign��6!   $��7��62   $��2��6?   5/      50      