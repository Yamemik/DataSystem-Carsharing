   M S B A M L   `   `   `  ����E  AAutoDealer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AutoDealer
AutoDealer  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       AutoDealer.DealerWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AutoDealer     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  Автомобили��5	   	   $	��500��6   $	��800��6)   
���   � � 	Resources 5
       �� 
TargetType �� Property �� Value��%�  '��       '�� (    �� 5   
   " ��6   .�5      ��  � ��
 ��  �6+   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   �� 5       � ��$ 3q�6'   �� 5       � ��
 ����6+   �� 5       � ��$ 14(�6)   �� 5       � ��$ Impact)�6+   5      �� 5   
   " ��6   .�5      ��  � ��$ Impact)�6+   �� 5       � ��
 ����6+   �� 5       � ��$ 20(�6)   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      �� 5      $	��200 �6    � RowDefinitions 5    
   �� 5!      $��50 �6   �� 5"      �� 5#      $��50 �6   .+�5%   
   �� $��5q�6   $
��Wrap=�6   $��Center=�63   $��Center=�6N   $��3��6k   Автомобили6�   �� 5'   
   -   5        $��2��5'      $
��Left=�6   .��6O   
Назад6V   �� 5(   
   -   5        $��2��5(      $��2��6!   $��Right=�6.   .��6`   
Выйти6g   �� 5,   
   $��1��6   $��2��6%   $��5q�62    �� Orientation$ 
Horizontal=�6=   .+�5-      �� -   5        $��Добавить��5-      $��Center=�6=   �� 5.      -   5        $��Изменить��5.      $��Center=�6>   �� 5/      -   5        $��Удалить��5/      $��Center=�6<   50      &   System.Windows.Controls.DataGrid  51   
   -   5          Name$ DGCar��52      $��3��51      $��1��6'   	   AutoGenerateColumns	 .  
   CanUserAddRows
 .  
�������   AlternatingRowBackground
 �����   RowBackground
 �������64   ��  53      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 54      8   "  6Q   .�55      ��  � ��
 �����63   �� 56       � ��$ 16(�61   57      58         Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *c_id+  5<      $ 
Марка��6%    64   �� *c_mark+  5=      $ Модель��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P    65   �� *c_name+6P     5>      $" Характеристики��6%      
Visibility$ Hidden=�6\    6=   �� *
c_specific+5?        5@      $ photo��6%   $ Hidden=�6P    64   �� *	c_photo+6P     5A      $ 
Тариф��6%   $ Hidden=�6Q    64   �� *
c_tariff+6Q     5B      $ Доп.условия��6%   $ Hidden=�6S    6:   �� *c_as+6S     5C      $ Доп.услуги��6%    69   �� *AddService.as_enu+4  .System.Windows.Controls.DataGridTemplateColumn  5M      $
 auto 6)      CellTemplate 5N      �� 5O      .R�5P      �� -   5        $��Подробнее��5P   %   69   5Q      5S      5U      5V      5W      