   M S B A M L   `   `   `  ����E  AAutoDealer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AutoDealer
AutoDealer  5   	   &     AutoDealer.AddEditContractWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AutoDealer     5   	     � Title$C  =Добавление/изменение аренды авто��5   	   $	��600��62   $	��600��6?    � WindowStyle$ 
ToolWindow=�6K    � WindowStartupLocation$ CenterScreen=�6d   ��5	      �� 5
   
    �� ImageSource$ CarImage\bg.jpg��6   -   5        iB_Background��5
   3    � 	Resources 5       �� 
TargetType �� Property �� Value��%�  '��       '�� �    '�� �    �� 5   
   " ��6   .�5      ��  � ��$ 10q�6'   �� 5       � ��$ 20(�6)   �� 5       �@��TextWrapping$
 Wrap=�6-   �� 5       �@��	IsEnabled . 65   �� 5       �@�Language$ ru-ru�6)   �� 5      # �@��VerticalScrollBarVisibility$
 Auto=�6<   �� 5      % �@��HorizontalScrollBarVisibility$
 Auto=�6>   5      �� 5   
   " ��6   .�5      ��  � ��
 ��  �6+   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   �� 5       � ��$ 3q�6'   �� 5       � ��
 ����6+   �� 5       � ��$ 14(�6)   �� 5       � ��$ Impact)�6+   5      �� 5   
   " ��6   .�5       ��  � ��$ 20(�6)   �� 5!       � ��$ Center=�62   �� 5"       � ��
 �����6+   �� 5#       �@��TextAlignment$ Center=�6.   5$      5%      .��5&      �  � ColumnDefinitions 5'   
   �� 5(      $	��200 �6   6-   �� 5)      6!   	 � RowDefinitions	 5+   
   �� 5,      $��50 �6   6*   �� 5-      $��50 �6   6*   �� 5.      $��50 �6   6*   �� 5/      $��50 �6   6*   �� 50      $��50 �6   6*   �� 51      $��50 �6   6*   �� 52      $��50 �6   6*   �� 53      $��50 �6   6*   �� 54      $��50 �6   6*   �� 55      $��50 �6   6*   �� 56      $��50 �6   6*   .+�59   
   �� $��id��6   6    �� 5:   
   $(��"Продолжительность��6   $��3��6-   6<   �� 5;   
   $��Доп.услуги��6   $��8��6&   65   �� 5<   
   $��
Тариф��6   $��7��6!   60   �� 5=   
   $��Цена��6   $��6��6    6/   �� 5>   
   $��Автомобиль��6   $��5��6&   65   �� 5?   
   $��Клиент��6   $��4��6"   61   �� 5@   
   $��Дата начала��6   $��1��6'   66   �� 5A   
   $!��Дата окончания��6   $��2��6*   69   �� 5B   
   $��
Сумма��6   $��9��6!   60   �� 5D   
   -   5        
 ��Name$
 id��5D      $��1��66    �� 
IsReadOnly . ��6   �� *con_id+6Z   �� 5E   
   -   5        $
 long1��5E      $��1��6;   $��3��6K    . ��6!   �� *
con_long+6l   �� 5F   
   -   5         ��Name$	 if1��5F      $��10q�6H    �� DisplayMemberPath$ as_enu��6T   $��1��6o   $��8��6    �� SelectedItem 6    �� *Car.AddService+6�   �� 5G   
   -   5        $	 if2��5G      $��10q�6D   $ t_name��6P   $��1��6k   $��7��6{    6    �� *
Car.Tariff+6�   �� 5H   
   -   5        $

 cost��5H      $��1��6:   $��6��6J    . ��6    �� *
con_cost+6k   �� 5I   
   -   5        $	 car��5I      $ c_name��6=   $��1��6X   $��5��6h    �� 
IsReadOnly . $��10q�6�    6    �� *Car+6�   �� 5J   
   -   5        $ client��5J      $ cl_name��6C   $��1��6_   $��4��6o    . $��10q�6�    6#   �� *Client+6�   (  "System.Windows.Controls.DatePicker  5K   
   -	   5          Name$
 date��5K      $��1��6E   $��1��6U   $��10q�6b      SelectedDate 6#   �� *
con_date+6�     5L   
   -
   5        $ dateend��5L      $��1��6K   $��2��6[   $��10q�6h    6&   �� *con_dateend+6�   �� 5M   
   -   5        $	
 sum��5M      $��1��68   $��9��6H    . ��6   �� *	con_sum+6i   �� 5N   
   -   5        $��Рассчитать��5N      $��1��6&   $��9��66   $��Right=�6C   $��10q�6_   
�������
���   �$��Center=�6�   $��60��6�   $��10(�6�   
�������6�   �� 5P   
   -   5         ��Name$ BtnSave��5P      $��Сохранить��6"   $��10��6L   $
��Left=�6Z   �� 5Q   
   -   5        $ 	BtnCancel��5Q      $��Отменить��6$   $��10��6O   $��1��6]   $
��Left=�6m   5S      5T      