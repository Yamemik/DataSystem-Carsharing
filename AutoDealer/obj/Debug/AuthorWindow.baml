   M S B A M L   `   `   `  ����E  AAutoDealer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AutoDealer
AutoDealer  5   	       AutoDealer.AuthorWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AutoDealer     5   	     � Title$  Авторизация��5   	   $	��200��6   $	��600��6*    � WindowStyle$ 
ToolWindow=�66    � WindowStartupLocation$ CenterOwner=�6O   ��5	      �� 5
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
   " ��6   .�5       ��  � ��
 �����6+   �� 5!       � ��$ 22(�6)   �� 5"       � ��$ Impact)�6+   �� 5#       � ��$ Center=�62   �� 5$       �@��TextAlignment$ Center=�6.   5%      5&      .��5'      �  � ColumnDefinitions 5(   
   �� 5)      $	��200 �6   6-   �� 5*      6!   	 � RowDefinitions	 5,   
   �� 5-      $��50 �6   6*   �� 5.      $��50 �6   6*   �� 5/      $��50 �6   6*   .+�52   
   �� $��
Логин��6   6#   �� 53   
   $��Пароль��6   $��1��6"   61   �� 55   
   -   5        
 ��Name$
 login��55      $��1��6!   63   �� 56   
   -   5        $
 password��56      $��1��6$   $��1��64   6C   �� 58   
   -   5         ��Name$ BtnSave��58      $��
Войти��6"   $��7��6H   $
��Left=�6U   �� 59   
   -   5        $ 	BtnCancel��59      $��Отменить��6$   $��7��6O   $��1��6\   $
��Left=�6l   5;      5<      