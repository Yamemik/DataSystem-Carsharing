   M S B A M L   `   `   `  ����E  AAutoDealer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AutoDealer
AutoDealer  5   	       AutoDealer.ClientWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AutoDealer     5   	     � Title$  Клиенты��5   	   $	��450��6   $	��800��6&   
���   � � WindowStartupLocation$ CenterScreen=�6E    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�  '��       '�� (    �� 5
   
   " ��6   .�5      ��  � ��
 ��  �6+   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   �� 5       � ��$ 3q�6'   �� 5       � ��
 ����6+   �� 5       � ��$ 14(�6)   �� 5       � ��$ Impact)�6+   5      �� 5   
   " ��6   .�5      ��  � ��$ Impact)�6+   �� 5       � ��
 ����6+   �� 5       � ��$ 20(�6)   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   �� 5      $	��200 �6    � RowDefinitions 5   
   �� 5       $��50 �6   �� 5!      �� 5"      $��50 �6   .+�5$   
   �� $��5q�6   $
��Wrap=�6   $��Center=�63   $��Center=�6N   $��3��6k   Клиенты6�   �� 5%   
   -   5        $��2��5%      $
��Left=�6   .��6O   
Назад6V   �� 5&   
   $��1��6   $��2��6%   $��5q�62    �� Orientation$ 
Horizontal=�6=   $��Center=�6V   $��2��6s   .+�5'      �� -   5        $��Добавить��5'      $��Center=�6=   �� 5(      -   5        $��Изменить��5(      $��Center=�6>   �� 5)      -   5        $��Удалить��5)      $��Center=�6<   5*      &   System.Windows.Controls.DataGrid  5+   
   -   5        	  Name$	 	dg_client��5,      $��3��5+      $��1��6'   
   AutoGenerateColumns
 .     CanUserAddRows .  
�������   AlternatingRowBackground
 �����   RowBackground
 �����   
IsReadOnly .  5-      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 5.      8   "  6Q   .�5/      ��  � ��
 �����63   �� 50       � ��$ 16(�61   51      52         Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *cl_id+  55      $ Клиент ФИО��6%    69   �� *	cl_name+  56      $! Номер телефона��6%    6=   �� *cl_tel+  57      $ 
Адрес��6%    64   �� *
cl_address+  58      $ Паспорт(id)��6%      
Visibility$ Hidden=�6:    6N   �� *cl_passport+  59      $ Паспорт��6%    66   �� *Passport.ps_all+  5:      $+ %Вод.удостоверение(id)��6%   $ Hidden=�6D      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6v    6X   �� *	cl_driver+6v     5;      $' !Вод.удостоверение��6%   $ * 6i    6@   �� *DriverLicense.dl_all+6i   5=      5>      5?      