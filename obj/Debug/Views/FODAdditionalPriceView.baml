   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UnderTheSea.ViewsUnderTheSea.Views  5   	   .    (UnderTheSea.Views.FODAdditionalPriceView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:UnderTheSea.Views     5   	     � Title$  FODAdditionalPriceView��5   	   $	��300��6(   $	��300��65   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   $��Additional Price��6-   �� 5   
   -   5         ��Name$ PropertyList��5       $��1��6    �� View 5      �� 5      .P�5      �� $��Property��6S    �� DisplayMemberBinding 6%   �� *propertyName+6g   �� 5      $��Price��6T    6%   �� *propertyPrice+6e   5      5      �� 5   
   $��Total Charge:��6   $��2��6(   �� 5   
   -   5         ��Name$ TotalCharge��5      $��3��6)   �� 5   
   $��Amount of Money: ��6   $��4��6,   �� 5    
   -   5         ��Name$ AmountOfMoney��5       $��5��6)   �� 5"   
   -   5         ��Name$ btnPay��5"      $	��Pay��6!   $��6��6/   5#      5$      