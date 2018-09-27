using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Delete(Task task)
        {
            _context.Task.Remove(task);
        }

        public void Update(Task task)
        {

        }

        private void CheckValidations(Task task)
        {
            if (task == null)
            {
                throw new ArgumentNullException("Person", "Please select record from Grid or Add New");
            }

            if (string.IsNullOrEmpty(task.Description))
            {
                throw new ArgumentNullException("Description", "Please enter Description");
            }
            else if (task.DueDate.HasValue)
            {
                throw new ArgumentNullException("Due Date", "Please enter due date");
            }
            else if ((int)task.Priority == -1)
            {
                throw new ArgumentNullException("Profession", "Please enter Profession");
            }
        }
    }
}
