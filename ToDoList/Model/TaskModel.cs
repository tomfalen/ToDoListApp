using System;
using System.Windows.Controls;

namespace ToDoList.Model
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public ComboBoxItem Priority { get; set; }

        public override bool Equals(object obj)
        {
            var model = obj as TaskModel;
            if (model != null && model.Id == this.Id)
                return true;
            else
                return false;
        }
    }
}
