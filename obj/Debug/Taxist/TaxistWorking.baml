   M S B A M L   `   `   `  ����I  ETaxiServiceWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TaxiServiceWPFTaxiServiceWPF  5   	   "    TaxiServiceWPF.TaxistWorking   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TaxiServiceWPF     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  64   -   5          � Title$  TaxistWorking��5   	   $	��300��6   $	��400��6,    � WindowStyle$
 None=�69    � AllowsTransparency .  � 
ResizeMode$ 	CanResize=�6�   '  !System.Windows.Shell.WindowChrome   WindowChrome 5	        5
   
      CaptionHeight$ 0Q�6   .��5      � ���	#FF202225 � ColumnDefinitions 5   
   �� 5      6!   �� 5      $
��2.5* �6   6.   �� 5      6!   .+�5   
   ]� $��2��6   $	��Top=�6$   $��Right=�6<   ��.  .+�5      �� -   5         ��Name$ buttonClose��5   a   $	��Top=�6   $��Right=�6-   $��60��6I   $��30��6T   
������ 
������ .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6+   $��25��68   $��25��6C   6Q   5      5      � 5   
   $��1��6   .+�5      � 	 � RowDefinitions	 5      �� 5      6&   �� 5      6&   .+�5      �� -   5        $��comboBoxDistrict��5      $��18(�63   
�������)  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 District��6T   .@�5      �� .��6#   	Central6,   �� 5       .��6#   	Wetland6,   �� 5!      .��6#   
Richland6-   �� 5"      .��6#   Monroe6+   �� 5#      .��6#   Dane6)   5$      �� 5&      -   5        $ 
buttonWork��5&      $��5,5,5,50q�6.   $��18(�6@   $��DemiBold"�6N   $��1��6d   $	��213��6q   $��57��6}   .��6�   WORK6�   5'      5(      5)      5*      