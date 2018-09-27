using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;
using ToDoList.Model;

namespace ToDoList
{
    public class TaskListViewModel : ObservableObject, IPageViewModel
    {
        private ICommand _editTaskCommand;
        private ICommand _deleteTaskCommand;
        private DateTime _currentDate;
        private List<TaskModel> _taskList;
        private Business _context;
        private TaskModel _task;
        private int _selectedIndex;

        public TaskListViewModel()
        {
            _currentDate = DateTime.Now;
            _context = new Business();
        }
        public string Name
        {
            get
            {
                return "Task List";
            }
        }

        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                if (value != _selectedIndex)
                {
                    _selectedIndex = value;
                    OnPropertyChanged("SelectedIndex");
                }
            }
        }

        public DateTime CurrentDate
        {
            get { return _currentDate; }
            set
            {
                if (value != _currentDate)
                {
                    _currentDate = value;
                    OnPropertyChanged("CurrentDate");
                    GetTaskList();
                }
            }
        }

        public TaskModel CurrentTask
        {
            get
            {
                return _task;
            }
            set
            {
                if (value != _task)
                {
                    _task = value;
                    OnPropertyChanged("CurrentTask");
                }
            }
        }

        public List<TaskModel> TaskList
        {
            get
            {
                return _taskList;
            }
            set
            {
                if(value != _taskList)
                {
                    _taskList = value;
                    OnPropertyChanged("TaskList");
                }
            }
        }

        public void GetTaskList()
        {
            TaskList = _context.Get()
                 .Where(x => x.DueDate == CurrentDate.Date)
                 .Select(x => new TaskModel()
                 {
                     AuthorName = x.AuthorName,
                     Description = x.Description,
                     CreatedDate = x.CreatedDate, DueDate = x.DueDate,
                     Id = x.Id,
                     Priority = new ComboBoxItem()
                     {
                         Content = x.Priority
                    }
                })
                .ToList();
        }

        public ICommand EditTaskCommand
        {
            get
            {
                if (_editTaskCommand == null)
                {
                    _editTaskCommand = new RelayCommand(
                        param => EditTask(),
                        param => CanExecuteAddTaskCommand()
                    );
                }
                return _editTaskCommand;
            }

        }

        private bool CanExecuteAddTaskCommand()
        {
            return true;
        }

        public ICommand DeleteTaskCommand
        {
            get
            {
                if (_deleteTaskCommand == null)
                {
                    _deleteTaskCommand = new RelayCommand(
                        param => DeleteTask(),
                        param => CanExecuteAddTaskCommand()
                    );
                }
                return _deleteTaskCommand;
            }

        }

        private void DeleteTask()
        {
            _context.Delete(CurrentTask);
        }

        private void EditTask()
        {
            _context.Update(CurrentTask);
        }
    }
}
