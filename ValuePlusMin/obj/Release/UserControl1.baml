   M S B A M L   `   `   `  ����   ValuePlusMin&     ValuePlusMin.ValuePlusMinControl   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -     >�Name$  ValuePlusMin��$	��230��$��60��$��Disabled=� � UseLayoutRounding .  .��� -    �Name$
 Grid��$��0q�$��Disabled=� J� RenderTransformOrigin$ 0.5,0.5&� � ColumnDefinitions �� $��60 ��� �� $��60 �.+�A� -    A�Name$ btnMin��$��0q�$��50��$��50��$��0����
� .���  � Color$ 	#FF0078B4��� $ 	#FF00508C�� � Offset$
 0.85Q��� -   
�������$��5��$��0q�$��0��$��20��$��Disabled=�A� -   $ btnPlus��$��50��$��50��$��0��$��2����
� .��� $ 	#FF0078B4��� $ 	#FF00508C��$
 0.85Q��� -   
�������$��5��$��0q�$��0��$��20��$��Disabled=�$��2���� -   
�������$��20��$��0q�$��0��$��5��$��Disabled=�$��2���� $	��0.5q�$��50��$��0q�$��1�� �� CornerRadius$ 5��}�. ���	#FF9B9B9B
�������._��� -   	 ��Name$	 tbxValue��$��1��
 �� TextWrapping$

 Wrap=�" �� VerticalScrollBarVisibility$ Disabled=�$��Center=�$��Center=� �� MaxLines$ 1��$��0q�$��30(����	#FFC8C8C8$��Consolas)� �� AcceptsReturn . $��0q�$��50�� �� TextAlignment$ Center=����� *Value+ �� ElementName$ ValuePlusMin�� �� Mode$ TwoWay=� �� StringFormat$ {0:F}��