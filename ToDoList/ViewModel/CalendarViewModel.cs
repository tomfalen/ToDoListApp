using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class CalendarViewModel : ObservableObject, IPageViewModel
    {

        public string Name
        {
            get
            {
                return "Calendar";
            }
        }
    }
}
