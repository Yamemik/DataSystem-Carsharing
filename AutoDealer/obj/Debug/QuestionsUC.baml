   M S B A M L   `   `   `  ����E  AAutoDealer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AutoDealer
AutoDealer  5          AutoDealer.QuestionsUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:AutoDealer     5      .��5
      �   � RowDefinitions  5   
   �� 5      �� 5      $
��Auto �6   .+�5   
   �  � ColumnDefinitions 5      �� 5      �� 5        5      �� 5      $
��Auto �6    �� 5      �� 5      $
��Auto �6    .+�5      �� $��2��6   
�������$
��Wrap=�6i   ��6,   �� *CurrentQuestion.Text+6i   �� 5      $��1��6A   $��2��6N   ��6   �� *CurrentQuestion+ � 	Resources 5       �� DataType&    AutoDealer.QuestionRadioButtonVM   AutoDealer.AnswerVM 	� 	GroupName d� 	IsChecked#   AutoDealer.QuestionCheckBoxVM��%  (��       5   #   *, +)(��     5'   #   *, +)�� 5      "  6#   .R�5      �� .+�5      �� ��6+   �� *	Answers+��5   "   �� 5    &   "  63   (��       *, +).R�5!   *   	� $ Answer��66   ��6I   �� *Text+ 6b   �� *IsRightView+5"   '   5$      5%      5&      �� 5'      "  6#   .R�5(      �� ��6'   �� *	Answers+��5)      �� 5*   "   "  6/   (��       *, +).R�5+   &   �� ��6/   �� *Text+ 6H   �� *IsRightView+5,   #   5.      5/      50      52      �� 53      -   5         ��Name$ btPrev��53   (   
���P��$��2��68   $��Предыдущий��6E   $��-1��6�   ��6Z   �� *JumpQuestionCommand+6�   �� 54      -   5        $ btNext��54   (   
���P��$��2��68   $��1��6E   $��Следующий��6U   $��1��6�   ��6i   �� *JumpQuestionCommand+6�   55      �� 56   
   $��1��6   
���  ��$!��Закончить тест��6/   ��6H   �� *JumpCommand+57      58      