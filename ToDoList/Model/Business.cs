using System.Collections.Generic;
using System.Linq;

namespace ToDoList.Model
{
    public class Business
    {
        toDoListAppEntities _context;
        public Business()
        {
            _context = new toDoListAppEntities();
        }

        public List<Task> Get()
        {
            return _context.Task.ToList();
        }

        public void Delete(TaskModel task)
        {
            Task taskDelete = _context.Task.Where(x => x.Id == task.Id).FirstOrDefault();
            _context.Task.Remove(taskDelete);
            _context.SaveChanges();
        }

        public void Add(Task task)
        {
            _context.Task.Add(task);
            _context.SaveChanges();
        }

        public void Update(TaskModel task)
        {
            Task taskUpdate = _context.Task.Where(x => x.Id == task.Id).FirstOrDefault();
            taskUpdate.Description = task.Description;
            taskUpdate.DueDate = task.DueDate;
            taskUpdate.Priority = task.Priority.Content.ToString();
            _context.SaveChanges();
        }
    }
}
