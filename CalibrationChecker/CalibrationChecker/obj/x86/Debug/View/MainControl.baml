   M S B A M L   `   `   `  ����M  ICalibrationChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CalibrationChecker.ViewCalibrationChecker.View  5      )    #CalibrationChecker.View.MainControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:CalibrationChecker.View     5      R NOxyPlot.Wpf, Version=2.1.2.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0Y UOxyPlot.Wpf.Shared, Version=2.1.2.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0"oxyhttp://oxyplot.org/wpf   5      $	��700��5	      $
��1000��6     � 	Resources  5         ButtonStyle �� 
TargetType �� Property �� Value  TextBlockStyle  CheckBoxStyle��%s  &	        &	 n     &	     �� 5   
   " ��6$   .�5      ��  � ��$ 15(�6)   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " ��6'   .�5      ��  � ��$ 10(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 	30,20,0,0q�6'   5      �� 5   
   " ��6&   .�5      ��  � ��$ 30,0,0,0q�6'   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��460 �6   �� 5      $��80 �6   �� 5      $	��460 �6    � RowDefinitions 5    
   �� 5!      $	��150 �6   �� 5"      6   �� 5#      $��70 �6   .+�5(   
   � $��0��6   .+�5)      �� $��402,32,25,82q�66    J� RenderTransformOrigin$ 0.574,0.294&�6L   $
��Find��6p   $
��Bold"�6   ��6   �� *FindCalName+6   �� 5*      $��54,24,63,75q�63   $��20(�6H   ��6   �� *FileNameTxt+6X   �� 5+      $��54,80,318,22q�6   �� 5,      .+�5-      	� $��15(�6#   $��10,5,0,3q�61   $��1 Port��6C   $
��Bold"�6T   	� 5.      $��15(�6#   $��10,5,0,0q�61   $��2 Port��6C   $
��Bold"�6T   5/      50      �� 51      $��147,80,25,22q�67   #��[  6M   ��6   �� *LoadCalFileBt+.��52      �� Load Cal File Button�� 54      (Show Dialog Window)56      57      58      � 5:   
   $��2��6   .+�5;      �� $��277,24,25,75q�62   #��[  6H   ��6   �� *
LoadFile+.��6m   Load6s   �� 5<      $��277,80,25,22q�6   #��[  6+   .��6P   
Cal/Export6\   5=      � 5?   
   $��1��6   $��1��6   .+�5@      �� .+�5A      �� #��[ 6   
���  ��$	��S11��6U   $��	30,20,0,0q�6`   �� 5B      $��11��6;   #��[ 6�   ��6   �� *
CheckBoxP1+ d� 	IsChecked 6Q   �� *IsCheckedS11+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5C      #��[ 6   
����  �$	��S12��6V   $��	30,20,0,0q�6a   �� 5D      $��12��6;   #��[ 6�   ��6   �� *
CheckBoxP2+ 6Q   �� *IsCheckedS12+$ PropertyChanged=�6�   �� 5E      #��[ 6   
��� � �$	��S21��6X   $��	30,20,0,0q�6c   �� 5F      $��21��6;   #��[ 6�   ��6   �� *
CheckBoxP1+ 6Q   �� *IsCheckedS21+$ PropertyChanged=�6�   �� 5G      #��[ 6   
������$	��S22��6Y   $��	30,20,0,0q�6d   �� 5H      $��22��6;   #��[ 6�   ��6   �� *
CheckBoxP2+ 6Q   �� *IsCheckedS22+$ PropertyChanged=�6�   5I      5J      � 5L   
   $��1��6   .+�5M        OxyPlot.Wpf.PlotView  $��10,10,10,10q�6]     OxyPlot.Wpf.PlotViewBase	   Model	 6   �� *PlotModelmp+$ PropertyChanged=�6]   �� 5N      $
��Bold"�6   $��13,-11,-13,367q�6*   	Amplitude�� 5P      (dBm)5R      �� 5S      $
��Bold"�6   $��361,460,5,-1q�6*   Frequency (GHz)5U      5V      � 5X   
   $��1��6   $��2��6   .+�5Y        $��10,10,10,10q�6   5Z      � 5\   
   $��2��6   .+�5]      �� 
 �� TextAlignment$
 Center=�6   $��56,21,329,24q�6/   페이지 검색6M   �� 5^      $��136,18,254,24q�6\   ��6   �� *PageSearchTxt+$ PropertyChanged=�6u   �� 5_      
���   �
�������$��274,15,136,21q�6   ��6   �� *CurrentPage+$ PropertyChanged=�6�   �� 5`      $
 Center=�6   $��324,20,105,26q�6/   $ 0.446,0.188&�6F   /6m   �� 5a      
���   �
�������$��352,15,62,21q�6|   ��6   �� *	PagingTxt+$ PropertyChanged=�6�   5b      5d      5e      