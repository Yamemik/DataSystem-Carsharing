   M S B A M L   `   `   `  ����E  AAutoDealer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AutoDealer
AutoDealer  5   	       AutoDealer.PhotoCarWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AutoDealer     5   	     � Title$   ��5   	   $	��400��6   $	��500��6    � WindowStyle$ 
ToolWindow=�6+    � WindowStartupLocation$ CenterOwner=�6D   ��5	      �� 5
   
    �� ImageSource$ CarImage\bg.jpg��6   -   5        iB_Background��5
   3    � 	Resources 5       �� 
TargetType �� Property �� Value��%�  '��       '�� �    '�� �    �� 5   
   " ��6   .�5      ��  � ��$ 10q�6'   �� 5       � ��$ 20(�6)   �� 5       �@��TextWrapping$
 Wrap=�6-   �� 5       �@��	IsEnabled . 65   �� 5       �@�Language$ ru-ru�6)   �� 5      # �@��VerticalScrollBarVisibility$
 Auto=�6<   �� 5      % �@��HorizontalScrollBarVisibility$
 Auto=�6>   5      �� 5   
   " ��6   .�5      ��  � ��
 ��  �6+   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   �� 5       � ��$ 2q�6'   �� 5       � ��
 ����6+   �� 5       � ��$ 14(�6)   �� 5       � ��$ Impact)�6+   5      �� 5   
   " ��6   .�5       ��  � ��
 �����6+   �� 5!       � ��$ 22(�6)   �� 5"       � ��$ Impact)�6+   �� 5#       � ��$ Center=�62   �� 5$       �@��TextAlignment$ Center=�6.   5%      5&      .��5'      �  � RowDefinitions 5(   
   �� 5)      $��* �6   6)   �� 5*      $��30 �6   6*   �� 5+      $	��100 �6   6+   �� 5,      $��50 �6   6*   .+�5/   
   �� -   5        	 ��Name$	 imgcar��5/      $��5q�6    51      �� 53   
   $��1��6   Характеристики61   �� 55   
   -   5        
 ��Name$
 special��55   $    �� 
IsReadOnly . $��Center=�65   $��80��6R   $	��400��6^   $��2��6j   $��TimesNewRoman)�56      
���   �$��14(�6B   
������� �� TextWrapping$
 Wrap=�6h   $��Disabled=�57      $
��Auto=�6J   ��. .��6�   59      �� 5;   
   -   5         ��Name$ 	BtnCancel��5;      $��Закрыть��6$   $��7��6N   $��1��6[   $��Center=�6k   5=      5>      