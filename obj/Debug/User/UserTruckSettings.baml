   M S B A M L   `   `   `  ����I  ETaxiServiceWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TaxiServiceWPFTaxiServiceWPF  5   	   h dScar.Common.WPF.Controls.NumericUpDown, Version=1.0.6811.31762, Culture=neutral, PublicKeyToken=nullsVclr-namespace:Scar.Common.WPF.Controls;assembly=Scar.Common.WPF.Controls.NumericUpDownScar.Common.WPF.Controls 64   &     TaxiServiceWPF.UserTruckSettings   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TaxiServiceWPF     5   	   kcontrolsVclr-namespace:Scar.Common.WPF.Controls;assembly=Scar.Common.WPF.Controls.NumericUpDown     64   -   5          � Title$  UserTruckSettings��5   	   $	��200��6#   $	��230��60    � WindowStyle$
 None=�6<    � AllowsTransparency .  � 
ResizeMode$ 	CanResize=�6�   '  !System.Windows.Shell.WindowChrome   WindowChrome 5	        5
   
      CaptionHeight$ 0Q�6   .��5      � ���	#FF202225 � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      $
��0.5* �6   6,    � ColumnDefinitions 5   
   �� 5      $
��2.5* �6   6.   �� 5      $��1.25* �6   60   .+�5   
   �� $��5q�6   $��1��6   $��14(�6(   $
��Left=�66   $��Center=�6Q   .��6l   	People:6u   ,  &Scar.Common.WPF.Controls.NumericUpDown  5   
   -   5        $��numericUpDownAmountPeople��5   !   $��1��6B   $��1q�6O   $��Center=�6[      Value$ 1��6x   	   MinValue$	 1��6�   $��Center=�6�   $��18(�6�   $��1��6�   
�������
   MaxValue$
 2��6�   $��30��6�   $��60��6�   6  �� 5   
   $��14(�6   $��0��6   $��5q�6,   $
��Left=�67   $��Center=�6R   $��Kilograms cargo:��6m    � ToolTip$ From 100 to 10000��5      5      �� 5   
   -   5         ��Name$ 
buttonFind��5      $��5q�6%   $��2��60   $��60��6=   $��30��6H   $��Center=�6T   $
��Left=�6o   .��6�   Find6�   �� 5    
   -   5         ��Name$ tbMaxKilogramsCargo��5        $��21(�6   $��1��6=   $��Center=�6M   
����������	#FF202225$��5q�6�   .��6�   $ Only from 100 to 10000��5#      .��5$      5%      5&      