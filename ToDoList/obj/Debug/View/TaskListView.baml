   M S B A M L   `   `   `  ����C  ?ToDoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ToDoListToDoList  5          ToDoList.TaskListView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:ToDoList     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��75 �6   6*   �� 5      $	��150 �6   6+   �� 5      $��75 �6   6*   �� 5      $��25 �6   6*   .+�5   
   (  "System.Windows.Controls.DatePicker  $	��200��5   k   $��25��6w   $��0��6�   $
��Left=�6�   $��
31,28,0,23q�6�      SelectedDate 6   �� *CurrentDate+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��1��6   $	��686��6�   $ �� IsSynchronizedWithCurrentItem$ FalseY�6�    �� SelectedItem 6    �� *CurrentTask+$ TwoWay=�$ PropertyChanged=���6w   �� *
TaskList+ �� View 5      �� 5      .P�5      �� $��Description��6R    �� DisplayMemberBinding 6%   �� *Description+6R   �� 5      $��Due Date��6S    6%   �� *DueDate.Date+6S   �� 5      $��Created Date��6W    6%   �� *CreatedDate.Date+6W   �� 5      $��Priority��6W    6%   �� *Priority.Content+6W   5      5      �� 5   
   $��2��6   $
��Left=�6   .��68   Description6E   �� 5   
   $
��Left=�6l   $	��200��6�   $��25��6�   $��2��6�   $��
31,25,0,26q�6�   ��6   �� *CurrentTask.Description+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   $��2��6   $��Center=�6   .��6:   
Due Date6D     5   
   $	��200��5    s   $��25��6   $��2��6�    6   �� *CurrentTask.DueDate+$ TwoWay=�$ PropertyChanged=�6�   �� 5!   
   $��2��6   $��Right=�6   .��69   
Priority6C   �� 5"   
   $	��200��6r   $��25��6~   $��2��6�   $��Right=�6�   $��
0,25,24,25q�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�    6   �� *CurrentTask.Priority+$ TwoWay=�$ PropertyChanged=�z�5#      V� 5$      .~�5%      �� �� 5&      �� 5'      	 �� Angle$	 -0.047Q�6&   T� 5(      5)      .@�5+      �� $	��Low��6   5,      �� 5-      $��Medium��6   5.      �� 5/      $
��High��6   50      51      �� 52   
   $��4��6   $	��100��6   $��Center=�6*   $��Delete selected��6G   $	��4,0q�55      ��53      �� *DataContext.DeleteTaskCommand+
 �� RelativeSource
 ��  �� AncestorType   ToDoList.TaskListView"  ��54      �� 55   $   �� 56   
   $��4��6   $	��100��6   $��Right=�6*   $��Edit selected��6F   $	��4,0q�59      ��57      �� *DataContext.EditTaskCommand+
 �� "  ��58      �� 59   $   5:      5;      