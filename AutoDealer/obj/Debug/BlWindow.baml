   M S B A M L   `   `   `  ����E  AAutoDealer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AutoDealer
AutoDealer  5   	       AutoDealer.BlWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AutoDealer     5   	     � Title$  Чёрный список��5   	   $	��450��6   $	��500��6,   
���   � � 	Resources 5	       �� 
TargetType �� Property �� Value��%�  '��       '�� (    �� 5
   
   " ��6   .�5      ��  � ��
 ��  �6+   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   �� 5       � ��$ 3q�6'   �� 5       � ��
 ����6+   �� 5       � ��$ 14(�6)   �� 5       � ��$ Impact)�6+   5      �� 5   
   " ��6   .�5      ��  � ��$ Impact)�6+   �� 5       � ��
 ����6+   �� 5       � ��$ 20(�6)   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   �� 5      $	��200 �6    � RowDefinitions 5   
   �� 5       $��50 �6   �� 5!      �� 5"      $��50 �6   .+�5$   
   �� $��5q�6   $
��Wrap=�6   $��Center=�63   $��Center=�6N   $��3��6k   Чёрный список6�   �� 5%   
   -   5        $��2��5%      $
��Left=�6   .��6O   
Назад6V   �� 5&   
   $��1��6   $��2��6%   $��5q�62    �� Orientation$ 
Horizontal=�6=   $��Center=�6V   $��2��6s   .+�5'      �� -   5        $��Добавить��5'      $��Center=�6=   �� 5(      -   5        $��Удалить��5(      $��Center=�6<   5)      &   System.Windows.Controls.DataGrid  5*   
   -   5          Name$
 DGBl��5+      $��3��5*      $��1��6'   	   AutoGenerateColumns	 .  
   CanUserAddRows
 .  
�������   AlternatingRowBackground
 �����   RowBackground
 �����   
IsReadOnly . ��64   ��  5,      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 5-      8   "  6Q   .�5.      ��  � ��
 �����63   �� 5/       � ��$ 16(�61   50      51         Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *bl_id+  54      $ IDКлиент��6%    67   �� *	bl_client+  55      $ Клиент��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6X    65   �� *Client.cl_name+6X   57      58      59      