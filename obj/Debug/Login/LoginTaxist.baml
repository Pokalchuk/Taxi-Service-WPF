   M S B A M L   `   `   `  ����I  ETaxiServiceWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TaxiServiceWPFTaxiServiceWPF  5   	        TaxiServiceWPF.LoginTaxist   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TaxiServiceWPF     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  64   -   5           MaterialDesignBody#���   5   	   $��Medium"�5
   	   $��14(�5   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5   	     � Title$
  Menu��5   	   $	��400��6   $	��750��6#   $	��400��6/   $	��650��6?   $
��1000��6N   $	��600��6^   ���	#FFF7F3F3 � WindowStyle$
 None=�6�    � AllowsTransparency .  � 
ResizeMode$ 	CanResize=�6�   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 0Q�6   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   � $��0��6   ���	#FF202225 � RowDefinitions 5      �� 5      6"   �� 5      $
��2.7* �6    60   �� 5      6"    5      �� 5      6%   �� 5      $
��2.5* �6#   62   �� 5      6%   .+�5#      �� 
�������$��Center=�6)   $
��27.5(�6F   $��2��6V   $��0��6c   $��3��6s   .��6�   Affordable, reliable and fast6�   �� 5%      $��1��6   $��1��6!   $��..\Images\taxi2.png��61    J� Effect 5&      3  -System.Windows.Media.Effects.DropShadowEffect  5'      6)   5)      �� 5+      $��0��6   $��34(�6!   
������ $��1��6I   $��Center=�6Y   $��Bottom=�6v   $
��Bold"�6�   ��6�   Z� .��6�   Taxi Service6�   5,      � 5.   
   $��1��6   ���	#FF1A1B1F 5/      �� 50      6"   �� 51      6"   �� 52      6"   �� 53      6"   �� 54      6"   �� 55      6"   �� 56      6"    58      �� 59      $��0.13* �6#   63   �� 5:      6%   .+�5<      ]� $��1��6   $	��Top=�6(   $��Right=�6@   ��.  .+�5=      �� -   5        	 ��Name$	 buttonClose��5=   e   $	��Top=�6   $��Right=�61   $��60��6M   $��30��6X   
������ 
������ .��5>      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Close=�6/   $��25��6<   $��25��6G   6U   5?      5@      �� 5B      -   5         ��Name$ textBoxNickname��5B      $��1��6/   $��2��6?   $
��Left=�6L   $��Center=�6g   $��23(�6�   
�������)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nickname��6�   $	��250��6�   $��5q�6�   G� 5C      -   5         G�Name$ textBoxPassword��5C      $��1��63   $��3��6C   $
��Left=�6P   $��Center=�6k   $��23(�6�   
�������$ Password��6�   $	��250��6�   $��5q�6�   6�   �� 5D      -   5        $	 buttonLogin��5D      $��1��6*   $
��Left=�6;   ���	#FF673AB7$��0,10,0,0q�6m   $��2��6   $��4��6�   $	��150��6�   $��45��6�   $��25(�6�   .��6�   Login6�     5E      $��0��6'   $��2��67   $

 User=�6D   $��Center=�6P   $��Center=�6m   $��33��6�   $��35��6�   ���#7070706�     5F      $	
 Key=�6&   $��3��61   $��33��6?   $��35��6J   $��Center=�6V   $��Center=�6s   ���#7070706�   � 5H      $��6��6   $��2��6     5I      �� 5J      $��2* �6'   64   �� 5K      6)   �� 5L      6)   �� 5M      6)   .+�5P      �� ���#8d9795$��0��6-   $��2��6=   $
��19.5(�6Q   $��Center=�6a   $
��Left=�6|   .��6�   Our contacts6�   �� 5Q      -   5        $��Center=�5Q      $��Center=�66   $��65��6Q   $��50��6\   $��1��6i   
������ 
������ .��5R        $��1��6/   $
 Facebook=�6?   $��Center=�6O   $��Center=�6l   $��33��6�   $��35��6�   ���	#FF673AB76�   5S      �� 5T      -   5        $	 buttonInstagram��5T      $��Center=�62   $��Center=�6O   $��60��6j   $��50��6u   $��2��6�   
������ 
������ .��5U        $
 	Instagram=�6/   $��Center=�6@   $��Center=�6]   $��33��6x   $��35��6�   ���	#FF673AB76�   5V      �� 5W      -   5        $	 buttonGooglePlus��5W      $��Center=�63   $��Center=�6P   $��65��6k   $��50��6v   $��3��6�   
������ 
������ .��5X        $��3��6/   $
 
GooglePlus=�6?   $��Center=�6Q   $��Center=�6n   $��33��6�   $��35��6�   ���	#FF673AB76�   5Y      5[      5]      5^      5`      