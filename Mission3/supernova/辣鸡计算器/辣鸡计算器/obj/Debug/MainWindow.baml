   M S B A M L   `   `   `  ����J  F辣鸡计算器, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:辣鸡计算器辣鸡计算器  5   	        辣鸡计算器.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:辣鸡计算器     5   	     � Title$  凯砸自写自用��5   
   $	��700��6   $	��480��6&    � 
ResizeMode$ CanMinimize=�62   .��5	      � $��0,0,0,0q�6    � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   .+�5   
   �� -   5        $��ss��5      $��0��6   $��4��6+   $	��470��6?   $
��Auto��6K   $��0,0,0,0q�6Y   $��Right=�6j   $��36(�6�   
�������$��Microsoft YaHei UI Light)�6�   $
��Bold"�6�   �� 5   
   -   5        $��gongshi��5      $��0��6#   $��4��60   $
��Auto��6D   $��0,0,0,0q�6R   ���	#FF5D4D4D$��Right=�6z   $��36(�6�   
�������6�   �� 5    
   -   5        $��jiguo��5       $��0��6!   $��4��6.   $��60��6B   $��0q�6N   ���	#FF5D4D4D$��Right=�6p   $��36(�6�   
�������6�   �� 5!   
   -   5        $��B7��5!   _   $��7��6   $��50(�6   $��2��6+   $��0��68   
���������6|   Z� �� 5"   
   -   5        $��B8��5"   _   $��8��6   $��50(�6   $��2��6+   $��1��68   
���������6i   Z� 6   �� 5#   
   -   5        $��B9��5#   _   $��9��6   $��50(�6   $��2��6+   $��2��68   
���������6i   Z� 6   �� 5$   
   -   5        $��B4��5$   _   $��4��6   $��50(�6   $��3��6+   $��0��68   
���������6i   Z� 6   �� 5%   
   -   5        $��B5��5%   _   $��5��6   $��50(�6   $��3��6+   $��1��68   
���������6i   Z� 6   �� 5&   
   -	   5        $��B6��5&   _   $��6��6   $��50(�6   $��3��6+   $��2��68   
���������6i   Z� 6   �� 5'   
   -
   5        $��B1��5'   _   $��1��6   $��50(�6   $��4��6+   $��0��68   
���������6i   Z� 6   �� 5(   
   -   5        $��B2��5(   _   $��2��6   $��50(�6   $��4��6+   $��1��68   
���������6i   Z� 6   �� 5)   
   -   5        $��B3��5)   _   $��3��6   $��50(�6   $��4��6+   $��2��68   
���������6i   Z� 6   �� 5*   
   -   5        $��B��5*   _   $��.��6   $��50(�6   $��5��6+   $��0��68   
���������6h   Z� 6~   �� 5+   
   -   5        $��B0��5+   _   $��0��6   $��50(�6   $��5��6+   $��1��68   
���������6i   Z� 6   �� 5,   
   -   5        $��divide��5,      $��50(�6   $��/��6-   $��3��69   $��2��6I   
�������
���   ���6�   Z� �� 5-   
   -   5        $��Multiply��5-      $��50(�6!   $��*��6/   $��3��6;   $��3��6K   
���������6n   Z� 6�   �� 5.   
   -   5        $��Minus��5.      $��50(�6   $��-��6,   $��3��68   $��4��6H   
���������6k   Z� 6�   �� 5/   
   -   5        $	��Add��5/      $��50(�6   $��+��6*   $��3��66   $��5��6F   
���������6|   Z� �� 50   
   -   5        $��result��50      $��50(�6   $��2��6-   $��5��6=   $��=��6a   
���������6m   Z� 6�   �� 51   
   -   5        $	��del��51      $��30(�6   $��2��6*   $��1��6:   $��CE��6G   
�������$��2��6�   $��0.2,0,-0.4,0q�6�   ��6h   Z� 6�   �� 52   
   -   5        $��tuige��52      $��30(�6   $��1��6,   $��退格��69   
�������$��3��6�   $��0,0,118.2,0q�6�   ��6\   Z� 6�   ��53   
   �� 54       �� ImageSource$ x.jpg��6    j� Stretch$
 None=�6-   56      57      