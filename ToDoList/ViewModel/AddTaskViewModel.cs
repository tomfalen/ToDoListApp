using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToDoList
{
    public class AddTaskViewModel : ObservableObject , IPageViewModel
    {
        private ICommand _saveTaskCommand;
        private Task _currentTask;

        private int _TaskId;
        private string _AuthorName;
        private string _Description;
        private DateTime _DueDate;
        private DateTime _CreatedDate;
        private int _Priority;

        public string Name
        {
            get
            {
                return "Add Task";
            }
        }

        public int TaskId
        {
            get { return _TaskId; }
            set
            {
                if (value != _TaskId)
                {
                    _TaskId = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        public string AuthorName
        {
            get { return _AuthorName; }
            set
            {
                if (value != _AuthorName)
                {
                    _AuthorName = value;
                    OnPropertyChanged("AuthorName");
                }
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
        public DateTime DueDate
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
        public DateTime CreatedDate
        {
            get { return _CreatedDate; }
            set
            {
                if (value != _CreatedDate)
                {
                    _CreatedDate = value;
                    OnPropertyChanged("CreatedDate");
                }
            }
        }
        public int Priority
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

        public ICommand ChujWDupe
        {
            get
            {
                if (_saveTaskCommand == null)
                {
                    _saveTaskCommand = new RelayCommand(
                        param => SaveTask(),
                        param => (CurrentTask != null)
                    );
                }
                return _saveTaskCommand;
            }

        }


        private void SaveTask()
        {
            toDoListAppEntities context = new toDoListAppEntities();
            context.Task.Add(new Task()
            {
                AuthorName = WindowsIdentity.GetCurrent().Name,
                Description = _Description,
                CreatedDate = DateTime.Now,
                DueDate = _DueDate,
                Priority = _Priority,
            });
            context.SaveChanges();
        }
    }
}
