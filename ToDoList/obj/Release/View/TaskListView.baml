   M S B A M L   `   `   `  ���� C  ?ToDoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ToDoListToDoList      ToDoList.TaskListView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     (localclr-namespace:ToDoList     .���   � RowDefinitions  �� $��75 ��� $	��150 ��� $��75 ��� $��25 �.+�(  "System.Windows.Controls.DatePicker  $	��200��$��25��$��0��$
��Left=�$��
31,28,0,23q�   SelectedDate �� *CurrentDate+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $��1��$	��686��$ �� IsSynchronizedWithCurrentItem$ FalseY� �� SelectedItem �� *CurrentTask+$ TwoWay=�$ PropertyChanged=����� *
TaskList+ �� View �� .P��� $��Description�� �� DisplayMemberBinding �� *Description+�� $��Due Date�� �� *DueDate.Date+�� $��Created Date�� �� *CreatedDate.Date+�� $��Priority�� �� *Priority.Content+�� $��2��$
��Left=�.��Description�� $
��Left=�$	��200��$��25��$��2��$��
31,25,0,26q����� *CurrentTask.Description+$ TwoWay=�$ PropertyChanged=��� $��2��$��Center=�.��
Due Date  $	��200��$��25��$��2�� �� *CurrentTask.DueDate+$ TwoWay=�$ PropertyChanged=��� $��2��$��Right=�.��
Priority�� $	��200��$��25��$��2��$��Right=�$��
0,25,24,25q� J� RenderTransformOrigin$ 0.5,0.5&� �� *CurrentTask.Priority+$ TwoWay=�$ PropertyChanged=�z�V� .~��� �� �� 	 �� Angle$	 -0.047Q�T� .@��� $	��Low���� $��Medium���� $
��High���� $��4��$	��100��$��Center=�$��Delete selected��$	��4,0q����� *DataContext.DeleteTaskCommand+
 �� RelativeSource
 ��  �� AncestorType   ToDoList.TaskListView"  ���� �� $��4��$	��100��$��Right=�$��Edit selected��$	��4,0q����� *DataContext.EditTaskCommand+
 �� "  ���� 