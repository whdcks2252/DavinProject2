   M S B A M L   `   `   `  ���� M  ICalibrationChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CalibrationChecker.ViewCalibrationChecker.View  )    #CalibrationChecker.View.MainControl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     7local%clr-namespace:CalibrationChecker.View     R NOxyPlot.Wpf, Version=2.1.2.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0Y UOxyPlot.Wpf.Shared, Version=2.1.2.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0"oxyhttp://oxyplot.org/wpf   $	��700��$
��1000��  � 	Resources     ButtonStyle �� 
TargetType �� Property �� Value  TextBlockStyle  CheckBoxStyle��%�   &	        &	 ;     &	 �     �� " ��.���  � ��$ 15(���  � ��$
 Bold"��� " ��.���  � ��$ 10(���  � ��$
 Bold"���  � ��$ 	30,20,0,0q��� " ��.���  � ��$ 30,0,0,0q�.���  � ColumnDefinitions �� $	��460 ��� $��80 ��� $	��460 � � RowDefinitions �� $	��150 ��� �� $��70 �.+�� $��0��.+��� $��402,32,25,82q� J� RenderTransformOrigin$ 0.574,0.294&�$
��Find��$
��Bold"����� *FindCalName+�� $��54,24,63,75q�$��20(����� *FileNameTxt+�� $��54,80,318,22q��� .+�	� $��15(�$��10,5,0,3q�$��1 Port��$
��Bold"�	� $��15(�$��10,5,0,0q�$��2 Port��$
��Bold"��� $��147,80,25,22q�#��[  ���� *LoadCalFileBt+.���� Load Cal File Button�� (Show Dialog Window)� $��2��.+��� $��277,24,25,75q�#��[  ���� *
LoadFile+.��Load�� $��277,80,25,22q�#��[  ���� *CalExportBT+.��
Cal/Export� $��1��$��1��.+��� .+��� #��[ 
���  ��$	��S11��$��	30,20,0,0q��� $��11��#��[ ���� *
CheckBoxP1+ d� 	IsChecked �� *IsCheckedS11+ �� UpdateSourceTrigger$ PropertyChanged=��� #��[ 
����  �$	��S12��$��	30,20,0,0q��� $��12��#��[ ���� *
CheckBoxP2+ �� *IsCheckedS12+$ PropertyChanged=��� #��[ 
��� � �$	��S21��$��	30,20,0,0q��� $��21��#��[ ���� *
CheckBoxP1+ �� *IsCheckedS21+$ PropertyChanged=��� #��[ 
������$	��S22��$��	30,20,0,0q��� $��22��#��[ ���� *
CheckBoxP2+ �� *IsCheckedS22+$ PropertyChanged=�� $��1��.+�  OxyPlot.Wpf.PlotView  $��10,10,10,10q�  OxyPlot.Wpf.PlotViewBase	   Model	 �� *PlotModelmp+$ PropertyChanged=��� $
��Bold"�$��13,-11,-13,367q�	Amplitude�� (dBm)�� $
��Bold"�$��361,460,5,-1q�Frequency (GHz)� $��1��$��2��.+�  $��10,10,10,10q�	 �� *PlotModelmp2+$ PropertyChanged=�� $��2��.+��� 
 �� TextAlignment$
 Center=�$��56,21,329,24q�페이지 검색�� $��136,18,254,24q����� *PageSearchTxt+$ PropertyChanged=��� 
���   �
�������$��274,15,136,21q����� *CurrentPage+$ PropertyChanged=��� $
 Center=�$��324,20,105,26q�$ 0.446,0.188&�/�� 
���   �
�������$��352,15,62,21q����� *	PagingTxt+$ PropertyChanged=�