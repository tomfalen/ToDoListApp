   M S B A M L   `   `   `  ����C  ?ToDoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ToDoListToDoList  5          ToDoList.AddTaskView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:ToDoList     5      .��5
      � $��10q�6     � RowDefinitions  5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Description��6   $��0��6'   $��0��64   �� 5   
   $��Due Date��6   $��1��6$   $��0��61   �� 5   
   $��Priority��6   $��2��6$   $��0��61   �� 5   
   $��25��6   $	��150��6   $��1��6x   $��0��6�   ��6*   �� *Description+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   (  "System.Windows.Controls.DatePicker  5   
   $��25��6   $	��150��6!   $��1��6-   $��1��6=      SelectedDate 5      �� *	DueDate+$ TwoWay=�$ PropertyChanged=��� 5   
   $��25��6   $	��150��6   $��1��6+   $��2��6;    �� SelectedValuePath$ .��6H    �� SelectedItem 5      �� *
Priority+$ TwoWay=�$ PropertyChanged=�.@�5      �� $	��Low��6   5      �� 5       $��Medium��6   5!      �� 5"      $
��High��6   5#      5$      �� 5%   
    �� Orientation$ 
Horizontal=�6   $��3��6.   $��2��6;   $��Right=�6O   $��5,5,5,5q�6k   .+�5&      �� $	��150��6   $��Add new��6!   $	��4,0q�5)      ��5'      �� *DataContext.AddTaskCommand+ �� RelativeSource �� 	 �� AncestorType   ToDoList.AddTaskView"	  ��5(      �� 5)   $   5*      5+      5,      