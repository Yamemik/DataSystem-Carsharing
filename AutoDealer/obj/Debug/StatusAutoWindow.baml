   M S B A M L   `   `   `  ����E  AAutoDealer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AutoDealer
AutoDealer  5   	   !    AutoDealer.StatusAutoWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AutoDealer     5   	     � Title$-  'Свободные автомобили��5   	   $	��500��6&   $	��600��63   
���   � � 	Resources 5	       �� 
TargetType �� Property �� Value��%�  '��       '�� (    �� 5
   
   " ��6   .�5      ��  � ��
 ��  �6+   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   �� 5       � ��$ 3q�6'   �� 5       � ��
 ����6+   �� 5       � ��$ 14(�6)   �� 5       � ��$ Impact)�6+   5      �� 5   
   " ��6   .�5      ��  � ��$ Impact)�6+   �� 5       � ��
 ����6+   �� 5       � ��$ 20(�6)   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      �� 5      $	��200 �6    � RowDefinitions 5   
   �� 5       $��50 �6   �� 5!      �� 5"      $��50 �6   .+�5$   
   �� $��5q�6   $
��Wrap=�6   $��Center=�63   $��Center=�6N   $��3��6k   )'Свободные автомобили6�   �� 5&   
   -   5        $��2��5&      $��1��6   $��Center=�6.   .��6a   Закрыть6j   &   System.Windows.Controls.DataGrid  5*   
   -   5          Name$ DGCar��5+      $��3��5*      $��1��6'      AutoGenerateColumns .  	   CanUserAddRows	 .  
�������
   AlternatingRowBackground

 �����   RowBackground
 �������64   ��  5,      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 5-      8   "  6Q   .�5.      ��  � ��
 �����63   �� 5/       � ��$ 16(�61   50      51         Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      
Visibility$ Hidden=�6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *c_id+6J     55      $ 
Марка��6%    64   �� *c_mark+  56      $ Модель��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P    65   �� *c_name+6P     57      $" Характеристики��6%   $ Hidden=�6\    6=   �� *
c_specific+58        59      $ photo��6%   $ Hidden=�6P    64   �� *	c_photo+6P     5:      $ 
Тариф��6%   $ Hidden=�6Q    64   �� *
c_tariff+6Q     5;      $ Доп.условия��6%   $ Hidden=�6S   $ * 6g    6:   �� *c_as+6g     5<      $ Доп.услуги��6%   $ Hidden=�6_    69   �� *AddService.as_enu+6_   4  .System.Windows.Controls.DataGridTemplateColumn  5F      $
 auto 6)      CellTemplate 5G      �� 5H      .R�5I      �� -   5        $��Подробнее��5I   %   69   5J      5L      5N      5O      5P      