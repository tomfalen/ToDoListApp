using System;
using System.Security.Principal;
using System.Windows.Controls;
using System.Windows.Input;
using ToDoList.Model;

namespace ToDoList
{
    public class AddTaskViewModel : ObservableObject , IPageViewModel
    {
        private ICommand _saveTaskCommand;
        private Task _currentTask;

        private string _Description;
        private DateTime? _DueDate;
        private ComboBoxItem _Priority;
        private Business businessLogic;

        public AddTaskViewModel()
        {
            businessLogic = new Business();
        }

        public string Name
        {
            get
            {
                return "Add Task";
            }
        }

        public string Description
        {
            get { return _Description; }
            set
            {
                if (value != _Description)
                {
                    _Description = value;
                    OnPropertyChanged("Description");
                }
            }
        }
        public DateTime? DueDate
        {
            get { return _DueDate; }
            set
            {
                if (value != _DueDate)
                {
                    _DueDate = value;
                    OnPropertyChanged("DueDate");
                }
            }
        }
        public ComboBoxItem Priority
        {
            get { return _Priority; }
            set
            {
                if (value != _Priority)
                {
                    _Priority = value;
                    OnPropertyChanged("Priority");
                }
            }
        }

        public Task CurrentTask
        {
            get { return _currentTask; }
            set
            {
                if (value != _currentTask)
                {
                    _currentTask = value;
                    OnPropertyChanged("CurrentProduct");
                }
            }
        }

        public ICommand AddTaskCommand
        {
            get
            {
                if (_saveTaskCommand == null)
                {
                    _saveTaskCommand = new RelayCommand(
                        param => SaveTask(),
                        param => CanExecuteAddTaskCommand()
                    );
                }
                return _saveTaskCommand;
            }

        }

        private bool CanExecuteAddTaskCommand()
        {
            return true;
        }


        private void SaveTask()
        {
            Task task = new Task()
            {
                AuthorName = WindowsIdentity.GetCurrent().Name,
                Description = _Description,
                CreatedDate = DateTime.Now,
                DueDate = _DueDate,
                Priority = _Priority.Content.ToString(),
            };
            businessLogic.Add(task);
        }
    }
}
